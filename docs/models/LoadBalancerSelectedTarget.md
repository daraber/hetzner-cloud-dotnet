# Hetzner.Cloud.Model.LoadBalancerSelectedTarget
Resolved label selector target Servers. Only present for type \"label_selector\".

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HealthStatus** | [**List&lt;LoadBalancerTargetHealthStatus&gt;**](LoadBalancerTargetHealthStatus.md) | List of health statuses of the services on this target. Only present for target types \&quot;server\&quot; and \&quot;ip\&quot;. | [optional] 
**Server** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Type** | **string** | Type of the resource. Here always \&quot;server\&quot;. | [optional] 
**UsePrivateIp** | **bool** | Use the private network IP instead of the public IP. Only present for target types \&quot;server\&quot; and \&quot;label_selector\&quot;. | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

