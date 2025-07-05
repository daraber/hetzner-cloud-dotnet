# Hetzner.Cloud.Model.LoadBalancerAddTarget
A target to be added to a load balancer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the resource | 
**Ip** | [**LoadBalancerTargetIp**](LoadBalancerTargetIp.md) |  | [optional] 
**LabelSelector** | [**LabelSelector**](LabelSelector.md) |  | [optional] 
**Server** | [**ResourceId**](ResourceId.md) |  | [optional] 
**UsePrivateIp** | **bool** | Use the private network IP instead of the public IP of the Server, requires the Server and Load Balancer to be in the same network. | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

