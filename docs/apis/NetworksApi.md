# Hetzner.Cloud.Api.NetworksApi

All URIs are relative to *https://api.hetzner.cloud/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddRouteToNetwork**](NetworksApi.md#addroutetonetwork) | **POST** /networks/{id}/actions/add_route | Add a route to a Network |
| [**AddSubnetToNetwork**](NetworksApi.md#addsubnettonetwork) | **POST** /networks/{id}/actions/add_subnet | Add a subnet to a Network |
| [**ChangeIpRangeOfNetwork**](NetworksApi.md#changeiprangeofnetwork) | **POST** /networks/{id}/actions/change_ip_range | Change IP range of a Network |
| [**ChangeNetworkProtection**](NetworksApi.md#changenetworkprotection) | **POST** /networks/{id}/actions/change_protection | Change Network Protection |
| [**CreateNetwork**](NetworksApi.md#createnetwork) | **POST** /networks | Create a Network |
| [**DeleteNetwork**](NetworksApi.md#deletenetwork) | **DELETE** /networks/{id} | Delete a Network |
| [**DeleteRouteFromNetwork**](NetworksApi.md#deleteroutefromnetwork) | **POST** /networks/{id}/actions/delete_route | Delete a route from a Network |
| [**DeleteSubnetFromNetwork**](NetworksApi.md#deletesubnetfromnetwork) | **POST** /networks/{id}/actions/delete_subnet | Delete a subnet from a Network |
| [**GetActionForNetwork**](NetworksApi.md#getactionfornetwork) | **GET** /networks/{id}/actions/{action_id} | Get an Action for a Network |
| [**GetNetwork**](NetworksApi.md#getnetwork) | **GET** /networks/{id} | Get a Network |
| [**GetNetworkAction**](NetworksApi.md#getnetworkaction) | **GET** /networks/actions/{id} | Get an Action |
| [**ListActionsForNetwork**](NetworksApi.md#listactionsfornetwork) | **GET** /networks/{id}/actions | Get all Actions for a Network |
| [**ListNetworkActions**](NetworksApi.md#listnetworkactions) | **GET** /networks/actions | Get all Actions |
| [**ListNetworks**](NetworksApi.md#listnetworks) | **GET** /networks | Get all Networks |
| [**ReplaceNetwork**](NetworksApi.md#replacenetwork) | **PUT** /networks/{id} | Update a Network |

<a id="addroutetonetwork"></a>
# **AddRouteToNetwork**
> AddRouteToNetworkResponse AddRouteToNetwork (long id, Route body = null)

Add a route to a Network

Adds a route entry to a [Network](#networks).  If a change is currently being performed on this [Network](#networks), a error response with code `conflict` will be returned. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Network. |  |
| **body** | **Route** |  | [optional]  |

### Return type

[**AddRouteToNetworkResponse**](AddRouteToNetworkResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for adding a route to a [Network](#networks).  The &#x60;action&#x60; key contains an [Action](#actions) with command &#x60;add_route&#x60;.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="addsubnettonetwork"></a>
# **AddSubnetToNetwork**
> AddSubnetToNetworkResponse AddSubnetToNetwork (long id, Subnet body = null)

Add a subnet to a Network

Adds a new subnet to the [Network](#networks).  If the subnet `ip_range` is not provided, the first available `/24` IP range will be used.  If a change is currently being performed on this [Network](#networks), a error response with code `conflict` will be returned. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Network. |  |
| **body** | **Subnet** |  | [optional]  |

### Return type

[**AddSubnetToNetworkResponse**](AddSubnetToNetworkResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for adding a subnet to a [Network](#networks).  The &#x60;action&#x60; key contains an [Action](#actions) with command &#x60;add_subnet&#x60;.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changeiprangeofnetwork"></a>
# **ChangeIpRangeOfNetwork**
> ChangeIpRangeOfNetworkResponse ChangeIpRangeOfNetwork (long id, ChangeIpRangeOfNetworkRequest changeIpRangeOfNetworkRequest = null)

Change IP range of a Network

Changes the IP range of a [Network](#networks).  The following restrictions apply to changing the IP range: - IP ranges can only be extended and never shrunk. - IPs can only be added to the end of the existing range, therefore only the netmask is allowed to be changed.  To update the routes on the connected [Servers](#servers), they need to be rebooted or the routes to be updated manually.  For example if the [Network](#networks) has a range of `10.0.0.0/16` to extend it the new range has to start with the IP `10.0.0.0` as well. The netmask `/16` can be changed to a smaller one then `16` therefore increasing the IP range. A valid entry would be `10.0.0.0/15`, `10.0.0.0/14` or `10.0.0.0/13` and so on.  If a change is currently being performed on this [Network](#networks), a error response with code `conflict` will be returned. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Network. |  |
| **changeIpRangeOfNetworkRequest** | [**ChangeIpRangeOfNetworkRequest**](ChangeIpRangeOfNetworkRequest.md) |  | [optional]  |

### Return type

[**ChangeIpRangeOfNetworkResponse**](ChangeIpRangeOfNetworkResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for changing the [Networks](#networks) IP range.  The &#x60;action&#x60; key contains an [Action](#actions) with command &#x60;change_ip_range&#x60;.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changenetworkprotection"></a>
# **ChangeNetworkProtection**
> ChangeNetworkProtectionResponse ChangeNetworkProtection (long id, ChangeNetworkProtectionRequest changeNetworkProtectionRequest = null)

Change Network Protection

Changes the protection settings of a [Network](#networks).  If a change is currently being performed on this [Network](#networks), a error response with code `conflict` will be returned. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Network. |  |
| **changeNetworkProtectionRequest** | [**ChangeNetworkProtectionRequest**](ChangeNetworkProtectionRequest.md) |  | [optional]  |

### Return type

[**ChangeNetworkProtectionResponse**](ChangeNetworkProtectionResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for changing the [Networks](#networks) protection.  The &#x60;action&#x60; key contains an [Action](#actions) with command &#x60;change_protection&#x60;.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createnetwork"></a>
# **CreateNetwork**
> CreateNetworkResponse CreateNetwork (CreateNetworkRequest createNetworkRequest = null)

Create a Network

Creates a [Network](#networks).  The provided `ip_range` can only be extended later on, but not reduced.  Subnets can be added now or later on using the [add subnet action](#network-actions-add-a-subnet-to-a-network). If you do not specify an `ip_range` for the subnet the first available /24 range will be used.  Routes can be added now or later by using the [add route action](#network-actions-add-a-route-to-a-network). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createNetworkRequest** | [**CreateNetworkRequest**](CreateNetworkRequest.md) |  | [optional]  |

### Return type

[**CreateNetworkResponse**](CreateNetworkResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for creating a [Network](#networks).  Contains the newly created [Network](#networks).  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletenetwork"></a>
# **DeleteNetwork**
> void DeleteNetwork (long id)

Delete a Network

Deletes a [Network](#networks).  Attached resources will be detached automatically. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Network. |  |

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
| **204** | Response for deleting a [Network](#networks). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteroutefromnetwork"></a>
# **DeleteRouteFromNetwork**
> DeleteRouteFromNetworkResponse DeleteRouteFromNetwork (long id, Route body = null)

Delete a route from a Network

Delete a route entry from a [Network](#networks).  If a change is currently being performed on this [Network](#networks), a error response with code `conflict` will be returned. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Network. |  |
| **body** | **Route** |  | [optional]  |

### Return type

[**DeleteRouteFromNetworkResponse**](DeleteRouteFromNetworkResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for deleting a route from a [Network](#networks).  The &#x60;action&#x60; key contains an [Action](#actions) with command &#x60;delete_route&#x60;.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletesubnetfromnetwork"></a>
# **DeleteSubnetFromNetwork**
> DeleteSubnetFromNetworkResponse DeleteSubnetFromNetwork (long id, DeleteSubnetFromNetworkRequest deleteSubnetFromNetworkRequest = null)

Delete a subnet from a Network

Deletes a single subnet entry from a [Network](#networks).  Subnets containing attached resources can not be deleted, they must be detached beforehand.  If a change is currently being performed on this [Network](#networks), a error response with code `conflict` will be returned. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Network. |  |
| **deleteSubnetFromNetworkRequest** | [**DeleteSubnetFromNetworkRequest**](DeleteSubnetFromNetworkRequest.md) |  | [optional]  |

### Return type

[**DeleteSubnetFromNetworkResponse**](DeleteSubnetFromNetworkResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Response for deleting a subnet from a [Network](#networks).  The &#x60;action&#x60; key contains an [Action](#actions) with command &#x60;delete_subnet&#x60;.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getactionfornetwork"></a>
# **GetActionForNetwork**
> GetActionForNetworkResponse GetActionForNetwork (long id, long actionId)

Get an Action for a Network

Returns a specific [Action](#actions) for a [Network](#networks).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Network. |  |
| **actionId** | **long** | ID of the Action. |  |

### Return type

[**GetActionForNetworkResponse**](GetActionForNetworkResponse.md)

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

<a id="getnetwork"></a>
# **GetNetwork**
> GetNetworkResponse GetNetwork (long id)

Get a Network

Get a specific [Network](#networks).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Network. |  |

### Return type

[**GetNetworkResponse**](GetNetworkResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;network&#x60; key contains the network |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getnetworkaction"></a>
# **GetNetworkAction**
> GetActionResponse GetNetworkAction (long id)

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

<a id="listactionsfornetwork"></a>
# **ListActionsForNetwork**
> ListActionsForNetworkResponse ListActionsForNetwork (long id, string sort = null, string status = null, long page = null, long perPage = null)

Get all Actions for a Network

Lists [Actions](#actions) for a [Network](#networks).  Use the provided URI parameters to modify the result. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Network. |  |
| **sort** | **string** | Sort actions by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **status** | **string** | Filter the actions by status. Can be used multiple times. The response will only contain actions matching the specified statuses.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListActionsForNetworkResponse**](ListActionsForNetworkResponse.md)

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

<a id="listnetworkactions"></a>
# **ListNetworkActions**
> ListActionsResponse ListNetworkActions (long id = null, string sort = null, string status = null, long page = null, long perPage = null)

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

<a id="listnetworks"></a>
# **ListNetworks**
> ListNetworksResponse ListNetworks (string name = null, string labelSelector = null, long page = null, long perPage = null)

Get all Networks

List multiple [Networks](#networks).  Use the provided URI parameters to modify the result. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Filter resources by their name. The response will only contain the resources matching the specified name.  | [optional]  |
| **labelSelector** | **string** | Filter resources by labels. The response will only contain resources matching the label selector. For more information, see \&quot;[Label Selector](#label-selector)\&quot;.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListNetworksResponse**](ListNetworksResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response for listing [Networks](#networks). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="replacenetwork"></a>
# **ReplaceNetwork**
> ReplaceNetworkResponse ReplaceNetwork (long id, ReplaceNetworkRequest replaceNetworkRequest = null)

Update a Network

Update a [Network](#networks).  Note that when updating [Labels](#labels), the [Networks](#networks) current set of [Labels](#labels) will be replaced with the [Labels](#labels) provided with the request. So, for example, if you want to add a new [Label](#labels), you have to provide all existing [Labels](#labels) plus the new [Label](#labels) in the request body.  If a change is currently being performed on this [Network](#networks), a error response with code `conflict` will be returned. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Network. |  |
| **replaceNetworkRequest** | [**ReplaceNetworkRequest**](ReplaceNetworkRequest.md) |  | [optional]  |

### Return type

[**ReplaceNetworkResponse**](ReplaceNetworkResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response for updating a [Network](#networks).  Contains the updated [Network](#networks).  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

