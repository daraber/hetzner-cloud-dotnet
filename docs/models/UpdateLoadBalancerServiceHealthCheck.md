# Hetzner.Cloud.Model.UpdateLoadBalancerServiceHealthCheck
Service health check

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Http** | [**UpdateLoadBalancerServiceHealthCheckHttp**](UpdateLoadBalancerServiceHealthCheckHttp.md) |  | [optional] 
**Interval** | **int** | Time interval in seconds health checks are performed | [optional] 
**Port** | **int** | Port the health check will be performed on | [optional] 
**Protocol** | **string** | Type of the health check | [optional] 
**Retries** | **int** | Unsuccessful retries needed until a target is considered unhealthy; an unhealthy target needs the same number of successful retries to become healthy again | [optional] 
**Timeout** | **int** | Time in seconds after an attempt is considered a timeout | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

