# FingerprintPro.ServerSdk.Model.Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VisitorId** | **string** |  | 
**Visits** | [**List&lt;ResponseVisits&gt;**](ResponseVisits.md) |  | 
**LastTimestamp** | **long?** | When more results are available (e.g., you scanned 200 results using &#x60;limit&#x60; parameter, but a total of 600 results are available), a special &#x60;lastTimestamp&#x60; top-level attribute is added to the response. If you want to paginate the results further in the past, you should use the value of this attribute. | [optional] 
**PaginationKey** | **string** | Visit&#x27;s &#x60;requestId&#x60; of the last visit in the current page. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

