# Hetzner.Cloud.Model.UpdateLoadBalancerService
An update to a service for a Load Balancer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ListenPort** | **int** | Port the Load Balancer listens on | 
**DestinationPort** | **int** | Port the Load Balancer will balance to | [optional] 
**HealthCheck** | [**UpdateLoadBalancerServiceHealthCheck**](UpdateLoadBalancerServiceHealthCheck.md) |  | [optional] 
**Http** | [**Http**](Http.md) |  | [optional] 
**Protocol** | **string** | Protocol of the Load Balancer | [optional] 
**Proxyprotocol** | **bool** | Is Proxyprotocol enabled or not | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

