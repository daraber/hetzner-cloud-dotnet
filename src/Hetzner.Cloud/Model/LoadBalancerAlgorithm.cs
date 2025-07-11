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
    /// Algorithm of the Load Balancer
    /// </summary>
    public partial class LoadBalancerAlgorithm : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerAlgorithm" /> class.
        /// </summary>
        /// <param name="type">Type of the algorithm. (default to TypeEnum.RoundRobin)</param>
        [JsonConstructor]
        public LoadBalancerAlgorithm(TypeEnum type = TypeEnum.RoundRobin)
        {
            Type = type;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Type of the algorithm.
        /// </summary>
        /// <value>Type of the algorithm.</value>
        public enum TypeEnum
        {
            /// <summary>
            /// Enum LeastConnections for value: least_connections
            /// </summary>
            LeastConnections = 1,

            /// <summary>
            /// Enum RoundRobin for value: round_robin
            /// </summary>
            RoundRobin = 2
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static TypeEnum TypeEnumFromString(string value)
        {
            if (value.Equals("least_connections"))
                return TypeEnum.LeastConnections;

            if (value.Equals("round_robin"))
                return TypeEnum.RoundRobin;

            throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeEnum? TypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("least_connections"))
                return TypeEnum.LeastConnections;

            if (value.Equals("round_robin"))
                return TypeEnum.RoundRobin;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="TypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string TypeEnumToJsonValue(TypeEnum value)
        {
            if (value == TypeEnum.LeastConnections)
                return "least_connections";

            if (value == TypeEnum.RoundRobin)
                return "round_robin";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Type of the algorithm.
        /// </summary>
        /// <value>Type of the algorithm.</value>
        [JsonPropertyName("type")]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoadBalancerAlgorithm {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
    /// A Json converter for type <see cref="LoadBalancerAlgorithm" />
    /// </summary>
    public class LoadBalancerAlgorithmJsonConverter : JsonConverter<LoadBalancerAlgorithm>
    {
        /// <summary>
        /// Deserializes json to <see cref="LoadBalancerAlgorithm" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override LoadBalancerAlgorithm Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<LoadBalancerAlgorithm.TypeEnum?> type = default;

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
                        case "type":
                            string? typeRawValue = utf8JsonReader.GetString();
                            if (typeRawValue != null)
                                type = new Option<LoadBalancerAlgorithm.TypeEnum?>(LoadBalancerAlgorithm.TypeEnumFromStringOrDefault(typeRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class LoadBalancerAlgorithm.", nameof(type));

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class LoadBalancerAlgorithm.");

            return new LoadBalancerAlgorithm(type.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="LoadBalancerAlgorithm" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="loadBalancerAlgorithm"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, LoadBalancerAlgorithm loadBalancerAlgorithm, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, loadBalancerAlgorithm, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="LoadBalancerAlgorithm" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="loadBalancerAlgorithm"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, LoadBalancerAlgorithm loadBalancerAlgorithm, JsonSerializerOptions jsonSerializerOptions)
        {
            var typeRawValue = LoadBalancerAlgorithm.TypeEnumToJsonValue(loadBalancerAlgorithm.Type);
            writer.WriteString("type", typeRawValue);
        }
    }

    /// <summary>
    /// The LoadBalancerAlgorithmSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(LoadBalancerAlgorithm))]
    public partial class LoadBalancerAlgorithmSerializationContext : JsonSerializerContext { }
}
