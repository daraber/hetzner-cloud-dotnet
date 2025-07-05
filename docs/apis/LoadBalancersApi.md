# Hetzner.Cloud.Api.LoadBalancersApi

All URIs are relative to *https://api.hetzner.cloud/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddService**](LoadBalancersApi.md#addservice) | **POST** /load_balancers/{id}/actions/add_service | Add Service |
| [**AddTarget**](LoadBalancersApi.md#addtarget) | **POST** /load_balancers/{id}/actions/add_target | Add Target |
| [**AttachLoadBalancerToNetwork**](LoadBalancersApi.md#attachloadbalancertonetwork) | **POST** /load_balancers/{id}/actions/attach_to_network | Attach a Load Balancer to a Network |
| [**ChangeAlgorithm**](LoadBalancersApi.md#changealgorithm) | **POST** /load_balancers/{id}/actions/change_algorithm | Change Algorithm |
| [**ChangeLoadBalancerProtection**](LoadBalancersApi.md#changeloadbalancerprotection) | **POST** /load_balancers/{id}/actions/change_protection | Change Load Balancer Protection |
| [**ChangeReverseDnsEntryForThisLoadBalancer**](LoadBalancersApi.md#changereversednsentryforthisloadbalancer) | **POST** /load_balancers/{id}/actions/change_dns_ptr | Change reverse DNS entry for this Load Balancer |
| [**ChangeTypeOfLoadBalancer**](LoadBalancersApi.md#changetypeofloadbalancer) | **POST** /load_balancers/{id}/actions/change_type | Change the Type of a Load Balancer |
| [**CreateLoadBalancer**](LoadBalancersApi.md#createloadbalancer) | **POST** /load_balancers | Create a Load Balancer |
| [**DeleteLoadBalancer**](LoadBalancersApi.md#deleteloadbalancer) | **DELETE** /load_balancers/{id} | Delete a Load Balancer |
| [**DeleteService**](LoadBalancersApi.md#deleteservice) | **POST** /load_balancers/{id}/actions/delete_service | Delete Service |
| [**DetachLoadBalancerFromNetwork**](LoadBalancersApi.md#detachloadbalancerfromnetwork) | **POST** /load_balancers/{id}/actions/detach_from_network | Detach a Load Balancer from a Network |
| [**DisablePublicInterfaceOfLoadBalancer**](LoadBalancersApi.md#disablepublicinterfaceofloadbalancer) | **POST** /load_balancers/{id}/actions/disable_public_interface | Disable the public interface of a Load Balancer |
| [**EnablePublicInterfaceOfLoadBalancer**](LoadBalancersApi.md#enablepublicinterfaceofloadbalancer) | **POST** /load_balancers/{id}/actions/enable_public_interface | Enable the public interface of a Load Balancer |
| [**GetActionForLoadBalancer**](LoadBalancersApi.md#getactionforloadbalancer) | **GET** /load_balancers/{id}/actions/{action_id} | Get an Action for a Load Balancer |
| [**GetLoadBalancer**](LoadBalancersApi.md#getloadbalancer) | **GET** /load_balancers/{id} | Get a Load Balancer |
| [**GetLoadBalancerAction**](LoadBalancersApi.md#getloadbalanceraction) | **GET** /load_balancers/actions/{id} | Get an Action |
| [**GetMetricsForLoadbalancer**](LoadBalancersApi.md#getmetricsforloadbalancer) | **GET** /load_balancers/{id}/metrics | Get Metrics for a LoadBalancer |
| [**ListActionsForLoadBalancer**](LoadBalancersApi.md#listactionsforloadbalancer) | **GET** /load_balancers/{id}/actions | Get all Actions for a Load Balancer |
| [**ListLoadBalancerActions**](LoadBalancersApi.md#listloadbalanceractions) | **GET** /load_balancers/actions | Get all Actions |
| [**ListLoadBalancers**](LoadBalancersApi.md#listloadbalancers) | **GET** /load_balancers | Get all Load Balancers |
| [**RemoveTarget**](LoadBalancersApi.md#removetarget) | **POST** /load_balancers/{id}/actions/remove_target | Remove Target |
| [**ReplaceLoadBalancer**](LoadBalancersApi.md#replaceloadbalancer) | **PUT** /load_balancers/{id} | Update a Load Balancer |
| [**UpdateService**](LoadBalancersApi.md#updateservice) | **POST** /load_balancers/{id}/actions/update_service | Update Service |

<a id="addservice"></a>
# **AddService**
> AddServiceResponse AddService (long id, LoadBalancerService body = null)

Add Service

Adds a service to a Load Balancer.  #### Call specific error codes  | Code                       | Description                                             | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | `source_port_already_used` | The source port you are trying to add is already in use | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |
| **body** | **LoadBalancerService** |  | [optional]  |

### Return type

[**AddServiceResponse**](AddServiceResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains the &#x60;add_service&#x60; Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="addtarget"></a>
# **AddTarget**
> AddTargetResponse AddTarget (long id, LoadBalancerAddTarget body = null)

Add Target

Adds a target to a Load Balancer.  #### Call specific error codes  | Code                                    | Description                                                                                           | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | `cloud_resource_ip_not_allowed`         | The IP you are trying to add as a target belongs to a Hetzner Cloud resource                          | | `ip_not_owned`                          | The IP you are trying to add as a target is not owned by the Project owner                            | | `load_balancer_not_attached_to_network` | The Load Balancer is not attached to a network                                                        | | `robot_unavailable`                     | Robot was not available. The caller may retry the operation after a short delay.                      | | `server_not_attached_to_network`        | The server you are trying to add as a target is not attached to the same network as the Load Balancer | | `missing_ipv4`                          | The server that you are trying to add as a public target does not have a public IPv4 address          | | `target_already_defined`                | The Load Balancer target you are trying to define is already defined                                  | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |
| **body** | **LoadBalancerAddTarget** |  | [optional]  |

### Return type

[**AddTargetResponse**](AddTargetResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains the &#x60;add_target&#x60; Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="attachloadbalancertonetwork"></a>
# **AttachLoadBalancerToNetwork**
> AttachLoadBalancerToNetworkResponse AttachLoadBalancerToNetwork (long id, AttachLoadBalancerToNetworkRequest attachLoadBalancerToNetworkRequest = null)

Attach a Load Balancer to a Network

Attach a Load Balancer to a Network.  **Call specific error codes**  | Code                             | Description                                                           | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | `load_balancer_already_attached` | The Load Balancer is already attached to a network                    | | `ip_not_available`               | The provided Network IP is not available                              | | `no_subnet_available`            | No Subnet or IP is available for the Load Balancer within the network | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |
| **attachLoadBalancerToNetworkRequest** | [**AttachLoadBalancerToNetworkRequest**](AttachLoadBalancerToNetworkRequest.md) |  | [optional]  |

### Return type

[**AttachLoadBalancerToNetworkResponse**](AttachLoadBalancerToNetworkResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains the &#x60;attach_to_network&#x60; Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changealgorithm"></a>
# **ChangeAlgorithm**
> ChangeAlgorithmResponse ChangeAlgorithm (long id, LoadBalancerAlgorithm body = null)

Change Algorithm

Change the algorithm that determines to which target new requests are sent.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |
| **body** | **LoadBalancerAlgorithm** |  | [optional]  |

### Return type

[**ChangeAlgorithmResponse**](ChangeAlgorithmResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains the &#x60;change_algorithm&#x60; Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changeloadbalancerprotection"></a>
# **ChangeLoadBalancerProtection**
> ChangeLoadBalancerProtectionResponse ChangeLoadBalancerProtection (long id, ChangeLoadBalancerProtectionRequest changeLoadBalancerProtectionRequest = null)

Change Load Balancer Protection

Changes the protection configuration of a Load Balancer.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |
| **changeLoadBalancerProtectionRequest** | [**ChangeLoadBalancerProtectionRequest**](ChangeLoadBalancerProtectionRequest.md) |  | [optional]  |

### Return type

[**ChangeLoadBalancerProtectionResponse**](ChangeLoadBalancerProtectionResponse.md)

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

<a id="changereversednsentryforthisloadbalancer"></a>
# **ChangeReverseDnsEntryForThisLoadBalancer**
> ChangeReverseDnsEntryForThisLoadBalancerResponse ChangeReverseDnsEntryForThisLoadBalancer (long id, ChangeReverseDnsEntryForThisLoadBalancerRequest changeReverseDnsEntryForThisLoadBalancerRequest = null)

Change reverse DNS entry for this Load Balancer

Changes the hostname that will appear when getting the hostname belonging to the public IPs (IPv4 and IPv6) of this Load Balancer.  Floating IPs assigned to the Server are not affected by this. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |
| **changeReverseDnsEntryForThisLoadBalancerRequest** | [**ChangeReverseDnsEntryForThisLoadBalancerRequest**](ChangeReverseDnsEntryForThisLoadBalancerRequest.md) | Select the IP address for which to change the DNS entry by passing &#x60;ip&#x60;. It can be either IPv4 or IPv6. The target hostname is set by passing &#x60;dns_ptr&#x60;. | [optional]  |

### Return type

[**ChangeReverseDnsEntryForThisLoadBalancerResponse**](ChangeReverseDnsEntryForThisLoadBalancerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key in the reply contains an Action object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changetypeofloadbalancer"></a>
# **ChangeTypeOfLoadBalancer**
> ChangeTypeOfLoadBalancerResponse ChangeTypeOfLoadBalancer (long id, ChangeTypeOfLoadBalancerRequest changeTypeOfLoadBalancerRequest = null)

Change the Type of a Load Balancer

Changes the type (Max Services, Max Targets and Max Connections) of a Load Balancer.  **Call specific error codes**  | Code                         | Description                                                     | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | `invalid_load_balancer_type` | The Load Balancer type does not fit for the given Load Balancer | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |
| **changeTypeOfLoadBalancerRequest** | [**ChangeTypeOfLoadBalancerRequest**](ChangeTypeOfLoadBalancerRequest.md) |  | [optional]  |

### Return type

[**ChangeTypeOfLoadBalancerResponse**](ChangeTypeOfLoadBalancerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains the &#x60;change_load_balancer_type&#x60; Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createloadbalancer"></a>
# **CreateLoadBalancer**
> CreateLoadBalancerResponse CreateLoadBalancer (CreateLoadBalancerRequest createLoadBalancerRequest = null)

Create a Load Balancer

Creates a Load Balancer.  #### Call specific error codes  | Code                                    | Description                                                                                           | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | `cloud_resource_ip_not_allowed`         | The IP you are trying to add as a target belongs to a Hetzner Cloud resource                          | | `ip_not_owned`                          | The IP is not owned by the owner of the project of the Load Balancer                                  | | `load_balancer_not_attached_to_network` | The Load Balancer is not attached to a network                                                        | | `robot_unavailable`                     | Robot was not available. The caller may retry the operation after a short delay.                      | | `server_not_attached_to_network`        | The server you are trying to add as a target is not attached to the same network as the Load Balancer | | `source_port_already_used`              | The source port you are trying to add is already in use                                               | | `missing_ipv4`                          | The server that you are trying to add as a public target does not have a public IPv4 address          | | `target_already_defined`                | The Load Balancer target you are trying to define is already defined                                  | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createLoadBalancerRequest** | [**CreateLoadBalancerRequest**](CreateLoadBalancerRequest.md) |  | [optional]  |

### Return type

[**CreateLoadBalancerResponse**](CreateLoadBalancerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;load_balancer&#x60; key contains the Load Balancer that was just created |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteloadbalancer"></a>
# **DeleteLoadBalancer**
> void DeleteLoadBalancer (long id)

Delete a Load Balancer

Deletes a Load Balancer.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |

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
| **204** | Load Balancer deleted |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteservice"></a>
# **DeleteService**
> DeleteServiceResponse DeleteService (long id, DeleteServiceRequest deleteServiceRequest = null)

Delete Service

Delete a service of a Load Balancer.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |
| **deleteServiceRequest** | [**DeleteServiceRequest**](DeleteServiceRequest.md) |  | [optional]  |

### Return type

[**DeleteServiceResponse**](DeleteServiceResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains the &#x60;delete_service&#x60; Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="detachloadbalancerfromnetwork"></a>
# **DetachLoadBalancerFromNetwork**
> DetachLoadBalancerFromNetworkResponse DetachLoadBalancerFromNetwork (long id, DetachLoadBalancerFromNetworkRequest detachLoadBalancerFromNetworkRequest = null)

Detach a Load Balancer from a Network

Detaches a Load Balancer from a network.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |
| **detachLoadBalancerFromNetworkRequest** | [**DetachLoadBalancerFromNetworkRequest**](DetachLoadBalancerFromNetworkRequest.md) |  | [optional]  |

### Return type

[**DetachLoadBalancerFromNetworkResponse**](DetachLoadBalancerFromNetworkResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains the &#x60;detach_from_network&#x60; Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="disablepublicinterfaceofloadbalancer"></a>
# **DisablePublicInterfaceOfLoadBalancer**
> DisablePublicInterfaceOfLoadBalancerResponse DisablePublicInterfaceOfLoadBalancer (long id)

Disable the public interface of a Load Balancer

Disable the public interface of a Load Balancer. The Load Balancer will be not accessible from the internet via its public IPs.  #### Call specific error codes  | Code                                      | Description                                                                    | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | `load_balancer_not_attached_to_network`   |  The Load Balancer is not attached to a network                                | | `targets_without_use_private_ip`          | The Load Balancer has targets that use the public IP instead of the private IP | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |

### Return type

[**DisablePublicInterfaceOfLoadBalancerResponse**](DisablePublicInterfaceOfLoadBalancerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains the &#x60;disable_public_interface&#x60; Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="enablepublicinterfaceofloadbalancer"></a>
# **EnablePublicInterfaceOfLoadBalancer**
> EnablePublicInterfaceOfLoadBalancerResponse EnablePublicInterfaceOfLoadBalancer (long id)

Enable the public interface of a Load Balancer

Enable the public interface of a Load Balancer. The Load Balancer will be accessible from the internet via its public IPs.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |

### Return type

[**EnablePublicInterfaceOfLoadBalancerResponse**](EnablePublicInterfaceOfLoadBalancerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains the &#x60;enable_public_interface&#x60; Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getactionforloadbalancer"></a>
# **GetActionForLoadBalancer**
> GetActionForLoadBalancerResponse GetActionForLoadBalancer (long id, long actionId)

Get an Action for a Load Balancer

Returns a specific Action for a Load Balancer.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |
| **actionId** | **long** | ID of the Action. |  |

### Return type

[**GetActionForLoadBalancerResponse**](GetActionForLoadBalancerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;action&#x60; key contains the Load Balancer Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getloadbalancer"></a>
# **GetLoadBalancer**
> GetLoadBalancerResponse GetLoadBalancer (long id)

Get a Load Balancer

Gets a specific Load Balancer object.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |

### Return type

[**GetLoadBalancerResponse**](GetLoadBalancerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;load_balancer&#x60; key contains the Load Balancer |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getloadbalanceraction"></a>
# **GetLoadBalancerAction**
> GetActionResponse GetLoadBalancerAction (long id)

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

<a id="getmetricsforloadbalancer"></a>
# **GetMetricsForLoadbalancer**
> GetMetricsForLoadbalancerResponse GetMetricsForLoadbalancer (long id, string type, string start, string end, string step = null)

Get Metrics for a LoadBalancer

You must specify the type of metric to get: `open_connections`, `connections_per_second`, `requests_per_second` or `bandwidth`. You can also specify more than one type by comma separation, e.g. `requests_per_second,bandwidth`.  Depending on the type you will get different time series data:  |Type | Timeseries | Unit | Description | |- -- - |- -- -- -- -- -- -|- -- -- -|- -- -- -- -- -- --| | open_connections | open_connections | number | Open connections | | connections_per_second | connections_per_second | connections/s | Connections per second | | requests_per_second | requests_per_second | requests/s | Requests per second | | bandwidth | bandwidth.in | bytes/s | Ingress bandwidth | || bandwidth.out | bytes/s | Egress bandwidth |  Metrics are available for the last 30 days only.  If you do not provide the step argument we will automatically adjust it so that 200 samples are returned.  We limit the number of samples to a maximum of 500 and will adjust the step parameter accordingly. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |
| **type** | **string** | Type of metrics to get |  |
| **start** | **string** | Start of period to get Metrics for (in ISO-8601 format) |  |
| **end** | **string** | End of period to get Metrics for (in ISO-8601 format) |  |
| **step** | **string** | Resolution of results in seconds | [optional]  |

### Return type

[**GetMetricsForLoadbalancerResponse**](GetMetricsForLoadbalancerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;metrics&#x60; key in the reply contains a metrics object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listactionsforloadbalancer"></a>
# **ListActionsForLoadBalancer**
> ListActionsForLoadBalancerResponse ListActionsForLoadBalancer (long id, string sort = null, string status = null, long page = null, long perPage = null)

Get all Actions for a Load Balancer

Returns all Action objects for a Load Balancer. You can sort the results by using the `sort` URI parameter, and filter them with the `status` parameter.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |
| **sort** | **string** | Sort actions by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **status** | **string** | Filter the actions by status. Can be used multiple times. The response will only contain actions matching the specified statuses.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListActionsForLoadBalancerResponse**](ListActionsForLoadBalancerResponse.md)

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

<a id="listloadbalanceractions"></a>
# **ListLoadBalancerActions**
> ListActionsResponse ListLoadBalancerActions (long id = null, string sort = null, string status = null, long page = null, long perPage = null)

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

<a id="listloadbalancers"></a>
# **ListLoadBalancers**
> ListLoadBalancersResponse ListLoadBalancers (string sort = null, string name = null, string labelSelector = null, long page = null, long perPage = null)

Get all Load Balancers

Gets all existing Load Balancers that you have available.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sort** | **string** | Sort resources by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **name** | **string** | Filter resources by their name. The response will only contain the resources matching the specified name.  | [optional]  |
| **labelSelector** | **string** | Filter resources by labels. The response will only contain resources matching the label selector. For more information, see \&quot;[Label Selector](#label-selector)\&quot;.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListLoadBalancersResponse**](ListLoadBalancersResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;load_balancers&#x60; key contains a list of Load Balancers |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removetarget"></a>
# **RemoveTarget**
> RemoveTargetResponse RemoveTarget (long id, RemoveTargetRequest removeTargetRequest = null)

Remove Target

Removes a target from a Load Balancer.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |
| **removeTargetRequest** | [**RemoveTargetRequest**](RemoveTargetRequest.md) |  | [optional]  |

### Return type

[**RemoveTargetResponse**](RemoveTargetResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains the &#x60;remove_target&#x60; Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="replaceloadbalancer"></a>
# **ReplaceLoadBalancer**
> ReplaceLoadBalancerResponse ReplaceLoadBalancer (long id, ReplaceLoadBalancerRequest replaceLoadBalancerRequest = null)

Update a Load Balancer

Updates a Load Balancer. You can update a Load Balancer’s name and a Load Balancer’s labels.  Note that when updating labels, the Load Balancer’s current set of labels will be replaced with the labels provided in the request body. So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body.  Note: if the Load Balancer object changes during the request, the response will be a “conflict” error. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |
| **replaceLoadBalancerRequest** | [**ReplaceLoadBalancerRequest**](ReplaceLoadBalancerRequest.md) |  | [optional]  |

### Return type

[**ReplaceLoadBalancerResponse**](ReplaceLoadBalancerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;load_balancer&#x60; key contains the updated Load Balancer |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateservice"></a>
# **UpdateService**
> UpdateServiceResponse UpdateService (long id, UpdateLoadBalancerService body = null)

Update Service

Updates a Load Balancer Service.  #### Call specific error codes  | Code                       | Description                                             | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | `source_port_already_used` | The source port you are trying to add is already in use | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Load Balancer. |  |
| **body** | **UpdateLoadBalancerService** |  | [optional]  |

### Return type

[**UpdateServiceResponse**](UpdateServiceResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key contains the &#x60;update_service&#x60; Action |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

