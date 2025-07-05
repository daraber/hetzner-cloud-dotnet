# Hetzner.Cloud.Model.Firewall
Firewalls can limit the network access to or from your resources.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppliedTo** | [**List&lt;FirewallResourceId&gt;**](FirewallResourceId.md) |  | 
**Created** | **string** | Point in time when the Resource was created (in ISO-8601 format). | 
**Id** | **long** | ID of the Firewall. | 
**Name** | **string** | Name of the [Firewall](#firewalls).  Limited to a maximum of 128 characters.  Must be unique per Project.  | 
**Rules** | [**List&lt;RuleResponse&gt;**](RuleResponse.md) |  | 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

