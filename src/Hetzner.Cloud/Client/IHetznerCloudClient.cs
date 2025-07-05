using Hetzner.Cloud.Api;

namespace Hetzner.Cloud.Client;

/// <summary>
/// Provides access to the Hetzner Cloud API endpoints.
/// </summary>
public interface IHetznerCloudClient
{
    /// <summary>
    /// Gets the client for managing server actions.
    /// </summary>
    ActionsApi Actions { get; }

    /// <summary>
    /// Gets the client for managing SSL certificates.
    /// </summary>
    CertificatesApi Certificates { get; }

    /// <summary>
    /// Gets the client for managing datacenters.
    /// </summary>
    DatacentersApi Datacenters { get; }

    /// <summary>
    /// Gets the client for managing firewalls.
    /// </summary>
    FirewallsApi Firewalls { get; }

    /// <summary>
    /// Gets the client for managing floating IP addresses.
    /// </summary>
    FloatingIpsApi FloatingIps { get; }

    /// <summary>
    /// Gets the client for managing server images.
    /// </summary>
    ImagesApi Images { get; }

    /// <summary>
    /// Gets the client for managing ISO images.
    /// </summary>
    IsosApi Isos { get; }

    /// <summary>
    /// Gets the client for managing load balancers.
    /// </summary>
    LoadBalancersApi LoadBalancers { get; }

    /// <summary>
    /// Gets the client for managing load balancer types.
    /// </summary>
    LoadBalancerTypesApi LoadBalancerTypes { get; }

    /// <summary>
    /// Gets the client for managing locations.
    /// </summary>
    LocationsApi Locations { get; }

    /// <summary>
    /// Gets the client for managing networks.
    /// </summary>
    NetworksApi Networks { get; }

    /// <summary>
    /// Gets the client for managing placement groups.
    /// </summary>
    PlacementGroupsApi PlacementGroups { get; }

    /// <summary>
    /// Gets the client for retrieving pricing information.
    /// </summary>
    PricingApi Pricing { get; }

    /// <summary>
    /// Gets the client for managing primary IP addresses.
    /// </summary>
    PrimaryIpsApi PrimaryIps { get; }

    /// <summary>
    /// Gets the client for managing servers.
    /// </summary>
    ServersApi Servers { get; }

    /// <summary>
    /// Gets the client for managing server types.
    /// </summary>
    ServerTypesApi ServerTypes { get; }

    /// <summary>
    /// Gets the client for managing SSH keys.
    /// </summary>
    SshKeysApi SshKeys { get; }

    /// <summary>
    /// Gets the client for managing volumes.
    /// </summary>
    VolumesApi Volumes { get; }
}