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
    /// IP address (v6)
    /// </summary>
    public partial class LoadBalancerPublicNetIpv6 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerPublicNetIpv6" /> class.
        /// </summary>
        /// <param name="dnsPtr">Reverse DNS PTR entry for the IPv6 address of this Load Balancer</param>
        /// <param name="ip">IP address (v6) of this Load Balancer</param>
        [JsonConstructor]
        public LoadBalancerPublicNetIpv6(Option<string?> dnsPtr = default, Option<string?> ip = default)
        {
            DnsPtrOption = dnsPtr;
            IpOption = ip;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of DnsPtr
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DnsPtrOption { get; private set; }

        /// <summary>
        /// Reverse DNS PTR entry for the IPv6 address of this Load Balancer
        /// </summary>
        /// <value>Reverse DNS PTR entry for the IPv6 address of this Load Balancer</value>
        /* <example>lb1.example.com</example> */
        [JsonPropertyName("dns_ptr")]
        public string? DnsPtr { get { return this.DnsPtrOption; } set { this.DnsPtrOption = new(value); } }

        /// <summary>
        /// Used to track the state of Ip
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IpOption { get; private set; }

        /// <summary>
        /// IP address (v6) of this Load Balancer
        /// </summary>
        /// <value>IP address (v6) of this Load Balancer</value>
        /* <example>2001:db8::1</example> */
        [JsonPropertyName("ip")]
        public string? Ip { get { return this.IpOption; } set { this.IpOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoadBalancerPublicNetIpv6 {\n");
            sb.Append("  DnsPtr: ").Append(DnsPtr).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
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
    /// A Json converter for type <see cref="LoadBalancerPublicNetIpv6" />
    /// </summary>
    public class LoadBalancerPublicNetIpv6JsonConverter : JsonConverter<LoadBalancerPublicNetIpv6>
    {
        /// <summary>
        /// Deserializes json to <see cref="LoadBalancerPublicNetIpv6" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override LoadBalancerPublicNetIpv6 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> dnsPtr = default;
            Option<string?> ip = default;

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
                        case "dns_ptr":
                            dnsPtr = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "ip":
                            ip = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new LoadBalancerPublicNetIpv6(dnsPtr, ip);
        }

        /// <summary>
        /// Serializes a <see cref="LoadBalancerPublicNetIpv6" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="loadBalancerPublicNetIpv6"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, LoadBalancerPublicNetIpv6 loadBalancerPublicNetIpv6, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, loadBalancerPublicNetIpv6, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="LoadBalancerPublicNetIpv6" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="loadBalancerPublicNetIpv6"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, LoadBalancerPublicNetIpv6 loadBalancerPublicNetIpv6, JsonSerializerOptions jsonSerializerOptions)
        {
            if (loadBalancerPublicNetIpv6.DnsPtrOption.IsSet)
                if (loadBalancerPublicNetIpv6.DnsPtrOption.Value != null)
                    writer.WriteString("dns_ptr", loadBalancerPublicNetIpv6.DnsPtr);
                else
                    writer.WriteNull("dns_ptr");

            if (loadBalancerPublicNetIpv6.IpOption.IsSet)
                if (loadBalancerPublicNetIpv6.IpOption.Value != null)
                    writer.WriteString("ip", loadBalancerPublicNetIpv6.Ip);
                else
                    writer.WriteNull("ip");
        }
    }

    /// <summary>
    /// The LoadBalancerPublicNetIpv6SerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(LoadBalancerPublicNetIpv6))]
    public partial class LoadBalancerPublicNetIpv6SerializationContext : JsonSerializerContext { }
}
