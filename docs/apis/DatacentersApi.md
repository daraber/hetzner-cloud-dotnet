# Hetzner.Cloud.Api.DatacentersApi

All URIs are relative to *https://api.hetzner.cloud/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDatacenter**](DatacentersApi.md#getdatacenter) | **GET** /datacenters/{id} | Get a Datacenter |
| [**ListDatacenters**](DatacentersApi.md#listdatacenters) | **GET** /datacenters | Get all Datacenters |

<a id="getdatacenter"></a>
# **GetDatacenter**
> GetDatacenterResponse GetDatacenter (long id)

Get a Datacenter

Returns a single [Datacenter](#datacenters).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Datacenter. |  |

### Return type

[**GetDatacenterResponse**](GetDatacenterResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contains the queried [Datacenter](#datacenters). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listdatacenters"></a>
# **ListDatacenters**
> ListDatacentersResponse ListDatacenters (string name = null, string sort = null, long page = null, long perPage = null)

Get all Datacenters

Returns all [Datacenters](#datacenters).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Filter resources by their name. The response will only contain the resources matching the specified name.  | [optional]  |
| **sort** | **string** | Sort resources by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListDatacentersResponse**](ListDatacentersResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contains the queried [Datacenters](#datacenters). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

