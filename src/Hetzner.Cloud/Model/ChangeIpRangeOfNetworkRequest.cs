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
    /// Request for POST https://api.hetzner.cloud/v1/networks/{id}/actions/change_ip_range
    /// </summary>
    public partial class ChangeIpRangeOfNetworkRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeIpRangeOfNetworkRequest" /> class.
        /// </summary>
        /// <param name="ipRange">IP range of the [Network](#networks).  Uses CIDR notation.  Must span all included subnets. Must be one of the private IPv4 ranges of RFC1918.  Minimum network size is /24. We highly recommend that you pick a larger [Network](#networks) with a /16 netmask. </param>
        [JsonConstructor]
        public ChangeIpRangeOfNetworkRequest(string ipRange)
        {
            IpRange = ipRange;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// IP range of the [Network](#networks).  Uses CIDR notation.  Must span all included subnets. Must be one of the private IPv4 ranges of RFC1918.  Minimum network size is /24. We highly recommend that you pick a larger [Network](#networks) with a /16 netmask. 
        /// </summary>
        /// <value>IP range of the [Network](#networks).  Uses CIDR notation.  Must span all included subnets. Must be one of the private IPv4 ranges of RFC1918.  Minimum network size is /24. We highly recommend that you pick a larger [Network](#networks) with a /16 netmask. </value>
        /* <example>10.0.0.0/16</example> */
        [JsonPropertyName("ip_range")]
        public string IpRange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChangeIpRangeOfNetworkRequest {\n");
            sb.Append("  IpRange: ").Append(IpRange).Append("\n");
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
    /// A Json converter for type <see cref="ChangeIpRangeOfNetworkRequest" />
    /// </summary>
    public class ChangeIpRangeOfNetworkRequestJsonConverter : JsonConverter<ChangeIpRangeOfNetworkRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="ChangeIpRangeOfNetworkRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ChangeIpRangeOfNetworkRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> ipRange = default;

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
                        case "ip_range":
                            ipRange = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!ipRange.IsSet)
                throw new ArgumentException("Property is required for class ChangeIpRangeOfNetworkRequest.", nameof(ipRange));

            if (ipRange.IsSet && ipRange.Value == null)
                throw new ArgumentNullException(nameof(ipRange), "Property is not nullable for class ChangeIpRangeOfNetworkRequest.");

            return new ChangeIpRangeOfNetworkRequest(ipRange.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="ChangeIpRangeOfNetworkRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="changeIpRangeOfNetworkRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ChangeIpRangeOfNetworkRequest changeIpRangeOfNetworkRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, changeIpRangeOfNetworkRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ChangeIpRangeOfNetworkRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="changeIpRangeOfNetworkRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ChangeIpRangeOfNetworkRequest changeIpRangeOfNetworkRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (changeIpRangeOfNetworkRequest.IpRange == null)
                throw new ArgumentNullException(nameof(changeIpRangeOfNetworkRequest.IpRange), "Property is required for class ChangeIpRangeOfNetworkRequest.");

            writer.WriteString("ip_range", changeIpRangeOfNetworkRequest.IpRange);
        }
    }

    /// <summary>
    /// The ChangeIpRangeOfNetworkRequestSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(ChangeIpRangeOfNetworkRequest))]
    public partial class ChangeIpRangeOfNetworkRequestSerializationContext : JsonSerializerContext { }
}
