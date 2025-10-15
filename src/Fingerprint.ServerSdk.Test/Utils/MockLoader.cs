using System.Text;

namespace Fingerprint.ServerSdk.Test.Utils;

public static class MockLoader
{
    public static byte[] Load(string fileName)
    {
        // Load selected json file store in /mocks directory, and save it to a "mockResponse" property

        var mockResponse = File.ReadAllText($"../../../mocks/{fileName}");

        return Encoding.UTF8.GetBytes(mockResponse);
    }
}