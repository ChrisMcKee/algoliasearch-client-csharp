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
/// SourceUpdateResponse
/// </summary>
[DataContract(Name = "SourceUpdateResponse")]
public partial class SourceUpdateResponse
{
  /// <summary>
  /// Initializes a new instance of the SourceUpdateResponse class.
  /// </summary>
  [JsonConstructor]
  public SourceUpdateResponse() { }
  /// <summary>
  /// Initializes a new instance of the SourceUpdateResponse class.
  /// </summary>
  /// <param name="sourceID">The source UUID. (required).</param>
  /// <param name="name">name (required).</param>
  /// <param name="updatedAt">Date of last update (RFC3339 format). (required).</param>
  public SourceUpdateResponse(string sourceID, string name, string updatedAt)
  {
    SourceID = sourceID ?? throw new ArgumentNullException(nameof(sourceID));
    Name = name ?? throw new ArgumentNullException(nameof(name));
    UpdatedAt = updatedAt ?? throw new ArgumentNullException(nameof(updatedAt));
  }

  /// <summary>
  /// The source UUID.
  /// </summary>
  /// <value>The source UUID.</value>
  [DataMember(Name = "sourceID")]
  public string SourceID { get; set; }

  /// <summary>
  /// Gets or Sets Name
  /// </summary>
  [DataMember(Name = "name")]
  public string Name { get; set; }

  /// <summary>
  /// Date of last update (RFC3339 format).
  /// </summary>
  /// <value>Date of last update (RFC3339 format).</value>
  [DataMember(Name = "updatedAt")]
  public string UpdatedAt { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class SourceUpdateResponse {\n");
    sb.Append("  SourceID: ").Append(SourceID).Append("\n");
    sb.Append("  Name: ").Append(Name).Append("\n");
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
    return JsonConvert.SerializeObject(this, Formatting.Indented);
  }

}

