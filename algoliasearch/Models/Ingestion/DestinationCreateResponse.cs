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
/// Response from the API when the Destination is successfully created.
/// </summary>
[DataContract(Name = "DestinationCreateResponse")]
[JsonObject(MemberSerialization.OptOut)]
public partial class DestinationCreateResponse
{
  /// <summary>
  /// Initializes a new instance of the DestinationCreateResponse class.
  /// </summary>
  [JsonConstructor]
  public DestinationCreateResponse() { }
  /// <summary>
  /// Initializes a new instance of the DestinationCreateResponse class.
  /// </summary>
  /// <param name="destinationID">The destination UUID. (required).</param>
  /// <param name="name">An human readable name describing the object. (required).</param>
  /// <param name="createdAt">Date of creation (RFC3339 format). (required).</param>
  public DestinationCreateResponse(string destinationID, string name, string createdAt)
  {
    DestinationID = destinationID ?? throw new ArgumentNullException(nameof(destinationID));
    Name = name ?? throw new ArgumentNullException(nameof(name));
    CreatedAt = createdAt ?? throw new ArgumentNullException(nameof(createdAt));
  }

  /// <summary>
  /// The destination UUID.
  /// </summary>
  /// <value>The destination UUID.</value>
  [DataMember(Name = "destinationID", IsRequired = true, EmitDefaultValue = false)]
  public string DestinationID { get; set; }

  /// <summary>
  /// An human readable name describing the object.
  /// </summary>
  /// <value>An human readable name describing the object.</value>
  [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
  public string Name { get; set; }

  /// <summary>
  /// Date of creation (RFC3339 format).
  /// </summary>
  /// <value>Date of creation (RFC3339 format).</value>
  [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
  public string CreatedAt { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class DestinationCreateResponse {\n");
    sb.Append("  DestinationID: ").Append(DestinationID).Append("\n");
    sb.Append("  Name: ").Append(Name).Append("\n");
    sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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

