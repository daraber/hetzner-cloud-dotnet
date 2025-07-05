# Hetzner.Cloud.Model.DnsPtr
Request for POST https://api.hetzner.cloud/v1/floating_ips/{id}/actions/change_dns_ptr | Request for POST https://api.hetzner.cloud/v1/primary_ips/{id}/actions/change_dns_ptr

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarDnsPtr** | **string** | Domain Name to point to.  PTR record content used for reverse DNS.  | DNS pointer for the specific IP address | 
**Ip** | **string** | Single IPv4 or IPv6 address to create pointer for.  | Single IPv6 address of this Server for which the reverse DNS entry has been set up | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

