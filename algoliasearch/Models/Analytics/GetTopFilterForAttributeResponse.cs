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

namespace Algolia.Search.Models.Analytics;

/// <summary>
/// GetTopFilterForAttributeResponse
/// </summary>
[DataContract(Name = "getTopFilterForAttributeResponse")]
[JsonObject(MemberSerialization.OptOut)]
public partial class GetTopFilterForAttributeResponse
{
  /// <summary>
  /// Initializes a new instance of the GetTopFilterForAttributeResponse class.
  /// </summary>
  [JsonConstructor]
  public GetTopFilterForAttributeResponse() { }
  /// <summary>
  /// Initializes a new instance of the GetTopFilterForAttributeResponse class.
  /// </summary>
  /// <param name="values">Filter values for an attribute. (required).</param>
  public GetTopFilterForAttributeResponse(List<GetTopFilterForAttribute> values)
  {
    Values = values ?? throw new ArgumentNullException(nameof(values));
  }

  /// <summary>
  /// Filter values for an attribute.
  /// </summary>
  /// <value>Filter values for an attribute.</value>
  [DataMember(Name = "values", IsRequired = true, EmitDefaultValue = false)]
  public List<GetTopFilterForAttribute> Values { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class GetTopFilterForAttributeResponse {\n");
    sb.Append("  Values: ").Append(Values).Append("\n");
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
