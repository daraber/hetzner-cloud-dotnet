# Hetzner.Cloud.Model.CreateNetworkRequest
Request for POST https://api.hetzner.cloud/v1/networks

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpRange** | **string** | IP range of the [Network](#networks).  Uses CIDR notation.  Must span all included subnets. Must be one of the private IPv4 ranges of RFC1918.  Minimum network size is /24. We highly recommend that you pick a larger [Network](#networks) with a /16 netmask.  | 
**Name** | **string** | Name of the [Network](#networks). | 
**ExposeRoutesToVswitch** | **bool** | Toggle to expose routes to the [Networks](#networks) vSwitch.  Indicates if the routes from this [Network](#networks) should be exposed to the vSwitch in this [Network](#networks). Only takes effect if a [vSwitch is setup](https://docs.hetzner.com/cloud/networks/connect-dedi-vswitch) in this [Network](#networks).  | [optional] 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | [optional] 
**Routes** | [**List&lt;Route&gt;**](Route.md) | Array of routes set in this [Network](#networks). | [optional] 
**Subnets** | [**List&lt;Subnet&gt;**](Subnet.md) | Array of subnets to allocate. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

