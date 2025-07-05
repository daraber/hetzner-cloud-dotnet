# Hetzner.Cloud.Model.CreateServerRequestPublicNet
Public Network options

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableIpv4** | **bool** | Attach an IPv4 on the public NIC. If false, no IPv4 address will be attached. | [optional] [default to true]
**EnableIpv6** | **bool** | Attach an IPv6 on the public NIC. If false, no IPv6 address will be attached. | [optional] [default to true]
**Ipv4** | **int** | ID of the ipv4 Primary IP to use. If omitted and enable_ipv4 is true, a new ipv4 Primary IP will automatically be created. | [optional] 
**Ipv6** | **int** | ID of the ipv6 Primary IP to use. If omitted and enable_ipv6 is true, a new ipv6 Primary IP will automatically be created. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

