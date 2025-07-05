# Hetzner.Cloud.Api.FloatingIpsApi

All URIs are relative to *https://api.hetzner.cloud/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssignFloatingIpToServer**](FloatingIpsApi.md#assignfloatingiptoserver) | **POST** /floating_ips/{id}/actions/assign | Assign a Floating IP to a Server |
| [**ChangeFloatingIpProtection**](FloatingIpsApi.md#changefloatingipprotection) | **POST** /floating_ips/{id}/actions/change_protection | Change Floating IP Protection |
| [**ChangeReverseDnsRecordsForFloatingIp**](FloatingIpsApi.md#changereversednsrecordsforfloatingip) | **POST** /floating_ips/{id}/actions/change_dns_ptr | Change reverse DNS records for a Floating IP |
| [**CreateFloatingIp**](FloatingIpsApi.md#createfloatingip) | **POST** /floating_ips | Create a Floating IP |
| [**DeleteFloatingIp**](FloatingIpsApi.md#deletefloatingip) | **DELETE** /floating_ips/{id} | Delete a Floating IP |
| [**GetActionForFloatingIp**](FloatingIpsApi.md#getactionforfloatingip) | **GET** /floating_ips/{id}/actions/{action_id} | Get an Action for a Floating IP |
| [**GetFloatingIp**](FloatingIpsApi.md#getfloatingip) | **GET** /floating_ips/{id} | Get a Floating IP |
| [**GetFloatingIpAction**](FloatingIpsApi.md#getfloatingipaction) | **GET** /floating_ips/actions/{id} | Get an Action |
| [**ListActionsForFloatingIp**](FloatingIpsApi.md#listactionsforfloatingip) | **GET** /floating_ips/{id}/actions | Get all Actions for a Floating IP |
| [**ListFloatingIpActions**](FloatingIpsApi.md#listfloatingipactions) | **GET** /floating_ips/actions | Get all Actions |
| [**ListFloatingIps**](FloatingIpsApi.md#listfloatingips) | **GET** /floating_ips | Get all Floating IPs |
| [**ReplaceFloatingIp**](FloatingIpsApi.md#replacefloatingip) | **PUT** /floating_ips/{id} | Update a Floating IP |
| [**UnassignFloatingIp**](FloatingIpsApi.md#unassignfloatingip) | **POST** /floating_ips/{id}/actions/unassign | Unassign a Floating IP |

<a id="assignfloatingiptoserver"></a>
# **AssignFloatingIpToServer**
> AssignFloatingIpToServerResponse AssignFloatingIpToServer (long id, AssignFloatingIpToServerRequest assignFloatingIpToServerRequest = null)

Assign a Floating IP to a Server

Assigns a [Floating IP](#floating-ips) to a [Server](#servers).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Floating IP. |  |
| **assignFloatingIpToServerRequest** | [**AssignFloatingIpToServerRequest**](AssignFloatingIpToServerRequest.md) |  | [optional]  |

### Return type

[**AssignFloatingIpToServerResponse**](AssignFloatingIpToServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for assigning a [Floating IP](#floating-ips).  Contains an [Action](#actions) of type &#x60;assign_floating_ip&#x60;.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changefloatingipprotection"></a>
# **ChangeFloatingIpProtection**
> ChangeFloatingIpProtectionResponse ChangeFloatingIpProtection (long id, Protection body = null)

Change Floating IP Protection

Changes the protection settings configured for the [Floating IP](#floating-ips).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Floating IP. |  |
| **body** | **Protection** |  | [optional]  |

### Return type

[**ChangeFloatingIpProtectionResponse**](ChangeFloatingIpProtectionResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for changing a [Floating IPs](#floating-ips) protection settings.  Contains an [Action](#actions) of type &#x60;change_protection&#x60;.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changereversednsrecordsforfloatingip"></a>
# **ChangeReverseDnsRecordsForFloatingIp**
> ChangeReverseDnsRecordsForFloatingIpResponse ChangeReverseDnsRecordsForFloatingIp (long id, DnsPtr body = null)

Change reverse DNS records for a Floating IP

Change the reverse DNS records for this [Floating IP](#floating-ips).  Allows to modify the PTR records set for the IP address. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Floating IP. |  |
| **body** | **DnsPtr** | The &#x60;ip&#x60; attributes specifies for which IP address the record is set. For IPv4 addresses this must be the exact address of the [Floating IP](#floating-ips). For IPv6 addresses this must be a single address within the &#x60;/64&#x60; subnet of the [Floating IP](#floating-ips).  The &#x60;dns_ptr&#x60; attribute specifies the hostname used for the IP address.  For IPv6 [Floating IPs](#floating-ips) up to 100 entries can be created.  | [optional]  |

### Return type

[**ChangeReverseDnsRecordsForFloatingIpResponse**](ChangeReverseDnsRecordsForFloatingIpResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for changing a [Floating IPs](#floating-ips) DNS pointer.  Contains an [Action](#actions) of type &#x60;change_dns_ptr&#x60;.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createfloatingip"></a>
# **CreateFloatingIp**
> CreateFloatingIpResponse CreateFloatingIp (CreateFloatingIpRequest createFloatingIpRequest = null)

Create a Floating IP

Create a [Floating IP](#floating-ips).  Provide the `server` attribute to assign the [Floating IP](#floating-ips) to that server or provide a `home_location` to locate the [Floating IP](#floating-ips) at. Note that the [Floating IP](#floating-ips) can be assigned to a [Server](#servers) in any [Location](#locations) later on. For optimal routing it is advised to use the [Floating IP](#floating-ips) in the same [Location](#locations) it was created in. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createFloatingIpRequest** | [**CreateFloatingIpRequest**](CreateFloatingIpRequest.md) | The &#x60;type&#x60; argument is required while &#x60;home_location&#x60; and &#x60;server&#x60; are mutually exclusive. | [optional]  |

### Return type

[**CreateFloatingIpResponse**](CreateFloatingIpResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for creating a [Floating IP](#floating-ips).  Contains the created IP.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletefloatingip"></a>
# **DeleteFloatingIp**
> void DeleteFloatingIp (long id)

Delete a Floating IP

Deletes a [Floating IP](#floating-ips).  If the IP is assigned to a resource it will be unassigned. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Floating IP. |  |

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
| **204** | Floating IP deleted. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getactionforfloatingip"></a>
# **GetActionForFloatingIp**
> GetActionForFloatingIpResponse GetActionForFloatingIp (long id, long actionId)

Get an Action for a Floating IP

Returns a specific [Action](#actions) for a [Floating IP](#floating-ips).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Floating IP. |  |
| **actionId** | **long** | ID of the Action. |  |

### Return type

[**GetActionForFloatingIpResponse**](GetActionForFloatingIpResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response for getting an [Action](#actions). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfloatingip"></a>
# **GetFloatingIp**
> GetFloatingIpResponse GetFloatingIp (long id)

Get a Floating IP

Returns a single [Floating IP](#floating-ips).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Floating IP. |  |

### Return type

[**GetFloatingIpResponse**](GetFloatingIpResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response for getting a single [Floating IP](#floating-ips). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfloatingipaction"></a>
# **GetFloatingIpAction**
> GetActionResponse GetFloatingIpAction (long id)

Get an Action

Returns a single [Action](#actions).


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
| **200** | Response for getting a single [Action](#actions). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listactionsforfloatingip"></a>
# **ListActionsForFloatingIp**
> ListActionsForFloatingIpResponse ListActionsForFloatingIp (long id, string sort = null, string status = null, long page = null, long perPage = null)

Get all Actions for a Floating IP

Lists [Actions](#actions) for a [Floating IP](#floating-ips).  Use the provided URI parameters to modify the result. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Floating IP. |  |
| **sort** | **string** | Sort actions by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **status** | **string** | Filter the actions by status. Can be used multiple times. The response will only contain actions matching the specified statuses.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListActionsForFloatingIpResponse**](ListActionsForFloatingIpResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response for listing [Actions](#actions). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listfloatingipactions"></a>
# **ListFloatingIpActions**
> ListActionsResponse ListFloatingIpActions (long id = null, string sort = null, string status = null, long page = null, long perPage = null)

Get all Actions

Lists multiple [Actions](#actions).  Use the provided URI parameters to modify the result. 


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
| **200** | Response for listing [Actions](#actions). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listfloatingips"></a>
# **ListFloatingIps**
> ListFloatingIpsResponse ListFloatingIps (string name = null, string labelSelector = null, string sort = null, long page = null, long perPage = null)

Get all Floating IPs

List multiple [Floating IPs](#floating-ips).  Use the provided URI parameters to modify the result. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Filter resources by their name. The response will only contain the resources matching the specified name.  | [optional]  |
| **labelSelector** | **string** | Filter resources by labels. The response will only contain resources matching the label selector. For more information, see \&quot;[Label Selector](#label-selector)\&quot;.  | [optional]  |
| **sort** | **string** | Sort resources by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListFloatingIpsResponse**](ListFloatingIpsResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response for listing [Floating IPs](#floating-ips). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="replacefloatingip"></a>
# **ReplaceFloatingIp**
> ReplaceFloatingIpResponse ReplaceFloatingIp (long id, ReplaceFloatingIpRequest replaceFloatingIpRequest = null)

Update a Floating IP

Update the description or [Labels](#labels) of a [Floating IP](#floating-ips). Note that when updating [Labels](#labels), the [Floating IPs](#floating-ips) current set of [Labels](#labels) will be replaced with the [Labels](#labels) provided with the request. So, for example, if you want to add a new [Label](#labels), you have to provide all existing [Labels](#labels) plus the new [Label](#labels) in the request body.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Floating IP. |  |
| **replaceFloatingIpRequest** | [**ReplaceFloatingIpRequest**](ReplaceFloatingIpRequest.md) |  | [optional]  |

### Return type

[**ReplaceFloatingIpResponse**](ReplaceFloatingIpResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response for updating a [Floating IP](#floating-ips).  Contains the updated [Floating IP](#floating-ips).  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="unassignfloatingip"></a>
# **UnassignFloatingIp**
> UnassignFloatingIpResponse UnassignFloatingIp (long id)

Unassign a Floating IP

Unassigns a [Floating IP](#floating-ips).  Results in the IP being unreachable. Can be assigned to another resource again. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Floating IP. |  |

### Return type

[**UnassignFloatingIpResponse**](UnassignFloatingIpResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for unassigning a [Floating IP](#floating-ips).  Contains an [Action](#actions) of type &#x60;unassign_floating_ip&#x60;.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

