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

namespace Algolia.Search.Models.Ingestion
{
  /// <summary>
  /// The trigger input for a task of type &#39;subscription&#39;.
  /// </summary>
  [DataContract(Name = "SubscriptionTrigger")]
  public partial class SubscriptionTrigger
  {

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
    public SubscriptionTriggerType Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriptionTrigger" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    public SubscriptionTrigger() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriptionTrigger" /> class.
    /// </summary>
    /// <param name="type">type (required).</param>
    public SubscriptionTrigger(SubscriptionTriggerType type)
    {
      this.Type = type;
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
      return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }

  }

}