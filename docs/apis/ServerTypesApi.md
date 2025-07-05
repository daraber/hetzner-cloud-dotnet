# Hetzner.Cloud.Api.ServerTypesApi

All URIs are relative to *https://api.hetzner.cloud/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetServerType**](ServerTypesApi.md#getservertype) | **GET** /server_types/{id} | Get a Server Type |
| [**ListServerTypes**](ServerTypesApi.md#listservertypes) | **GET** /server_types | Get all Server Types |

<a id="getservertype"></a>
# **GetServerType**
> GetServerTypeResponse GetServerType (long id)

Get a Server Type

Gets a specific Server type object.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server Type. |  |

### Return type

[**GetServerTypeResponse**](GetServerTypeResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;server_type&#x60; key in the reply contains a Server type object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listservertypes"></a>
# **ListServerTypes**
> ListServerTypesResponse ListServerTypes (string name = null, long page = null, long perPage = null)

Get all Server Types

Gets all Server type objects.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Filter resources by their name. The response will only contain the resources matching the specified name.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListServerTypesResponse**](ListServerTypesResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;server_types&#x60; key in the reply contains an array of Server type objects with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

