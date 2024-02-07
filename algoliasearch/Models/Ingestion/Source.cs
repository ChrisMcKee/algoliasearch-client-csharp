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
/// Source
/// </summary>
[DataContract(Name = "Source")]
[JsonObject(MemberSerialization.OptOut)]
public partial class Source
{

  /// <summary>
  /// Gets or Sets Type
  /// </summary>
  [DataMember(Name = "type")]
  public SourceType Type { get; set; }
  /// <summary>
  /// Initializes a new instance of the Source class.
  /// </summary>
  [JsonConstructor]
  public Source() { }
  /// <summary>
  /// Initializes a new instance of the Source class.
  /// </summary>
  /// <param name="sourceID">The source UUID. (required).</param>
  /// <param name="type">type (required).</param>
  /// <param name="name">name (required).</param>
  /// <param name="input">input (required).</param>
  /// <param name="createdAt">Date of creation (RFC3339 format). (required).</param>
  public Source(string sourceID, SourceType type, string name, SourceInput input, string createdAt)
  {
    SourceID = sourceID ?? throw new ArgumentNullException(nameof(sourceID));
    Type = type;
    Name = name ?? throw new ArgumentNullException(nameof(name));
    Input = input ?? throw new ArgumentNullException(nameof(input));
    CreatedAt = createdAt ?? throw new ArgumentNullException(nameof(createdAt));
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
  /// Gets or Sets Input
  /// </summary>
  [DataMember(Name = "input")]
  public SourceInput Input { get; set; }

  /// <summary>
  /// The authentication UUID.
  /// </summary>
  /// <value>The authentication UUID.</value>
  [DataMember(Name = "authenticationID")]
  public string AuthenticationID { get; set; }

  /// <summary>
  /// Date of creation (RFC3339 format).
  /// </summary>
  /// <value>Date of creation (RFC3339 format).</value>
  [DataMember(Name = "createdAt")]
  public string CreatedAt { get; set; }

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
    sb.Append("class Source {\n");
    sb.Append("  SourceID: ").Append(SourceID).Append("\n");
    sb.Append("  Type: ").Append(Type).Append("\n");
    sb.Append("  Name: ").Append(Name).Append("\n");
    sb.Append("  Input: ").Append(Input).Append("\n");
    sb.Append("  AuthenticationID: ").Append(AuthenticationID).Append("\n");
    sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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

