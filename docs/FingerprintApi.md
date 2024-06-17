# FingerprintPro.ServerSdk.Api.FingerprintApi

All URIs are relative to *https://api.fpjs.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteVisitorData**](FingerprintApi.md#deletevisitordata) | **DELETE** /visitors/{visitor_id} | Delete data by visitor ID
[**GetEvent**](FingerprintApi.md#getevent) | **GET** /events/{request_id} | Get event by request ID
[**GetVisits**](FingerprintApi.md#getvisits) | **GET** /visitors/{visitor_id} | Get visits by visitor ID

<a name="deletevisitordata"></a>
# **DeleteVisitorData**
> void DeleteVisitorData (string visitorId)

Delete data by visitor ID

Request deleting all data associated with the specified visitor ID. This API is useful for compliance with privacy regulations. All delete requests are queued:   * Recent data (10 days or newer) belonging to the specified visitor will be deleted within 24 hours. * Data from older (11 days or more) identification events  will be deleted after 90 days.  If you are interested in using this API, please [contact our support team](https://fingerprint.com/support/) to activate it for you. Otherwise, you will receive a 403. 

### Example
```csharp
using System;
using System.Diagnostics;
using FingerprintPro.ServerSdk.Api;
using FingerprintPro.ServerSdk.Client;
using FingerprintPro.ServerSdk.Model;

namespace Example
{
    public class DeleteVisitorDataExample
    {
        public void main()
        {
            var configuration = new Configuration("YOUR_API_KEY");
            var apiInstance = new FingerprintApi(configuration);
            var visitorId = visitorId_example;  // string | The [visitor ID](https://dev.fingerprint.com/docs/js-agent#visitorid) you want to delete.

            try
            {
                // Delete data by visitor ID
                apiInstance.DeleteVisitorData(visitorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FingerprintApi.DeleteVisitorData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **visitorId** | **string**| The [visitor ID](https://dev.fingerprint.com/docs/js-agent#visitorid) you want to delete. | 

### Return type

void (empty response body)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getevent"></a>
# **GetEvent**
> EventResponse GetEvent (string requestId)

Get event by request ID

Get a detailed analysis of an individual identification event, including Smart Signals.  **Only for Enterprise customers:** Please note that the response includes mobile signals (e.g. `rootApps`) even if the request originated from a non-mobile platform. It is highly recommended that you **ignore** the mobile signals for such requests.   Use `requestId` as the URL path parameter. This API method is scoped to a request, i.e. all returned information is by `requestId`. 

### Example
```csharp
using System;
using System.Diagnostics;
using FingerprintPro.ServerSdk.Api;
using FingerprintPro.ServerSdk.Client;
using FingerprintPro.ServerSdk.Model;

namespace Example
{
    public class GetEventExample
    {
        public void main()
        {
            var configuration = new Configuration("YOUR_API_KEY");
            var apiInstance = new FingerprintApi(configuration);
            var requestId = requestId_example;  // string | The unique [identifier](https://dev.fingerprint.com/docs/js-agent#requestid) of each identification request.

            try
            {
                // Get event by request ID
                EventResponse result = apiInstance.GetEvent(requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FingerprintApi.GetEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestId** | **string**| The unique [identifier](https://dev.fingerprint.com/docs/js-agent#requestid) of each identification request. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getvisits"></a>
# **GetVisits**
> Response GetVisits (string visitorId, string requestId = null, string linkedId = null, int? limit = null, string paginationKey = null, long? before = null)

Get visits by visitor ID

Get a history of visits (identification events) for a specific `visitorId`. Use the `visitorId` as a URL path parameter. Only information from the _Identification_ product is returned.  #### Headers  * `Retry-After` — Present in case of `429 Too many requests`. Indicates how long you should wait before making a follow-up request. The value is non-negative decimal integer indicating the seconds to delay after the response is received. 

### Example
```csharp
using System;
using System.Diagnostics;
using FingerprintPro.ServerSdk.Api;
using FingerprintPro.ServerSdk.Client;
using FingerprintPro.ServerSdk.Model;

namespace Example
{
    public class GetVisitsExample
    {
        public void main()
        {
            var configuration = new Configuration("YOUR_API_KEY");
            var apiInstance = new FingerprintApi(configuration);
            var visitorId = visitorId_example;  // string | Unique [visitor identifier](https://dev.fingerprint.com/docs/js-agent#visitorid) issued by Fingerprint Pro.
            var requestId = requestId_example;  // string | Filter visits by `requestId`.   Every identification request has a unique identifier associated with it called `requestId`. This identifier is returned to the client in the identification [result](https://dev.fingerprint.com/docs/js-agent#requestid). When you filter visits by `requestId`, only one visit will be returned.  (optional) 
            var linkedId = linkedId_example;  // string | Filter visits by your custom identifier.   You can use [`linkedId`](https://dev.fingerprint.com/docs/js-agent#linkedid) to associate identification requests with your own identifier, for example: session ID, purchase ID, or transaction ID. You can then use this `linked_id` parameter to retrieve all events associated with your custom identifier.  (optional) 
            var limit = 56;  // int? | Limit scanned results.   For performance reasons, the API first scans some number of events before filtering them. Use `limit` to specify how many events are scanned before they are filtered by `requestId` or `linkedId`. Results are always returned sorted by the timestamp (most recent first). By default, the most recent 100 visits are scanned, the maximum is 500.  (optional) 
            var paginationKey = paginationKey_example;  // string | Use `paginationKey` to get the next page of results.   When more results are available (e.g., you requested 200 results using `limit` parameter, but a total of 600 results are available), the `paginationKey` top-level attribute is added to the response. The key corresponds to the `requestId` of the last returned event. In the following request, use that value in the `paginationKey` parameter to get the next page of results:  1. First request, returning most recent 200 events: `GET api-base-url/visitors/:visitorId?limit=200` 2. Use `response.paginationKey` to get the next page of results: `GET api-base-url/visitors/:visitorId?limit=200&paginationKey=1683900801733.Ogvu1j`  Pagination happens during scanning and before filtering, so you can get less visits than the `limit` you specified with more available on the next page. When there are no more results available for scanning, the `paginationKey` attribute is not returned.  (optional) 
            var before = 789;  // long? | ⚠️ Deprecated pagination method, please use `paginationKey` instead. Timestamp (in milliseconds since epoch) used to paginate results.  (optional) 

            try
            {
                // Get visits by visitor ID
                Response result = apiInstance.GetVisits(visitorId, requestId, linkedId, limit, paginationKey, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FingerprintApi.GetVisits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **visitorId** | **string**| Unique [visitor identifier](https://dev.fingerprint.com/docs/js-agent#visitorid) issued by Fingerprint Pro. | 
 **requestId** | **string**| Filter visits by `requestId`.   Every identification request has a unique identifier associated with it called `requestId`. This identifier is returned to the client in the identification [result](https://dev.fingerprint.com/docs/js-agent#requestid). When you filter visits by `requestId`, only one visit will be returned.  | [optional] 
 **linkedId** | **string**| Filter visits by your custom identifier.   You can use [`linkedId`](https://dev.fingerprint.com/docs/js-agent#linkedid) to associate identification requests with your own identifier, for example: session ID, purchase ID, or transaction ID. You can then use this `linked_id` parameter to retrieve all events associated with your custom identifier.  | [optional] 
 **limit** | **int?**| Limit scanned results.   For performance reasons, the API first scans some number of events before filtering them. Use `limit` to specify how many events are scanned before they are filtered by `requestId` or `linkedId`. Results are always returned sorted by the timestamp (most recent first). By default, the most recent 100 visits are scanned, the maximum is 500.  | [optional] 
 **paginationKey** | **string**| Use `paginationKey` to get the next page of results.   When more results are available (e.g., you requested 200 results using `limit` parameter, but a total of 600 results are available), the `paginationKey` top-level attribute is added to the response. The key corresponds to the `requestId` of the last returned event. In the following request, use that value in the `paginationKey` parameter to get the next page of results:  1. First request, returning most recent 200 events: `GET api-base-url/visitors/:visitorId?limit=200` 2. Use `response.paginationKey` to get the next page of results: `GET api-base-url/visitors/:visitorId?limit=200&paginationKey=1683900801733.Ogvu1j`  Pagination happens during scanning and before filtering, so you can get less visits than the `limit` you specified with more available on the next page. When there are no more results available for scanning, the `paginationKey` attribute is not returned.  | [optional] 
 **before** | **long?**| ⚠️ Deprecated pagination method, please use `paginationKey` instead. Timestamp (in milliseconds since epoch) used to paginate results.  | [optional] 

### Return type

[**Response**](Response.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
