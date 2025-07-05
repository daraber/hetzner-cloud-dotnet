# Hetzner.Cloud.Model.Route
Request for POST https://api.hetzner.cloud/v1/networks/{id}/actions/add_route | Request for POST https://api.hetzner.cloud/v1/networks/{id}/actions/delete_route

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Destination** | **string** | Destination network or host of the route.  Packages addressed for IPs matching the destination IP prefix will be send to the specified gateway.  Must be one of * private IPv4 ranges of RFC1918 * or &#x60;0.0.0.0/0&#x60;.  Must not overlap with * an existing ip_range in any subnets * or with any destinations in other routes * or with &#x60;172.31.1.1&#x60;.  &#x60;172.31.1.1&#x60; is being used as a gateway for the public network interface of [Servers](#servers).  | 
**Gateway** | **string** | Gateway of the route.  Packages addressed for the specified destination will be send to this IP address.  Cannot be * the first IP of the networks ip_range, * an IP behind a vSwitch or * &#x60;172.31.1.1&#x60;.  &#x60;172.31.1.1&#x60; is being used as a gateway for the public network interface of [Servers](#servers).  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

