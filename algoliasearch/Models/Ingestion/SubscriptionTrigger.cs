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
using Algolia.Search.Models;
using Algolia.Search.Models.Common;
using Algolia.Search.Serializer;

namespace Algolia.Search.Models.Ingestion;

/// <summary>
/// The trigger input for a task of type 'subscription'.
/// </summary>
[DataContract(Name = "SubscriptionTrigger")]
[JsonObject(MemberSerialization.OptOut)]
public partial class SubscriptionTrigger
{

  /// <summary>
  /// Gets or Sets Type
  /// </summary>
  [DataMember(Name = "type")]
  public SubscriptionTriggerType Type { get; set; }
  /// <summary>
  /// Initializes a new instance of the SubscriptionTrigger class.
  /// </summary>
  [JsonConstructor]
  public SubscriptionTrigger() { }
  /// <summary>
  /// Initializes a new instance of the SubscriptionTrigger class.
  /// </summary>
  /// <param name="type">type (required).</param>
  public SubscriptionTrigger(SubscriptionTriggerType type)
  {
    Type = type;
  }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class SubscriptionTrigger {\n");
    sb.Append("  Type: ").Append(Type).Append("\n");
    sb.Append("}\n");
    return sb.ToString();
  }

  /// <summary>
  /// Returns the JSON string presentation of the object
  /// </summary>
  /// <returns>JSON string presentation of the object</returns>
  public virtual string ToJson()
  {
    return JsonConvert.SerializeObject(this, Formatting.Indented);
  }

}

