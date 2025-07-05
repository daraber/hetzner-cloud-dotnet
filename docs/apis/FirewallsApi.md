# Hetzner.Cloud.Api.FirewallsApi

All URIs are relative to *https://api.hetzner.cloud/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApplyToResources**](FirewallsApi.md#applytoresources) | **POST** /firewalls/{id}/actions/apply_to_resources | Apply to Resources |
| [**CreateFirewall**](FirewallsApi.md#createfirewall) | **POST** /firewalls | Create a Firewall |
| [**DeleteFirewall**](FirewallsApi.md#deletefirewall) | **DELETE** /firewalls/{id} | Delete a Firewall |
| [**GetActionForFirewall**](FirewallsApi.md#getactionforfirewall) | **GET** /firewalls/{id}/actions/{action_id} | Get an Action for a Firewall |
| [**GetFirewall**](FirewallsApi.md#getfirewall) | **GET** /firewalls/{id} | Get a Firewall |
| [**GetFirewallAction**](FirewallsApi.md#getfirewallaction) | **GET** /firewalls/actions/{id} | Get an Action |
| [**ListActionsForFirewall**](FirewallsApi.md#listactionsforfirewall) | **GET** /firewalls/{id}/actions | Get all Actions for a Firewall |
| [**ListFirewallActions**](FirewallsApi.md#listfirewallactions) | **GET** /firewalls/actions | Get all Actions |
| [**ListFirewalls**](FirewallsApi.md#listfirewalls) | **GET** /firewalls | Get all Firewalls |
| [**RemoveFromResources**](FirewallsApi.md#removefromresources) | **POST** /firewalls/{id}/actions/remove_from_resources | Remove from Resources |
| [**ReplaceFirewall**](FirewallsApi.md#replacefirewall) | **PUT** /firewalls/{id} | Update a Firewall |
| [**SetRules**](FirewallsApi.md#setrules) | **POST** /firewalls/{id}/actions/set_rules | Set Rules |

<a id="applytoresources"></a>
# **ApplyToResources**
> ApplyToResourcesResponse ApplyToResources (long id, ApplyToResourcesRequest applyToResourcesRequest = null)

Apply to Resources

Applies a [Firewall](#firewalls) to multiple resources.  Supported resources: - [Servers](#servers) (with a public network interface) - [Label Selectors](#label-selector)  A server can be applied to [a maximum of 5 Firewalls](https://docs.hetzner.com/cloud/firewalls/overview#limits).  #### Error Codes specific to this Call  | Code                          | Description                                                                                     | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | `firewall_already_applied`    | [Firewall](#firewalls) is already applied to resource                                           | | `incompatible_network_type`   | The network type of the resource is not supported by [Firewalls](#firewalls)                    | | `firewall_resource_not_found` | The resource the [Firewall](#firewalls) should be applied to was not found                      | | `private_net_only_server`     | The [Server](#servers) the [Firewall](#firewalls) should be applied to has no public interface  | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Firewall. |  |
| **applyToResourcesRequest** | [**ApplyToResourcesRequest**](ApplyToResourcesRequest.md) |  | [optional]  |

### Return type

[**ApplyToResourcesResponse**](ApplyToResourcesResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;actions&#x60; key contains multiple [Actions](#actions) with the &#x60;apply_firewall&#x60; command. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createfirewall"></a>
# **CreateFirewall**
> CreateFirewallResponse CreateFirewall (CreateFirewallRequest createFirewallRequest = null)

Create a Firewall

Create a [Firewall](#firewalls).  #### Error Codes specific to this Call  | Code                          | Description                                                                 | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | `server_already_added`        | [Server](#servers) applied more than once                                   | | `incompatible_network_type`   | The resources network type is not supported by [Firewalls](#firewalls)      | | `firewall_resource_not_found` | The resource the [Firewall](#firewalls) should be attached to was not found | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createFirewallRequest** | [**CreateFirewallRequest**](CreateFirewallRequest.md) |  | [optional]  |

### Return type

[**CreateFirewallResponse**](CreateFirewallResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;firewall&#x60; key contains the created [Firewall](#firewalls). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletefirewall"></a>
# **DeleteFirewall**
> void DeleteFirewall (long id)

Delete a Firewall

Deletes the [Firewall](#firewalls).  #### Error Codes specific to this Call  | Code                 | Description                                        | |- -- -- -- -- -- -- -- -- -- -- |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | `resource_in_use`    | [Firewall](#firewalls) still applied to a resource | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Firewall. |  |

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
| **204** | Firewall deleted |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getactionforfirewall"></a>
# **GetActionForFirewall**
> GetActionForFirewallResponse GetActionForFirewall (long id, long actionId)

Get an Action for a Firewall

Returns a specific [Action](#actions) for a [Firewall](#firewalls).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Firewall. |  |
| **actionId** | **long** | ID of the Action. |  |

### Return type

[**GetActionForFirewallResponse**](GetActionForFirewallResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;action&#x60; key contains the [Firewall](#firewalls) [Action](#actions). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfirewall"></a>
# **GetFirewall**
> GetFirewallResponse GetFirewall (long id)

Get a Firewall

Returns a single [Firewall](#firewalls).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Firewall. |  |

### Return type

[**GetFirewallResponse**](GetFirewallResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;firewall&#x60; key contains the [Firewall](#firewalls). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfirewallaction"></a>
# **GetFirewallAction**
> GetActionResponse GetFirewallAction (long id)

Get an Action

Returns the specific [Action](#actions).


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
| **200** | The &#x60;action&#x60; key contains the [Action](#actions). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listactionsforfirewall"></a>
# **ListActionsForFirewall**
> ListActionsForFirewallResponse ListActionsForFirewall (long id, string sort = null, string status = null, long page = null, long perPage = null)

Get all Actions for a Firewall

Returns all [Actions](#actions) for the [Firewall](#firewalls).  Use the provided URI parameters to modify the result. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Firewall |  |
| **sort** | **string** | Sort actions by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **status** | **string** | Filter the actions by status. Can be used multiple times. The response will only contain actions matching the specified statuses.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListActionsForFirewallResponse**](ListActionsForFirewallResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;actions&#x60; key contains a list of [Actions](#actions). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listfirewallactions"></a>
# **ListFirewallActions**
> ListActionsResponse ListFirewallActions (long id = null, string sort = null, string status = null, long page = null, long perPage = null)

Get all Actions

Returns all [Actions](#actions) for [Firewalls](#firewalls).  Use the provided URI parameters to modify the result. 


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
| **200** | The &#x60;actions&#x60; key contains a list of [Actions](#actions). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listfirewalls"></a>
# **ListFirewalls**
> ListFirewallsResponse ListFirewalls (string sort = null, string name = null, string labelSelector = null, long page = null, long perPage = null)

Get all Firewalls

Returns all [Firewalls](#firewalls).  Use the provided URI parameters to modify the result. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sort** | **string** | Sort resources by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **name** | **string** | Filter resources by their name. The response will only contain the resources matching the specified name.  | [optional]  |
| **labelSelector** | **string** | Filter resources by labels. The response will only contain resources matching the label selector. For more information, see \&quot;[Label Selector](#label-selector)\&quot;.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListFirewallsResponse**](ListFirewallsResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;firewalls&#x60; key contains the [Firewalls](#firewalls). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removefromresources"></a>
# **RemoveFromResources**
> RemoveFromResourcesResponse RemoveFromResources (long id, RemoveFromResourcesRequest removeFromResourcesRequest = null)

Remove from Resources

Removes a [Firewall](#firewalls) from multiple resources.  Supported resources: - [Servers](#servers) (with a public network interface)  #### Error Codes specific to this Call  | Code                                  | Description                                                                                             | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | `firewall_already_removed`            | [Firewall](#firewalls) is already removed from the resource                                             | | `firewall_resource_not_found`         | The resource the [Firewall](#firewalls) should be removed from was not found                            | | `firewall_managed_by_label_selector`  | [Firewall](#firewall) is applied via a [Label Selector](#label-selector) and cannot be removed manually | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Firewall. |  |
| **removeFromResourcesRequest** | [**RemoveFromResourcesRequest**](RemoveFromResourcesRequest.md) |  | [optional]  |

### Return type

[**RemoveFromResourcesResponse**](RemoveFromResourcesResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;actions&#x60; key contains multiple [Actions](#actions) with the &#x60;remove_firewall&#x60; command. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="replacefirewall"></a>
# **ReplaceFirewall**
> ReplaceFirewallResponse ReplaceFirewall (long id, ReplaceFirewallRequest replaceFirewallRequest = null)

Update a Firewall

Update a [Firewall](#firewalls).  Provided [Labels](#labels) will overwritte the existing ones.  In case of a parallel running change on the [Firewall](#firewalls) a `conflict` error will be returned. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Firewall. |  |
| **replaceFirewallRequest** | [**ReplaceFirewallRequest**](ReplaceFirewallRequest.md) |  | [optional]  |

### Return type

[**ReplaceFirewallResponse**](ReplaceFirewallResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;firewall&#x60; key contains the updated [Firewall](#firewalls). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="setrules"></a>
# **SetRules**
> SetRulesResponse SetRules (long id, SetRulesRequest setRulesRequest = null)

Set Rules

Set the rules of a [Firewall](#firewalls).  Overwrites the existing rules with the given ones. Pass an empty array to remove all rules.  Rules are limited to 50 entries per [Firewall](#firewalls) and [500 effective rules](https://docs.hetzner.com/cloud/firewalls/overview#limits). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Firewall. |  |
| **setRulesRequest** | [**SetRulesRequest**](SetRulesRequest.md) |  | [optional]  |

### Return type

[**SetRulesResponse**](SetRulesResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains an [Action](#actions) with the &#x60;set_firewall_rules&#x60; command and additionally one with the &#x60;apply_firewall&#x60; command per resource of the [Firewall](#firewalls). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

