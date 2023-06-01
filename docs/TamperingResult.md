# FingerprintPro.ServerSdk.Model.TamperingResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Result** | **bool?** | Flag indicating whether browser tampering was detected according to our internal thresholds. | [optional] 
**AnomalyScore** | [**decimal?**](BigDecimal.md) | Confidence score (`0.0 - 1.0`) for the tampering detection. Values above `0.5` suggest that we're reasonably sure there was a tampering attempt. Values below `0.5` are genuine browsers. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

