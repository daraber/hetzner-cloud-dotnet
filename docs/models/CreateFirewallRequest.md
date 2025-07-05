# Hetzner.Cloud.Model.CreateFirewallRequest
Request for POST https://api.hetzner.cloud/v1/firewalls

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the [Firewall](#firewalls).  Limited to a maximum of 128 characters.  Must be unique per Project.  | 
**ApplyTo** | [**List&lt;FirewallResource&gt;**](FirewallResource.md) | Resources to apply the [Firewall](#firewalls) to.  Resources added directly are taking precedence over those added via a [Label Selector](#label-selector).  | [optional] 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | [optional] 
**Rules** | [**List&lt;Rule&gt;**](Rule.md) | Array of rules.  Rules are limited to 50 entries per [Firewall](#firewalls) and [500 effective rules](https://docs.hetzner.com/cloud/firewalls/overview#limits).  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

