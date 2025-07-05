using System;
using System.Threading;
using System.Threading.Tasks;

namespace Hetzner.Cloud.Client;

/// <summary>
/// Provides a bearer token for authentication with the Hetzner Cloud API.
/// </summary>
internal sealed class BearerTokenProvider(BearerToken apiToken) : TokenProvider<BearerToken>([apiToken])
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BearerTokenProvider"/> class with a single bearer token.
    /// </summary>
    /// <param name="apiToken">The bearer token to use for authentication.</param>
    public BearerTokenProvider(string apiToken) : this(new BearerToken(apiToken))
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(apiToken);
    }

    internal override ValueTask<BearerToken> GetAsync(string header = "", CancellationToken cancellation = default)
    {
        return new ValueTask<BearerToken>(apiToken);
    }
}