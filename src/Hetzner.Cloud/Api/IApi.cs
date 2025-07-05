using System.Net.Http;

namespace Hetzner.Cloud.Api
{
    /// <summary>
    /// Any Api client
    /// </summary>
    internal interface IApi
    {
        /// <summary>
        /// The HttpClient
        /// </summary>
        HttpClient HttpClient { get; }
    }
}