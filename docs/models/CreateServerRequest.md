# Hetzner.Cloud.Model.CreateServerRequest
Request for POST https://api.hetzner.cloud/v1/servers

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Image** | **string** | ID or name of the Image the Server is created from | 
**Name** | **string** | Name of the Server to create (must be unique per Project and a valid hostname as per RFC 1123) | 
**ServerType** | **string** | ID or name of the Server type this Server should be created with | 
**Automount** | **bool** | Auto-mount Volumes after attach | [optional] 
**Datacenter** | **string** | ID or name of Datacenter to create Server in (must not be used together with location) | [optional] 
**Firewalls** | [**List&lt;CreateServerRequestFirewalls&gt;**](CreateServerRequestFirewalls.md) | Firewalls which should be applied on the Server&#39;s public network interface at creation time | [optional] 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | [optional] 
**Location** | **string** | ID or name of Location to create Server in (must not be used together with datacenter) | [optional] 
**Networks** | **List&lt;long&gt;** | Network IDs which should be attached to the Server private network interface at the creation time | [optional] 
**PlacementGroup** | **long** | ID of the Placement Group the server should be in | [optional] 
**PublicNet** | [**CreateServerRequestPublicNet**](CreateServerRequestPublicNet.md) |  | [optional] 
**SshKeys** | **List&lt;string&gt;** | SSH key IDs (&#x60;integer&#x60;) or names (&#x60;string&#x60;) which should be injected into the Server at creation time | [optional] 
**StartAfterCreate** | **bool** | This automatically triggers a [Power on a Server-Server Action](#server-actions-power-on-a-server) after the creation is finished and is returned in the &#x60;next_actions&#x60; response object. | [optional] [default to true]
**UserData** | **string** | Cloud-Init user data to use during Server creation. This field is limited to 32KiB. | [optional] 
**Volumes** | **List&lt;long&gt;** | Volume IDs which should be attached to the Server at the creation time. Volumes must be in the same Location. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

