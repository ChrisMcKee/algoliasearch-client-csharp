//
// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
//
using System;
using System.Text;
using System.Linq;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Algolia.Search.Serializer;
using System.Text.Json;
using System.IO;
using System.Reflection;
using Algolia.Search.Models.Common;

namespace Algolia.Search.Models.Recommend;

/// <summary>
/// SnippetResult
/// </summary>
[JsonConverter(typeof(SnippetResultJsonConverter))]
public partial class SnippetResult : AbstractSchema
{
  /// <summary>
  /// Initializes a new instance of the SnippetResult class
  /// with a SnippetResultOption
  /// </summary>
  /// <param name="actualInstance">An instance of SnippetResultOption.</param>
  public SnippetResult(SnippetResultOption actualInstance)
  {
    IsNullable = false;
    SchemaType = "oneOf";
    ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
  }

  /// <summary>
  /// Initializes a new instance of the SnippetResult class
  /// with a Dictionary{string, SnippetResultOption}
  /// </summary>
  /// <param name="actualInstance">An instance of Dictionary&lt;string, SnippetResultOption&gt;.</param>
  public SnippetResult(Dictionary<string, SnippetResultOption> actualInstance)
  {
    IsNullable = false;
    SchemaType = "oneOf";
    ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
  }

  /// <summary>
  /// Initializes a new instance of the SnippetResult class
  /// with a List{SnippetResultOption}
  /// </summary>
  /// <param name="actualInstance">An instance of List&lt;SnippetResultOption&gt;.</param>
  public SnippetResult(List<SnippetResultOption> actualInstance)
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
  /// Get the actual instance of `SnippetResultOption`. If the actual instance is not `SnippetResultOption`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of SnippetResultOption</returns>
  public SnippetResultOption AsSnippetResultOption()
  {
    return (SnippetResultOption)ActualInstance;
  }

  /// <summary>
  /// Get the actual instance of `Dictionary{string, SnippetResultOption}`. If the actual instance is not `Dictionary{string, SnippetResultOption}`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of Dictionary&lt;string, SnippetResultOption&gt;</returns>
  public Dictionary<string, SnippetResultOption> AsDictionary()
  {
    return (Dictionary<string, SnippetResultOption>)ActualInstance;
  }

  /// <summary>
  /// Get the actual instance of `List{SnippetResultOption}`. If the actual instance is not `List{SnippetResultOption}`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of List&lt;SnippetResultOption&gt;</returns>
  public List<SnippetResultOption> AsList()
  {
    return (List<SnippetResultOption>)ActualInstance;
  }


  /// <summary>
  /// Check if the actual instance is of `SnippetResultOption` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsSnippetResultOption()
  {
    return ActualInstance.GetType() == typeof(SnippetResultOption);
  }

  /// <summary>
  /// Check if the actual instance is of `Dictionary{string, SnippetResultOption}` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsDictionary()
  {
    return ActualInstance.GetType() == typeof(Dictionary<string, SnippetResultOption>);
  }

  /// <summary>
  /// Check if the actual instance is of `List{SnippetResultOption}` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsList()
  {
    return ActualInstance.GetType() == typeof(List<SnippetResultOption>);
  }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    var sb = new StringBuilder();
    sb.Append("class SnippetResult {\n");
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
    return JsonSerializer.Serialize(ActualInstance, JsonConfig.Options);
  }

  /// <summary>
  /// Returns true if objects are equal
  /// </summary>
  /// <param name="obj">Object to be compared</param>
  /// <returns>Boolean</returns>
  public override bool Equals(object obj)
  {
    if (obj is not SnippetResult input)
    {
      return false;
    }

    return ActualInstance.Equals(input.ActualInstance);
  }

  /// <summary>
  /// Gets the hash code
  /// </summary>
  /// <returns>Hash code</returns>
  public override int GetHashCode()
  {
    unchecked // Overflow is fine, just wrap
    {
      int hashCode = 41;
      if (ActualInstance != null)
        hashCode = hashCode * 59 + ActualInstance.GetHashCode();
      return hashCode;
    }
  }
}





/// <summary>
/// Custom JSON converter for SnippetResult
/// </summary>
public class SnippetResultJsonConverter : JsonConverter<SnippetResult>
{

  /// <summary>
  /// Check if the object can be converted
  /// </summary>
  /// <param name="objectType">Object type</param>
  /// <returns>True if the object can be converted</returns>
  public override bool CanConvert(Type objectType)
  {
    return objectType == typeof(SnippetResult);
  }

  /// <summary>
  /// To convert a JSON string into an object
  /// </summary>
  /// <param name="reader">JSON reader</param>
  /// <param name="typeToConvert">Object type</param>
  /// <param name="options">Serializer options</param>
  /// <returns>The object converted from the JSON string</returns>
  public override SnippetResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    var jsonDocument = JsonDocument.ParseValue(ref reader);
    var root = jsonDocument.RootElement;
    if (root.ValueKind == JsonValueKind.Object)
    {
      try
      {
        return new SnippetResult(jsonDocument.Deserialize<SnippetResultOption>(JsonConfig.Options));
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine($"Failed to deserialize into SnippetResultOption: {exception}");
      }
    }
    if (root.ValueKind == JsonValueKind.Object)
    {
      try
      {
        return new SnippetResult(jsonDocument.Deserialize<Dictionary<string, SnippetResultOption>>(JsonConfig.Options));
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine($"Failed to deserialize into Dictionary<string, SnippetResultOption>: {exception}");
      }
    }
    if (root.ValueKind == JsonValueKind.Array)
    {
      try
      {
        return new SnippetResult(jsonDocument.Deserialize<List<SnippetResultOption>>(JsonConfig.Options));
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine($"Failed to deserialize into List<SnippetResultOption>: {exception}");
      }
    }
    throw new InvalidDataException($"The JSON string cannot be deserialized into any schema defined.");
  }

  /// <summary>
  /// To write the JSON string
  /// </summary>
  /// <param name="writer">JSON writer</param>
  /// <param name="value">SnippetResult to be converted into a JSON string</param>
  /// <param name="options">JSON Serializer options</param>
  public override void Write(Utf8JsonWriter writer, SnippetResult value, JsonSerializerOptions options)
  {
    writer.WriteRawValue(value.ToJson());
  }
}

