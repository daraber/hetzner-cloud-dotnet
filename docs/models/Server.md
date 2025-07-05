# Hetzner.Cloud.Model.Server
Servers are virtual machines that can be provisioned.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Created** | **string** | Point in time when the Resource was created (in ISO-8601 format). | 
**Datacenter** | [**Datacenter**](Datacenter.md) |  | 
**Id** | **long** | ID of the Server. | 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | 
**Locked** | **bool** | True if Server has been locked and is not available to user | 
**Name** | **string** | Name of the Server (must be unique per Project and a valid hostname as per RFC 1123) | 
**PrimaryDiskSize** | **int** | Size of the primary Disk | 
**PrivateNet** | [**List&lt;ServerPrivateNet&gt;**](ServerPrivateNet.md) | Private networks information | 
**Protection** | [**ServerProtection**](ServerProtection.md) |  | 
**PublicNet** | [**ServerPublicNet**](ServerPublicNet.md) |  | 
**RescueEnabled** | **bool** | True if rescue mode is enabled. Server will then boot into rescue system on next reboot | 
**ServerType** | [**ServerType**](ServerType.md) |  | 
**Status** | **string** | Status of the Server | 
**BackupWindow** | **string** | Time window (UTC) in which the backup will run, or null if the backups are not enabled | 
**Image** | [**ImageOptional**](ImageOptional.md) |  | 
**IncludedTraffic** | **long** | Free Traffic for the current billing period in bytes | 
**IngoingTraffic** | **long** | Inbound Traffic for the current billing period in bytes | 
**Iso** | [**IsoOptional**](IsoOptional.md) |  | 
**LoadBalancers** | **List&lt;long&gt;** | Load Balancer IDs assigned to the server. | [optional] 
**OutgoingTraffic** | **long** | Outbound Traffic for the current billing period in bytes | 
**PlacementGroup** | [**PlacementGroupNullable**](PlacementGroupNullable.md) |  | [optional] 
**Volumes** | **List&lt;long&gt;** | IDs of Volumes assigned to this Server | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

