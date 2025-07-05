# Hetzner.Cloud.Api.PrimaryIpsApi

All URIs are relative to *https://api.hetzner.cloud/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssignPrimaryIpToResource**](PrimaryIpsApi.md#assignprimaryiptoresource) | **POST** /primary_ips/{id}/actions/assign | Assign a Primary IP to a resource |
| [**ChangePrimaryIpProtection**](PrimaryIpsApi.md#changeprimaryipprotection) | **POST** /primary_ips/{id}/actions/change_protection | Change Primary IP Protection |
| [**ChangeReverseDnsRecordsForPrimaryIp**](PrimaryIpsApi.md#changereversednsrecordsforprimaryip) | **POST** /primary_ips/{id}/actions/change_dns_ptr | Change reverse DNS records for a Primary IP |
| [**CreatePrimaryIp**](PrimaryIpsApi.md#createprimaryip) | **POST** /primary_ips | Create a Primary IP |
| [**DeletePrimaryIp**](PrimaryIpsApi.md#deleteprimaryip) | **DELETE** /primary_ips/{id} | Delete a Primary IP |
| [**GetPrimaryIp**](PrimaryIpsApi.md#getprimaryip) | **GET** /primary_ips/{id} | Get a Primary IP |
| [**GetPrimaryIpAction**](PrimaryIpsApi.md#getprimaryipaction) | **GET** /primary_ips/actions/{id} | Get an Action |
| [**ListPrimaryIpActions**](PrimaryIpsApi.md#listprimaryipactions) | **GET** /primary_ips/actions | Get all Actions |
| [**ListPrimaryIps**](PrimaryIpsApi.md#listprimaryips) | **GET** /primary_ips | Get all Primary IPs |
| [**ReplacePrimaryIp**](PrimaryIpsApi.md#replaceprimaryip) | **PUT** /primary_ips/{id} | Update a Primary IP |
| [**UnassignPrimaryIpFromResource**](PrimaryIpsApi.md#unassignprimaryipfromresource) | **POST** /primary_ips/{id}/actions/unassign | Unassign a Primary IP from a resource |

<a id="assignprimaryiptoresource"></a>
# **AssignPrimaryIpToResource**
> AssignPrimaryIpToResourceResponse AssignPrimaryIpToResource (long id, AssignPrimaryIpToResourceRequest assignPrimaryIpToResourceRequest = null)

Assign a Primary IP to a resource

Assign a [Primary IP](#primary-ips) to a resource.  A [Server](#servers) can only have one [Primary IP](#primary-ips) of type `ipv4` and one of type `ipv6` assigned. If you need more IPs use [Floating IPs](#floating-ips).  A [Server](#servers) must be powered off (status `off`) in order for this operation to succeed.  #### Error Codes specific to this Call  | Code                          | Description                                                                      | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | `server_not_stopped`          | The [Server](#servers) is running, but needs to be powered off                   | | `primary_ip_already_assigned` | [Primary IP](#primary-ips) is already assigned to a different [Server](#servers) | | `server_has_ipv4`             | The [Server](#servers) already has an IPv4 address                               | | `server_has_ipv6`             | The [Server](#servers) already has an IPv6 address                               | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Primary IP. |  |
| **assignPrimaryIpToResourceRequest** | [**AssignPrimaryIpToResourceRequest**](AssignPrimaryIpToResourceRequest.md) |  | [optional]  |

### Return type

[**AssignPrimaryIpToResourceResponse**](AssignPrimaryIpToResourceResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for assigning a [Primary IP](#primary-ips).  Contains an [Action](#actions) of type &#x60;assign_primary_ip&#x60;.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changeprimaryipprotection"></a>
# **ChangePrimaryIpProtection**
> ChangePrimaryIpProtectionResponse ChangePrimaryIpProtection (long id, Protection body = null)

Change Primary IP Protection

Changes the protection configuration of a [Primary IP](#primary-ips).  A [Primary IPs](#primary-ips) deletion protection can only be enabled if its `auto_delete` property is set to `false`. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Primary IP. |  |
| **body** | **Protection** |  | [optional]  |

### Return type

[**ChangePrimaryIpProtectionResponse**](ChangePrimaryIpProtectionResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for changing a [Primary IPs](#primary-ips) protection settings.  Contains an [Action](#actions) of type &#x60;change_protection&#x60;.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changereversednsrecordsforprimaryip"></a>
# **ChangeReverseDnsRecordsForPrimaryIp**
> ChangeReverseDnsRecordsForPrimaryIpResponse ChangeReverseDnsRecordsForPrimaryIp (long id, DnsPtr body = null)

Change reverse DNS records for a Primary IP

Change the reverse DNS records for this [Primary IP](#primary-ips).  Allows to modify the PTR records set for the IP address. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Primary IP. |  |
| **body** | **DnsPtr** | The &#x60;ip&#x60; attributes specifies for which IP address the record is set. For IPv4 addresses this must be the exact address of the [Primary IP](#primary-ips). For IPv6 addresses this must be a single address within the &#x60;/64&#x60; subnet of the [Primary IP](#primary-ips).  The &#x60;dns_ptr&#x60; attribute specifies the hostname used for the IP address.  For IPv6 [Floating IPs](#floating-ips) up to 100 entries can be created.  | [optional]  |

### Return type

[**ChangeReverseDnsRecordsForPrimaryIpResponse**](ChangeReverseDnsRecordsForPrimaryIpResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for changing a [Primary IPs](#primary-ips) DNS pointer.  Contains an [Action](#actions) of type &#x60;change_dns_ptr&#x60;.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createprimaryip"></a>
# **CreatePrimaryIp**
> CreatePrimaryIpResponse CreatePrimaryIp (CreatePrimaryIpRequest createPrimaryIpRequest = null)

Create a Primary IP

Create a new [Primary IP](#primary-ips).  Can optionally be assigned to a resource by providing an `assignee_id` and `assignee_type`.  If not assigned to a resource the `datacenter` key needs to be provided. This can be either the ID or the name of the [Datacenter](#datacenters) this [Primary IP](#primary-ips) shall be created in.  A [Primary IP](#primary-ips) can only be assigned to resource in the same [Datacenter](#datacenters) later on.  #### Call specific error codes  | Code                          | Description                                                              | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | `server_not_stopped`          | The specified [Server](#servers) is running, but needs to be powered off | | `server_has_ipv4`             | The [Server](#servers) already has an ipv4 address                       | | `server_has_ipv6`             | The [Server](#servers) already has an ipv6 address                       | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createPrimaryIpRequest** | [**CreatePrimaryIpRequest**](CreatePrimaryIpRequest.md) | Request Body for creating a new [Primary IP](#primary-ips).  The &#x60;datacenter&#x60; and &#x60;assignee_id&#x60;/&#x60;assignee_type&#x60; attributes are mutually exclusive.  | [optional]  |

### Return type

[**CreatePrimaryIpResponse**](CreatePrimaryIpResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for creating a [Primary IP](#primary-ips).  Contains the newly created [Primary IP](#primary-ips).  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteprimaryip"></a>
# **DeletePrimaryIp**
> void DeletePrimaryIp (long id)

Delete a Primary IP

Deletes a [Primary IP](#primary-ips).  If assigned to a [Server](#servers) the [Primary IP](#primary-ips) will be unassigned automatically. The [Server](#servers) must be powered off (status `off`) in order for this operation to succeed. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Primary IP. |  |

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
| **204** | [Primary IP](#primary-ips) deletion succeeded. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getprimaryip"></a>
# **GetPrimaryIp**
> GetPrimaryIpResponse GetPrimaryIp (long id)

Get a Primary IP

Returns a [Primary IP](#primary-ips).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Primary IP. |  |

### Return type

[**GetPrimaryIpResponse**](GetPrimaryIpResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;primary_ip&#x60; key contains the [Primary IP](#primary-ips). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getprimaryipaction"></a>
# **GetPrimaryIpAction**
> GetActionResponse GetPrimaryIpAction (long id)

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

<a id="listprimaryipactions"></a>
# **ListPrimaryIpActions**
> ListActionsResponse ListPrimaryIpActions (long id = null, string sort = null, string status = null, long page = null, long perPage = null)

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

<a id="listprimaryips"></a>
# **ListPrimaryIps**
> ListPrimaryIpsResponse ListPrimaryIps (string name = null, string labelSelector = null, string ip = null, long page = null, long perPage = null, string sort = null)

Get all Primary IPs

List multiple [Primary IPs](#primary-ips).  Use the provided URI parameters to modify the result. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Filter resources by their name. The response will only contain the resources matching the specified name.  | [optional]  |
| **labelSelector** | **string** | Filter resources by labels. The response will only contain resources matching the label selector. For more information, see \&quot;[Label Selector](#label-selector)\&quot;.  | [optional]  |
| **ip** | **string** | Filter results by IP address. | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |
| **sort** | **string** | Sort resources by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |

### Return type

[**ListPrimaryIpsResponse**](ListPrimaryIpsResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response for listing [Primary IPs](#primary-ips). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="replaceprimaryip"></a>
# **ReplacePrimaryIp**
> ReplacePrimaryIpResponse ReplacePrimaryIp (long id, ReplacePrimaryIpRequest replacePrimaryIpRequest = null)

Update a Primary IP

Update the [Primary IP](#primary-ips).  Note that when updating [Labels](#labels), the [Primary IPs](#primary-ips) current set of [Labels](#labels) will be replaced with the [Labels](#labels) provided with the request. So, for example, if you want to add a new [Label](#labels), you have to provide all existing [Labels](#labels) plus the new [Label](#labels) in the request body.  If another change is concurrently performed on this [Primary IP](#primary-ips), a error response with code `conflict` will be returned. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Primary IP. |  |
| **replacePrimaryIpRequest** | [**ReplacePrimaryIpRequest**](ReplacePrimaryIpRequest.md) |  | [optional]  |

### Return type

[**ReplacePrimaryIpResponse**](ReplacePrimaryIpResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;primary_ip&#x60; key contains the updated [Primary IP](#primary-ips). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="unassignprimaryipfromresource"></a>
# **UnassignPrimaryIpFromResource**
> UnassignPrimaryIpFromResourceResponse UnassignPrimaryIpFromResource (long id)

Unassign a Primary IP from a resource

Unassign a [Primary IP](#primary-ips) from a resource.  A [Server](#servers) must be powered off (status `off`) in order for this operation to succeed.  A [Server](#server) requires at least one network interface (public or private) to be powered on.  #### Error Codes specific to this Call  | Code                              | Description                                                   | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | `server_not_stopped`              | The [Server](#server) is running, but needs to be powered off | | `server_is_load_balancer_target`  | The [Server](#server) IPv4 address is a loadbalancer target   | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Primary IP. |  |

### Return type

[**UnassignPrimaryIpFromResourceResponse**](UnassignPrimaryIpFromResourceResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for unassigning a [Primary IP](#primary-ips).  Contains an [Action](#actions) of type &#x60;unassign_primary_ip&#x60;.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

