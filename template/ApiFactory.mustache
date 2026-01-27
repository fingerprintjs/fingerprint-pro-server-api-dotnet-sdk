using System;
using Microsoft.Extensions.DependencyInjection;
using Fingerprint.ServerSdk.Api;

namespace Fingerprint.ServerSdk.Client
{
    /// <summary>
    /// An IApiFactory interface
    /// </summary>
    public interface IApiFactory
    {
        /// <summary>
        /// A method to create an IApi of type TResult
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        TResult Create<TResult>() where TResult : IApi;
    }

    /// <summary>
    /// An ApiFactory
    /// </summary>
    public class ApiFactory : IApiFactory
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
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public TResult Create<TResult>() where TResult : IApi
        {
            return Services.GetRequiredService<TResult>();
        }
    }
}