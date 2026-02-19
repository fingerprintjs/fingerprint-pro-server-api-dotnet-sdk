# Fingerprint.ServerSdk.Model.EventRuleActionBlock
Informs the client the request should be blocked using the response described by this rule action.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RulesetId** | **string** | The ID of the evaluated ruleset. | 
**Type** | **RuleActionType** |  | 
**RuleId** | **string** | The ID of the rule that matched the identification event. | [optional] 
**RuleExpression** | **string** | The expression of the rule that matched the identification event. | [optional] 
**StatusCode** | **int** | A valid HTTP status code. | [optional] 
**Headers** | [**List&lt;RuleActionHeaderField&gt;**](RuleActionHeaderField.md) | A list of headers to send. | [optional] 
**Body** | **string** | The response body to send to the client. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

