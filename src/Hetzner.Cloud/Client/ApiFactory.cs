using System;
using Hetzner.Cloud.Api;
using Microsoft.Extensions.DependencyInjection;

namespace Hetzner.Cloud.Client
{
    /// <summary>
    /// An IApiFactory interface
    /// </summary>
    internal interface IApiFactory
    {
        /// <summary>
        /// A method to create an IApi of type IResult
        /// </summary>
        /// <typeparam name="IResult"></typeparam>
        /// <returns></returns>
        IResult Create<IResult>() where IResult : IApi;
    }

    /// <summary>
    /// An ApiFactory
    /// </summary>
    internal class ApiFactory : IApiFactory
    {
        /// <summary>
        /// The service provider
        /// </summary>
        public IServiceProvider Services { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiFactory"/> class.
        /// </summary>
        /// <param name="services"></param>
        public ApiFactory(IServiceProvider services)
        {
            Services = services;
        }

        /// <summary>
        /// A method to create an IApi of type IResult
        /// </summary>
        /// <typeparam name="IResult"></typeparam>
        /// <returns></returns>
        public IResult Create<IResult>() where IResult : IApi
        {
            return Services.GetRequiredService<IResult>();
        }
    }
}
