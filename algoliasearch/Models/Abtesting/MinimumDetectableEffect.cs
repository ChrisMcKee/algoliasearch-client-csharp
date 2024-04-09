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

namespace Algolia.Search.Models.Abtesting;

/// <summary>
/// Configuration for the smallest difference between test variants you want to detect.
/// </summary>
public partial class MinimumDetectableEffect
{

  /// <summary>
  /// Gets or Sets Effect
  /// </summary>
  [JsonPropertyName("effect")]
  public Effect? Effect { get; set; }
  /// <summary>
  /// Initializes a new instance of the MinimumDetectableEffect class.
  /// </summary>
  public MinimumDetectableEffect()
  {
  }

  /// <summary>
  /// Smallest difference in an observable metric between variants. For example, to detect a 10% difference between variants, set this value to 0.1. 
  /// </summary>
  /// <value>Smallest difference in an observable metric between variants. For example, to detect a 10% difference between variants, set this value to 0.1. </value>
  [JsonPropertyName("size")]
  public double? Size { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class MinimumDetectableEffect {\n");
    sb.Append("  Size: ").Append(Size).Append("\n");
    sb.Append("  Effect: ").Append(Effect).Append("\n");
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
    if (obj is not MinimumDetectableEffect input)
    {
      return false;
    }

    return
        (Size == input.Size || Size.Equals(input.Size)) &&
        (Effect == input.Effect || Effect.Equals(input.Effect));
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
      hashCode = (hashCode * 59) + Size.GetHashCode();
      hashCode = (hashCode * 59) + Effect.GetHashCode();
      return hashCode;
    }
  }

}

