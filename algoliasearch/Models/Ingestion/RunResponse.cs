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
/// The response from the run task API, containing an Observability Run ID and the time it was created at.
/// </summary>
[DataContract(Name = "RunResponse")]
[JsonObject(MemberSerialization.OptOut)]
public partial class RunResponse
{
  /// <summary>
  /// Initializes a new instance of the RunResponse class.
  /// </summary>
  [JsonConstructor]
  public RunResponse() { }
  /// <summary>
  /// Initializes a new instance of the RunResponse class.
  /// </summary>
  /// <param name="runID">The run UUID. (required).</param>
  /// <param name="createdAt">Date of creation (RFC3339 format). (required).</param>
  public RunResponse(string runID, string createdAt)
  {
    RunID = runID ?? throw new ArgumentNullException(nameof(runID));
    CreatedAt = createdAt ?? throw new ArgumentNullException(nameof(createdAt));
  }

  /// <summary>
  /// The run UUID.
  /// </summary>
  /// <value>The run UUID.</value>
  [DataMember(Name = "runID", IsRequired = true, EmitDefaultValue = false)]
  public string RunID { get; set; }

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
    sb.Append("class RunResponse {\n");
    sb.Append("  RunID: ").Append(RunID).Append("\n");
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

