# FingerprintPro.ServerSdk.Model.Identification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VisitorId** | **string** | String of 20 characters that uniquely identifies the visitor's browser. | 
**RequestId** | **string** | Unique identifier of the user's request. | 
**BrowserDetails** | [**BrowserDetails**](BrowserDetails.md) |  | 
**Incognito** | **bool?** | Flag if user used incognito session. | 
**Ip** | **string** | IP address of the requesting browser or bot. | 
**IpLocation** | [**DeprecatedGeolocation**](DeprecatedGeolocation.md) |  | [optional] 
**LinkedId** | **string** | A customer-provided id that was sent with the request. | [optional] 
**Suspect** | **bool?** | Field is `true` if you have previously set the `suspect` flag for this event using the [Server API Update event endpoint](https://dev.fingerprint.com/reference/updateevent). | [optional] 
**Timestamp** | **long?** | Timestamp of the event with millisecond precision in Unix time. | 
**Time** | **DateTime?** | Time expressed according to ISO 8601 in UTC format, when the request from the JS agent was made. We recommend to treat requests that are older than 2 minutes as malicious. Otherwise, request replay attacks are possible. | 
**Url** | **string** | Page URL from which the request was sent. | 
**Tag** | [**Tag**](Tag.md) |  | 
**Confidence** | [**IdentificationConfidence**](IdentificationConfidence.md) |  | [optional] 
**VisitorFound** | **bool?** | Attribute represents if a visitor had been identified before. | 
**FirstSeenAt** | [**IdentificationSeenAt**](IdentificationSeenAt.md) |  | 
**LastSeenAt** | [**IdentificationSeenAt**](IdentificationSeenAt.md) |  | 
**Components** | [**RawDeviceAttributes**](RawDeviceAttributes.md) |  | [optional] 
**Replayed** | **bool?** | `true` if we determined that this payload was replayed, `false` otherwise.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

