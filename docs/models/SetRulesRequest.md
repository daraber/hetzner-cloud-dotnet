# Hetzner.Cloud.Model.SetRulesRequest
Request for POST https://api.hetzner.cloud/v1/firewalls/{id}/actions/set_rules

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rules** | [**List&lt;Rule&gt;**](Rule.md) | Array of rules.  Rules are limited to 50 entries per [Firewall](#firewalls) and [500 effective rules](https://docs.hetzner.com/cloud/firewalls/overview#limits).  Existing rules will be replaced.  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

