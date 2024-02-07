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
/// The input for an `onDemand` task whose source is of type `bigquery` and for which extracted data spans a given time range.
/// </summary>
[DataContract(Name = "OnDemandDateUtilsInput")]
[JsonObject(MemberSerialization.OptOut)]
public partial class OnDemandDateUtilsInput
{
  /// <summary>
  /// Initializes a new instance of the OnDemandDateUtilsInput class.
  /// </summary>
  [JsonConstructor]
  public OnDemandDateUtilsInput() { }
  /// <summary>
  /// Initializes a new instance of the OnDemandDateUtilsInput class.
  /// </summary>
  /// <param name="startDate">The start date of the extraction (RFC3339 format). (required).</param>
  /// <param name="endDate">The end date of the extraction (RFC3339 format). (required).</param>
  public OnDemandDateUtilsInput(string startDate, string endDate)
  {
    StartDate = startDate ?? throw new ArgumentNullException(nameof(startDate));
    EndDate = endDate ?? throw new ArgumentNullException(nameof(endDate));
  }

  /// <summary>
  /// The start date of the extraction (RFC3339 format).
  /// </summary>
  /// <value>The start date of the extraction (RFC3339 format).</value>
  [DataMember(Name = "startDate")]
  public string StartDate { get; set; }

  /// <summary>
  /// The end date of the extraction (RFC3339 format).
  /// </summary>
  /// <value>The end date of the extraction (RFC3339 format).</value>
  [DataMember(Name = "endDate")]
  public string EndDate { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class OnDemandDateUtilsInput {\n");
    sb.Append("  StartDate: ").Append(StartDate).Append("\n");
    sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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

