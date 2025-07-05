# Hetzner.Cloud.Model.CreatePrimaryIpRequest
Request for POST https://api.hetzner.cloud/v1/primary_ips

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssigneeType** | **string** | Type of resource the [Primary IP](#primary-ips) can get assigned to.  Currently [Primary IPs](#primary-ips) can only be assigned to [Servers](#servers), therefore this field must be set to &#x60;server&#x60;.  | 
**Name** | **string** | Name of the Resource. Must be unique per Project. | 
**Type** | **IpType** |  | 
**AssigneeId** | **long** | ID of resource to assign the [Primary IP](#primary-ips) to.  Omitted if the [Primary IP](#primary-ips) should not get assigned.  | [optional] 
**AutoDelete** | **bool** | Auto deletion state.  If enabled the [Primary IP](#primary-ips) will be deleted once the assigned resource gets deleted.  | [optional] [default to false]
**Datacenter** | **string** | [Datacenter](#datacenters) ID or name.  The  [Primary IP](#primary-ips) will be bound to this [Datacenter](#datacenters). Omit if &#x60;assignee_id&#x60;/&#x60;assignee_type&#x60; is provided.  | [optional] 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

