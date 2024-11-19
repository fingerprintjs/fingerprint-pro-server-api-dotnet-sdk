using FingerprintPro.ServerSdk.Client;
using FingerprintPro.ServerSdk.Model;

namespace FingerprintPro.ServerSdk.Exceptions;

public class FailedToDeserializeException : ApiException
{
    public FailedToDeserializeException() : base(500, "Failed to deserialize response body.", ErrorCode.Failed)
    {
    }
}
