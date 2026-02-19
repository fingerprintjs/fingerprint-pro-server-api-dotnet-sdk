# Fingerprint.ServerSdk.Model.TamperingDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnomalyScore** | **double** | Confidence score (`0.0 - 1.0`) for tampering detection:   * Values above `0.5` indicate tampering.   * Values below `0.5` indicate genuine browsers.  | [optional] 
**AntiDetectBrowser** | **bool** | True if the identified browser resembles an \"anti-detect\" browser, such as Incognition, which attempts to evade identification by manipulating its fingerprint.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

