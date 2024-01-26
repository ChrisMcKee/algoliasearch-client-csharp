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
/// `batchDictionaryEntries` parameters. 
/// </summary>
[DataContract(Name = "batchDictionaryEntriesParams")]
[JsonObject(MemberSerialization.OptOut)]
public partial class BatchDictionaryEntriesParams
{
  /// <summary>
  /// Initializes a new instance of the BatchDictionaryEntriesParams class.
  /// </summary>
  [JsonConstructor]
  public BatchDictionaryEntriesParams() { }
  /// <summary>
  /// Initializes a new instance of the BatchDictionaryEntriesParams class.
  /// </summary>
  /// <param name="requests">Operations to batch. (required).</param>
  public BatchDictionaryEntriesParams(List<BatchDictionaryEntriesRequest> requests)
  {
    Requests = requests ?? throw new ArgumentNullException(nameof(requests));
  }

  /// <summary>
  /// Incidates whether to replace all custom entries in the dictionary with the ones sent with this request.
  /// </summary>
  /// <value>Incidates whether to replace all custom entries in the dictionary with the ones sent with this request.</value>
  [DataMember(Name = "clearExistingDictionaryEntries", EmitDefaultValue = false)]
  public bool? ClearExistingDictionaryEntries { get; set; }

  /// <summary>
  /// Operations to batch.
  /// </summary>
  /// <value>Operations to batch.</value>
  [DataMember(Name = "requests", IsRequired = true, EmitDefaultValue = false)]
  public List<BatchDictionaryEntriesRequest> Requests { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class BatchDictionaryEntriesParams {\n");
    sb.Append("  ClearExistingDictionaryEntries: ").Append(ClearExistingDictionaryEntries).Append("\n");
    sb.Append("  Requests: ").Append(Requests).Append("\n");
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

