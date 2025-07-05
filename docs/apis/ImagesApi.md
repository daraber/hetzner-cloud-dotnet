# Hetzner.Cloud.Api.ImagesApi

All URIs are relative to *https://api.hetzner.cloud/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChangeImageProtection**](ImagesApi.md#changeimageprotection) | **POST** /images/{id}/actions/change_protection | Change Image Protection |
| [**DeleteImage**](ImagesApi.md#deleteimage) | **DELETE** /images/{id} | Delete an Image |
| [**GetActionForImage**](ImagesApi.md#getactionforimage) | **GET** /images/{id}/actions/{action_id} | Get an Action for an Image |
| [**GetImage**](ImagesApi.md#getimage) | **GET** /images/{id} | Get an Image |
| [**GetImageAction**](ImagesApi.md#getimageaction) | **GET** /images/actions/{id} | Get an Action |
| [**ListActionsForImage**](ImagesApi.md#listactionsforimage) | **GET** /images/{id}/actions | Get all Actions for an Image |
| [**ListImageActions**](ImagesApi.md#listimageactions) | **GET** /images/actions | Get all Actions |
| [**ListImages**](ImagesApi.md#listimages) | **GET** /images | Get all Images |
| [**ReplaceImage**](ImagesApi.md#replaceimage) | **PUT** /images/{id} | Update an Image |

<a id="changeimageprotection"></a>
# **ChangeImageProtection**
> ChangeImageProtectionResponse ChangeImageProtection (long id, ChangeImageProtectionRequest changeImageProtectionRequest = null)

Change Image Protection

Changes the protection configuration of the Image. Can only be used on snapshots.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Image. |  |
| **changeImageProtectionRequest** | [**ChangeImageProtectionRequest**](ChangeImageProtectionRequest.md) |  | [optional]  |

### Return type

[**ChangeImageProtectionResponse**](ChangeImageProtectionResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains the &#x60;change_protection&#x60; Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteimage"></a>
# **DeleteImage**
> void DeleteImage (long id)

Delete an Image

Deletes an Image. Only Images of type `snapshot` and `backup` can be deleted.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Image. |  |

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
| **204** | Image deleted |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getactionforimage"></a>
# **GetActionForImage**
> GetActionForImageResponse GetActionForImage (long id, long actionId)

Get an Action for an Image

Returns a specific Action for an Image.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Image. |  |
| **actionId** | **long** | ID of the Action. |  |

### Return type

[**GetActionForImageResponse**](GetActionForImageResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;action&#x60; key contains the Image Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getimage"></a>
# **GetImage**
> GetImageResponse GetImage (long id)

Get an Image

Returns a specific Image object.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Image. |  |

### Return type

[**GetImageResponse**](GetImageResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;image&#x60; key in the reply contains an Image object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getimageaction"></a>
# **GetImageAction**
> GetActionResponse GetImageAction (long id)

Get an Action

Returns a specific Action object.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Action |  |

### Return type

[**GetActionResponse**](GetActionResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;action&#x60; key in the reply has this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listactionsforimage"></a>
# **ListActionsForImage**
> ListActionsForImageResponse ListActionsForImage (long id, string sort = null, string status = null, long page = null, long perPage = null)

Get all Actions for an Image

Returns all Action objects for an Image. You can sort the results by using the `sort` URI parameter, and filter them with the `status` parameter.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Image. |  |
| **sort** | **string** | Sort actions by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **status** | **string** | Filter the actions by status. Can be used multiple times. The response will only contain actions matching the specified statuses.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListActionsForImageResponse**](ListActionsForImageResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;actions&#x60; key contains a list of Actions |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listimageactions"></a>
# **ListImageActions**
> ListActionsResponse ListImageActions (long id = null, string sort = null, string status = null, long page = null, long perPage = null)

Get all Actions

Returns all Action objects. You can `sort` the results by using the sort URI parameter, and filter them with the `status` and `id` parameter.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Filter the actions by ID. Can be used multiple times. The response will only contain actions matching the specified IDs.  | [optional]  |
| **sort** | **string** | Sort actions by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **status** | **string** | Filter the actions by status. Can be used multiple times. The response will only contain actions matching the specified statuses.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListActionsResponse**](ListActionsResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;actions&#x60; key contains a list of Actions |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listimages"></a>
# **ListImages**
> ListImagesResponse ListImages (string sort = null, string type = null, string status = null, string boundTo = null, bool includeDeprecated = null, string name = null, string labelSelector = null, string architecture = null, long page = null, long perPage = null)

Get all Images

Returns all Image objects. You can select specific Image types only and sort the results by using URI parameters.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sort** | **string** | Sort resources by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **type** | **string** | Can be used multiple times. | [optional]  |
| **status** | **string** | Can be used multiple times. The response will only contain Images matching the status. | [optional]  |
| **boundTo** | **string** | Can be used multiple times. Server ID linked to the Image. Only available for Images of type &#x60;backup&#x60; | [optional]  |
| **includeDeprecated** | **bool** | Can be used multiple times. | [optional]  |
| **name** | **string** | Filter resources by their name. The response will only contain the resources matching the specified name.  | [optional]  |
| **labelSelector** | **string** | Filter resources by labels. The response will only contain resources matching the label selector. For more information, see \&quot;[Label Selector](#label-selector)\&quot;.  | [optional]  |
| **architecture** | **string** | Return only Images with the given architecture. | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListImagesResponse**](ListImagesResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;images&#x60; key in the reply contains an array of Image objects with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="replaceimage"></a>
# **ReplaceImage**
> ReplaceImageResponse ReplaceImage (long id, ReplaceImageRequest replaceImageRequest = null)

Update an Image

Updates the Image. You may change the description, convert a Backup Image to a Snapshot Image or change the Image labels. Only Images of type `snapshot` and `backup` can be updated.  Note that when updating labels, the current set of labels will be replaced with the labels provided in the request body. So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Image. |  |
| **replaceImageRequest** | [**ReplaceImageRequest**](ReplaceImageRequest.md) |  | [optional]  |

### Return type

[**ReplaceImageResponse**](ReplaceImageResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The image key in the reply contains the modified Image object |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

