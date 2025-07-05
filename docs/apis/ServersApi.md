# Hetzner.Cloud.Api.ServersApi

All URIs are relative to *https://api.hetzner.cloud/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddServerToPlacementGroup**](ServersApi.md#addservertoplacementgroup) | **POST** /servers/{id}/actions/add_to_placement_group | Add a Server to a Placement Group |
| [**AttachIsoToServer**](ServersApi.md#attachisotoserver) | **POST** /servers/{id}/actions/attach_iso | Attach an ISO to a Server |
| [**AttachServerToNetwork**](ServersApi.md#attachservertonetwork) | **POST** /servers/{id}/actions/attach_to_network | Attach a Server to a Network |
| [**ChangeAliasIpsOfNetwork**](ServersApi.md#changealiasipsofnetwork) | **POST** /servers/{id}/actions/change_alias_ips | Change alias IPs of a Network |
| [**ChangeReverseDnsEntryForThisServer**](ServersApi.md#changereversednsentryforthisserver) | **POST** /servers/{id}/actions/change_dns_ptr | Change reverse DNS entry for this Server |
| [**ChangeServerProtection**](ServersApi.md#changeserverprotection) | **POST** /servers/{id}/actions/change_protection | Change Server Protection |
| [**ChangeTypeOfServer**](ServersApi.md#changetypeofserver) | **POST** /servers/{id}/actions/change_type | Change the Type of a Server |
| [**CreateImageFromServer**](ServersApi.md#createimagefromserver) | **POST** /servers/{id}/actions/create_image | Create Image from a Server |
| [**CreateServer**](ServersApi.md#createserver) | **POST** /servers | Create a Server |
| [**DeleteServer**](ServersApi.md#deleteserver) | **DELETE** /servers/{id} | Delete a Server |
| [**DetachIsoFromServer**](ServersApi.md#detachisofromserver) | **POST** /servers/{id}/actions/detach_iso | Detach an ISO from a Server |
| [**DetachServerFromNetwork**](ServersApi.md#detachserverfromnetwork) | **POST** /servers/{id}/actions/detach_from_network | Detach a Server from a Network |
| [**DisableBackupsForServer**](ServersApi.md#disablebackupsforserver) | **POST** /servers/{id}/actions/disable_backup | Disable Backups for a Server |
| [**DisableRescueModeForServer**](ServersApi.md#disablerescuemodeforserver) | **POST** /servers/{id}/actions/disable_rescue | Disable Rescue Mode for a Server |
| [**EnableAndConfigureBackupsForServer**](ServersApi.md#enableandconfigurebackupsforserver) | **POST** /servers/{id}/actions/enable_backup | Enable and Configure Backups for a Server |
| [**EnableRescueModeForServer**](ServersApi.md#enablerescuemodeforserver) | **POST** /servers/{id}/actions/enable_rescue | Enable Rescue Mode for a Server |
| [**GetActionForServer**](ServersApi.md#getactionforserver) | **GET** /servers/{id}/actions/{action_id} | Get an Action for a Server |
| [**GetMetricsForServer**](ServersApi.md#getmetricsforserver) | **GET** /servers/{id}/metrics | Get Metrics for a Server |
| [**GetServer**](ServersApi.md#getserver) | **GET** /servers/{id} | Get a Server |
| [**GetServerAction**](ServersApi.md#getserveraction) | **GET** /servers/actions/{id} | Get an Action |
| [**ListActionsForServer**](ServersApi.md#listactionsforserver) | **GET** /servers/{id}/actions | Get all Actions for a Server |
| [**ListServerActions**](ServersApi.md#listserveractions) | **GET** /servers/actions | Get all Actions |
| [**ListServers**](ServersApi.md#listservers) | **GET** /servers | Get all Servers |
| [**PowerOffServer**](ServersApi.md#poweroffserver) | **POST** /servers/{id}/actions/poweroff | Power off a Server |
| [**PowerOnServer**](ServersApi.md#poweronserver) | **POST** /servers/{id}/actions/poweron | Power on a Server |
| [**RebuildServerFromImage**](ServersApi.md#rebuildserverfromimage) | **POST** /servers/{id}/actions/rebuild | Rebuild a Server from an Image |
| [**RemoveFromPlacementGroup**](ServersApi.md#removefromplacementgroup) | **POST** /servers/{id}/actions/remove_from_placement_group | Remove from Placement Group |
| [**ReplaceServer**](ServersApi.md#replaceserver) | **PUT** /servers/{id} | Update a Server |
| [**RequestConsoleForServer**](ServersApi.md#requestconsoleforserver) | **POST** /servers/{id}/actions/request_console | Request Console for a Server |
| [**ResetRootPasswordOfServer**](ServersApi.md#resetrootpasswordofserver) | **POST** /servers/{id}/actions/reset_password | Reset root Password of a Server |
| [**ResetServer**](ServersApi.md#resetserver) | **POST** /servers/{id}/actions/reset | Reset a Server |
| [**ShutdownServer**](ServersApi.md#shutdownserver) | **POST** /servers/{id}/actions/shutdown | Shutdown a Server |
| [**SoftRebootServer**](ServersApi.md#softrebootserver) | **POST** /servers/{id}/actions/reboot | Soft-reboot a Server |

<a id="addservertoplacementgroup"></a>
# **AddServerToPlacementGroup**
> AddServerToPlacementGroupResponse AddServerToPlacementGroup (long id, AddServerToPlacementGroupRequest addServerToPlacementGroupRequest = null)

Add a Server to a Placement Group

Adds a Server to a Placement Group.  Server must be powered off for this command to succeed.  #### Call specific error codes  | Code                          | Description                                                          | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | `server_not_stopped`          | The action requires a stopped server                                 | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |
| **addServerToPlacementGroupRequest** | [**AddServerToPlacementGroupRequest**](AddServerToPlacementGroupRequest.md) |  | [optional]  |

### Return type

[**AddServerToPlacementGroupResponse**](AddServerToPlacementGroupResponse.md)

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

<a id="attachisotoserver"></a>
# **AttachIsoToServer**
> AttachIsoToServerResponse AttachIsoToServer (long id, AttachIsoToServerRequest attachIsoToServerRequest = null)

Attach an ISO to a Server

Attaches an ISO to a Server. The Server will immediately see it as a new disk. An already attached ISO will automatically be detached before the new ISO is attached.  Servers with attached ISOs have a modified boot order: They will try to boot from the ISO first before falling back to hard disk. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |
| **attachIsoToServerRequest** | [**AttachIsoToServerRequest**](AttachIsoToServerRequest.md) |  | [optional]  |

### Return type

[**AttachIsoToServerResponse**](AttachIsoToServerResponse.md)

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

<a id="attachservertonetwork"></a>
# **AttachServerToNetwork**
> AttachServerToNetworkResponse AttachServerToNetwork (long id, AttachServerToNetworkRequest attachServerToNetworkRequest = null)

Attach a Server to a Network

Attaches a Server to a network. This will complement the fixed public Server interface by adding an additional ethernet interface to the Server which is connected to the specified network.  The Server will get an IP auto assigned from a subnet of type `server` in the same `network_zone`.  Using the `alias_ips` attribute you can also define one or more additional IPs to the Servers. Please note that you will have to configure these IPs by hand on your Server since only the primary IP will be given out by DHCP.  **Call specific error codes**  | Code                             | Description                                                           | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | `server_already_attached`        | The server is already attached to the network                         | | `ip_not_available`               | The provided Network IP is not available                              | | `no_subnet_available`            | No Subnet or IP is available for the Server within the network        | | `networks_overlap`               | The network IP range overlaps with one of the server networks         | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |
| **attachServerToNetworkRequest** | [**AttachServerToNetworkRequest**](AttachServerToNetworkRequest.md) |  | [optional]  |

### Return type

[**AttachServerToNetworkResponse**](AttachServerToNetworkResponse.md)

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

<a id="changealiasipsofnetwork"></a>
# **ChangeAliasIpsOfNetwork**
> ChangeAliasIpsOfNetworkResponse ChangeAliasIpsOfNetwork (long id, ChangeAliasIpsOfNetworkRequest changeAliasIpsOfNetworkRequest = null)

Change alias IPs of a Network

Changes the alias IPs of an already attached Network. Note that the existing aliases for the specified Network will be replaced with these provided in the request body. So if you want to add an alias IP, you have to provide the existing ones from the Network plus the new alias IP in the request body.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |
| **changeAliasIpsOfNetworkRequest** | [**ChangeAliasIpsOfNetworkRequest**](ChangeAliasIpsOfNetworkRequest.md) |  | [optional]  |

### Return type

[**ChangeAliasIpsOfNetworkResponse**](ChangeAliasIpsOfNetworkResponse.md)

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

<a id="changereversednsentryforthisserver"></a>
# **ChangeReverseDnsEntryForThisServer**
> ChangeReverseDnsEntryForThisServerResponse ChangeReverseDnsEntryForThisServer (long id, ChangeReverseDnsEntryForThisServerRequest changeReverseDnsEntryForThisServerRequest = null)

Change reverse DNS entry for this Server

Changes the hostname that will appear when getting the hostname belonging to the primary IPs (IPv4 and IPv6) of this Server.  Floating IPs assigned to the Server are not affected by this. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |
| **changeReverseDnsEntryForThisServerRequest** | [**ChangeReverseDnsEntryForThisServerRequest**](ChangeReverseDnsEntryForThisServerRequest.md) | Select the IP address for which to change the DNS entry by passing &#x60;ip&#x60;. It can be either IPv4 or IPv6. The target hostname is set by passing &#x60;dns_ptr&#x60;. | [optional]  |

### Return type

[**ChangeReverseDnsEntryForThisServerResponse**](ChangeReverseDnsEntryForThisServerResponse.md)

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

<a id="changeserverprotection"></a>
# **ChangeServerProtection**
> ChangeServerProtectionResponse ChangeServerProtection (long id, ChangeServerProtectionRequest changeServerProtectionRequest = null)

Change Server Protection

Changes the protection configuration of the Server.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |
| **changeServerProtectionRequest** | [**ChangeServerProtectionRequest**](ChangeServerProtectionRequest.md) |  | [optional]  |

### Return type

[**ChangeServerProtectionResponse**](ChangeServerProtectionResponse.md)

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

<a id="changetypeofserver"></a>
# **ChangeTypeOfServer**
> ChangeTypeOfServerResponse ChangeTypeOfServer (long id, ChangeTypeOfServerRequest changeTypeOfServerRequest = null)

Change the Type of a Server

Changes the type (Cores, RAM and disk sizes) of a Server.  Server must be powered off for this command to succeed.  This copies the content of its disk, and starts it again.  You can only migrate to Server types with the same `storage_type` and equal or bigger disks. Shrinking disks is not possible as it might destroy data.  If the disk gets upgraded, the Server type can not be downgraded any more. If you plan to downgrade the Server type, set `upgrade_disk` to `false`.  #### Call specific error codes  | Code                          | Description                                                          | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | `invalid_server_type`         | The server type does not fit for the given server or is deprecated   | | `server_not_stopped`          | The action requires a stopped server                                 | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |
| **changeTypeOfServerRequest** | [**ChangeTypeOfServerRequest**](ChangeTypeOfServerRequest.md) |  | [optional]  |

### Return type

[**ChangeTypeOfServerResponse**](ChangeTypeOfServerResponse.md)

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

<a id="createimagefromserver"></a>
# **CreateImageFromServer**
> CreateImageFromServerResponse CreateImageFromServer (long id, CreateImageFromServerRequest createImageFromServerRequest = null)

Create Image from a Server

Creates an Image (snapshot) from a Server by copying the contents of its disks. This creates a snapshot of the current state of the disk and copies it into an Image. If the Server is currently running you must make sure that its disk content is consistent. Otherwise, the created Image may not be readable.  To make sure disk content is consistent, we recommend to shut down the Server prior to creating an Image.  You can either create a `backup` Image that is bound to the Server and therefore will be deleted when the Server is deleted, or you can create a `snapshot` Image which is completely independent of the Server it was created from and will survive Server deletion. Backup Images are only available when the backup option is enabled for the Server. Snapshot Images are billed on a per GB basis. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |
| **createImageFromServerRequest** | [**CreateImageFromServerRequest**](CreateImageFromServerRequest.md) |  | [optional]  |

### Return type

[**CreateImageFromServerResponse**](CreateImageFromServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;image&#x60; key in the reply contains an the created Image, which is an object with this structure  The &#x60;action&#x60; key in the reply contains an Action object with this structure  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createserver"></a>
# **CreateServer**
> CreateServerResponse CreateServer (CreateServerRequest createServerRequest = null)

Create a Server

Creates a new Server. Returns preliminary information about the Server as well as an Action that covers progress of creation.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createServerRequest** | [**CreateServerRequest**](CreateServerRequest.md) | Please note that Server names must be unique per Project and valid hostnames as per RFC 1123 (i.e. may only contain letters, digits, periods, and dashes).  For &#x60;server_type&#x60; you can either use the ID as listed in &#x60;/server_types&#x60; or its name.  For &#x60;image&#x60; you can either use the ID as listed in &#x60;/images&#x60; or its name.  If you want to create the Server in a Location, you must set &#x60;location&#x60; to the ID or name as listed in &#x60;/locations&#x60;. This is the recommended way. You can be even more specific by setting &#x60;datacenter&#x60; to the ID or name as listed in &#x60;/datacenters&#x60;. However we only recommend this if you want to assign a specific Primary IP to the Server which is located in the specified Datacenter.  Some properties like &#x60;start_after_create&#x60; or &#x60;automount&#x60; will trigger Actions after the Server is created. Those Actions are listed in the &#x60;next_actions&#x60; field in the response.  For accessing your Server we strongly recommend to use SSH keys by passing the respective key IDs in &#x60;ssh_keys&#x60;. If you do not specify any &#x60;ssh_keys&#x60; we will generate a root password for you and return it in the response.  Please note that provided user-data is stored in our systems. While we take measures to protect it we highly recommend that you don’t use it to store passwords or other sensitive information.  #### Call specific error codes  | Code                             | Description                                                | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | &#x60;placement_error&#x60;                | An error during the placement occurred                     | | &#x60;primary_ip_assigned&#x60;            | The specified Primary IP is already assigned to a server   | | &#x60;primary_ip_datacenter_mismatch&#x60; | The specified Primary IP is in a different datacenter      | | &#x60;primary_ip_version_mismatch&#x60;    | The specified Primary IP has the wrong IP Version          |  | [optional]  |

### Return type

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;server&#x60; key in the reply contains a Server object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteserver"></a>
# **DeleteServer**
> DeleteServerResponse DeleteServer (long id)

Delete a Server

Deletes a Server. This immediately removes the Server from your account, and it is no longer accessible. Any resources attached to the server (like Volumes, Primary IPs, Floating IPs, Firewalls, Placement Groups) are detached while the server is deleted. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |

### Return type

[**DeleteServerResponse**](DeleteServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;action&#x60; key in the reply contains an Action object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="detachisofromserver"></a>
# **DetachIsoFromServer**
> DetachIsoFromServerResponse DetachIsoFromServer (long id)

Detach an ISO from a Server

Detaches an ISO from a Server. In case no ISO Image is attached to the Server, the status of the returned Action is immediately set to `success`


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |

### Return type

[**DetachIsoFromServerResponse**](DetachIsoFromServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key in the reply contains an Action object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="detachserverfromnetwork"></a>
# **DetachServerFromNetwork**
> DetachServerFromNetworkResponse DetachServerFromNetwork (long id, DetachServerFromNetworkRequest detachServerFromNetworkRequest = null)

Detach a Server from a Network

Detaches a Server from a network. The interface for this network will vanish.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |
| **detachServerFromNetworkRequest** | [**DetachServerFromNetworkRequest**](DetachServerFromNetworkRequest.md) |  | [optional]  |

### Return type

[**DetachServerFromNetworkResponse**](DetachServerFromNetworkResponse.md)

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

<a id="disablebackupsforserver"></a>
# **DisableBackupsForServer**
> DisableBackupsForServerResponse DisableBackupsForServer (long id)

Disable Backups for a Server

Disables the automatic backup option and deletes all existing Backups for a Server. No more additional charges for backups will be made.  Caution: This immediately removes all existing backups for the Server! 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |

### Return type

[**DisableBackupsForServerResponse**](DisableBackupsForServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key in the reply contains an Action object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="disablerescuemodeforserver"></a>
# **DisableRescueModeForServer**
> DisableRescueModeForServerResponse DisableRescueModeForServer (long id)

Disable Rescue Mode for a Server

Disables the Hetzner Rescue System for a Server. This makes a Server start from its disks on next reboot.  Rescue Mode is automatically disabled when you first boot into it or if you do not use it for 60 minutes.  Disabling rescue mode will not reboot your Server — you will have to do this yourself. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |

### Return type

[**DisableRescueModeForServerResponse**](DisableRescueModeForServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key in the reply contains an Action object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="enableandconfigurebackupsforserver"></a>
# **EnableAndConfigureBackupsForServer**
> EnableAndConfigureBackupsForServerResponse EnableAndConfigureBackupsForServer (long id)

Enable and Configure Backups for a Server

Enables and configures the automatic daily backup option for the Server. Enabling automatic backups will increase the price of the Server by 20%. In return, you will get seven slots where Images of type backup can be stored.  Backups are automatically created daily. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |

### Return type

[**EnableAndConfigureBackupsForServerResponse**](EnableAndConfigureBackupsForServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key in the reply contains an Action object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="enablerescuemodeforserver"></a>
# **EnableRescueModeForServer**
> EnableRescueModeForServerResponse EnableRescueModeForServer (long id, EnableRescueModeForServerRequest enableRescueModeForServerRequest = null)

Enable Rescue Mode for a Server

Enable the Hetzner Rescue System for this Server. The next time a Server with enabled rescue mode boots it will start a special minimal Linux distribution designed for repair and reinstall.  In case a Server cannot boot on its own you can use this to access a Server’s disks.  Rescue Mode is automatically disabled when you first boot into it or if you do not use it for 60 minutes.  Enabling rescue mode will not [reboot](https://docs.hetzner.cloud/#server-actions-soft-reboot-a-server) your Server — you will have to do this yourself. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |
| **enableRescueModeForServerRequest** | [**EnableRescueModeForServerRequest**](EnableRescueModeForServerRequest.md) |  | [optional]  |

### Return type

[**EnableRescueModeForServerResponse**](EnableRescueModeForServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;root_password&#x60; key in the reply contains the root password that can be used to access the booted rescue system.  The &#x60;action&#x60; key in the reply contains an Action object with this structure  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getactionforserver"></a>
# **GetActionForServer**
> GetActionForServerResponse GetActionForServer (long id, long actionId)

Get an Action for a Server

Returns a specific Action object for a Server.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |
| **actionId** | **long** | ID of the Action. |  |

### Return type

[**GetActionForServerResponse**](GetActionForServerResponse.md)

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

<a id="getmetricsforserver"></a>
# **GetMetricsForServer**
> GetMetricsForServerResponse GetMetricsForServer (long id, string type, string start, string end, string step = null)

Get Metrics for a Server

Get Metrics for specified Server.  You must specify the type of metric to get: cpu, disk or network. You can also specify more than one type by comma separation, e.g. cpu,disk.  Depending on the type you will get different time series data  | Type    | Timeseries              | Unit      | Description                                          | |- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | cpu     | cpu                     | percent   | Percent CPU usage                                    | | disk    | disk.0.iops.read        | iop/s     | Number of read IO operations per second              | |         | disk.0.iops.write       | iop/s     | Number of write IO operations per second             | |         | disk.0.bandwidth.read   | bytes/s   | Bytes read per second                                | |         | disk.0.bandwidth.write  | bytes/s   | Bytes written per second                             | | network | network.0.pps.in        | packets/s | Public Network interface packets per second received | |         | network.0.pps.out       | packets/s | Public Network interface packets per second sent     | |         | network.0.bandwidth.in  | bytes/s   | Public Network interface bytes/s received            | |         | network.0.bandwidth.out | bytes/s   | Public Network interface bytes/s sent                |  Metrics are available for the last 30 days only.  If you do not provide the step argument we will automatically adjust it so that a maximum of 200 samples are returned.  We limit the number of samples returned to a maximum of 500 and will adjust the step parameter accordingly. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |
| **type** | **string** | Type of metrics to get |  |
| **start** | **string** | Start of period to get Metrics for (in ISO-8601 format) |  |
| **end** | **string** | End of period to get Metrics for (in ISO-8601 format) |  |
| **step** | **string** | Resolution of results in seconds | [optional]  |

### Return type

[**GetMetricsForServerResponse**](GetMetricsForServerResponse.md)

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

<a id="getserver"></a>
# **GetServer**
> GetServerResponse GetServer (long id)

Get a Server

Returns a specific Server object. The Server must exist inside the Project


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |

### Return type

[**GetServerResponse**](GetServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;server&#x60; key in the reply contains a Server object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getserveraction"></a>
# **GetServerAction**
> GetActionResponse GetServerAction (long id)

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

<a id="listactionsforserver"></a>
# **ListActionsForServer**
> ListActionsForServerResponse ListActionsForServer (long id, string sort = null, string status = null, long page = null, long perPage = null)

Get all Actions for a Server

Returns all Action objects for a Server. You can `sort` the results by using the sort URI parameter, and filter them with the `status` parameter.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server |  |
| **sort** | **string** | Sort actions by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **status** | **string** | Filter the actions by status. Can be used multiple times. The response will only contain actions matching the specified statuses.  | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListActionsForServerResponse**](ListActionsForServerResponse.md)

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

<a id="listserveractions"></a>
# **ListServerActions**
> ListActionsResponse ListServerActions (long id = null, string sort = null, string status = null, long page = null, long perPage = null)

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

<a id="listservers"></a>
# **ListServers**
> ListServersResponse ListServers (string name = null, string labelSelector = null, string sort = null, string status = null, long page = null, long perPage = null)

Get all Servers

Returns all existing Server objects


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Filter resources by their name. The response will only contain the resources matching the specified name.  | [optional]  |
| **labelSelector** | **string** | Filter resources by labels. The response will only contain resources matching the label selector. For more information, see \&quot;[Label Selector](#label-selector)\&quot;.  | [optional]  |
| **sort** | **string** | Sort resources by field and direction. Can be used multiple times. For more information, see \&quot;[Sorting](#sorting)\&quot;.  | [optional]  |
| **status** | **string** | Can be used multiple times. The response will only contain Server matching the status | [optional]  |
| **page** | **long** | Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 1] |
| **perPage** | **long** | Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. | [optional] [default to 25] |

### Return type

[**ListServersResponse**](ListServersResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A paged array of servers |  * x-next - A link to the next page of responses <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="poweroffserver"></a>
# **PowerOffServer**
> PowerOffServerResponse PowerOffServer (long id)

Power off a Server

Cuts power to the Server. This forcefully stops it without giving the Server operating system time to gracefully stop. May lead to data loss, equivalent to pulling the power cord. Power off should only be used when shutdown does not work.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |

### Return type

[**PowerOffServerResponse**](PowerOffServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key in the reply contains an Action object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="poweronserver"></a>
# **PowerOnServer**
> PowerOnServerResponse PowerOnServer (long id)

Power on a Server

Starts a Server by turning its power on.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |

### Return type

[**PowerOnServerResponse**](PowerOnServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key in the reply contains an Action object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="rebuildserverfromimage"></a>
# **RebuildServerFromImage**
> RebuildServerFromImageResponse RebuildServerFromImage (long id, RebuildServerFromImageRequest rebuildServerFromImageRequest = null)

Rebuild a Server from an Image

Rebuilds a Server overwriting its disk with the content of an Image, thereby **destroying all data** on the target Server  The Image can either be one you have created earlier (`backup` or `snapshot` Image) or it can be a completely fresh `system` Image provided by us. You can get a list of all available Images with `GET /images`.  Your Server will automatically be powered off before the rebuild command executes. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |
| **rebuildServerFromImageRequest** | [**RebuildServerFromImageRequest**](RebuildServerFromImageRequest.md) | To select which Image to rebuild from you can either pass an ID or a name as the &#x60;image&#x60; argument. Passing a name only works for &#x60;system&#x60; Images since the other Image types do not have a name set. | [optional]  |

### Return type

[**RebuildServerFromImageResponse**](RebuildServerFromImageResponse.md)

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

<a id="removefromplacementgroup"></a>
# **RemoveFromPlacementGroup**
> RemoveFromPlacementGroupResponse RemoveFromPlacementGroup (long id)

Remove from Placement Group

Removes a Server from a Placement Group. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |

### Return type

[**RemoveFromPlacementGroupResponse**](RemoveFromPlacementGroupResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key in the reply contains an Action object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="replaceserver"></a>
# **ReplaceServer**
> ReplaceServerResponse ReplaceServer (long id, ReplaceServerRequest replaceServerRequest = null)

Update a Server

Updates a Server. You can update a Server’s name and a Server’s labels. Please note that Server names must be unique per Project and valid hostnames as per RFC 1123 (i.e. may only contain letters, digits, periods, and dashes). Also note that when updating labels, the Server’s current set of labels will be replaced with the labels provided in the request body. So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |
| **replaceServerRequest** | [**ReplaceServerRequest**](ReplaceServerRequest.md) |  | [optional]  |

### Return type

[**ReplaceServerResponse**](ReplaceServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The &#x60;server&#x60; key in the reply contains the updated Server |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="requestconsoleforserver"></a>
# **RequestConsoleForServer**
> RequestConsoleForServerResponse RequestConsoleForServer (long id)

Request Console for a Server

Requests credentials for remote access via VNC over websocket to keyboard, monitor, and mouse for a Server. The provided URL is valid for 1 minute, after this period a new url needs to be created to connect to the Server. How long the connection is open after the initial connect is not subject to this timeout.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |

### Return type

[**RequestConsoleForServerResponse**](RequestConsoleForServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key in the reply contains an Action object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="resetrootpasswordofserver"></a>
# **ResetRootPasswordOfServer**
> ResetRootPasswordOfServerResponse ResetRootPasswordOfServer (long id)

Reset root Password of a Server

Resets the root password. Only works for Linux systems that are running the qemu guest agent. Server must be powered on (status `running`) in order for this operation to succeed.  This will generate a new password for this Server and return it.  If this does not succeed you can use the rescue system to netboot the Server and manually change your Server password by hand. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |

### Return type

[**ResetRootPasswordOfServerResponse**](ResetRootPasswordOfServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;root_password&#x60; key in the reply contains the new root password that will be active if the Action succeeds.  The &#x60;action&#x60; key in the reply contains an Action object with this structure:  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="resetserver"></a>
# **ResetServer**
> ResetServerResponse ResetServer (long id)

Reset a Server

Cuts power to a Server and starts it again. This forcefully stops it without giving the Server operating system time to gracefully stop. This may lead to data loss, it’s equivalent to pulling the power cord and plugging it in again. Reset should only be used when reboot does not work.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |

### Return type

[**ResetServerResponse**](ResetServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key in the reply contains an Action object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="shutdownserver"></a>
# **ShutdownServer**
> ShutdownServerResponse ShutdownServer (long id)

Shutdown a Server

Shuts down a Server gracefully by sending an ACPI shutdown request. The Server operating system must support ACPI and react to the request, otherwise the Server will not shut down. Please note that the `action` status in this case only reflects whether the action was sent to the server. It does not mean that the server actually shut down successfully. If you need to ensure that the server is off, use the `poweroff` action 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |

### Return type

[**ShutdownServerResponse**](ShutdownServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key in the reply contains an Action object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="softrebootserver"></a>
# **SoftRebootServer**
> SoftRebootServerResponse SoftRebootServer (long id)

Soft-reboot a Server

Reboots a Server gracefully by sending an ACPI request. The Server operating system must support ACPI and react to the request, otherwise the Server will not reboot.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | ID of the Server. |  |

### Return type

[**SoftRebootServerResponse**](SoftRebootServerResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The &#x60;action&#x60; key in the reply contains an Action object with this structure |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

