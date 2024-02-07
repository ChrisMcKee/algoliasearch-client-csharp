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

namespace Algolia.Search.Models.Recommend;

/// <summary>
/// Rule object.
/// </summary>
[DataContract(Name = "RuleResponse")]
[JsonObject(MemberSerialization.OptOut)]
public partial class RuleResponse
{
  /// <summary>
  /// Initializes a new instance of the RuleResponse class.
  /// </summary>
  [JsonConstructor]
  public RuleResponse() { }
  /// <summary>
  /// Initializes a new instance of the RuleResponse class.
  /// </summary>
  /// <param name="objectID">Unique identifier for a rule object. (required).</param>
  public RuleResponse(string objectID)
  {
    ObjectID = objectID ?? throw new ArgumentNullException(nameof(objectID));
  }

  /// <summary>
  /// Gets or Sets Metadata
  /// </summary>
  [DataMember(Name = "_metadata")]
  public RuleResponseMetadata? Metadata { get; set; }

  /// <summary>
  /// Unique identifier for a rule object.
  /// </summary>
  /// <value>Unique identifier for a rule object.</value>
  [DataMember(Name = "objectID")]
  public string ObjectID { get; set; }

  /// <summary>
  /// [Conditions](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/#conditions) required to activate a rule. You can use up to 25 conditions per rule. 
  /// </summary>
  /// <value>[Conditions](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/#conditions) required to activate a rule. You can use up to 25 conditions per rule. </value>
  [DataMember(Name = "conditions")]
  public List<Condition> Conditions { get; set; }

  /// <summary>
  /// Gets or Sets Consequence
  /// </summary>
  [DataMember(Name = "consequence")]
  public Consequence? Consequence { get; set; }

  /// <summary>
  /// Description of the rule's purpose. This can be helpful for display in the Algolia dashboard.
  /// </summary>
  /// <value>Description of the rule's purpose. This can be helpful for display in the Algolia dashboard.</value>
  [DataMember(Name = "description")]
  public string? Description { get; set; }

  /// <summary>
  /// Indicates whether to enable the rule. If it isn't enabled, it isn't applied at query time.
  /// </summary>
  /// <value>Indicates whether to enable the rule. If it isn't enabled, it isn't applied at query time.</value>
  [DataMember(Name = "enabled")]
  public bool? Enabled { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class RuleResponse {\n");
    sb.Append("  Metadata: ").Append(Metadata).Append("\n");
    sb.Append("  ObjectID: ").Append(ObjectID).Append("\n");
    sb.Append("  Conditions: ").Append(Conditions).Append("\n");
    sb.Append("  Consequence: ").Append(Consequence).Append("\n");
    sb.Append("  Description: ").Append(Description).Append("\n");
    sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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

