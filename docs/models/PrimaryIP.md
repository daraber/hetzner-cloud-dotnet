# Hetzner.Cloud.Model.PrimaryIP

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssigneeType** | **string** | Type of resource the [Primary IP](#primary-ips) can get assigned to.  | 
**Blocked** | **bool** | Blocked state of the [Primary IP](#primary-ips). | 
**Created** | **string** | Point in time when the Resource was created (in ISO-8601 format). | 
**Datacenter** | [**Datacenter**](Datacenter.md) |  | 
**DnsPtr** | [**List&lt;DnsPtr&gt;**](DnsPtr.md) | List of reverse DNS records. | 
**Id** | **long** | ID of the Primary IP. | 
**Ip** | **string** | IP address. | 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | 
**Name** | **string** | Name of the Resource. Must be unique per Project. | 
**Protection** | [**Protection**](Protection.md) |  | 
**Type** | **IpType** |  | 
**AssigneeId** | **long** | ID of resource the [Primary IP](#primary-ips) is assigned to.  &#x60;null&#x60; if the [Primary IP](#primary-ips) is not assigned.  | 
**AutoDelete** | **bool** | Auto deletion state.  If enabled the [Primary IP](#primary-ips) will be deleted once the assigned resource gets deleted.  | [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

