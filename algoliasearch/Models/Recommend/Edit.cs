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

namespace Algolia.Search.Models.Recommend;

/// <summary>
/// Edit
/// </summary>
[DataContract(Name = "edit")]
[JsonObject(MemberSerialization.OptOut)]
public partial class Edit
{

  /// <summary>
  /// Gets or Sets Type
  /// </summary>
  [DataMember(Name = "type")]
  public EditType? Type { get; set; }
  /// <summary>
  /// Initializes a new instance of the Edit class.
  /// </summary>
  public Edit()
  {
  }

  /// <summary>
  /// Text or patterns to remove from the query string.
  /// </summary>
  /// <value>Text or patterns to remove from the query string.</value>
  [DataMember(Name = "delete")]
  public string? Delete { get; set; }

  /// <summary>
  /// Text that should be inserted in place of the removed text inside the query string.
  /// </summary>
  /// <value>Text that should be inserted in place of the removed text inside the query string.</value>
  [DataMember(Name = "insert")]
  public string? Insert { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class Edit {\n");
    sb.Append("  Type: ").Append(Type).Append("\n");
    sb.Append("  Delete: ").Append(Delete).Append("\n");
    sb.Append("  Insert: ").Append(Insert).Append("\n");
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

