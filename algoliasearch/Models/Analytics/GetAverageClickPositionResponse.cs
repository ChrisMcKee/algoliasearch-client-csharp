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

namespace Algolia.Search.Models.Analytics;

/// <summary>
/// GetAverageClickPositionResponse
/// </summary>
[DataContract(Name = "getAverageClickPositionResponse")]
public partial class GetAverageClickPositionResponse
{
  /// <summary>
  /// Initializes a new instance of the GetAverageClickPositionResponse class.
  /// </summary>
  [JsonConstructor]
  public GetAverageClickPositionResponse() { }
  /// <summary>
  /// Initializes a new instance of the GetAverageClickPositionResponse class.
  /// </summary>
  /// <param name="average">Average count of all click events. (required).</param>
  /// <param name="clickCount">Number of click events. (required).</param>
  /// <param name="dates">Average click positions. (required).</param>
  public GetAverageClickPositionResponse(double average, int clickCount, List<AverageClickEvent> dates)
  {
    Average = average;
    ClickCount = clickCount;
    Dates = dates ?? throw new ArgumentNullException(nameof(dates));
  }

  /// <summary>
  /// Average count of all click events.
  /// </summary>
  /// <value>Average count of all click events.</value>
  [DataMember(Name = "average")]
  public double Average { get; set; }

  /// <summary>
  /// Number of click events.
  /// </summary>
  /// <value>Number of click events.</value>
  [DataMember(Name = "clickCount")]
  public int ClickCount { get; set; }

  /// <summary>
  /// Average click positions.
  /// </summary>
  /// <value>Average click positions.</value>
  [DataMember(Name = "dates")]
  public List<AverageClickEvent> Dates { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class GetAverageClickPositionResponse {\n");
    sb.Append("  Average: ").Append(Average).Append("\n");
    sb.Append("  ClickCount: ").Append(ClickCount).Append("\n");
    sb.Append("  Dates: ").Append(Dates).Append("\n");
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

