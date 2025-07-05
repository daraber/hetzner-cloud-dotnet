# Hetzner.Cloud.Model.Subnet
Subnets divide the ip_range from the parent Network object into multiple Subnetworks that you can use for different specific purposes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkZone** | **string** | Name of the [Network Zone](#network-zones).  The [Location](#locations) contains the &#x60;network_zone&#x60; property it belongs to.  | Name of the [Network Zone](#network-zones).  The [Location](#locations) contains the &#x60;network_zone&#x60; it belongs to.  | 
**Type** | **string** | Type of subnet.  - &#x60;cloud&#x60; - Used to connect cloud [Servers](#servers) and [Load Balancers](#load-balancers). - &#x60;server&#x60; - Same as the &#x60;cloud&#x60; type. **Deprecated**, use the &#x60;cloud&#x60; type instead. - &#x60;vswitch&#x60; - Used to [connect cloud Servers and Load Balancers with dedicated Servers](https://docs.hetzner.com/cloud/networks/connect-dedi-vswitch).  | 
**IpRange** | **string** | IP range of the subnet.  Uses CIDR notation.  Must be a subnet of the parent [Networks](#networks) &#x60;ip_range&#x60;.  Must not overlap with any other subnets or with any destinations in routes.  Minimum network size is /30. We highly recommend that you pick a larger subnet with a /24 netmask.  | [optional] 
**VswitchId** | **long** | ID of the robot vSwitch.  Must only be supplied for subnets of type &#x60;vswitch&#x60;.  | ID of the robot vSwitch.  Must be supplied if the subnet is of type &#x60;vswitch&#x60;.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

