# Hetzner.Cloud.Model.AttachServerToNetworkRequest
Request for POST https://api.hetzner.cloud/v1/servers/{id}/actions/attach_to_network

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Network** | **long** | ID of an existing network to attach the Server to | 
**AliasIps** | **List&lt;string&gt;** | Additional IPs to be assigned to this Server | [optional] 
**Ip** | **string** | IP to request to be assigned to this Server; if you do not provide this then you will be auto assigned an IP address | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

