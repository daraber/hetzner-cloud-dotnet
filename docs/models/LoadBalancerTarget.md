# Hetzner.Cloud.Model.LoadBalancerTarget
A target of a Load Balancer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the resource | 
**HealthStatus** | [**List&lt;LoadBalancerTargetHealthStatus&gt;**](LoadBalancerTargetHealthStatus.md) | List of health statuses of the services on this target. Only present for target types \&quot;server\&quot; and \&quot;ip\&quot;. | [optional] 
**Ip** | [**LoadBalancerTargetIp**](LoadBalancerTargetIp.md) |  | [optional] 
**LabelSelector** | [**LabelSelector**](LabelSelector.md) |  | [optional] 
**Server** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Targets** | [**List&lt;LoadBalancerSelectedTarget&gt;**](LoadBalancerSelectedTarget.md) | List of resolved label selector target Servers. Only present for type \&quot;label_selector\&quot;. | [optional] 
**UsePrivateIp** | **bool** | Use the private network IP instead of the public IP. Only present for target types \&quot;server\&quot; and \&quot;label_selector\&quot;. | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

