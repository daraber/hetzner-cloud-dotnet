# Hetzner.Cloud.Model.ServerType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Architecture** | **Architecture** |  | 
**Cores** | **int** | Number of cpu cores a Server of this type will have | 
**CpuType** | **string** | Type of cpu | 
**Description** | **string** | Description of the Server type | 
**Disk** | **decimal** | Disk size a Server of this type will have in GB | 
**Id** | **long** | ID of the Server type | 
**Memory** | **decimal** | Memory a Server of this type will have in GB | 
**Name** | **string** | Unique identifier of the Server type | 
**Prices** | [**List&lt;PricePerTime&gt;**](PricePerTime.md) | Price per [Location](#locations). | 
**StorageType** | **string** | Type of Server boot drive. Local has higher speed. Network has better availability. | 
**Deprecated** | **bool** | This field is deprecated. Use the deprecation object instead | 
**Deprecation** | [**DeprecationInfo**](DeprecationInfo.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

