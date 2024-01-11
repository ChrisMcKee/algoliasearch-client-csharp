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

namespace Algolia.Search.Models.Analytics
{
  /// <summary>
  /// AverageClickEvent
  /// </summary>
  [DataContract(Name = "averageClickEvent")]
  public partial class AverageClickEvent
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="AverageClickEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    public AverageClickEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AverageClickEvent" /> class.
    /// </summary>
    /// <param name="average">Average count of all click events. (required).</param>
    /// <param name="clickCount">Number of click events. (required).</param>
    /// <param name="date">Date of the event in the format YYYY-MM-DD. (required).</param>
    public AverageClickEvent(double average, int clickCount, string date)
    {
      this.Average = average;
      this.ClickCount = clickCount;
      this.Date = date ?? throw new ArgumentNullException("date is a required property for AverageClickEvent and cannot be null");
    }

    /// <summary>
    /// Average count of all click events.
    /// </summary>
    /// <value>Average count of all click events.</value>
    [DataMember(Name = "average", IsRequired = true, EmitDefaultValue = true)]
    public double Average { get; set; }

    /// <summary>
    /// Number of click events.
    /// </summary>
    /// <value>Number of click events.</value>
    [DataMember(Name = "clickCount", IsRequired = true, EmitDefaultValue = true)]
    public int ClickCount { get; set; }

    /// <summary>
    /// Date of the event in the format YYYY-MM-DD.
    /// </summary>
    /// <value>Date of the event in the format YYYY-MM-DD.</value>
    [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
    public string Date { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class AverageClickEvent {\n");
      sb.Append("  Average: ").Append(Average).Append("\n");
      sb.Append("  ClickCount: ").Append(ClickCount).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
      return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }

  }

}