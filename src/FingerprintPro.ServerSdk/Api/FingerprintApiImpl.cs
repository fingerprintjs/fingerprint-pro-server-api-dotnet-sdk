using System.Net.Http;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using FingerprintPro.ServerSdk.Client;
using FingerprintPro.ServerSdk.Model;
using FingerprintPro.ServerSdk.Model;

namespace FingerprintPro.ServerSdk.Api;

public class FingerprintApi : IFingerprintApi
{
    private readonly ApiClient _apiClient;

    private ExceptionFactory _exceptionFactory = (name, response) => null;

    /// <summary>
    /// Initializes a new instance of the <see cref="FingerprintApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public FingerprintApi(Configuration configuration)
    {
        _apiClient = new ApiClient(configuration);
    }

    public EventResponse GetEvent(string requestId)
    {
        return GetEventWithHttpInfo(requestId).Data;
    }

    public ApiResponse<EventResponse> GetEventWithHttpInfo(string requestId)
    {
        return GetEventAsyncWithHttpInfo(requestId).Result;
    }


    public Response GetVisits(string visitorId, string requestId = null, string linkedId = null, int? limit = null,
        string paginationKey = null, long? before = null)
    {
        throw new NotImplementedException();
    }

    public ApiResponse<Response> GetVisitsWithHttpInfo(string visitorId, string requestId = null,
        string linkedId = null, int? limit = null,
        string paginationKey = null, long? before = null)
    {
        throw new NotImplementedException();
    }

    public async Task<EventResponse> GetEventAsync(string requestId)
    {
        return (await GetEventAsyncWithHttpInfo(requestId)).Data;
    }

    public async Task<ApiResponse<EventResponse>> GetEventAsyncWithHttpInfo(string requestId)
    {
        var definition = new GetEventDefinition();

        return await _apiClient.DoRequest<EventResponse>(definition, HttpMethod.Get, requestId);
    }

    public Task<Response> GetVisitsAsync(string visitorId, string requestId = null, string linkedId = null,
        int? limit = null,
        string paginationKey = null, long? before = null)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse<Response>> GetVisitsAsyncWithHttpInfo(string visitorId, string requestId = null,
        string linkedId = null, int? limit = null,
        string paginationKey = null, long? before = null)
    {
        Dictionary<string, dynamic> queryParams = new();

        if (!string.IsNullOrEmpty(requestId))
        {
            queryParams.Add("request_id", requestId);

        }

        if (!string.IsNullOrEmpty(linkedId))
        {
            queryParams.Add("linked_id", linkedId);
        }

        if (limit != null)
        {
            queryParams.Add("limit", limit);
        }

        if (!string.IsNullOrEmpty(paginationKey))
        {
            queryParams.Add("paginationKey", paginationKey);
        }

        if (before != null)
        {
            queryParams.Add("before", before);
        }

        var definition = new GetVisitsDefinition();
        var path = _apiClient.GetRequestPath(definition, visitorId);

        var request = _apiClient.CreateRequestMessage(HttpMethod.Get, path);
        var response = await _apiClient.Client.SendAsync(request);

        throw new NotImplementedException();
    }

    private Exception HandleException(string methodName, HttpResponseMessage response, string responseContent,
        OperationDefinition operationDefinition)
    {
        var statusCode = (int)response.StatusCode;

        var instance = operationDefinition.GetResponse(statusCode, responseContent);

        if (instance is Exception exception)
        {
            return exception;
        }

        return new ApiException(statusCode,
            $"Error calling {methodName}: {response.ReasonPhrase}", response.Content);
    }
}
