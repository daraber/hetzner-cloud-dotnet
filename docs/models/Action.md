# Hetzner.Cloud.Model.Action
Actions show the results and progress of asynchronous requests to the API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Command executed in the Action. | 
**Id** | **long** | ID of the Action | 
**Progress** | **int** | Progress of the Action in percent. | 
**Resources** | [**List&lt;Resource&gt;**](Resource.md) | Resources the Action relates to. | 
**Started** | **string** | Point in time when the Action was started (in ISO-8601 format). | 
**Status** | **string** | Status of the Action. | 
**Error** | [**Error**](Error.md) |  | 
**Finished** | **string** | Point in time when the Action was finished (in ISO-8601 format). Only set if the Action is finished otherwise null. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

