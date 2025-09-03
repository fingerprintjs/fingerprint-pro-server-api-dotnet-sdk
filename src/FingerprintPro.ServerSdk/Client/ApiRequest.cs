using System.Net.Http;
using FingerprintPro.ServerSdk.Api;

namespace FingerprintPro.ServerSdk.Client;

public class ApiRequest
{
    public OperationDefinition OperationDefinition;

    public HttpMethod Method;

    public List<KeyValuePair<string, string>> QueryParams { get; set; } = new();

    public HttpContent? Body;

    public string[]? Args;
}
