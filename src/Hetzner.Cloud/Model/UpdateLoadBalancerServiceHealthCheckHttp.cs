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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization.Metadata;
using Hetzner.Cloud.Client;

namespace Hetzner.Cloud.Model
{
    /// <summary>
    /// Additional configuration for protocol http
    /// </summary>
    public partial class UpdateLoadBalancerServiceHealthCheckHttp : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLoadBalancerServiceHealthCheckHttp" /> class.
        /// </summary>
        /// <param name="domain">Host header to send in the HTTP request. May not contain spaces, percent or backslash symbols. Can be null, in that case no host header is sent.</param>
        /// <param name="path">HTTP path to use for health checks. May not contain literal spaces, use percent-encoding instead.</param>
        /// <param name="response">String that must be contained in HTTP response in order to pass the health check</param>
        /// <param name="statusCodes">List of returned HTTP status codes in order to pass the health check. Supports the wildcards &#x60;?&#x60; for exactly one character and &#x60;*&#x60; for multiple ones.</param>
        /// <param name="tls">Use HTTPS for health check</param>
        [JsonConstructor]
        public UpdateLoadBalancerServiceHealthCheckHttp(Option<string?> domain = default, Option<string?> path = default, Option<string?> response = default, Option<List<string>?> statusCodes = default, Option<bool?> tls = default)
        {
            DomainOption = domain;
            PathOption = path;
            ResponseOption = response;
            StatusCodesOption = statusCodes;
            TlsOption = tls;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Domain
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DomainOption { get; private set; }

        /// <summary>
        /// Host header to send in the HTTP request. May not contain spaces, percent or backslash symbols. Can be null, in that case no host header is sent.
        /// </summary>
        /// <value>Host header to send in the HTTP request. May not contain spaces, percent or backslash symbols. Can be null, in that case no host header is sent.</value>
        /* <example>example.com</example> */
        [JsonPropertyName("domain")]
        public string? Domain { get { return this.DomainOption; } set { this.DomainOption = new(value); } }

        /// <summary>
        /// Used to track the state of Path
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PathOption { get; private set; }

        /// <summary>
        /// HTTP path to use for health checks. May not contain literal spaces, use percent-encoding instead.
        /// </summary>
        /// <value>HTTP path to use for health checks. May not contain literal spaces, use percent-encoding instead.</value>
        /* <example>/</example> */
        [JsonPropertyName("path")]
        public string? Path { get { return this.PathOption; } set { this.PathOption = new(value); } }

        /// <summary>
        /// Used to track the state of Response
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ResponseOption { get; private set; }

        /// <summary>
        /// String that must be contained in HTTP response in order to pass the health check
        /// </summary>
        /// <value>String that must be contained in HTTP response in order to pass the health check</value>
        /* <example>{&quot;status&quot;: &quot;ok&quot;}</example> */
        [JsonPropertyName("response")]
        public string? Response { get { return this.ResponseOption; } set { this.ResponseOption = new(value); } }

        /// <summary>
        /// Used to track the state of StatusCodes
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> StatusCodesOption { get; private set; }

        /// <summary>
        /// List of returned HTTP status codes in order to pass the health check. Supports the wildcards &#x60;?&#x60; for exactly one character and &#x60;*&#x60; for multiple ones.
        /// </summary>
        /// <value>List of returned HTTP status codes in order to pass the health check. Supports the wildcards &#x60;?&#x60; for exactly one character and &#x60;*&#x60; for multiple ones.</value>
        /* <example>[&quot;2??&quot;,&quot;3??&quot;]</example> */
        [JsonPropertyName("status_codes")]
        public List<string>? StatusCodes { get { return this.StatusCodesOption; } set { this.StatusCodesOption = new(value); } }

        /// <summary>
        /// Used to track the state of Tls
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> TlsOption { get; private set; }

        /// <summary>
        /// Use HTTPS for health check
        /// </summary>
        /// <value>Use HTTPS for health check</value>
        /* <example>false</example> */
        [JsonPropertyName("tls")]
        public bool? Tls { get { return this.TlsOption; } set { this.TlsOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateLoadBalancerServiceHealthCheckHttp {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  StatusCodes: ").Append(StatusCodes).Append("\n");
            sb.Append("  Tls: ").Append(Tls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="UpdateLoadBalancerServiceHealthCheckHttp" />
    /// </summary>
    public class UpdateLoadBalancerServiceHealthCheckHttpJsonConverter : JsonConverter<UpdateLoadBalancerServiceHealthCheckHttp>
    {
        /// <summary>
        /// Deserializes json to <see cref="UpdateLoadBalancerServiceHealthCheckHttp" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UpdateLoadBalancerServiceHealthCheckHttp Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> domain = default;
            Option<string?> path = default;
            Option<string?> response = default;
            Option<List<string>?> statusCodes = default;
            Option<bool?> tls = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "domain":
                            domain = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "path":
                            path = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "response":
                            response = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "status_codes":
                            statusCodes = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "tls":
                            tls = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (path.IsSet && path.Value == null)
                throw new ArgumentNullException(nameof(path), "Property is not nullable for class UpdateLoadBalancerServiceHealthCheckHttp.");

            if (response.IsSet && response.Value == null)
                throw new ArgumentNullException(nameof(response), "Property is not nullable for class UpdateLoadBalancerServiceHealthCheckHttp.");

            if (statusCodes.IsSet && statusCodes.Value == null)
                throw new ArgumentNullException(nameof(statusCodes), "Property is not nullable for class UpdateLoadBalancerServiceHealthCheckHttp.");

            if (tls.IsSet && tls.Value == null)
                throw new ArgumentNullException(nameof(tls), "Property is not nullable for class UpdateLoadBalancerServiceHealthCheckHttp.");

            return new UpdateLoadBalancerServiceHealthCheckHttp(domain, path, response, statusCodes, tls);
        }

        /// <summary>
        /// Serializes a <see cref="UpdateLoadBalancerServiceHealthCheckHttp" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="updateLoadBalancerServiceHealthCheckHttp"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UpdateLoadBalancerServiceHealthCheckHttp updateLoadBalancerServiceHealthCheckHttp, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, updateLoadBalancerServiceHealthCheckHttp, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UpdateLoadBalancerServiceHealthCheckHttp" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="updateLoadBalancerServiceHealthCheckHttp"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UpdateLoadBalancerServiceHealthCheckHttp updateLoadBalancerServiceHealthCheckHttp, JsonSerializerOptions jsonSerializerOptions)
        {
            if (updateLoadBalancerServiceHealthCheckHttp.PathOption.IsSet && updateLoadBalancerServiceHealthCheckHttp.Path == null)
                throw new ArgumentNullException(nameof(updateLoadBalancerServiceHealthCheckHttp.Path), "Property is required for class UpdateLoadBalancerServiceHealthCheckHttp.");

            if (updateLoadBalancerServiceHealthCheckHttp.ResponseOption.IsSet && updateLoadBalancerServiceHealthCheckHttp.Response == null)
                throw new ArgumentNullException(nameof(updateLoadBalancerServiceHealthCheckHttp.Response), "Property is required for class UpdateLoadBalancerServiceHealthCheckHttp.");

            if (updateLoadBalancerServiceHealthCheckHttp.StatusCodesOption.IsSet && updateLoadBalancerServiceHealthCheckHttp.StatusCodes == null)
                throw new ArgumentNullException(nameof(updateLoadBalancerServiceHealthCheckHttp.StatusCodes), "Property is required for class UpdateLoadBalancerServiceHealthCheckHttp.");

            if (updateLoadBalancerServiceHealthCheckHttp.DomainOption.IsSet)
                if (updateLoadBalancerServiceHealthCheckHttp.DomainOption.Value != null)
                    writer.WriteString("domain", updateLoadBalancerServiceHealthCheckHttp.Domain);
                else
                    writer.WriteNull("domain");

            if (updateLoadBalancerServiceHealthCheckHttp.PathOption.IsSet)
                writer.WriteString("path", updateLoadBalancerServiceHealthCheckHttp.Path);

            if (updateLoadBalancerServiceHealthCheckHttp.ResponseOption.IsSet)
                writer.WriteString("response", updateLoadBalancerServiceHealthCheckHttp.Response);

            if (updateLoadBalancerServiceHealthCheckHttp.StatusCodesOption.IsSet)
            {
                writer.WritePropertyName("status_codes");
                JsonSerializer.Serialize(writer, updateLoadBalancerServiceHealthCheckHttp.StatusCodes, jsonSerializerOptions);
            }
            if (updateLoadBalancerServiceHealthCheckHttp.TlsOption.IsSet)
                writer.WriteBoolean("tls", updateLoadBalancerServiceHealthCheckHttp.TlsOption.Value!.Value);
        }
    }

    /// <summary>
    /// The UpdateLoadBalancerServiceHealthCheckHttpSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(UpdateLoadBalancerServiceHealthCheckHttp))]
    public partial class UpdateLoadBalancerServiceHealthCheckHttpSerializationContext : JsonSerializerContext { }
}
