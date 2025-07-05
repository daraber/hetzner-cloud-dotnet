# Hetzner.Cloud.Model.ServerPublicNet
Public network information. The Server's IPv4 address can be found in `public_net->ipv4->ip`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FloatingIps** | **List&lt;long&gt;** | IDs of Floating IPs assigned to this Server | 
**Firewalls** | [**List&lt;ServerPublicNetFirewall&gt;**](ServerPublicNetFirewall.md) | Firewalls applied to the public network interface of this Server | [optional] 
**Ipv4** | [**Ipv4**](Ipv4.md) |  | 
**Ipv6** | [**Ipv6**](Ipv6.md) |  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

