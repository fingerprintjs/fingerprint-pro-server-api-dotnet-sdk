using Fingerprint.ServerSdk.Client;
using Fingerprint.ServerSdk.Model;

namespace Fingerprint.ServerSdk.Exceptions;

public class FailedToDeserializeException : ApiException
{
    public FailedToDeserializeException() : base(500, "Failed to deserialize response body.", ErrorCode.Failed)
    {
    }
}
