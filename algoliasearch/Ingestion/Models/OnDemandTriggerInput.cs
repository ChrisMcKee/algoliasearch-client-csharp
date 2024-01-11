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
  /// The trigger information of a task of type &#x60;onDemand&#x60;.
  /// </summary>
  [DataContract(Name = "OnDemandTriggerInput")]
  public partial class OnDemandTriggerInput
  {

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
    public OnDemandTriggerType Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="OnDemandTriggerInput" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    public OnDemandTriggerInput() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OnDemandTriggerInput" /> class.
    /// </summary>
    /// <param name="type">type (required).</param>
    public OnDemandTriggerInput(OnDemandTriggerType type)
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
      sb.Append("class OnDemandTriggerInput {\n");
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