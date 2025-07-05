# Hetzner.Cloud.Model.CreateLoadBalancerRequest
Request for POST https://api.hetzner.cloud/v1/load_balancers

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoadBalancerType** | **string** | ID or name of the Load Balancer type this Load Balancer should be created with | 
**Name** | **string** | Name of the Load Balancer | 
**Algorithm** | [**LoadBalancerAlgorithm**](LoadBalancerAlgorithm.md) |  | [optional] 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | [optional] 
**Location** | **string** | ID or name of Location to create Load Balancer in | [optional] 
**Network** | **long** | ID of the network the Load Balancer should be attached to on creation | [optional] 
**NetworkZone** | **string** | Name of network zone | [optional] 
**PublicInterface** | **bool** | Enable or disable the public interface of the Load Balancer | [optional] 
**Services** | [**List&lt;LoadBalancerService&gt;**](LoadBalancerService.md) | Array of services | [optional] 
**Targets** | [**List&lt;LoadBalancerAddTarget&gt;**](LoadBalancerAddTarget.md) | Array of targets | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

