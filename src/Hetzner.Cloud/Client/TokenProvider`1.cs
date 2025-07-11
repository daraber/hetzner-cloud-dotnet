// <auto-generated>
/*
 * Hetzner Cloud API
 *
 * Copied from the official API documentation for the Public Hetzner Cloud.
 *
 * The version of the OpenAPI document: 0.22.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Linq;
using System.Collections.Generic;
using Hetzner.Cloud.Client;

namespace Hetzner.Cloud
{
    /// <summary>
    /// A class which will provide tokens.
    /// </summary>
    public abstract class TokenProvider<TTokenBase> where TTokenBase : TokenBase
    {
        /// <summary>
        /// The array of tokens.
        /// </summary>
        protected TTokenBase[] _tokens;

        internal abstract System.Threading.Tasks.ValueTask<TTokenBase> GetAsync(string header = "", System.Threading.CancellationToken cancellation = default);

        /// <summary>
        /// Instantiates a TokenProvider.
        /// </summary>
        /// <param name="tokens"></param>
        public TokenProvider(IEnumerable<TTokenBase> tokens)
        {
            _tokens = tokens.ToArray();

            if (_tokens.Length == 0)
                throw new ArgumentException("You did not provide any tokens.");
        }
    }
}