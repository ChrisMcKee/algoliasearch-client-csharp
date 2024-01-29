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

namespace Algolia.Search.Models.Search;

/// <summary>
/// SaveObjectResponse
/// </summary>
[DataContract(Name = "saveObjectResponse")]
[JsonObject(MemberSerialization.OptOut)]
public partial class SaveObjectResponse
{
  /// <summary>
  /// Initializes a new instance of the SaveObjectResponse class.
  /// </summary>
  [JsonConstructor]
  public SaveObjectResponse() { }
  /// <summary>
  /// Initializes a new instance of the SaveObjectResponse class.
  /// </summary>
  /// <param name="createdAt">Date of creation (ISO-8601 format). (required).</param>
  /// <param name="taskID">Unique identifier of a task. A successful API response means that a task was added to a queue. It might not run immediately. You can check the task&#39;s progress with the &#x60;task&#x60; operation and this &#x60;taskID&#x60;.  (required).</param>
  public SaveObjectResponse(string createdAt, long taskID)
  {
    CreatedAt = createdAt ?? throw new ArgumentNullException(nameof(createdAt));
    TaskID = taskID;
  }

  /// <summary>
  /// Date of creation (ISO-8601 format).
  /// </summary>
  /// <value>Date of creation (ISO-8601 format).</value>
  [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
  public string CreatedAt { get; set; }

  /// <summary>
  /// Unique identifier of a task. A successful API response means that a task was added to a queue. It might not run immediately. You can check the task's progress with the `task` operation and this `taskID`. 
  /// </summary>
  /// <value>Unique identifier of a task. A successful API response means that a task was added to a queue. It might not run immediately. You can check the task's progress with the `task` operation and this `taskID`. </value>
  [DataMember(Name = "taskID", IsRequired = true, EmitDefaultValue = false)]
  public long TaskID { get; set; }

  /// <summary>
  /// Unique object identifier.
  /// </summary>
  /// <value>Unique object identifier.</value>
  [DataMember(Name = "objectID", EmitDefaultValue = false)]
  public string ObjectID { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class SaveObjectResponse {\n");
    sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
    sb.Append("  TaskID: ").Append(TaskID).Append("\n");
    sb.Append("  ObjectID: ").Append(ObjectID).Append("\n");
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
