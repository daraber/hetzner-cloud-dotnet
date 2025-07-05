# Hetzner.Cloud.Model.Network

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Created** | **string** | Point in time when the Resource was created (in ISO-8601 format). | 
**ExposeRoutesToVswitch** | **bool** | Indicates if the routes from this [Network](#networks) should be exposed to the vSwitch connection. | 
**Id** | **long** | ID of the [Network](#networks). | 
**IpRange** | **string** | IP range of the [Network](#networks). Uses CIDR notation. | 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | 
**Name** | **string** | Name of the [Network](#networks). | 
**Protection** | [**Protection**](Protection.md) |  | 
**Routes** | [**List&lt;Route&gt;**](Route.md) | Array of routes set in this [Network](#networks). | 
**Servers** | **List&lt;long&gt;** | Array of IDs of [Servers](#servers) attached to this [Network](#networks). | 
**Subnets** | [**List&lt;SubnetWithGateway&gt;**](SubnetWithGateway.md) | List of subnets allocated in this [Network](#networks). | 
**LoadBalancers** | **List&lt;long&gt;** | Array of IDs of [Load Balancers](#load-balancers) attached to this [Network](#networks). | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

