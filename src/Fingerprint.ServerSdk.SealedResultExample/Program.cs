using System.Text.Json;
using Fingerprint.ServerSdk;

var sealedResult = Environment.GetEnvironmentVariable("BASE64_SEALED_RESULT")!;
var sealedKey = Environment.GetEnvironmentVariable("BASE64_KEY")!;

var model = Sealed.UnsealEventResponse(Convert.FromBase64String(sealedResult), new[]
{
    new Sealed.DecryptionKey(Convert.FromBase64String(sealedKey), Sealed.DecryptionAlgorithm.Aes256Gcm)
});

Console.WriteLine(JsonSerializer.Serialize(model));