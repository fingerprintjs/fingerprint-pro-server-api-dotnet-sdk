using Fingerprint.ServerSdk.Client;

namespace Fingerprint.ServerSdk.Examples;

public class ExampleException(string message, IApiResponse response) : Exception(message)
{
    public IApiResponse Response = response;
}