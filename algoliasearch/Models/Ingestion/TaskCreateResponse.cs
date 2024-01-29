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
/// The response from the API after a task creation.
/// </summary>
[DataContract(Name = "TaskCreateResponse")]
[JsonObject(MemberSerialization.OptOut)]
public partial class TaskCreateResponse
{
  /// <summary>
  /// Initializes a new instance of the TaskCreateResponse class.
  /// </summary>
  [JsonConstructor]
  public TaskCreateResponse() { }
  /// <summary>
  /// Initializes a new instance of the TaskCreateResponse class.
  /// </summary>
  /// <param name="taskID">The task UUID. (required).</param>
  /// <param name="createdAt">Date of creation (RFC3339 format). (required).</param>
  public TaskCreateResponse(string taskID, string createdAt)
  {
    TaskID = taskID ?? throw new ArgumentNullException(nameof(taskID));
    CreatedAt = createdAt ?? throw new ArgumentNullException(nameof(createdAt));
  }

  /// <summary>
  /// The task UUID.
  /// </summary>
  /// <value>The task UUID.</value>
  [DataMember(Name = "taskID", IsRequired = true, EmitDefaultValue = false)]
  public string TaskID { get; set; }

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
    sb.Append("class TaskCreateResponse {\n");
    sb.Append("  TaskID: ").Append(TaskID).Append("\n");
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
