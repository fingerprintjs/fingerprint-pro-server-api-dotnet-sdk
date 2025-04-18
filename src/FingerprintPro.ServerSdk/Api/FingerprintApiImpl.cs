using System.Globalization;
using FingerprintPro.ServerSdk.Client;
using FingerprintPro.ServerSdk.Model;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using FingerprintPro.ServerSdk.Json;

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

    #region GetEvent

    public EventsGetResponse GetEvent(string requestId)
    {
        return GetEventWithHttpInfo(requestId).Data;
    }

    public ApiResponse<EventsGetResponse> GetEventWithHttpInfo(string requestId)
    {
        return GetEventAsyncWithHttpInfo(requestId).Result;
    }

    public async Task<EventsGetResponse> GetEventAsync(string requestId)
    {
        return (await GetEventAsyncWithHttpInfo(requestId)).Data;
    }

    public Task<ApiResponse<EventsGetResponse>> GetEventAsyncWithHttpInfo(string requestId)
    {
        var definition = new GetEventDefinition();

        var request = new ApiRequest
        {
            OperationDefinition = definition,
            Method = HttpMethod.Get,
            Args = new[] { requestId },
        };

        return _apiClient.DoRequest<EventsGetResponse>(request);
    }

    #endregion

    #region UpdateEvent

    public void UpdateEvent(EventsUpdateRequest body, string requestId)
    {
        UpdateEventWithHttpInfo(body, requestId);
    }

    public ApiResponse<object> UpdateEventWithHttpInfo(EventsUpdateRequest body, string requestId)
    {
        return UpdateEventAsyncWithHttpInfo(body, requestId).Result;
    }

    public async Task UpdateEventAsync(EventsUpdateRequest body, string requestId)
    {
        await UpdateEventAsyncWithHttpInfo(body, requestId);
    }

    public Task<ApiResponse<object>> UpdateEventAsyncWithHttpInfo(EventsUpdateRequest body, string requestId)
    {
        var definition = new UpdateEventDefinition();
        var request = new ApiRequest()
        {
            OperationDefinition = definition,
            Method = HttpMethod.Put,
            Args = new[] { requestId },
            Body = new StringContent(JsonUtils.Serialize(body), Encoding.UTF8, "application/json"),
        };

        return _apiClient.DoRequestEmpty(request);
    }

    #endregion

    #region GetVisits

    public async Task<VisitorsGetResponse> GetVisitsAsync(string visitorId, string? requestId = null,
        string? linkedId = null,
        int? limit = null,
        string? paginationKey = null, long? before = null)
    {
        return (await GetVisitsAsyncWithHttpInfo(visitorId, requestId, linkedId, limit, paginationKey, before)).Data;
    }

    public Task<ApiResponse<VisitorsGetResponse>> GetVisitsAsyncWithHttpInfo(string visitorId, string? requestId = null,
        string? linkedId = null, int? limit = null,
        string? paginationKey = null, long? before = null)
    {
        Dictionary<string, string> queryParams = new();

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
            var limitStr = limit.ToString();

            if (!string.IsNullOrEmpty(limitStr))
            {
                queryParams.Add("limit", limitStr);
            }
        }

        if (!string.IsNullOrEmpty(paginationKey))
        {
            queryParams.Add("paginationKey", paginationKey);
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

        return _apiClient.DoRequest<VisitorsGetResponse>(request);
    }

    public VisitorsGetResponse GetVisits(string visitorId, string? requestId = null, string? linkedId = null,
        int? limit = null,
        string? paginationKey = null, long? before = null)
    {
        return GetVisitsWithHttpInfo(visitorId, requestId, linkedId, limit, paginationKey, before).Data;
    }

    public ApiResponse<VisitorsGetResponse> GetVisitsWithHttpInfo(string visitorId, string? requestId = null,
        string? linkedId = null, int? limit = null,
        string? paginationKey = null, long? before = null)
    {
        return GetVisitsAsyncWithHttpInfo(visitorId, requestId, linkedId, limit, paginationKey, before).Result;
    }

    #endregion

    #region DeleteVisitorData

    public void DeleteVisitorData(string visitorId)
    {
        DeleteVisitorDataWithHttpInfo(visitorId);
    }

    public ApiResponse<object> DeleteVisitorDataWithHttpInfo(string visitorId)
    {
        return DeleteVisitorDataAsyncWithHttpInfo(visitorId).Result;
    }

    public async Task DeleteVisitorDataAsync(string visitorId)
    {
        await DeleteVisitorDataAsyncWithHttpInfo(visitorId);
    }

    public Task<ApiResponse<object>> DeleteVisitorDataAsyncWithHttpInfo(string visitorId)
    {
        var definition = new DeleteVisitorDataDefinition();

        var request = new ApiRequest
        {
            OperationDefinition = definition,
            Method = HttpMethod.Delete,
            Args = new[] { visitorId }
        };

        return _apiClient.DoRequestEmpty(request);
    }

    #endregion

    #region GetRelatedVisitors

    public RelatedVisitorsResponse GetRelatedVisitors(string visitorId)
    {
        return GetRelatedVisitorsWithHttpInfo(visitorId).Data;
    }

    public ApiResponse<RelatedVisitorsResponse> GetRelatedVisitorsWithHttpInfo(string visitorId)
    {
        return GetRelatedVisitorsAsyncWithHttpInfo(visitorId).Result;
    }

    public async Task<RelatedVisitorsResponse> GetRelatedVisitorsAsync(string visitorId)
    {
        var response = await GetRelatedVisitorsAsyncWithHttpInfo(visitorId);
        return response.Data;
    }

    public Task<ApiResponse<RelatedVisitorsResponse>> GetRelatedVisitorsAsyncWithHttpInfo(string visitorId)
    {
        var definition = new GetRelatedVisitorsDefinition();

        var request = new ApiRequest
        {
            OperationDefinition = definition,
            Method = HttpMethod.Get,
            QueryParams = new Dictionary<string, string>()
            {
                { "visitor_id", visitorId }
            }
        };

        return _apiClient.DoRequest<RelatedVisitorsResponse>(request);
    }

    #endregion

    #region SearchEvents

    public SearchEventsResponse SearchEvents(int? limit, string paginationKey = null!, string visitorId = null!,
        string bot = null!, string ipAddress = null!, string linkedId = null!, long? start = null!, long? end = null!,
        bool? reverse = null!, bool? suspect = null!, bool? vpn = null!, bool? virtualMachine = null!,
        bool? tampering = null!, bool? antiDetectBrowser = null!, bool? incognito = null!,
        bool? privacySettings = null!, bool? jailbroken = null!, bool? frida = null!, bool? factoryReset = null!,
        bool? clonedApp = null!, bool? emulator = null!, bool? rootApps = null!, string vpnConfidence = null!,
        float? minSuspectScore = null!)
    {
        return SearchEventsWithHttpInfo(limit, paginationKey, visitorId, bot, ipAddress, linkedId, start, end, reverse,
            suspect, vpn, virtualMachine, tampering, antiDetectBrowser, incognito, privacySettings, jailbroken, frida,
            factoryReset, clonedApp, emulator, rootApps, vpnConfidence, minSuspectScore).Data;
    }

    public ApiResponse<SearchEventsResponse> SearchEventsWithHttpInfo(int? limit, string paginationKey = null!,
        string visitorId = null!, string bot = null!, string ipAddress = null!, string linkedId = null!,
        long? start = null!, long? end = null!, bool? reverse = null!, bool? suspect = null!, bool? vpn = null!,
        bool? virtualMachine = null!, bool? tampering = null!, bool? antiDetectBrowser = null!, bool? incognito = null!,
        bool? privacySettings = null!, bool? jailbroken = null!, bool? frida = null!, bool? factoryReset = null!,
        bool? clonedApp = null!, bool? emulator = null!, bool? rootApps = null!, string vpnConfidence = null!,
        float? minSuspectScore = null!)
    {
        return SearchEventsAsyncWithHttpInfo(limit, paginationKey, visitorId, bot, ipAddress, linkedId, start, end,
            reverse, suspect, vpn, virtualMachine, tampering, antiDetectBrowser, incognito, privacySettings, jailbroken,
            frida, factoryReset, clonedApp, emulator, rootApps, vpnConfidence, minSuspectScore).Result;
    }

    public async Task<SearchEventsResponse> SearchEventsAsync(int? limit, string paginationKey = null!,
        string visitorId = null!, string bot = null!, string ipAddress = null!, string linkedId = null!,
        long? start = null!, long? end = null!, bool? reverse = null!, bool? suspect = null!, bool? vpn = null!,
        bool? virtualMachine = null!, bool? tampering = null!, bool? antiDetectBrowser = null!, bool? incognito = null!,
        bool? privacySettings = null!, bool? jailbroken = null!, bool? frida = null!, bool? factoryReset = null!,
        bool? clonedApp = null!, bool? emulator = null!, bool? rootApps = null!, string vpnConfidence = null!,
        float? minSuspectScore = null!)
    {
        var response = await SearchEventsAsyncWithHttpInfo(limit, paginationKey, visitorId, bot, ipAddress, linkedId,
            start, end, reverse, suspect, vpn, virtualMachine, tampering, antiDetectBrowser, incognito, privacySettings,
            jailbroken, frida, factoryReset, clonedApp, emulator, rootApps, vpnConfidence, minSuspectScore);
        return response.Data;
    }

    public Task<ApiResponse<SearchEventsResponse>> SearchEventsAsyncWithHttpInfo(int? limit,
        string paginationKey = null!, string visitorId = null!, string bot = null!,
        string ipAddress = null!, string linkedId = null!, long? start = null!, long? end = null!,
        bool? reverse = null!, bool? suspect = null!,
        bool? vpn = null!, bool? virtualMachine = null!, bool? tampering = null!, bool? antiDetectBrowser = null!,
        bool? incognito = null!,
        bool? privacySettings = null!, bool? jailbroken = null!, bool? frida = null!, bool? factoryReset = null!,
        bool? clonedApp = null!,
        bool? emulator = null!, bool? rootApps = null!, string vpnConfidence = null!, float? minSuspectScore = null!)
    {
        var definition = new SearchEventsDefinition();
        var queryParams = new Dictionary<string, string>()
        {
            { "limit", limit.ToString() }
        };

        if (!string.IsNullOrEmpty(paginationKey))
        {
            queryParams.Add("pagination_key", paginationKey);
        }

        if (!string.IsNullOrEmpty(visitorId))
        {
            queryParams.Add("visitor_id", visitorId);
        }

        if (!string.IsNullOrEmpty(bot))
        {
            queryParams.Add("bot", bot);
        }

        if (!string.IsNullOrEmpty(ipAddress))
        {
            queryParams.Add("ip_address", ipAddress);
        }

        if (!string.IsNullOrEmpty(linkedId))
        {
            queryParams.Add("linked_id", linkedId);
        }

        if (start != null)
        {
            queryParams.Add("start", start.ToString());
        }

        if (end != null)
        {
            queryParams.Add("end", end.ToString());
        }

        if (reverse != null)
        {
            queryParams.Add("reverse", reverse.ToString());
        }

        if (suspect != null)
        {
            queryParams.Add("suspect", suspect.ToString()!);
        }

        if (vpn != null)
        {
            queryParams.Add("vpn", vpn.ToString());
        }

        if (virtualMachine != null)
        {
            queryParams.Add("virtual_machine", virtualMachine.ToString());
        }

        if (tampering != null)
        {
            queryParams.Add("tampering", tampering.ToString());
        }

        if (antiDetectBrowser != null)
        {
            queryParams.Add("anti_detect_browser", antiDetectBrowser.ToString());
        }

        if (incognito != null)
        {
            queryParams.Add("incognito", incognito.ToString());
        }

        if (privacySettings != null)
        {
            queryParams.Add("privacy_settings", privacySettings.ToString());
        }

        if (jailbroken != null)
        {
            queryParams.Add("jailbroken", jailbroken.ToString());
        }

        if (frida != null)
        {
            queryParams.Add("frida", frida.ToString());
        }

        if (factoryReset != null)
        {
            queryParams.Add("factory_reset", factoryReset.ToString());
        }

        if (clonedApp != null)
        {
            queryParams.Add("cloned_app", clonedApp.ToString());
        }

        if (emulator != null)
        {
            queryParams.Add("emulator", emulator.ToString());
        }

        if (rootApps != null)
        {
            queryParams.Add("root_apps", rootApps.ToString());
        }

        if (!string.IsNullOrEmpty(vpnConfidence))
        {
            queryParams.Add("vpn_confidence", vpnConfidence);
        }

        if (minSuspectScore != null)
        {
            queryParams.Add("min_suspect_score", string.Format(CultureInfo.InvariantCulture, "{0:F}", minSuspectScore));
        }

        var request = new ApiRequest
        {
            OperationDefinition = definition,
            Method = HttpMethod.Get,
            QueryParams = queryParams
        };

        return _apiClient.DoRequest<SearchEventsResponse>(request);
    }

    #endregion
}