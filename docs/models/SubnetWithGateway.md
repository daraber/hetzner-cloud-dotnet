# Hetzner.Cloud.Model.SubnetWithGateway

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gateway** | **string** | Gateway for [Servers](#servers) attached to this subnet.  For subnets of type &#x60;server&#x60; this is always the first IP of the subnets IP range.  | 
**NetworkZone** | **string** | Name of the [Network Zone](#network-zones).  The [Location](#locations) contains the &#x60;network_zone&#x60; property it belongs to.  | 
**Type** | **string** | Type of subnet.  - &#x60;cloud&#x60; - Used to connect cloud [Servers](#servers) and [Load Balancers](#load-balancers). - &#x60;server&#x60; - Same as the &#x60;cloud&#x60; type. **Deprecated**, use the &#x60;cloud&#x60; type instead. - &#x60;vswitch&#x60; - Used to [connect cloud Servers and Load Balancers with dedicated Servers](https://docs.hetzner.com/cloud/networks/connect-dedi-vswitch).  | 
**IpRange** | **string** | IP range of the subnet.  Uses CIDR notation.  | [optional] 
**VswitchId** | **long** | ID of the robot vSwitch if the subnet is of type &#x60;vswitch&#x60;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

