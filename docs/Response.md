# FingerprintPro.ServerSdk.Model.Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VisitorId** | **string** |  | 
**Visits** | [**List&lt;ResponseVisits&gt;**](ResponseVisits.md) |  | 
**LastTimestamp** | **long?** | ⚠️ Deprecated paging attribute, please use &#x60;paginationKey&#x60; instead. Timestamp of the last visit in the current page of results.  | [optional] 
**PaginationKey** | **string** | Request ID of the last visit in the current page of results. Use this value in the following request as the &#x60;paginationKey&#x60; parameter to get the next page of results. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

