# FingerprintPro.ServerSdk.Model.Botd
Contains all the information from Bot Detection product

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bot** | [**BotdBot**](BotdBot.md) |  | 
**Meta** | [**Tag**](Tag.md) |  | [optional] 
**LinkedId** | **string** | A customer-provided id that was sent with the request. | [optional] 
**Url** | **string** | Page URL from which the request was sent. | 
**Ip** | **string** | IP address of the requesting browser or bot. | 
**Time** | **DateTime?** | Time in UTC when the request from the JS agent was made. We recommend to treat requests that are older than 2 minutes as malicious. Otherwise, request replay attacks are possible. | 
**UserAgent** | **string** |  | 
**RequestId** | **string** | Unique identifier of the user's request. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

