# Fingerprint.ServerSdk.Model.EventSearch
Contains a list of all identification events matching the specified search criteria.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Events** | [**List&lt;Event&gt;**](Event.md) |  | 
**PaginationKey** | **string** | Use this value in the `pagination_key` parameter to request the next page of search results. | [optional] 
**TotalHits** | **long** | This value represents the total number of events matching the search query, up to the limit provided in the `total_hits` query parameter. Only present if the `total_hits` query parameter was provided. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

