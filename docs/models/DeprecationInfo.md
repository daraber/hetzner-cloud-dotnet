# Hetzner.Cloud.Model.DeprecationInfo
Describes if, when and how the resource is deprecated. If this field is set to `null` the resource is not deprecated. If a value is set, it is considered deprecated. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Announced** | **string** | Date of the deprecation announcement.  | 
**UnavailableAfter** | **string** | Date of the deprecated resource removal.  Once this date is reached, the resource will not be returned by resource type \&quot;list\&quot; endpoint, and the resource can not be used to create new resources. For example, if this is an image, you can not create new servers with this image after the mentioned date.  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

