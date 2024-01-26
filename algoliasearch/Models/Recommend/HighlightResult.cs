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
/// HighlightResult
/// </summary>
[JsonConverter(typeof(HighlightResultJsonConverter))]
[DataContract(Name = "highlightResult")]
public partial class HighlightResult : AbstractSchema
{
  /// <summary>
  /// Initializes a new instance of the HighlightResult class
  /// with a HighlightResultOption
  /// </summary>
  /// <param name="actualInstance">An instance of HighlightResultOption.</param>
  public HighlightResult(HighlightResultOption actualInstance)
  {
    IsNullable = false;
    SchemaType = "oneOf";
    ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
  }

  /// <summary>
  /// Initializes a new instance of the HighlightResult class
  /// with a Dictionary{string, HighlightResultOption}
  /// </summary>
  /// <param name="actualInstance">An instance of Dictionary&lt;string, HighlightResultOption&gt;.</param>
  public HighlightResult(Dictionary<string, HighlightResultOption> actualInstance)
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
  /// Get the actual instance of `HighlightResultOption`. If the actual instance is not `HighlightResultOption`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of HighlightResultOption</returns>
  public HighlightResultOption AsHighlightResultOption()
  {
    return (HighlightResultOption)ActualInstance;
  }

  /// <summary>
  /// Get the actual instance of `Dictionary{string, HighlightResultOption}`. If the actual instance is not `Dictionary{string, HighlightResultOption}`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of Dictionary&lt;string, HighlightResultOption&gt;</returns>
  public Dictionary<string, HighlightResultOption> AsDictionary()
  {
    return (Dictionary<string, HighlightResultOption>)ActualInstance;
  }


  /// <summary>
  /// Check if the actual instance is of `HighlightResultOption` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsHighlightResultOption()
  {
    return ActualInstance.GetType() == typeof(HighlightResultOption);
  }

  /// <summary>
  /// Check if the actual instance is of `Dictionary{string, HighlightResultOption}` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsDictionary()
  {
    return ActualInstance.GetType() == typeof(Dictionary<string, HighlightResultOption>);
  }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    var sb = new StringBuilder();
    sb.Append("class HighlightResult {\n");
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
  /// Converts the JSON string into an instance of HighlightResult
  /// </summary>
  /// <param name="jsonString">JSON string</param>
  /// <returns>An instance of HighlightResult</returns>
  public static HighlightResult FromJson(string jsonString)
  {
    HighlightResult newHighlightResult = null;

    if (string.IsNullOrEmpty(jsonString))
    {
      return newHighlightResult;
    }
    try
    {
      return new HighlightResult(JsonConvert.DeserializeObject<HighlightResultOption>(jsonString, AdditionalPropertiesSerializerSettings));
    }
    catch (Exception exception)
    {
      // deserialization failed, try the next one
      System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into HighlightResultOption: {exception}");
    }
    try
    {
      return new HighlightResult(JsonConvert.DeserializeObject<Dictionary<string, HighlightResultOption>>(jsonString, AdditionalPropertiesSerializerSettings));
    }
    catch (Exception exception)
    {
      // deserialization failed, try the next one
      System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into Dictionary<string, HighlightResultOption>: {exception}");
    }

    throw new InvalidDataException($"The JSON string `{jsonString}` cannot be deserialized into any schema defined.");
  }

}

/// <summary>
/// Custom JSON converter for HighlightResult
/// </summary>
public class HighlightResultJsonConverter : JsonConverter
{
  /// <summary>
  /// To write the JSON string
  /// </summary>
  /// <param name="writer">JSON writer</param>
  /// <param name="value">Object to be converted into a JSON string</param>
  /// <param name="serializer">JSON Serializer</param>
  public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
  {
    writer.WriteRawValue((string)(typeof(HighlightResult).GetMethod("ToJson")?.Invoke(value, null)));
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

