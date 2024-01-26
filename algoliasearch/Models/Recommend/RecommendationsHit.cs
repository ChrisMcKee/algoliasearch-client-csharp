//
// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
//
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Reflection;
using Algolia.Search.Models;
using Algolia.Search.Models.Common;
using Algolia.Search.Serializer;

namespace Algolia.Search.Models.Recommend;

/// <summary>
/// RecommendationsHit
/// </summary>
[JsonConverter(typeof(RecommendationsHitJsonConverter))]
[DataContract(Name = "recommendationsHit")]
public partial class RecommendationsHit : AbstractSchema
{
  /// <summary>
  /// Initializes a new instance of the RecommendationsHit class
  /// with a RecommendHit
  /// </summary>
  /// <param name="actualInstance">An instance of RecommendHit.</param>
  public RecommendationsHit(RecommendHit actualInstance)
  {
    IsNullable = false;
    SchemaType = "oneOf";
    ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
  }

  /// <summary>
  /// Initializes a new instance of the RecommendationsHit class
  /// with a TrendingFacetHit
  /// </summary>
  /// <param name="actualInstance">An instance of TrendingFacetHit.</param>
  public RecommendationsHit(TrendingFacetHit actualInstance)
  {
    IsNullable = false;
    SchemaType = "oneOf";
    ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
  }


  /// <summary>
  /// Gets or Sets ActualInstance
  /// </summary>
  public sealed override object ActualInstance { get; set; }

  /// <summary>
  /// Get the actual instance of `RecommendHit`. If the actual instance is not `RecommendHit`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of RecommendHit</returns>
  public RecommendHit AsRecommendHit()
  {
    return (RecommendHit)ActualInstance;
  }

  /// <summary>
  /// Get the actual instance of `TrendingFacetHit`. If the actual instance is not `TrendingFacetHit`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of TrendingFacetHit</returns>
  public TrendingFacetHit AsTrendingFacetHit()
  {
    return (TrendingFacetHit)ActualInstance;
  }


  /// <summary>
  /// Check if the actual instance is of `RecommendHit` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsRecommendHit()
  {
    return ActualInstance.GetType() == typeof(RecommendHit);
  }

  /// <summary>
  /// Check if the actual instance is of `TrendingFacetHit` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsTrendingFacetHit()
  {
    return ActualInstance.GetType() == typeof(TrendingFacetHit);
  }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    var sb = new StringBuilder();
    sb.Append("class RecommendationsHit {\n");
    sb.Append("  ActualInstance: ").Append(ActualInstance).Append("\n");
    sb.Append("}\n");
    return sb.ToString();
  }

  /// <summary>
  /// Returns the JSON string presentation of the object
  /// </summary>
  /// <returns>JSON string presentation of the object</returns>
  public override string ToJson()
  {
    return JsonConvert.SerializeObject(ActualInstance, JsonConfig.AlgoliaJsonSerializerSettings);
  }

  /// <summary>
  /// Converts the JSON string into an instance of RecommendationsHit
  /// </summary>
  /// <param name="jsonString">JSON string</param>
  /// <returns>An instance of RecommendationsHit</returns>
  public static RecommendationsHit FromJson(string jsonString)
  {
    RecommendationsHit newRecommendationsHit = null;

    if (string.IsNullOrEmpty(jsonString))
    {
      return newRecommendationsHit;
    }
    try
    {
      return new RecommendationsHit(JsonConvert.DeserializeObject<RecommendHit>(jsonString, AdditionalPropertiesSerializerSettings));
    }
    catch (Exception exception)
    {
      // deserialization failed, try the next one
      System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into RecommendHit: {exception}");
    }
    try
    {
      return new RecommendationsHit(JsonConvert.DeserializeObject<TrendingFacetHit>(jsonString, AdditionalPropertiesSerializerSettings));
    }
    catch (Exception exception)
    {
      // deserialization failed, try the next one
      System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into TrendingFacetHit: {exception}");
    }

    throw new InvalidDataException($"The JSON string `{jsonString}` cannot be deserialized into any schema defined.");
  }

}

/// <summary>
/// Custom JSON converter for RecommendationsHit
/// </summary>
public class RecommendationsHitJsonConverter : JsonConverter
{
  /// <summary>
  /// To write the JSON string
  /// </summary>
  /// <param name="writer">JSON writer</param>
  /// <param name="value">Object to be converted into a JSON string</param>
  /// <param name="serializer">JSON Serializer</param>
  public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
  {
    writer.WriteRawValue((string)(typeof(RecommendationsHit).GetMethod("ToJson")?.Invoke(value, null)));
  }

  /// <summary>
  /// To convert a JSON string into an object
  /// </summary>
  /// <param name="reader">JSON reader</param>
  /// <param name="objectType">Object type</param>
  /// <param name="existingValue">Existing value</param>
  /// <param name="serializer">JSON Serializer</param>
  /// <returns>The object converted from the JSON string</returns>
  public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
  {
    if (reader.TokenType != JsonToken.Null)
    {
      return objectType.GetMethod("FromJson")?.Invoke(null, new object[] { JObject.Load(reader).ToString(Formatting.None) });
    }
    return null;
  }

  /// <summary>
  /// Check if the object can be converted
  /// </summary>
  /// <param name="objectType">Object type</param>
  /// <returns>True if the object can be converted</returns>
  public override bool CanConvert(Type objectType)
  {
    return false;
  }
}

