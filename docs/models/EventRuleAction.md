# Fingerprint.ServerSdk.Model.EventRuleAction
Describes the action the client should take, according to the rule in the ruleset that matched the event. When getting an event by event ID, the rule_action will only be included when the ruleset_id query parameter is specified.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RulesetId** | **string** | The ID of the evaluated ruleset. | 
**Type** | **RuleActionType** |  | 
**RuleId** | **string** | The ID of the rule that matched the identification event. | [optional] 
**RuleExpression** | **string** | The expression of the rule that matched the identification event. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

