# Hetzner.Cloud.Model.LoadBalancerServiceHealthCheckHttp
Additional configuration for protocol http

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | HTTP path to use for health checks. May not contain literal spaces, use percent-encoding instead. | 
**Domain** | **string** | Host header to send in the HTTP request. May not contain spaces, percent or backslash symbols. Can be null, in that case no host header is sent. | 
**Response** | **string** | String that must be contained in HTTP response in order to pass the health check | [optional] 
**StatusCodes** | **List&lt;string&gt;** | List of returned HTTP status codes in order to pass the health check. Supports the wildcards &#x60;?&#x60; for exactly one character and &#x60;*&#x60; for multiple ones. | [optional] 
**Tls** | **bool** | Use HTTPS for health check | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

