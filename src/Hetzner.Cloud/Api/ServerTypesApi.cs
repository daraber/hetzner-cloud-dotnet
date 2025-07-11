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
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Hetzner.Cloud.Client;
using Hetzner.Cloud.Model;
using System.Diagnostics.CodeAnalysis;

namespace Hetzner.Cloud.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface IServerTypesApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        ServerTypesApiEvents Events { get; }

        /// <summary>
        /// Get a Server Type
        /// </summary>
        /// <remarks>
        /// Gets a specific Server type object.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Server Type.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetServerTypeApiResponse"/>&gt;</returns>
        Task<IGetServerTypeApiResponse> GetServerTypeAsync(long id, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a Server Type
        /// </summary>
        /// <remarks>
        /// Gets a specific Server type object.
        /// </remarks>
        /// <param name="id">ID of the Server Type.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetServerTypeApiResponse"/>?&gt;</returns>
        Task<IGetServerTypeApiResponse?> GetServerTypeOrDefaultAsync(long id, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all Server Types
        /// </summary>
        /// <remarks>
        /// Gets all Server type objects.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter resources by their name. The response will only contain the resources matching the specified name.  (optional)</param>
        /// <param name="page">Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. (optional, default to 1)</param>
        /// <param name="perPage">Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. (optional, default to 25)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IListServerTypesApiResponse"/>&gt;</returns>
        Task<IListServerTypesApiResponse> ListServerTypesAsync(Option<string> name = default, Option<long> page = default, Option<long> perPage = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all Server Types
        /// </summary>
        /// <remarks>
        /// Gets all Server type objects.
        /// </remarks>
        /// <param name="name">Filter resources by their name. The response will only contain the resources matching the specified name.  (optional)</param>
        /// <param name="page">Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. (optional, default to 1)</param>
        /// <param name="perPage">Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. (optional, default to 25)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IListServerTypesApiResponse"/>?&gt;</returns>
        Task<IListServerTypesApiResponse?> ListServerTypesOrDefaultAsync(Option<string> name = default, Option<long> page = default, Option<long> perPage = default, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="IGetServerTypeApiResponse"/>
    /// </summary>
    public interface IGetServerTypeApiResponse : Hetzner.Cloud.Client.IApiResponse, IOk<Hetzner.Cloud.Model.GetServerTypeResponse?>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }
    }

    /// <summary>
    /// The <see cref="IListServerTypesApiResponse"/>
    /// </summary>
    public interface IListServerTypesApiResponse : Hetzner.Cloud.Client.IApiResponse, IOk<Hetzner.Cloud.Model.ListServerTypesResponse?>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ServerTypesApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnGetServerType;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorGetServerType;

        internal void ExecuteOnGetServerType(ServerTypesApi.GetServerTypeApiResponse apiResponse)
        {
            OnGetServerType?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorGetServerType(Exception exception)
        {
            OnErrorGetServerType?.Invoke(this, new ExceptionEventArgs(exception));
        }

        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnListServerTypes;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorListServerTypes;

        internal void ExecuteOnListServerTypes(ServerTypesApi.ListServerTypesApiResponse apiResponse)
        {
            OnListServerTypes?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorListServerTypes(Exception exception)
        {
            OnErrorListServerTypes?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class ServerTypesApi : IServerTypesApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<ServerTypesApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public ServerTypesApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="BearerToken"/>
        /// </summary>
        public TokenProvider<BearerToken> BearerTokenProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerTypesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServerTypesApi(ILogger<ServerTypesApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, ServerTypesApiEvents serverTypesApiEvents,
            TokenProvider<BearerToken> bearerTokenProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<ServerTypesApi>();
            HttpClient = httpClient;
            Events = serverTypesApiEvents;
            BearerTokenProvider = bearerTokenProvider;
        }

        partial void FormatGetServerType(ref long id);

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="id"></param>
        private void AfterGetServerTypeDefaultImplementation(IGetServerTypeApiResponse apiResponseLocalVar, long id)
        {
            bool suppressDefaultLog = false;
            AfterGetServerType(ref suppressDefaultLog, apiResponseLocalVar, id);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="id"></param>
        partial void AfterGetServerType(ref bool suppressDefaultLog, IGetServerTypeApiResponse apiResponseLocalVar, long id);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="id"></param>
        private void OnErrorGetServerTypeDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, long id)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorGetServerType(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, id);
            if (!suppressDefaultLogLocalVar)
                Logger.LogError(exceptionLocalVar, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLogLocalVar"></param>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="id"></param>
        partial void OnErrorGetServerType(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, long id);

        /// <summary>
        /// Get a Server Type Gets a specific Server type object.
        /// </summary>
        /// <param name="id">ID of the Server Type.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetServerTypeApiResponse"/>&gt;</returns>
        public async Task<IGetServerTypeApiResponse?> GetServerTypeOrDefaultAsync(long id, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await GetServerTypeAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Get a Server Type Gets a specific Server type object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Server Type.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetServerTypeApiResponse"/>&gt;</returns>
        public async Task<IGetServerTypeApiResponse> GetServerTypeAsync(long id, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                FormatGetServerType(ref id);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = HttpClient.BaseAddress.AbsolutePath == "/"
                        ? "/server_types/{id}"
                        : string.Concat(HttpClient.BaseAddress.AbsolutePath, "/server_types/{id}");
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7Bid%7D", Uri.EscapeDataString(id.ToString()));

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    BearerToken bearerTokenLocalVar1 = (BearerToken) await BearerTokenProvider.GetAsync(cancellation: cancellationToken).ConfigureAwait(false);

                    tokenBaseLocalVars.Add(bearerTokenLocalVar1);

                    bearerTokenLocalVar1.UseInHeader(httpRequestMessageLocalVar, "");

                    string[] acceptLocalVars = new string[] {
                        "application/json"
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Get;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<GetServerTypeApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<GetServerTypeApiResponse>();

                        GetServerTypeApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/server_types/{id}", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterGetServerTypeDefaultImplementation(apiResponseLocalVar, id);

                        Events.ExecuteOnGetServerType(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorGetServerTypeDefaultImplementation(e, "/server_types/{id}", uriBuilderLocalVar.Path, id);
                Events.ExecuteOnErrorGetServerType(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="GetServerTypeApiResponse"/>
        /// </summary>
        public partial class GetServerTypeApiResponse : Hetzner.Cloud.Client.ApiResponse, IGetServerTypeApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<GetServerTypeApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="GetServerTypeApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public GetServerTypeApiResponse(ILogger<GetServerTypeApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(global::System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public Hetzner.Cloud.Model.GetServerTypeResponse? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<Hetzner.Cloud.Model.GetServerTypeResponse>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out Hetzner.Cloud.Model.GetServerTypeResponse? result)
            {
                result = null;

                try
                {
                    result = Ok();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return result != null;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }

        partial void FormatListServerTypes(ref Option<string> name, ref Option<long> page, ref Option<long> perPage);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private void ValidateListServerTypes(Option<string> name)
        {
            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="name"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        private void AfterListServerTypesDefaultImplementation(IListServerTypesApiResponse apiResponseLocalVar, Option<string> name, Option<long> page, Option<long> perPage)
        {
            bool suppressDefaultLog = false;
            AfterListServerTypes(ref suppressDefaultLog, apiResponseLocalVar, name, page, perPage);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="name"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        partial void AfterListServerTypes(ref bool suppressDefaultLog, IListServerTypesApiResponse apiResponseLocalVar, Option<string> name, Option<long> page, Option<long> perPage);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="name"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        private void OnErrorListServerTypesDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> name, Option<long> page, Option<long> perPage)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorListServerTypes(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, name, page, perPage);
            if (!suppressDefaultLogLocalVar)
                Logger.LogError(exceptionLocalVar, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLogLocalVar"></param>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="name"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        partial void OnErrorListServerTypes(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> name, Option<long> page, Option<long> perPage);

        /// <summary>
        /// Get all Server Types Gets all Server type objects.
        /// </summary>
        /// <param name="name">Filter resources by their name. The response will only contain the resources matching the specified name.  (optional)</param>
        /// <param name="page">Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. (optional, default to 1)</param>
        /// <param name="perPage">Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. (optional, default to 25)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IListServerTypesApiResponse"/>&gt;</returns>
        public async Task<IListServerTypesApiResponse?> ListServerTypesOrDefaultAsync(Option<string> name = default, Option<long> page = default, Option<long> perPage = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await ListServerTypesAsync(name, page, perPage, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Get all Server Types Gets all Server type objects.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter resources by their name. The response will only contain the resources matching the specified name.  (optional)</param>
        /// <param name="page">Page number to return. For more information, see \&quot;[Pagination](#pagination)\&quot;. (optional, default to 1)</param>
        /// <param name="perPage">Maximum number of entries returned per page. For more information, see \&quot;[Pagination](#pagination)\&quot;. (optional, default to 25)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IListServerTypesApiResponse"/>&gt;</returns>
        public async Task<IListServerTypesApiResponse> ListServerTypesAsync(Option<string> name = default, Option<long> page = default, Option<long> perPage = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateListServerTypes(name);

                FormatListServerTypes(ref name, ref page, ref perPage);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = HttpClient.BaseAddress.AbsolutePath == "/"
                        ? "/server_types"
                        : string.Concat(HttpClient.BaseAddress.AbsolutePath, "/server_types");

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    if (name.IsSet)
                        parseQueryStringLocalVar["name"] = ClientUtils.ParameterToString(name.Value);

                    if (page.IsSet)
                        parseQueryStringLocalVar["page"] = ClientUtils.ParameterToString(page.Value);

                    if (perPage.IsSet)
                        parseQueryStringLocalVar["per_page"] = ClientUtils.ParameterToString(perPage.Value);

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    BearerToken bearerTokenLocalVar1 = (BearerToken) await BearerTokenProvider.GetAsync(cancellation: cancellationToken).ConfigureAwait(false);

                    tokenBaseLocalVars.Add(bearerTokenLocalVar1);

                    bearerTokenLocalVar1.UseInHeader(httpRequestMessageLocalVar, "");

                    string[] acceptLocalVars = new string[] {
                        "application/json"
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Get;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<ListServerTypesApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<ListServerTypesApiResponse>();

                        ListServerTypesApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/server_types", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterListServerTypesDefaultImplementation(apiResponseLocalVar, name, page, perPage);

                        Events.ExecuteOnListServerTypes(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorListServerTypesDefaultImplementation(e, "/server_types", uriBuilderLocalVar.Path, name, page, perPage);
                Events.ExecuteOnErrorListServerTypes(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="ListServerTypesApiResponse"/>
        /// </summary>
        public partial class ListServerTypesApiResponse : Hetzner.Cloud.Client.ApiResponse, IListServerTypesApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<ListServerTypesApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="ListServerTypesApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public ListServerTypesApiResponse(ILogger<ListServerTypesApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(global::System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public Hetzner.Cloud.Model.ListServerTypesResponse? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<Hetzner.Cloud.Model.ListServerTypesResponse>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out Hetzner.Cloud.Model.ListServerTypesResponse? result)
            {
                result = null;

                try
                {
                    result = Ok();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return result != null;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }
    }
}
