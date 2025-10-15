using Fingerprint.ServerSdk;

var sealedResult = Environment.GetEnvironmentVariable("BASE64_SEALED_RESULT")!;
var sealedKey = Environment.GetEnvironmentVariable("BASE64_KEY")!;

var events = Sealed.UnsealEventResponse(Convert.FromBase64String(sealedResult), new[]
{
    new Sealed.DecryptionKey(Convert.FromBase64String(sealedKey), Sealed.DecryptionAlgorithm.Aes256Gcm)
});

Console.WriteLine(events.ToJson());