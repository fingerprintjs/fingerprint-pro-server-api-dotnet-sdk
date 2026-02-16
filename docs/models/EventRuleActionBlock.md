# Fingerprint.ServerSdk.Model.EventRuleActionBlock
Informs the client the request should be blocked using the response described by this rule action.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **RuleActionType** |  | 
**StatusCode** | **int** | A valid HTTP status code. | [optional] 
**Headers** | [**List&lt;RuleActionHeaderField&gt;**](RuleActionHeaderField.md) | A list of headers to send. | [optional] 
**Body** | **string** | The response body to send to the client. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

