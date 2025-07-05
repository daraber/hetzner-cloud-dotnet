# Hetzner.Cloud.Model.ChangeReverseDnsEntryForThisServerRequest
Request for POST https://api.hetzner.cloud/v1/servers/{id}/actions/change_dns_ptr

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ip** | **string** | Primary IP address for which the reverse DNS entry should be set | 
**DnsPtr** | **string** | Hostname to set as a reverse DNS PTR entry, reset to original value if &#x60;null&#x60; | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

