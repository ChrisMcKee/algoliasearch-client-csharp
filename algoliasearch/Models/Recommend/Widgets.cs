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

namespace Algolia.Search.Models.Recommend;

/// <summary>
/// widgets returned from any rules that are applied to the current search.
/// </summary>
public partial class Widgets
{
  /// <summary>
  /// Initializes a new instance of the Widgets class.
  /// </summary>
  public Widgets()
  {
  }

  /// <summary>
  /// banners defined in the merchandising studio for the given search.
  /// </summary>
  /// <value>banners defined in the merchandising studio for the given search.</value>
  [JsonPropertyName("banners")]
  public List<Banner> Banners { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class Widgets {\n");
    sb.Append("  Banners: ").Append(Banners).Append("\n");
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
    if (obj is not Widgets input)
    {
      return false;
    }

    return
        (Banners == input.Banners || Banners != null && input.Banners != null && Banners.SequenceEqual(input.Banners));
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
      if (Banners != null)
      {
        hashCode = (hashCode * 59) + Banners.GetHashCode();
      }
      return hashCode;
    }
  }

}

