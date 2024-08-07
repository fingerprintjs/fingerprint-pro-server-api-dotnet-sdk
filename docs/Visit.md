# FingerprintPro.ServerSdk.Model.Visit
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestId** | **string** | Unique identifier of the user's identification request. | 
**BrowserDetails** | [**BrowserDetails**](BrowserDetails.md) |  | 
**Incognito** | **bool?** | Flag if user used incognito session. | 
**Ip** | **string** |  | 
**IpLocation** | [**DeprecatedIPLocation**](DeprecatedIPLocation.md) |  | [optional] 
**Timestamp** | **long?** | Timestamp of the event with millisecond precision in Unix time. | 
**Time** | **DateTime?** | Time expressed according to ISO 8601 in UTC format. | 
**Url** | **string** | Page URL from which the identification request was sent. | 
**Tag** | **Dictionary&lt;string, Object&gt;** | A customer-provided value or an object that was sent with identification request. | [optional] 
**LinkedId** | **string** | A customer-provided id that was sent with identification request. | [optional] 
**Confidence** | [**Confidence**](Confidence.md) |  | [optional] 
**VisitorFound** | **bool?** | Attribute represents if a visitor had been identified before. | 
**FirstSeenAt** | [**SeenAt**](SeenAt.md) |  | 
**LastSeenAt** | [**SeenAt**](SeenAt.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

