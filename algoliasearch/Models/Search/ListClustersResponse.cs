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
/// Clusters.
/// </summary>
[DataContract(Name = "listClustersResponse")]
[JsonObject(MemberSerialization.OptOut)]
public partial class ListClustersResponse
{
  /// <summary>
  /// Initializes a new instance of the ListClustersResponse class.
  /// </summary>
  [JsonConstructor]
  public ListClustersResponse() { }
  /// <summary>
  /// Initializes a new instance of the ListClustersResponse class.
  /// </summary>
  /// <param name="topUsers">Key-value pairs with cluster names as keys and lists of users with the highest number of records per cluster as values. (required).</param>
  public ListClustersResponse(List<string> topUsers)
  {
    TopUsers = topUsers ?? throw new ArgumentNullException(nameof(topUsers));
  }

  /// <summary>
  /// Key-value pairs with cluster names as keys and lists of users with the highest number of records per cluster as values.
  /// </summary>
  /// <value>Key-value pairs with cluster names as keys and lists of users with the highest number of records per cluster as values.</value>
  [DataMember(Name = "topUsers", IsRequired = true, EmitDefaultValue = false)]
  public List<string> TopUsers { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class ListClustersResponse {\n");
    sb.Append("  TopUsers: ").Append(TopUsers).Append("\n");
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

