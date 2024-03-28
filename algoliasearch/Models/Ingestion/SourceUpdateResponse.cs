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

namespace Algolia.Search.Models.Ingestion;

/// <summary>
/// SourceUpdateResponse
/// </summary>
public partial class SourceUpdateResponse
{
  /// <summary>
  /// Initializes a new instance of the SourceUpdateResponse class.
  /// </summary>
  [JsonConstructor]
  public SourceUpdateResponse() { }
  /// <summary>
  /// Initializes a new instance of the SourceUpdateResponse class.
  /// </summary>
  /// <param name="sourceID">Universally uniqud identifier (UUID) of a source. (required).</param>
  /// <param name="name">Descriptive name of the source. (required).</param>
  /// <param name="updatedAt">Date of last update in RFC3339 format. (required).</param>
  public SourceUpdateResponse(string sourceID, string name, string updatedAt)
  {
    SourceID = sourceID ?? throw new ArgumentNullException(nameof(sourceID));
    Name = name ?? throw new ArgumentNullException(nameof(name));
    UpdatedAt = updatedAt ?? throw new ArgumentNullException(nameof(updatedAt));
  }

  /// <summary>
  /// Universally uniqud identifier (UUID) of a source.
  /// </summary>
  /// <value>Universally uniqud identifier (UUID) of a source.</value>
  [JsonPropertyName("sourceID")]
  public string SourceID { get; set; }

  /// <summary>
  /// Descriptive name of the source.
  /// </summary>
  /// <value>Descriptive name of the source.</value>
  [JsonPropertyName("name")]
  public string Name { get; set; }

  /// <summary>
  /// Date of last update in RFC3339 format.
  /// </summary>
  /// <value>Date of last update in RFC3339 format.</value>
  [JsonPropertyName("updatedAt")]
  public string UpdatedAt { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class SourceUpdateResponse {\n");
    sb.Append("  SourceID: ").Append(SourceID).Append("\n");
    sb.Append("  Name: ").Append(Name).Append("\n");
    sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
    sb.Append("}\n");
    return sb.ToString();
  }

  /// <summary>
  /// Returns the JSON string presentation of the object
  /// </summary>
  /// <returns>JSON string presentation of the object</returns>
  public virtual string ToJson()
  {
    return JsonSerializer.Serialize(this, JsonConfig.Options);
  }

  /// <summary>
  /// Returns true if objects are equal
  /// </summary>
  /// <param name="obj">Object to be compared</param>
  /// <returns>Boolean</returns>
  public override bool Equals(object obj)
  {
    if (obj is not SourceUpdateResponse input)
    {
      return false;
    }

    return
        (SourceID == input.SourceID || (SourceID != null && SourceID.Equals(input.SourceID))) &&
        (Name == input.Name || (Name != null && Name.Equals(input.Name))) &&
        (UpdatedAt == input.UpdatedAt || (UpdatedAt != null && UpdatedAt.Equals(input.UpdatedAt)));
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
      if (SourceID != null)
      {
        hashCode = (hashCode * 59) + SourceID.GetHashCode();
      }
      if (Name != null)
      {
        hashCode = (hashCode * 59) + Name.GetHashCode();
      }
      if (UpdatedAt != null)
      {
        hashCode = (hashCode * 59) + UpdatedAt.GetHashCode();
      }
      return hashCode;
    }
  }

}

