# Hetzner.Cloud.Model.LoadBalancer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Algorithm** | [**LoadBalancerAlgorithm**](LoadBalancerAlgorithm.md) |  | 
**Created** | **string** | Point in time when the Resource was created (in ISO-8601 format). | 
**Id** | **long** | ID of the Load Balancer. | 
**IncludedTraffic** | **long** | Free Traffic for the current billing period in bytes | 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | 
**LoadBalancerType** | [**LoadBalancerType**](LoadBalancerType.md) |  | 
**Location** | [**Location**](Location.md) |  | 
**Name** | **string** | Name of the Resource. Must be unique per Project. | 
**PrivateNet** | [**List&lt;LoadBalancerPrivateNet&gt;**](LoadBalancerPrivateNet.md) | Private networks information | 
**Protection** | [**Protection**](Protection.md) |  | 
**PublicNet** | [**LoadBalancerPublicNet**](LoadBalancerPublicNet.md) |  | 
**Services** | [**List&lt;LoadBalancerService&gt;**](LoadBalancerService.md) | List of services that belong to this Load Balancer | 
**Targets** | [**List&lt;LoadBalancerTarget&gt;**](LoadBalancerTarget.md) | List of targets that belong to this Load Balancer | 
**IngoingTraffic** | **long** | Inbound Traffic for the current billing period in bytes | 
**OutgoingTraffic** | **long** | Outbound Traffic for the current billing period in bytes | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

