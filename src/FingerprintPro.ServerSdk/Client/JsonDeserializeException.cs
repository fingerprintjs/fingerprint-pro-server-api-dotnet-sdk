using System.Net.Http;
using FingerprintPro.ServerSdk.Model;

namespace FingerprintPro.ServerSdk.Client;

public class JsonDeserializeException : ApiException
{
    public JsonDeserializeException(HttpResponseMessage response, Exception e) : base((int)response.StatusCode, "Failed to deserialize JSON data", ErrorCode.Failed, response, e)
    {
    }
}
