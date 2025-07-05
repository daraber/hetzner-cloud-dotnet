# Hetzner.Cloud.Api.PlacementGroupsApi

All URIs are relative to *https://api.hetzner.cloud/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePlacementgroup**](PlacementGroupsApi.md#createplacementgroup) | **POST** /placement_groups | Create a PlacementGroup |
| [**DeletePlacementgroup**](PlacementGroupsApi.md#deleteplacementgroup) | **DELETE** /placement_groups/{id} | Delete a PlacementGroup |
| [**GetPlacementgroup**](PlacementGroupsApi.md#getplacementgroup) | **GET** /placement_groups/{id} | Get a PlacementGroup |
| [**ListPlacementgroups**](PlacementGroupsApi.md#listplacementgroups) | **GET** /placement_groups | Get all PlacementGroups |
| [**ReplacePlacementgroup**](PlacementGroupsApi.md#replaceplacementgroup) | **PUT** /placement_groups/{id} | Update a PlacementGroup |

<a id="createplacementgroup"></a>
# **CreatePlacementgroup**
> CreatePlacementgroupResponse CreatePlacementgroup (CreatePlacementgroupRequest createPlacementgroupRequest = null)

Create a PlacementGroup

Creates a new PlacementGroup. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createPlacementgroupRequest** | [**CreatePlacementgroupRequest**](CreatePlacementgroupRequest.md) |  | [optional]  |

### Return type

[**CreatePlacementgroupResponse**](CreatePlacementgroupResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;PlacementGroup&#x60; key contains the PlacementGroup that was just created. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteplacementgroup"></a>
# **DeletePlacementgroup**
> void DeletePlacementgroup (long id)

Delete a PlacementGroup

Deletes a PlacementGroup.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Placement Group. |  |

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | PlacementGroup deleted |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getplacementgroup"></a>
# **GetPlacementgroup**
> GetPlacementgroupResponse GetPlacementgroup (long id)

Get a PlacementGroup

Gets a specific PlacementGroup object.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Placement Group. |  |

### Return type

[**GetPlacementgroupResponse**](GetPlacementgroupResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;placement_group&#x60; key contains a PlacementGroup object |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listplacementgroups"></a>
# **ListPlacementgroups**
> ListPlacementgroupsResponse ListPlacementgroups (string sort = null, string name = null, string labelSelector = null, string type = null, long page = null, long perPage = null)

Get all PlacementGroups

Returns all PlacementGroup objects.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sort** | **string** | Sort resources by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **name** | **string** | Filter resources by their name. The response will only contain the resources matching the specified name.  | [optional]  |
| **labelSelector** | **string** | Filter resources by labels. The response will only contain resources matching the label selector. For more information, see \&quot;[Label Selector](#label-selector)\&quot;.  | [optional]  |
| **type** | **string** | Can be used multiple times. The response will only contain PlacementGroups matching the type. | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListPlacementgroupsResponse**](ListPlacementgroupsResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;placement_groups&#x60; key contains an array of PlacementGroup objects |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="replaceplacementgroup"></a>
# **ReplacePlacementgroup**
> ReplacePlacementgroupResponse ReplacePlacementgroup (long id, ReplacePlacementgroupRequest replacePlacementgroupRequest = null)

Update a PlacementGroup

Updates the PlacementGroup properties.  Note that when updating labels, the PlacementGroup’s current set of labels will be replaced with the labels provided in the request body. So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body.  Note: if the PlacementGroup object changes during the request, the response will be a “conflict” error. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Placement Group. |  |
| **replacePlacementgroupRequest** | [**ReplacePlacementgroupRequest**](ReplacePlacementgroupRequest.md) |  | [optional]  |

### Return type

[**ReplacePlacementgroupResponse**](ReplacePlacementgroupResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;certificate&#x60; key contains the PlacementGroup that was just updated |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

