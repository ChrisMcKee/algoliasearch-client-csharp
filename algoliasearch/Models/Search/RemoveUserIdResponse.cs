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
/// RemoveUserIdResponse
/// </summary>
[DataContract(Name = "removeUserIdResponse")]
[JsonObject(MemberSerialization.OptOut)]
public partial class RemoveUserIdResponse
{
  /// <summary>
  /// Initializes a new instance of the RemoveUserIdResponse class.
  /// </summary>
  [JsonConstructor]
  public RemoveUserIdResponse() { }
  /// <summary>
  /// Initializes a new instance of the RemoveUserIdResponse class.
  /// </summary>
  /// <param name="deletedAt">Timestamp of deletion in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format. (required).</param>
  public RemoveUserIdResponse(string deletedAt)
  {
    DeletedAt = deletedAt ?? throw new ArgumentNullException(nameof(deletedAt));
  }

  /// <summary>
  /// Timestamp of deletion in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.
  /// </summary>
  /// <value>Timestamp of deletion in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.</value>
  [DataMember(Name = "deletedAt", IsRequired = true, EmitDefaultValue = false)]
  public string DeletedAt { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class RemoveUserIdResponse {\n");
    sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
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
