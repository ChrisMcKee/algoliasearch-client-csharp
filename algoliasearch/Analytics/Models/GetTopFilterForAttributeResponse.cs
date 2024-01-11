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

namespace Algolia.Search.Models.Analytics
{
  /// <summary>
  /// GetTopFilterForAttributeResponse
  /// </summary>
  [DataContract(Name = "getTopFilterForAttributeResponse")]
  public partial class GetTopFilterForAttributeResponse
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="GetTopFilterForAttributeResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    public GetTopFilterForAttributeResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="GetTopFilterForAttributeResponse" /> class.
    /// </summary>
    /// <param name="values">Filter values for an attribute. (required).</param>
    public GetTopFilterForAttributeResponse(List<GetTopFilterForAttribute> values)
    {
      this.Values = values ?? throw new ArgumentNullException("values is a required property for GetTopFilterForAttributeResponse and cannot be null");
    }

    /// <summary>
    /// Filter values for an attribute.
    /// </summary>
    /// <value>Filter values for an attribute.</value>
    [DataMember(Name = "values", IsRequired = true, EmitDefaultValue = true)]
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
      return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }

  }

}