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

namespace Algolia.Search.Models.Search
{
  /// <summary>
  /// BrowseParams
  /// </summary>
  [JsonConverter(typeof(BrowseParamsJsonConverter))]
  [DataContract(Name = "browseParams")]
  public partial class BrowseParams : AbstractSchema
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="BrowseParams" /> class
    /// with the <see cref="SearchParamsString" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of SearchParamsString.</param>
    public BrowseParams(SearchParamsString actualInstance)
    {
      IsNullable = false;
      SchemaType = "oneOf";
      ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BrowseParams" /> class
    /// with the <see cref="BrowseParamsObject" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of BrowseParamsObject.</param>
    public BrowseParams(BrowseParamsObject actualInstance)
    {
      IsNullable = false;
      SchemaType = "oneOf";
      ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }


    private Object _actualInstance;

    /// <summary>
    /// Gets or Sets ActualInstance
    /// </summary>
    public override Object ActualInstance
    {
      get
      {
        return _actualInstance;
      }
      set
      {
        this._actualInstance = value;
      }
    }

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
    /// Get the actual instance of `BrowseParamsObject`. If the actual instance is not `BrowseParamsObject`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of BrowseParamsObject</returns>
    public BrowseParamsObject AsBrowseParamsObject()
    {
      return (BrowseParamsObject)ActualInstance;
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
    /// Check if the actual instance is of `BrowseParamsObject` type.
    /// </summary>
    /// <returns>Whether or not the instance is the type</returns>
    public bool IsBrowseParamsObject()
    {
      return ActualInstance.GetType() == typeof(BrowseParamsObject);
    }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class BrowseParams {\n");
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
      return JsonConvert.SerializeObject(ActualInstance, SerializerSettings);
    }

    /// <summary>
    /// Converts the JSON string into an instance of BrowseParams
    /// </summary>
    /// <param name="jsonString">JSON string</param>
    /// <returns>An instance of BrowseParams</returns>
    public static BrowseParams FromJson(string jsonString)
    {
      BrowseParams newBrowseParams = null;

      if (string.IsNullOrEmpty(jsonString))
      {
        return newBrowseParams;
      }
      try
      {
        return new BrowseParams(JsonConvert.DeserializeObject<SearchParamsString>(jsonString, AdditionalPropertiesSerializerSettings));
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SearchParamsString: {1}", jsonString, exception.ToString()));
      }
      try
      {
        return new BrowseParams(JsonConvert.DeserializeObject<BrowseParamsObject>(jsonString, AdditionalPropertiesSerializerSettings));
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into BrowseParamsObject: {1}", jsonString, exception.ToString()));
      }

      throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
    }

  }

  /// <summary>
  /// Custom JSON converter for BrowseParams
  /// </summary>
  public class BrowseParamsJsonConverter : JsonConverter
  {
    /// <summary>
    /// To write the JSON string
    /// </summary>
    /// <param name="writer">JSON writer</param>
    /// <param name="value">Object to be converted into a JSON string</param>
    /// <param name="serializer">JSON Serializer</param>
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
      writer.WriteRawValue((string)(typeof(BrowseParams).GetMethod("ToJson").Invoke(value, null)));
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
        return objectType.GetMethod("FromJson").Invoke(null, new[] { JObject.Load(reader).ToString(Formatting.None) });
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

}