# Fingerprint.ServerSdk.Model.EventRuleActionAllow
Informs the client that the request should be forwarded to the origin with optional request header modifications.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RulesetId** | **string** | The ID of the evaluated ruleset. | 
**Type** | **string** | Describes the action to take with the request. | 
**RuleId** | **string** | The ID of the rule that matched the identification event. | [optional] 
**RuleExpression** | **string** | The expression of the rule that matched the identification event. | [optional] 
**RequestHeaderModifications** | [**RequestHeaderModifications**](RequestHeaderModifications.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

