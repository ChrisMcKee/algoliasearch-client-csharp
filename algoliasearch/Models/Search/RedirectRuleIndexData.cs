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

namespace Algolia.Search.Models.Search;

/// <summary>
/// Redirect rule data.
/// </summary>
public partial class RedirectRuleIndexData
{
  /// <summary>
  /// Initializes a new instance of the RedirectRuleIndexData class.
  /// </summary>
  [JsonConstructor]
  public RedirectRuleIndexData() { }
  /// <summary>
  /// Initializes a new instance of the RedirectRuleIndexData class.
  /// </summary>
  /// <param name="ruleObjectID">ruleObjectID (required).</param>
  public RedirectRuleIndexData(string ruleObjectID)
  {
    RuleObjectID = ruleObjectID ?? throw new ArgumentNullException(nameof(ruleObjectID));
  }

  /// <summary>
  /// Gets or Sets RuleObjectID
  /// </summary>
  [JsonPropertyName("ruleObjectID")]
  public string RuleObjectID { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class RedirectRuleIndexData {\n");
    sb.Append("  RuleObjectID: ").Append(RuleObjectID).Append("\n");
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
    if (obj is not RedirectRuleIndexData input)
    {
      return false;
    }

    return
        (RuleObjectID == input.RuleObjectID || (RuleObjectID != null && RuleObjectID.Equals(input.RuleObjectID)));
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
      if (RuleObjectID != null)
      {
        hashCode = (hashCode * 59) + RuleObjectID.GetHashCode();
      }
      return hashCode;
    }
  }

}
