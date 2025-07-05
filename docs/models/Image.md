# Hetzner.Cloud.Model.Image

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Architecture** | **Architecture** |  | 
**Created** | **string** | Point in time when the Resource was created (in ISO-8601 format). | 
**Description** | **string** | Description of the Image | 
**DiskSize** | **decimal** | Size of the disk contained in the Image in GB | 
**Id** | **long** | ID of the Image. | 
**Labels** | **Dictionary&lt;string, string&gt;** | User-defined labels (&#x60;key/value&#x60; pairs) for the Resource. For more information, see \&quot;[Labels](#labels)\&quot;.  | 
**OsFlavor** | **string** | Flavor of operating system contained in the Image | 
**Protection** | [**Protection**](Protection.md) |  | 
**Status** | **string** | Whether the Image can be used or if it&#39;s still being created or unavailable | 
**Type** | **string** | Type of the Image | 
**BoundTo** | **long** | ID of Server the Image is bound to. Only set for Images of type &#x60;backup&#x60;. | 
**CreatedFrom** | [**CreatedFrom**](CreatedFrom.md) |  | 
**Deleted** | **string** | Point in time where the Image was deleted (in ISO-8601 format) | 
**Deprecated** | **string** | Point in time when the Image is considered to be deprecated (in ISO-8601 format) | 
**ImageSize** | **decimal** | Size of the Image file in our storage in GB. For snapshot Images this is the value relevant for calculating costs for the Image. | 
**Name** | **string** | Unique identifier of the Image. This value is only set for system Images. | 
**OsVersion** | **string** | Operating system version | 
**RapidDeploy** | **bool** | Indicates that rapid deploy of the Image is available | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

