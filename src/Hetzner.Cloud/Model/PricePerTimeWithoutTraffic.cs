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
    /// PricePerTimeWithoutTraffic
    /// </summary>
    public partial class PricePerTimeWithoutTraffic : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricePerTimeWithoutTraffic" /> class.
        /// </summary>
        /// <param name="location">Name of the [Location](#locations) the price is for.</param>
        /// <param name="priceHourly">priceHourly</param>
        /// <param name="priceMonthly">priceMonthly</param>
        [JsonConstructor]
        public PricePerTimeWithoutTraffic(string location, Price priceHourly, Price priceMonthly)
        {
            Location = location;
            PriceHourly = priceHourly;
            PriceMonthly = priceMonthly;
            OnCreated();
        }

        partial void OnCreated();

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PricePerTimeWithoutTraffic {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  PriceHourly: ").Append(PriceHourly).Append("\n");
            sb.Append("  PriceMonthly: ").Append(PriceMonthly).Append("\n");
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
    /// A Json converter for type <see cref="PricePerTimeWithoutTraffic" />
    /// </summary>
    public class PricePerTimeWithoutTrafficJsonConverter : JsonConverter<PricePerTimeWithoutTraffic>
    {
        /// <summary>
        /// Deserializes json to <see cref="PricePerTimeWithoutTraffic" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PricePerTimeWithoutTraffic Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> location = default;
            Option<Price?> priceHourly = default;
            Option<Price?> priceMonthly = default;

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
                        case "location":
                            location = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "price_hourly":
                            priceHourly = new Option<Price?>(JsonSerializer.Deserialize<Price>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "price_monthly":
                            priceMonthly = new Option<Price?>(JsonSerializer.Deserialize<Price>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!location.IsSet)
                throw new ArgumentException("Property is required for class PricePerTimeWithoutTraffic.", nameof(location));

            if (!priceHourly.IsSet)
                throw new ArgumentException("Property is required for class PricePerTimeWithoutTraffic.", nameof(priceHourly));

            if (!priceMonthly.IsSet)
                throw new ArgumentException("Property is required for class PricePerTimeWithoutTraffic.", nameof(priceMonthly));

            if (location.IsSet && location.Value == null)
                throw new ArgumentNullException(nameof(location), "Property is not nullable for class PricePerTimeWithoutTraffic.");

            if (priceHourly.IsSet && priceHourly.Value == null)
                throw new ArgumentNullException(nameof(priceHourly), "Property is not nullable for class PricePerTimeWithoutTraffic.");

            if (priceMonthly.IsSet && priceMonthly.Value == null)
                throw new ArgumentNullException(nameof(priceMonthly), "Property is not nullable for class PricePerTimeWithoutTraffic.");

            return new PricePerTimeWithoutTraffic(location.Value!, priceHourly.Value!, priceMonthly.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="PricePerTimeWithoutTraffic" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="pricePerTimeWithoutTraffic"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PricePerTimeWithoutTraffic pricePerTimeWithoutTraffic, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, pricePerTimeWithoutTraffic, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PricePerTimeWithoutTraffic" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="pricePerTimeWithoutTraffic"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PricePerTimeWithoutTraffic pricePerTimeWithoutTraffic, JsonSerializerOptions jsonSerializerOptions)
        {
            if (pricePerTimeWithoutTraffic.Location == null)
                throw new ArgumentNullException(nameof(pricePerTimeWithoutTraffic.Location), "Property is required for class PricePerTimeWithoutTraffic.");

            if (pricePerTimeWithoutTraffic.PriceHourly == null)
                throw new ArgumentNullException(nameof(pricePerTimeWithoutTraffic.PriceHourly), "Property is required for class PricePerTimeWithoutTraffic.");

            if (pricePerTimeWithoutTraffic.PriceMonthly == null)
                throw new ArgumentNullException(nameof(pricePerTimeWithoutTraffic.PriceMonthly), "Property is required for class PricePerTimeWithoutTraffic.");

            writer.WriteString("location", pricePerTimeWithoutTraffic.Location);

            writer.WritePropertyName("price_hourly");
            JsonSerializer.Serialize(writer, pricePerTimeWithoutTraffic.PriceHourly, jsonSerializerOptions);
            writer.WritePropertyName("price_monthly");
            JsonSerializer.Serialize(writer, pricePerTimeWithoutTraffic.PriceMonthly, jsonSerializerOptions);
        }
    }

    /// <summary>
    /// The PricePerTimeWithoutTrafficSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(PricePerTimeWithoutTraffic))]
    public partial class PricePerTimeWithoutTrafficSerializationContext : JsonSerializerContext { }
}
