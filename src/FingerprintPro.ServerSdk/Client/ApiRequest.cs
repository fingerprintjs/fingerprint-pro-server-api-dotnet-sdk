using System.Net.Http;
using FingerprintPro.ServerSdk.Api;

namespace FingerprintPro.ServerSdk.Client;

public class ApiRequest
{
    public OperationDefinition OperationDefinition;

    public HttpMethod Method;

    public Dictionary<string, string>? QueryParams;

    public HttpContent? Body;

    public string[]? Args;
}
