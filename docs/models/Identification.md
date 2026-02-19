# Fingerprint.ServerSdk.Model.Identification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VisitorId** | **string** | String of 20 characters that uniquely identifies the visitor's browser or mobile device. | 
**VisitorFound** | **bool** | Attribute represents if a visitor had been identified before. | 
**Confidence** | [**IdentificationConfidence**](IdentificationConfidence.md) |  | [optional] 
**FirstSeenAt** | **long** | Unix epoch time milliseconds timestamp indicating the time at which this visitor ID was first seen. example: `1758069706642` - Corresponding to Wed Sep 17 2025 00:41:46 GMT+0000  | [optional] 
**LastSeenAt** | **long** | Unix epoch time milliseconds timestamp indicating the time at which this visitor ID was last seen. example: `1758069706642` - Corresponding to Wed Sep 17 2025 00:41:46 GMT+0000  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

