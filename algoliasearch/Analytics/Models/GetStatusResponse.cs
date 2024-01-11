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
  /// GetStatusResponse
  /// </summary>
  [DataContract(Name = "getStatusResponse")]
  public partial class GetStatusResponse
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="GetStatusResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    public GetStatusResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="GetStatusResponse" /> class.
    /// </summary>
    /// <param name="updatedAt">Timestamp of the last update in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format. (required).</param>
    public GetStatusResponse(string updatedAt)
    {
      this.UpdatedAt = updatedAt ?? throw new ArgumentNullException("updatedAt is a required property for GetStatusResponse and cannot be null");
    }

    /// <summary>
    /// Timestamp of the last update in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.
    /// </summary>
    /// <value>Timestamp of the last update in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.</value>
    [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
    public string UpdatedAt { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class GetStatusResponse {\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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