using System.IO.Compression;
using FingerprintPro.ServerSdk.Model;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;

namespace FingerprintPro.ServerSdk
{
    public class Sealed
    {
        public enum DecryptionAlgorithm
        {
            Aes256Gcm
        }

        public class DecryptionKey
        {
            public byte[] Key { get; }
            public DecryptionAlgorithm Algorithm { get; }

            public DecryptionKey(byte[] key, DecryptionAlgorithm algorithm)
            {
                Key = key;
                Algorithm = algorithm;
            }
        }

        public class UnsealAggregateException : Exception
        {
            public List<UnsealException> UnsealExceptions { get; } = new();

            public UnsealAggregateException() : base("Failed to unseal with all decryption keys")
            {
            }

            public void AddUnsealException(UnsealException exception)
            {
                UnsealExceptions.Add(exception);
            }
        }

        public class InvalidSealedDataException : ArgumentException
        {
            public InvalidSealedDataException() : base("Invalid sealed data")
            {
            }
        }

        public class InvalidSealedDataHeaderException : ArgumentException
        {
            public InvalidSealedDataHeaderException() : base("Invalid sealed data header")
            {
            }
        }

        public class UnsealException : Exception
        {
            public DecryptionKey DecryptionKey { get; }
            public new Exception InnerException { get; }

            public UnsealException(string message, DecryptionKey decryptionKey, Exception exception) : base(message, exception)
            {
                DecryptionKey = decryptionKey;
                InnerException = exception;
            }
        }

        private static readonly byte[] SealHeader = { 0x9E, 0x85, 0xDC, 0xED };
        private const int _nonceLength = 12;
        private const int _authTagLength = 16;

        public static byte[] Unseal(byte[] sealedData, DecryptionKey[] keys)
        {
            if (!sealedData.Take(SealHeader.Length).SequenceEqual(SealHeader))
            {
                throw new InvalidSealedDataHeaderException();
            }

            var aggregateException = new UnsealAggregateException();

            foreach (var key in keys)
            {
                switch (key.Algorithm)
                {
                    case DecryptionAlgorithm.Aes256Gcm:
                        try
                        {
                            return DecryptAes256Gcm(sealedData.Skip(SealHeader.Length).ToArray(), key.Key);
                        }
                        catch (Exception exception)
                        {
                            aggregateException.AddUnsealException(new UnsealException("Failed to decrypt", key, exception));
                        }
                        break;

                    default:
                        throw new ArgumentException("Invalid decryption algorithm");
                }
            }

            throw aggregateException;
        }

        /// <summary>
        /// Decrypts the sealed response with the provided keys.
        /// </summary>
        /// <value>An decrypted instance of the EventResponse.</value>
        /// <remarks>
        /// The SDK will try to decrypt the result with each key until it succeeds.
        /// </remarks>
        public static EventResponse UnsealEventResponse(byte[] sealedData, DecryptionKey[] keys)
        {
            var unsealed = Unseal(sealedData, keys);
            var mapper = new JsonSerializer();

            var value = mapper.Deserialize<EventResponse>(
                new JsonTextReader(new StreamReader(new MemoryStream(unsealed))));

            if (value == null)
            {
                throw new InvalidSealedDataException();
            }

            return value;
        }

        private static byte[] DecryptAes256Gcm(byte[] sealedData, byte[] key)
        {
            var nonce = sealedData.Take(_nonceLength).ToArray();
            var cipherText = sealedData.Skip(_nonceLength).ToArray();

            var cipher = new GcmBlockCipher(new AesEngine());
            var parameters = new AeadParameters(new KeyParameter(key), _authTagLength * 8, nonce);
            cipher.Init(false, parameters);

            var output = new byte[cipher.GetOutputSize(cipherText.Length)];
            var len = cipher.ProcessBytes(cipherText, 0, cipherText.Length, output, 0);
            cipher.DoFinal(output, len);

            return Decompress(output);
        }


        private static byte[] Decompress(byte[] data)
        {
            using var compressedStream = new MemoryStream(data);
            using var deflateStream = new DeflateStream(compressedStream, CompressionMode.Decompress);
            using var resultStream = new MemoryStream();
            deflateStream.CopyTo(resultStream);
            return resultStream.ToArray();
        }
    }
}
