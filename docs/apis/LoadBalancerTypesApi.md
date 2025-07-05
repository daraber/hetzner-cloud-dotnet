# Hetzner.Cloud.Api.LoadBalancerTypesApi

All URIs are relative to *https://api.hetzner.cloud/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetLoadBalancerType**](LoadBalancerTypesApi.md#getloadbalancertype) | **GET** /load_balancer_types/{id} | Get a Load Balancer Type |
| [**ListLoadBalancerTypes**](LoadBalancerTypesApi.md#listloadbalancertypes) | **GET** /load_balancer_types | Get all Load Balancer Types |

<a id="getloadbalancertype"></a>
# **GetLoadBalancerType**
> GetLoadBalancerTypeResponse GetLoadBalancerType (long id)

Get a Load Balancer Type

Gets a specific Load Balancer type object.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer Type. |  |

### Return type

[**GetLoadBalancerTypeResponse**](GetLoadBalancerTypeResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;load_balancer_type&#x60; key in the reply contains a Load Balancer type object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listloadbalancertypes"></a>
# **ListLoadBalancerTypes**
> ListLoadBalancerTypesResponse ListLoadBalancerTypes (string name = null, long page = null, long perPage = null)

Get all Load Balancer Types

Gets all Load Balancer type objects.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Filter resources by their name. The response will only contain the resources matching the specified name.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListLoadBalancerTypesResponse**](ListLoadBalancerTypesResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;load_balancer_types&#x60; key in the reply contains an array of Load Balancer type objects with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

