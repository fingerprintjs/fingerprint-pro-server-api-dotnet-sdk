using FingerprintPro.ServerSdk.Client;

namespace FingerprintPro.ServerSdk.Exceptions;

public class FailedToDeserializeException : ApiException
{
    public FailedToDeserializeException() : base(500, "Failed to deserialize response body.")
    {
    }
}
