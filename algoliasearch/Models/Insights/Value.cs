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

namespace Algolia.Search.Models.Insights;

/// <summary>
/// Total monetary value of this event in units of `currency`.
/// </summary>
[JsonConverter(typeof(ValueJsonConverter))]
[DataContract(Name = "value")]
public partial class Value : AbstractSchema
{
  /// <summary>
  /// Initializes a new instance of the Value class
  /// with a double
  /// </summary>
  /// <param name="actualInstance">An instance of double.</param>
  public Value(double actualInstance)
  {
    IsNullable = false;
    SchemaType = "oneOf";
    ActualInstance = actualInstance;
  }

  /// <summary>
  /// Initializes a new instance of the Value class
  /// with a string
  /// </summary>
  /// <param name="actualInstance">An instance of string.</param>
  public Value(string actualInstance)
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
  /// Get the actual instance of `double`. If the actual instance is not `double`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of double</returns>
  public double AsDouble()
  {
    return (double)ActualInstance;
  }

  /// <summary>
  /// Get the actual instance of `string`. If the actual instance is not `string`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of string</returns>
  public string AsString()
  {
    return (string)ActualInstance;
  }


  /// <summary>
  /// Check if the actual instance is of `double` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsDouble()
  {
    return ActualInstance.GetType() == typeof(double);
  }

  /// <summary>
  /// Check if the actual instance is of `string` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsString()
  {
    return ActualInstance.GetType() == typeof(string);
  }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    var sb = new StringBuilder();
    sb.Append("class Value {\n");
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
  /// Converts the JSON string into an instance of Value
  /// </summary>
  /// <param name="jsonString">JSON string</param>
  /// <returns>An instance of Value</returns>
  public static Value FromJson(string jsonString)
  {
    var jToken = JToken.Parse(jsonString);
    if (jToken.Type == JTokenType.Float)
    {
      try
      {
        return new Value(JsonConvert.DeserializeObject<double>(jsonString, JsonConfig.AlgoliaJsonSerializerSettings));
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into double: {exception}");
      }
    }
    if (jToken.Type == JTokenType.String)
    {
      try
      {
        return new Value(JsonConvert.DeserializeObject<string>(jsonString, JsonConfig.AlgoliaJsonSerializerSettings));
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into string: {exception}");
      }
    }

    throw new InvalidDataException($"The JSON string `{jsonString}` cannot be deserialized into any schema defined.");
  }

}

/// <summary>
/// Custom JSON converter for Value
/// </summary>
public class ValueJsonConverter : JsonConverter
{
  /// <summary>
  /// To write the JSON string
  /// </summary>
  /// <param name="writer">JSON writer</param>
  /// <param name="value">Object to be converted into a JSON string</param>
  /// <param name="serializer">JSON Serializer</param>
  public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
  {
    writer.WriteRawValue((string)value?.GetType().GetMethod("ToJson")?.Invoke(value, null));
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
      return objectType.GetMethod("FromJson")?.Invoke(null, new object[] { JToken.Load(reader).ToString(Formatting.None) });
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

