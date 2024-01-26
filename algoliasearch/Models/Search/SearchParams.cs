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

namespace Algolia.Search.Models.Search;

/// <summary>
/// SearchParams
/// </summary>
[JsonConverter(typeof(SearchParamsJsonConverter))]
[DataContract(Name = "searchParams")]
public partial class SearchParams : AbstractSchema
{
  /// <summary>
  /// Initializes a new instance of the SearchParams class
  /// with a SearchParamsString
  /// </summary>
  /// <param name="actualInstance">An instance of SearchParamsString.</param>
  public SearchParams(SearchParamsString actualInstance)
  {
    IsNullable = false;
    SchemaType = "oneOf";
    ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
  }

  /// <summary>
  /// Initializes a new instance of the SearchParams class
  /// with a SearchParamsObject
  /// </summary>
  /// <param name="actualInstance">An instance of SearchParamsObject.</param>
  public SearchParams(SearchParamsObject actualInstance)
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
  /// Get the actual instance of `SearchParamsString`. If the actual instance is not `SearchParamsString`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of SearchParamsString</returns>
  public SearchParamsString AsSearchParamsString()
  {
    return (SearchParamsString)ActualInstance;
  }

  /// <summary>
  /// Get the actual instance of `SearchParamsObject`. If the actual instance is not `SearchParamsObject`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of SearchParamsObject</returns>
  public SearchParamsObject AsSearchParamsObject()
  {
    return (SearchParamsObject)ActualInstance;
  }


  /// <summary>
  /// Check if the actual instance is of `SearchParamsString` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsSearchParamsString()
  {
    return ActualInstance.GetType() == typeof(SearchParamsString);
  }

  /// <summary>
  /// Check if the actual instance is of `SearchParamsObject` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsSearchParamsObject()
  {
    return ActualInstance.GetType() == typeof(SearchParamsObject);
  }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    var sb = new StringBuilder();
    sb.Append("class SearchParams {\n");
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
  /// Converts the JSON string into an instance of SearchParams
  /// </summary>
  /// <param name="jsonString">JSON string</param>
  /// <returns>An instance of SearchParams</returns>
  public static SearchParams FromJson(string jsonString)
  {
    SearchParams newSearchParams = null;

    if (string.IsNullOrEmpty(jsonString))
    {
      return newSearchParams;
    }
    try
    {
      return new SearchParams(JsonConvert.DeserializeObject<SearchParamsString>(jsonString, AdditionalPropertiesSerializerSettings));
    }
    catch (Exception exception)
    {
      // deserialization failed, try the next one
      System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into SearchParamsString: {exception}");
    }
    try
    {
      return new SearchParams(JsonConvert.DeserializeObject<SearchParamsObject>(jsonString, AdditionalPropertiesSerializerSettings));
    }
    catch (Exception exception)
    {
      // deserialization failed, try the next one
      System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into SearchParamsObject: {exception}");
    }

    throw new InvalidDataException($"The JSON string `{jsonString}` cannot be deserialized into any schema defined.");
  }

}

/// <summary>
/// Custom JSON converter for SearchParams
/// </summary>
public class SearchParamsJsonConverter : JsonConverter
{
  /// <summary>
  /// To write the JSON string
  /// </summary>
  /// <param name="writer">JSON writer</param>
  /// <param name="value">Object to be converted into a JSON string</param>
  /// <param name="serializer">JSON Serializer</param>
  public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
  {
    writer.WriteRawValue((string)(typeof(SearchParams).GetMethod("ToJson")?.Invoke(value, null)));
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

