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
    /// PricePerTime
    /// </summary>
    public partial class PricePerTime : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricePerTime" /> class.
        /// </summary>
        /// <param name="includedTraffic">Free traffic per month in bytes in this [Location](#locations).</param>
        /// <param name="location">Name of the [Location](#locations) the price is for.</param>
        /// <param name="priceHourly">priceHourly</param>
        /// <param name="priceMonthly">priceMonthly</param>
        /// <param name="pricePerTbTraffic">pricePerTbTraffic</param>
        [JsonConstructor]
        public PricePerTime(long includedTraffic, string location, Price priceHourly, Price priceMonthly, Price pricePerTbTraffic)
        {
            IncludedTraffic = includedTraffic;
            Location = location;
            PriceHourly = priceHourly;
            PriceMonthly = priceMonthly;
            PricePerTbTraffic = pricePerTbTraffic;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Free traffic per month in bytes in this [Location](#locations).
        /// </summary>
        /// <value>Free traffic per month in bytes in this [Location](#locations).</value>
        /* <example>654321</example> */
        [JsonPropertyName("included_traffic")]
        public long IncludedTraffic { get; set; }

        /// <summary>
        /// Name of the [Location](#locations) the price is for.
        /// </summary>
        /// <value>Name of the [Location](#locations) the price is for.</value>
        /* <example>fsn1</example> */
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets PriceHourly
        /// </summary>
        [JsonPropertyName("price_hourly")]
        public Price PriceHourly { get; set; }

        /// <summary>
        /// Gets or Sets PriceMonthly
        /// </summary>
        [JsonPropertyName("price_monthly")]
        public Price PriceMonthly { get; set; }

        /// <summary>
        /// Gets or Sets PricePerTbTraffic
        /// </summary>
        [JsonPropertyName("price_per_tb_traffic")]
        public Price PricePerTbTraffic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PricePerTime {\n");
            sb.Append("  IncludedTraffic: ").Append(IncludedTraffic).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  PriceHourly: ").Append(PriceHourly).Append("\n");
            sb.Append("  PriceMonthly: ").Append(PriceMonthly).Append("\n");
            sb.Append("  PricePerTbTraffic: ").Append(PricePerTbTraffic).Append("\n");
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
    /// A Json converter for type <see cref="PricePerTime" />
    /// </summary>
    public class PricePerTimeJsonConverter : JsonConverter<PricePerTime>
    {
        /// <summary>
        /// Deserializes json to <see cref="PricePerTime" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PricePerTime Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> includedTraffic = default;
            Option<string?> location = default;
            Option<Price?> priceHourly = default;
            Option<Price?> priceMonthly = default;
            Option<Price?> pricePerTbTraffic = default;

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
                        case "included_traffic":
                            includedTraffic = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "location":
                            location = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "price_hourly":
                            priceHourly = new Option<Price?>(JsonSerializer.Deserialize<Price>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "price_monthly":
                            priceMonthly = new Option<Price?>(JsonSerializer.Deserialize<Price>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "price_per_tb_traffic":
                            pricePerTbTraffic = new Option<Price?>(JsonSerializer.Deserialize<Price>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!includedTraffic.IsSet)
                throw new ArgumentException("Property is required for class PricePerTime.", nameof(includedTraffic));

            if (!location.IsSet)
                throw new ArgumentException("Property is required for class PricePerTime.", nameof(location));

            if (!priceHourly.IsSet)
                throw new ArgumentException("Property is required for class PricePerTime.", nameof(priceHourly));

            if (!priceMonthly.IsSet)
                throw new ArgumentException("Property is required for class PricePerTime.", nameof(priceMonthly));

            if (!pricePerTbTraffic.IsSet)
                throw new ArgumentException("Property is required for class PricePerTime.", nameof(pricePerTbTraffic));

            if (includedTraffic.IsSet && includedTraffic.Value == null)
                throw new ArgumentNullException(nameof(includedTraffic), "Property is not nullable for class PricePerTime.");

            if (location.IsSet && location.Value == null)
                throw new ArgumentNullException(nameof(location), "Property is not nullable for class PricePerTime.");

            if (priceHourly.IsSet && priceHourly.Value == null)
                throw new ArgumentNullException(nameof(priceHourly), "Property is not nullable for class PricePerTime.");

            if (priceMonthly.IsSet && priceMonthly.Value == null)
                throw new ArgumentNullException(nameof(priceMonthly), "Property is not nullable for class PricePerTime.");

            if (pricePerTbTraffic.IsSet && pricePerTbTraffic.Value == null)
                throw new ArgumentNullException(nameof(pricePerTbTraffic), "Property is not nullable for class PricePerTime.");

            return new PricePerTime(includedTraffic.Value!.Value!, location.Value!, priceHourly.Value!, priceMonthly.Value!, pricePerTbTraffic.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="PricePerTime" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="pricePerTime"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PricePerTime pricePerTime, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, pricePerTime, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PricePerTime" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="pricePerTime"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PricePerTime pricePerTime, JsonSerializerOptions jsonSerializerOptions)
        {
            if (pricePerTime.Location == null)
                throw new ArgumentNullException(nameof(pricePerTime.Location), "Property is required for class PricePerTime.");

            if (pricePerTime.PriceHourly == null)
                throw new ArgumentNullException(nameof(pricePerTime.PriceHourly), "Property is required for class PricePerTime.");

            if (pricePerTime.PriceMonthly == null)
                throw new ArgumentNullException(nameof(pricePerTime.PriceMonthly), "Property is required for class PricePerTime.");

            if (pricePerTime.PricePerTbTraffic == null)
                throw new ArgumentNullException(nameof(pricePerTime.PricePerTbTraffic), "Property is required for class PricePerTime.");

            writer.WriteNumber("included_traffic", pricePerTime.IncludedTraffic);

            writer.WriteString("location", pricePerTime.Location);

            writer.WritePropertyName("price_hourly");
            JsonSerializer.Serialize(writer, pricePerTime.PriceHourly, jsonSerializerOptions);
            writer.WritePropertyName("price_monthly");
            JsonSerializer.Serialize(writer, pricePerTime.PriceMonthly, jsonSerializerOptions);
            writer.WritePropertyName("price_per_tb_traffic");
            JsonSerializer.Serialize(writer, pricePerTime.PricePerTbTraffic, jsonSerializerOptions);
        }
    }

    /// <summary>
    /// The PricePerTimeSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(PricePerTime))]
    public partial class PricePerTimeSerializationContext : JsonSerializerContext { }
}
