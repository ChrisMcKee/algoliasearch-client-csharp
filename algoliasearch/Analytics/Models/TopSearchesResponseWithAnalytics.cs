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
  /// TopSearchesResponseWithAnalytics
  /// </summary>
  [DataContract(Name = "topSearchesResponseWithAnalytics")]
  public partial class TopSearchesResponseWithAnalytics
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="TopSearchesResponseWithAnalytics" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    public TopSearchesResponseWithAnalytics() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TopSearchesResponseWithAnalytics" /> class.
    /// </summary>
    /// <param name="searches">Top searches with their hits count and analytics. (required).</param>
    public TopSearchesResponseWithAnalytics(List<TopSearchWithAnalytics> searches)
    {
      this.Searches = searches ?? throw new ArgumentNullException("searches is a required property for TopSearchesResponseWithAnalytics and cannot be null");
    }

    /// <summary>
    /// Top searches with their hits count and analytics.
    /// </summary>
    /// <value>Top searches with their hits count and analytics.</value>
    [DataMember(Name = "searches", IsRequired = true, EmitDefaultValue = true)]
    public List<TopSearchWithAnalytics> Searches { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class TopSearchesResponseWithAnalytics {\n");
      sb.Append("  Searches: ").Append(Searches).Append("\n");
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