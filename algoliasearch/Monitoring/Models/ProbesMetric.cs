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
  /// ProbesMetric
  /// </summary>
  [DataContract(Name = "ProbesMetric")]
  public partial class ProbesMetric
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ProbesMetric" /> class.
    /// </summary>
    /// <param name="t">Timestamp in [Unix epoch time](https://wikipedia.org/wiki/Unix_time) in milliseconds..</param>
    /// <param name="v">Value of the metric..</param>
    public ProbesMetric(long t = default(long), int v = default(int))
    {
      this.T = t;
      this.V = v;
    }

    /// <summary>
    /// Timestamp in [Unix epoch time](https://wikipedia.org/wiki/Unix_time) in milliseconds.
    /// </summary>
    /// <value>Timestamp in [Unix epoch time](https://wikipedia.org/wiki/Unix_time) in milliseconds.</value>
    [DataMember(Name = "t", EmitDefaultValue = false)]
    public long T { get; set; }

    /// <summary>
    /// Value of the metric.
    /// </summary>
    /// <value>Value of the metric.</value>
    [DataMember(Name = "v", EmitDefaultValue = false)]
    public int V { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class ProbesMetric {\n");
      sb.Append("  T: ").Append(T).Append("\n");
      sb.Append("  V: ").Append(V).Append("\n");
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
