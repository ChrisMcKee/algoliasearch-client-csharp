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

namespace Algolia.Search.Monitoring.Models
{
  /// <summary>
  /// LatencyResponseMetrics
  /// </summary>
  [DataContract(Name = "LatencyResponse_metrics")]
  public partial class LatencyResponseMetrics
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="LatencyResponseMetrics" /> class.
    /// </summary>
    /// <param name="latency">latency.</param>
    public LatencyResponseMetrics(Dictionary<string, List<TimeInner>> latency = default(Dictionary<string, List<TimeInner>>))
    {
      this.Latency = latency;
    }

    /// <summary>
    /// Gets or Sets Latency
    /// </summary>
    [DataMember(Name = "latency", EmitDefaultValue = false)]
    public Dictionary<string, List<TimeInner>> Latency { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class LatencyResponseMetrics {\n");
      sb.Append("  Latency: ").Append(Latency).Append("\n");
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
