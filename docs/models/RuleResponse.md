# Hetzner.Cloud.Model.RuleResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DestinationIps** | **List&lt;string&gt;** | List of permitted IPv4/IPv6 addresses for outgoing traffic.  The &#x60;direction&#x60; must be set to &#x60;out&#x60;.  IPs must be in [CIDR block notation](https://wikipedia.org/wiki/CIDR). You can specify 100 CIDR blocks at most.  The CIDR blocks may refer to networks (with empty host bits) or single hosts. For example, a network could be defined with &#x60;10.0.1.0/24&#x60; or &#x60;2001:db8:ff00:42::/64&#x60;, and a single host with &#x60;10.0.1.1/32&#x60; or &#x60;2001:db8:ff00:42::8329/128&#x60;.  Use &#x60;0.0.0.0/0&#x60; to allow any IPv4 addresses and &#x60;::/0&#x60; to allow any IPv6 addresses.  | 
**Direction** | **string** | Traffic direction in which the rule should be applied to.  Use &#x60;source_ips&#x60; for direction &#x60;in&#x60; and &#x60;destination_ips&#x60; for direction &#x60;out&#x60; to specify IPs.  | 
**Protocol** | **string** | Network protocol to apply the rule for. | 
**SourceIps** | **List&lt;string&gt;** | List of permitted IPv4/IPv6 addresses for incoming traffic.  The &#x60;direction&#x60; must be set to &#x60;in&#x60;.  IPs must be provided in [CIDR block notation](https://wikipedia.org/wiki/CIDR). You can specify 100 CIDR blocks at most.  The CIDR blocks may refer to networks (with empty host bits) or single hosts. For example, a network could be defined with &#x60;10.0.1.0/24&#x60; or &#x60;2001:db8:ff00:42::/64&#x60;, and a single host with &#x60;10.0.1.1/32&#x60; or &#x60;2001:db8:ff00:42::8329/128&#x60;.  Use &#x60;0.0.0.0/0&#x60; to allow any IPv4 addresses and &#x60;::/0&#x60; to allow any IPv6 addresses.  | 
**Description** | **string** | Description of the rule. | [optional] 
**Port** | **string** | Port or port range to apply the rule for.  Only applicable for protocols &#x60;tcp&#x60; and &#x60;udp&#x60;.  A port range can be specified by separating lower and upper bounds with a dash. &#x60;1024-5000&#x60; will include all ports starting from 1024 up to port 5000.  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

