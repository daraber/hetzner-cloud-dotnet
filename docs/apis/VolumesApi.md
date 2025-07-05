# Hetzner.Cloud.Api.VolumesApi

All URIs are relative to *https://api.hetzner.cloud/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AttachVolumeToServer**](VolumesApi.md#attachvolumetoserver) | **POST** /volumes/{id}/actions/attach | Attach Volume to a Server |
| [**ChangeVolumeProtection**](VolumesApi.md#changevolumeprotection) | **POST** /volumes/{id}/actions/change_protection | Change Volume Protection |
| [**CreateVolume**](VolumesApi.md#createvolume) | **POST** /volumes | Create a Volume |
| [**DeleteVolume**](VolumesApi.md#deletevolume) | **DELETE** /volumes/{id} | Delete a Volume |
| [**DetachVolume**](VolumesApi.md#detachvolume) | **POST** /volumes/{id}/actions/detach | Detach Volume |
| [**GetActionForVolume**](VolumesApi.md#getactionforvolume) | **GET** /volumes/{id}/actions/{action_id} | Get an Action for a Volume |
| [**GetVolume**](VolumesApi.md#getvolume) | **GET** /volumes/{id} | Get a Volume |
| [**GetVolumeAction**](VolumesApi.md#getvolumeaction) | **GET** /volumes/actions/{id} | Get an Action |
| [**ListActionsForVolume**](VolumesApi.md#listactionsforvolume) | **GET** /volumes/{id}/actions | Get all Actions for a Volume |
| [**ListVolumeActions**](VolumesApi.md#listvolumeactions) | **GET** /volumes/actions | Get all Actions |
| [**ListVolumes**](VolumesApi.md#listvolumes) | **GET** /volumes | Get all Volumes |
| [**ReplaceVolume**](VolumesApi.md#replacevolume) | **PUT** /volumes/{id} | Update a Volume |
| [**ResizeVolume**](VolumesApi.md#resizevolume) | **POST** /volumes/{id}/actions/resize | Resize Volume |

<a id="attachvolumetoserver"></a>
# **AttachVolumeToServer**
> AttachVolumeToServerResponse AttachVolumeToServer (long id, AttachVolumeToServerRequest attachVolumeToServerRequest = null)

Attach Volume to a Server

Attaches a Volume to a Server. Works only if the Server is in the same Location as the Volume.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Volume. |  |
| **attachVolumeToServerRequest** | [**AttachVolumeToServerRequest**](AttachVolumeToServerRequest.md) |  | [optional]  |

### Return type

[**AttachVolumeToServerResponse**](AttachVolumeToServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains the &#x60;attach_volume&#x60; Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changevolumeprotection"></a>
# **ChangeVolumeProtection**
> ChangeVolumeProtectionResponse ChangeVolumeProtection (long id, ChangeVolumeProtectionRequest changeVolumeProtectionRequest = null)

Change Volume Protection

Changes the protection configuration of a Volume.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Volume. |  |
| **changeVolumeProtectionRequest** | [**ChangeVolumeProtectionRequest**](ChangeVolumeProtectionRequest.md) |  | [optional]  |

### Return type

[**ChangeVolumeProtectionResponse**](ChangeVolumeProtectionResponse.md)

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

<a id="createvolume"></a>
# **CreateVolume**
> CreateVolumeResponse CreateVolume (CreateVolumeRequest createVolumeRequest = null)

Create a Volume

Creates a new Volume attached to a Server. If you want to create a Volume that is not attached to a Server, you need to provide the `location` key instead of `server`. This can be either the ID or the name of the Location this Volume will be created in. Note that a Volume can be attached to a Server only in the same Location as the Volume itself.  Specifying the Server during Volume creation will automatically attach the Volume to that Server after it has been initialized. In that case, the `next_actions` key in the response is an array which contains a single `attach_volume` action.  The minimum Volume size is 10GB and the maximum size is 10TB (10240GB).  A volume’s name can consist of alphanumeric characters, dashes, underscores, and dots, but has to start and end with an alphanumeric character. The total length is limited to 64 characters. Volume names must be unique per Project.  #### Call specific error codes  | Code                                | Description                                         | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | `no_space_left_in_location`         | There is no volume space left in the given location | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createVolumeRequest** | [**CreateVolumeRequest**](CreateVolumeRequest.md) |  | [optional]  |

### Return type

[**CreateVolumeResponse**](CreateVolumeResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;volume&#x60; key contains the Volume that was just created  The &#x60;action&#x60; key contains the Action tracking Volume creation  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletevolume"></a>
# **DeleteVolume**
> void DeleteVolume (long id)

Delete a Volume

Deletes a volume. All Volume data is irreversibly destroyed. The Volume must not be attached to a Server and it must not have delete protection enabled.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Volume. |  |

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
| **204** | Volume deleted |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="detachvolume"></a>
# **DetachVolume**
> DetachVolumeResponse DetachVolume (long id)

Detach Volume

Detaches a Volume from the Server it’s attached to. You may attach it to a Server again at a later time.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Volume. |  |

### Return type

[**DetachVolumeResponse**](DetachVolumeResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains the &#x60;detach_volume&#x60; Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getactionforvolume"></a>
# **GetActionForVolume**
> GetActionForVolumeResponse GetActionForVolume (long id, long actionId)

Get an Action for a Volume

Returns a specific Action for a Volume.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Volume. |  |
| **actionId** | **long** | ID of the Action. |  |

### Return type

[**GetActionForVolumeResponse**](GetActionForVolumeResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;action&#x60; key contains the Volume Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getvolume"></a>
# **GetVolume**
> GetVolumeResponse GetVolume (long id)

Get a Volume

Gets a specific Volume object.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Volume. |  |

### Return type

[**GetVolumeResponse**](GetVolumeResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;volume&#x60; key contains the volume |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getvolumeaction"></a>
# **GetVolumeAction**
> GetActionResponse GetVolumeAction (long id)

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

<a id="listactionsforvolume"></a>
# **ListActionsForVolume**
> ListActionsForVolumeResponse ListActionsForVolume (long id, string sort = null, string status = null, long page = null, long perPage = null)

Get all Actions for a Volume

Returns all Action objects for a Volume. You can `sort` the results by using the sort URI parameter, and filter them with the `status` parameter.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Volume. |  |
| **sort** | **string** | Sort actions by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **status** | **string** | Filter the actions by status. Can be used multiple times. The response will only contain actions matching the specified statuses.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListActionsForVolumeResponse**](ListActionsForVolumeResponse.md)

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

<a id="listvolumeactions"></a>
# **ListVolumeActions**
> ListActionsResponse ListVolumeActions (long id = null, string sort = null, string status = null, long page = null, long perPage = null)

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

<a id="listvolumes"></a>
# **ListVolumes**
> ListVolumesResponse ListVolumes (string status = null, string sort = null, string name = null, string labelSelector = null, long page = null, long perPage = null)

Get all Volumes

Gets all existing Volumes that you have available.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **string** | Can be used multiple times. The response will only contain Volumes matching the status. | [optional]  |
| **sort** | **string** | Sort resources by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **name** | **string** | Filter resources by their name. The response will only contain the resources matching the specified name.  | [optional]  |
| **labelSelector** | **string** | Filter resources by labels. The response will only contain resources matching the label selector. For more information, see \&quot;[Label Selector](#label-selector)\&quot;.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListVolumesResponse**](ListVolumesResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;volumes&#x60; key contains a list of volumes |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="replacevolume"></a>
# **ReplaceVolume**
> ReplaceVolumeResponse ReplaceVolume (long id, ReplaceVolumeRequest replaceVolumeRequest = null)

Update a Volume

Updates the Volume properties.  Note that when updating labels, the volume’s current set of labels will be replaced with the labels provided in the request body. So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Volume. |  |
| **replaceVolumeRequest** | [**ReplaceVolumeRequest**](ReplaceVolumeRequest.md) |  | [optional]  |

### Return type

[**ReplaceVolumeResponse**](ReplaceVolumeResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;volume&#x60; key contains the updated volume |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="resizevolume"></a>
# **ResizeVolume**
> ResizeVolumeResponse ResizeVolume (long id, ResizeVolumeRequest resizeVolumeRequest = null)

Resize Volume

Changes the size of a Volume. Note that downsizing a Volume is not possible.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Volume. |  |
| **resizeVolumeRequest** | [**ResizeVolumeRequest**](ResizeVolumeRequest.md) |  | [optional]  |

### Return type

[**ResizeVolumeResponse**](ResizeVolumeResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains the &#x60;resize_volume&#x60; Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

