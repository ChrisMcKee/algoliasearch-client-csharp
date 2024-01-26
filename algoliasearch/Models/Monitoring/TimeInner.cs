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

namespace Algolia.Search.Models.Monitoring;

/// <summary>
/// TimeInner
/// </summary>
[DataContract(Name = "Time_inner")]
[JsonObject(MemberSerialization.OptOut)]
public partial class TimeInner
{
  /// <summary>
  /// Initializes a new instance of the TimeInner class.
  /// </summary>
  public TimeInner()
  {
  }

  /// <summary>
  /// Timestamp in [Unix epoch time](https://wikipedia.org/wiki/Unix_time) in milliseconds.
  /// </summary>
  /// <value>Timestamp in [Unix epoch time](https://wikipedia.org/wiki/Unix_time) in milliseconds.</value>
  [DataMember(Name = "t", EmitDefaultValue = false)]
  public long T { get; set; }

  /// <summary>
  /// Time in ms.
  /// </summary>
  /// <value>Time in ms.</value>
  [DataMember(Name = "v", EmitDefaultValue = false)]
  public int? V { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class TimeInner {\n");
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
    return JsonConvert.SerializeObject(this, Formatting.Indented);
  }

}

