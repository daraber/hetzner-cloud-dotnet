# Hetzner.Cloud.Model.Volume
A Volume is a highly-available, scalable, and SSD-based block storage for Servers. Pricing for Volumes depends on the Volume size and Location, not the actual used storage. Please see [Hetzner Wiki](https://wiki.hetzner.de/index.php/CloudServer/en#Volumes) for more details about Volumes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Created** | **string** | Point in time when the Resource was created (in ISO-8601 format). | 
**Id** | **long** | ID of the Volume. | 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | 
**LinuxDevice** | **string** | Device path on the file system for the Volume | 
**Location** | [**Location**](Location.md) |  | 
**Name** | **string** | Name of the Resource. Must be unique per Project. | 
**Protection** | [**Protection**](Protection.md) |  | 
**Size** | **decimal** | Size in GB of the Volume | 
**Status** | **string** | Current status of the Volume | 
**Format** | **string** | Filesystem of the Volume if formatted on creation, null if not formatted on creation | 
**Server** | **long** | ID of the Server the Volume is attached to, null if it is not attached at all | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

