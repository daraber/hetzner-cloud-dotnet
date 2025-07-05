# Hetzner.Cloud.Model.ChangeIpRangeOfNetworkRequest
Request for POST https://api.hetzner.cloud/v1/networks/{id}/actions/change_ip_range

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpRange** | **string** | IP range of the [Network](#networks).  Uses CIDR notation.  Must span all included subnets. Must be one of the private IPv4 ranges of RFC1918.  Minimum network size is /24. We highly recommend that you pick a larger [Network](#networks) with a /16 netmask.  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

