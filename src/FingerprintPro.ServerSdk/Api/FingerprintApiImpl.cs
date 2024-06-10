using System.Net.Http;
using FingerprintPro.ServerSdk.Client;
using FingerprintPro.ServerSdk.Model;

namespace FingerprintPro.ServerSdk.Api;

public class FingerprintApi : IFingerprintApi
{
    private readonly ApiClient _apiClient;

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


    public Response GetVisits(string visitorId, string? requestId = null, string? linkedId = null, int? limit = null,
        string? paginationKey = null, long? before = null)
    {
        return GetVisitsWithHttpInfo(visitorId, requestId, linkedId, limit, paginationKey, before).Data;
    }

    public ApiResponse<Response> GetVisitsWithHttpInfo(string visitorId, string? requestId = null,
        string? linkedId = null, int? limit = null,
        string? paginationKey = null, long? before = null)
    {
        return GetVisitsAsyncWithHttpInfo(visitorId, requestId, linkedId, limit, paginationKey, before).Result;
    }

    public async Task<EventResponse> GetEventAsync(string requestId)
    {
        return (await GetEventAsyncWithHttpInfo(requestId)).Data;
    }

    public Task<ApiResponse<EventResponse>> GetEventAsyncWithHttpInfo(string requestId)
    {
        var definition = new GetEventDefinition();

        var request = new ApiRequest
        {
            OperationDefinition = definition,
            Method = HttpMethod.Get,
            Args = new[] { requestId },
        };

        return _apiClient.DoRequest<EventResponse>(request);
    }

    public async Task<Response> GetVisitsAsync(string visitorId, string? requestId = null, string? linkedId = null,
        int? limit = null,
        string? paginationKey = null, long? before = null)
    {
        return (await GetVisitsAsyncWithHttpInfo(visitorId, requestId, linkedId, limit, paginationKey, before)).Data;
    }

    public Task<ApiResponse<Response>> GetVisitsAsyncWithHttpInfo(string visitorId, string? requestId = null,
        string? linkedId = null, int? limit = null,
        string? paginationKey = null, long? before = null)
    {
        Dictionary<string, string> queryParams = new();

        if (!string.IsNullOrEmpty(requestId))
        {
            queryParams.Add("request_id", requestId!);
        }

        if (!string.IsNullOrEmpty(linkedId))
        {
            queryParams.Add("linked_id", linkedId!);
        }

        if (limit != null)
        {
            var limitStr = limit.ToString();

            if (!string.IsNullOrEmpty(limitStr))
            {
                queryParams.Add("limit", limitStr);
            }
        }

        if (!string.IsNullOrEmpty(paginationKey))
        {
            queryParams.Add("paginationKey", paginationKey!);
        }

        if (before != null)
        {
            var beforeStr = before.ToString();

            if (!string.IsNullOrEmpty(beforeStr))
            {
                queryParams.Add("before", beforeStr);
            }
        }

        var definition = new GetVisitsDefinition();
        var request = new ApiRequest()
        {
            OperationDefinition = definition,
            Method = HttpMethod.Get,
            Args = new[] { visitorId },
            QueryParams = queryParams
        };

        return _apiClient.DoRequest<Response>(request);
    }
}
