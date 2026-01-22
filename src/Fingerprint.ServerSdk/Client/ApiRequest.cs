using System.Net.Http;
using Fingerprint.ServerSdk.Api;

namespace Fingerprint.ServerSdk.Client;

public class ApiRequest
{
    public OperationDefinition OperationDefinition;

    public HttpMethod Method;

    public List<KeyValuePair<string, string>> QueryParams { get; set; } = new();

    public HttpContent? Body;

    public string[]? Args;
}
