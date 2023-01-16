# Fingerprint.Sdk.Api.FingerprintApi

All URIs are relative to *https://api.fpjs.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEvent**](FingerprintApi.md#getevent) | **GET** /events/{request_id} | Get event by requestId
[**GetVisits**](FingerprintApi.md#getvisits) | **GET** /visitors/{visitor_id} | Get visits by visitorId

<a name="getevent"></a>
# **GetEvent**
> EventResponse GetEvent (string requestId)

Get event by requestId

This endpoint allows you to get events with all the information from each activated product (Fingerprint Pro or Bot Detection). Use the requestId as a URL path :request_id parameter. This API method is scoped to a request, i.e. all returned information is by requestId.

### Example
```csharp
using System;
using System.Diagnostics;
using Fingerprint.Sdk.Api;
using Fingerprint.Sdk.Client;
using Fingerprint.Sdk.Model;

namespace Example
{
    public class GetEventExample
    {
        public void main()
        {
            var configuration = new Configuration("YOUR_API_KEY");
            var apiInstance = new FingerprintApi(configuration);
            var requestId = requestId_example;  // string | requestId is the unique identifier of each request

            try
            {
                // Get event by requestId
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
 **requestId** | **string**| requestId is the unique identifier of each request | 

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
> Response GetVisits (string visitorId, string requestId = null, string linkedId = null, int? limit = null, int? before = null)

Get visits by visitorId

This endpoint allows you to get a history of visits with all available information. Use the visitorId as a URL path parameter. This API method is scoped to a visitor, i.e. all returned information is by visitorId.

### Example
```csharp
using System;
using System.Diagnostics;
using Fingerprint.Sdk.Api;
using Fingerprint.Sdk.Client;
using Fingerprint.Sdk.Model;

namespace Example
{
    public class GetVisitsExample
    {
        public void main()
        {
            var configuration = new Configuration("YOUR_API_KEY");
            var apiInstance = new FingerprintApi(configuration);
            var visitorId = visitorId_example;  // string | 
            var requestId = requestId_example;  // string | Filter visits by requestId (optional) 
            var linkedId = linkedId_example;  // string | Filter visits by custom identifier (optional) 
            var limit = 56;  // int? | Limit scanned results (optional) 
            var before = 56;  // int? | Used to paginate results (optional) 

            try
            {
                // Get visits by visitorId
                Response result = apiInstance.GetVisits(visitorId, requestId, linkedId, limit, before);
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
 **visitorId** | **string**|  | 
 **requestId** | **string**| Filter visits by requestId | [optional] 
 **linkedId** | **string**| Filter visits by custom identifier | [optional] 
 **limit** | **int?**| Limit scanned results | [optional] 
 **before** | **int?**| Used to paginate results | [optional] 

### Return type

[**Response**](Response.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
