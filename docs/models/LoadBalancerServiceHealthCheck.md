# Hetzner.Cloud.Model.LoadBalancerServiceHealthCheck
Service health check

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Interval** | **int** | Time interval in seconds health checks are performed | 
**Port** | **int** | Port the health check will be performed on | 
**Protocol** | **string** | Type of the health check | 
**Retries** | **int** | Unsuccessful retries needed until a target is considered unhealthy; an unhealthy target needs the same number of successful retries to become healthy again | 
**Timeout** | **int** | Time in seconds after an attempt is considered a timeout | 
**Http** | [**LoadBalancerServiceHealthCheckHttp**](LoadBalancerServiceHealthCheckHttp.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

