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
/// UpdateApiKeyResponse
/// </summary>
[DataContract(Name = "updateApiKeyResponse")]
public partial class UpdateApiKeyResponse
{
  /// <summary>
  /// Initializes a new instance of the UpdateApiKeyResponse class.
  /// </summary>
  [JsonConstructor]
  public UpdateApiKeyResponse() { }
  /// <summary>
  /// Initializes a new instance of the UpdateApiKeyResponse class.
  /// </summary>
  /// <param name="key">API key. (required).</param>
  /// <param name="updatedAt">Timestamp of the last update in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format. (required).</param>
  public UpdateApiKeyResponse(string key, string updatedAt)
  {
    Key = key ?? throw new ArgumentNullException(nameof(key));
    UpdatedAt = updatedAt ?? throw new ArgumentNullException(nameof(updatedAt));
  }

  /// <summary>
  /// API key.
  /// </summary>
  /// <value>API key.</value>
  [DataMember(Name = "key")]
  public string Key { get; set; }

  /// <summary>
  /// Timestamp of the last update in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.
  /// </summary>
  /// <value>Timestamp of the last update in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.</value>
  [DataMember(Name = "updatedAt")]
  public string UpdatedAt { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class UpdateApiKeyResponse {\n");
    sb.Append("  Key: ").Append(Key).Append("\n");
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

