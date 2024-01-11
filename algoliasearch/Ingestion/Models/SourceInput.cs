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

namespace Algolia.Search.Models.Ingestion
{
  /// <summary>
  /// SourceInput
  /// </summary>
  [JsonConverter(typeof(SourceInputJsonConverter))]
  [DataContract(Name = "SourceInput")]
  public partial class SourceInput : AbstractSchema
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="SourceInput" /> class
    /// with the <see cref="SourceCommercetools" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of SourceCommercetools.</param>
    public SourceInput(SourceCommercetools actualInstance)
    {
      IsNullable = false;
      SchemaType = "oneOf";
      ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SourceInput" /> class
    /// with the <see cref="SourceBigCommerce" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of SourceBigCommerce.</param>
    public SourceInput(SourceBigCommerce actualInstance)
    {
      IsNullable = false;
      SchemaType = "oneOf";
      ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SourceInput" /> class
    /// with the <see cref="SourceJSON" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of SourceJSON.</param>
    public SourceInput(SourceJSON actualInstance)
    {
      IsNullable = false;
      SchemaType = "oneOf";
      ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SourceInput" /> class
    /// with the <see cref="SourceCSV" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of SourceCSV.</param>
    public SourceInput(SourceCSV actualInstance)
    {
      IsNullable = false;
      SchemaType = "oneOf";
      ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SourceInput" /> class
    /// with the <see cref="SourceBigQuery" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of SourceBigQuery.</param>
    public SourceInput(SourceBigQuery actualInstance)
    {
      IsNullable = false;
      SchemaType = "oneOf";
      ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SourceInput" /> class
    /// with the <see cref="SourceDocker" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of SourceDocker.</param>
    public SourceInput(SourceDocker actualInstance)
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
    /// Get the actual instance of `SourceCommercetools`. If the actual instance is not `SourceCommercetools`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of SourceCommercetools</returns>
    public SourceCommercetools AsSourceCommercetools()
    {
      return (SourceCommercetools)ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `SourceBigCommerce`. If the actual instance is not `SourceBigCommerce`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of SourceBigCommerce</returns>
    public SourceBigCommerce AsSourceBigCommerce()
    {
      return (SourceBigCommerce)ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `SourceJSON`. If the actual instance is not `SourceJSON`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of SourceJSON</returns>
    public SourceJSON AsSourceJSON()
    {
      return (SourceJSON)ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `SourceCSV`. If the actual instance is not `SourceCSV`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of SourceCSV</returns>
    public SourceCSV AsSourceCSV()
    {
      return (SourceCSV)ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `SourceBigQuery`. If the actual instance is not `SourceBigQuery`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of SourceBigQuery</returns>
    public SourceBigQuery AsSourceBigQuery()
    {
      return (SourceBigQuery)ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `SourceDocker`. If the actual instance is not `SourceDocker`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of SourceDocker</returns>
    public SourceDocker AsSourceDocker()
    {
      return (SourceDocker)ActualInstance;
    }


    /// <summary>
    /// Check if the actual instance is of `SourceCommercetools` type.
    /// </summary>
    /// <returns>Whether or not the instance is the type</returns>
    public bool IsSourceCommercetools()
    {
      return ActualInstance.GetType() == typeof(SourceCommercetools);
    }

    /// <summary>
    /// Check if the actual instance is of `SourceBigCommerce` type.
    /// </summary>
    /// <returns>Whether or not the instance is the type</returns>
    public bool IsSourceBigCommerce()
    {
      return ActualInstance.GetType() == typeof(SourceBigCommerce);
    }

    /// <summary>
    /// Check if the actual instance is of `SourceJSON` type.
    /// </summary>
    /// <returns>Whether or not the instance is the type</returns>
    public bool IsSourceJSON()
    {
      return ActualInstance.GetType() == typeof(SourceJSON);
    }

    /// <summary>
    /// Check if the actual instance is of `SourceCSV` type.
    /// </summary>
    /// <returns>Whether or not the instance is the type</returns>
    public bool IsSourceCSV()
    {
      return ActualInstance.GetType() == typeof(SourceCSV);
    }

    /// <summary>
    /// Check if the actual instance is of `SourceBigQuery` type.
    /// </summary>
    /// <returns>Whether or not the instance is the type</returns>
    public bool IsSourceBigQuery()
    {
      return ActualInstance.GetType() == typeof(SourceBigQuery);
    }

    /// <summary>
    /// Check if the actual instance is of `SourceDocker` type.
    /// </summary>
    /// <returns>Whether or not the instance is the type</returns>
    public bool IsSourceDocker()
    {
      return ActualInstance.GetType() == typeof(SourceDocker);
    }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class SourceInput {\n");
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
    /// Converts the JSON string into an instance of SourceInput
    /// </summary>
    /// <param name="jsonString">JSON string</param>
    /// <returns>An instance of SourceInput</returns>
    public static SourceInput FromJson(string jsonString)
    {
      SourceInput newSourceInput = null;

      if (string.IsNullOrEmpty(jsonString))
      {
        return newSourceInput;
      }
      try
      {
        return new SourceInput(JsonConvert.DeserializeObject<SourceCommercetools>(jsonString, AdditionalPropertiesSerializerSettings));
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SourceCommercetools: {1}", jsonString, exception.ToString()));
      }
      try
      {
        return new SourceInput(JsonConvert.DeserializeObject<SourceBigCommerce>(jsonString, AdditionalPropertiesSerializerSettings));
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SourceBigCommerce: {1}", jsonString, exception.ToString()));
      }
      try
      {
        return new SourceInput(JsonConvert.DeserializeObject<SourceJSON>(jsonString, AdditionalPropertiesSerializerSettings));
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SourceJSON: {1}", jsonString, exception.ToString()));
      }
      try
      {
        return new SourceInput(JsonConvert.DeserializeObject<SourceCSV>(jsonString, AdditionalPropertiesSerializerSettings));
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SourceCSV: {1}", jsonString, exception.ToString()));
      }
      try
      {
        return new SourceInput(JsonConvert.DeserializeObject<SourceBigQuery>(jsonString, AdditionalPropertiesSerializerSettings));
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SourceBigQuery: {1}", jsonString, exception.ToString()));
      }
      try
      {
        return new SourceInput(JsonConvert.DeserializeObject<SourceDocker>(jsonString, AdditionalPropertiesSerializerSettings));
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SourceDocker: {1}", jsonString, exception.ToString()));
      }

      throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
    }

  }

  /// <summary>
  /// Custom JSON converter for SourceInput
  /// </summary>
  public class SourceInputJsonConverter : JsonConverter
  {
    /// <summary>
    /// To write the JSON string
    /// </summary>
    /// <param name="writer">JSON writer</param>
    /// <param name="value">Object to be converted into a JSON string</param>
    /// <param name="serializer">JSON Serializer</param>
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
      writer.WriteRawValue((string)(typeof(SourceInput).GetMethod("ToJson").Invoke(value, null)));
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