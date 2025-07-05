# Hetzner.Cloud.Model.CreateFloatingIpRequest
Request for POST https://api.hetzner.cloud/v1/floating_ips

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **IpType** |  | 
**Description** | **string** | Description of the Resource. | [optional] 
**HomeLocation** | **string** | Home [Location](#locations) for the [Floating IP](#floating-ips).  Either the ID or the name of the [Location](#locations).  Only optional if no [Server](#servers) is provided. Routing is optimized for this [Locations](#locations).  | [optional] 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | [optional] 
**Name** | **string** | Name of the Resource. Must be unique per Project. | [optional] 
**Server** | **long** | [Server](#servers) the [Floating IP](#floating-ips) is assigned to.  &#x60;null&#x60; if not assigned.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

