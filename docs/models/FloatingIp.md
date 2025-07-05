# Hetzner.Cloud.Model.FloatingIp

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Blocked** | **bool** | Indicates whether the [Floating IP](#floating-ips) is blocked. | 
**Created** | **string** | Point in time when the Resource was created (in ISO-8601 format). | 
**DnsPtr** | [**List&lt;DnsPtr&gt;**](DnsPtr.md) | List of reverse DNS entries for the [Floating IP](#floating-ips).  | 
**HomeLocation** | [**Location**](Location.md) |  | 
**Id** | **long** | ID of the Floating IP. | 
**Ip** | **string** | IP address. | 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | 
**Name** | **string** | Name of the Resource. Must be unique per Project. | 
**Protection** | [**Protection**](Protection.md) |  | 
**Type** | **IpType** |  | 
**Description** | **string** | Description of the Resource. | 
**Server** | **long** | [Server](#servers) the [Floating IP](#floating-ips) is assigned to.  &#x60;null&#x60; if not assigned.  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

