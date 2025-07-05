# Hetzner.Cloud.Api.IsosApi

All URIs are relative to *https://api.hetzner.cloud/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetIso**](IsosApi.md#getiso) | **GET** /isos/{id} | Get an ISO |
| [**ListIsos**](IsosApi.md#listisos) | **GET** /isos | Get all ISOs |

<a id="getiso"></a>
# **GetIso**
> GetIsoResponse GetIso (long id)

Get an ISO

Returns a specific ISO object.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the ISO. |  |

### Return type

[**GetIsoResponse**](GetIsoResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;iso&#x60; key in the reply contains an array of ISO objects with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listisos"></a>
# **ListIsos**
> ListIsosResponse ListIsos (string name = null, string architecture = null, bool includeArchitectureWildcard = null, long page = null, long perPage = null)

Get all ISOs

Returns all available ISO objects.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Filter resources by their name. The response will only contain the resources matching the specified name.  | [optional]  |
| **architecture** | **string** | Return only ISOs with the given architecture. | [optional]  |
| **includeArchitectureWildcard** | **bool** | Include Images with wildcard architecture (architecture is null). Works only if architecture filter is specified. | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListIsosResponse**](ListIsosResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;isos&#x60; key in the reply contains an array of iso objects with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

