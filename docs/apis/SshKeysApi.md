# Hetzner.Cloud.Api.SshKeysApi

All URIs are relative to *https://api.hetzner.cloud/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSshKey**](SshKeysApi.md#createsshkey) | **POST** /ssh_keys | Create an SSH key |
| [**DeleteSshKey**](SshKeysApi.md#deletesshkey) | **DELETE** /ssh_keys/{id} | Delete an SSH key |
| [**GetSshKey**](SshKeysApi.md#getsshkey) | **GET** /ssh_keys/{id} | Get a SSH key |
| [**ListSshKeys**](SshKeysApi.md#listsshkeys) | **GET** /ssh_keys | Get all SSH keys |
| [**ReplaceSshKey**](SshKeysApi.md#replacesshkey) | **PUT** /ssh_keys/{id} | Update an SSH key |

<a id="createsshkey"></a>
# **CreateSshKey**
> CreateSshKeyResponse CreateSshKey (CreateSshKeyRequest createSshKeyRequest = null)

Create an SSH key

Creates a new SSH key with the given `name` and `public_key`. Once an SSH key is created, it can be used in other calls such as creating Servers.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createSshKeyRequest** | [**CreateSshKeyRequest**](CreateSshKeyRequest.md) |  | [optional]  |

### Return type

[**CreateSshKeyResponse**](CreateSshKeyResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;ssh_key&#x60; key in the reply contains the object that was just created |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletesshkey"></a>
# **DeleteSshKey**
> void DeleteSshKey (long id)

Delete an SSH key

Deletes an SSH key. It cannot be used anymore.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the SSH Key. |  |

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
| **204** | SSH key deleted |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsshkey"></a>
# **GetSshKey**
> GetSshKeyResponse GetSshKey (long id)

Get a SSH key

Returns a specific SSH key object.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the SSH Key. |  |

### Return type

[**GetSshKeyResponse**](GetSshKeyResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;ssh_key&#x60; key in the reply contains an SSH key object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listsshkeys"></a>
# **ListSshKeys**
> ListSshKeysResponse ListSshKeys (string sort = null, string name = null, string fingerprint = null, string labelSelector = null, long page = null, long perPage = null)

Get all SSH keys

Returns all SSH key objects.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sort** | **string** | Sort resources by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **name** | **string** | Filter resources by their name. The response will only contain the resources matching the specified name.  | [optional]  |
| **fingerprint** | **string** | Can be used to filter SSH keys by their fingerprint. The response will only contain the SSH key matching the specified fingerprint. | [optional]  |
| **labelSelector** | **string** | Filter resources by labels. The response will only contain resources matching the label selector. For more information, see \&quot;[Label Selector](#label-selector)\&quot;.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListSshKeysResponse**](ListSshKeysResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;ssh_keys&#x60; key in the reply contains an array of SSH key objects with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="replacesshkey"></a>
# **ReplaceSshKey**
> ReplaceSshKeyResponse ReplaceSshKey (long id, ReplaceSshKeyRequest replaceSshKeyRequest = null)

Update an SSH key

Updates an SSH key. You can update an SSH key name and an SSH key labels.  Please note that when updating labels, the SSH key current set of labels will be replaced with the labels provided in the request body. So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the SSH Key. |  |
| **replaceSshKeyRequest** | [**ReplaceSshKeyRequest**](ReplaceSshKeyRequest.md) |  | [optional]  |

### Return type

[**ReplaceSshKeyResponse**](ReplaceSshKeyResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;ssh_key&#x60; key in the reply contains the modified SSH key object with the new description |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

