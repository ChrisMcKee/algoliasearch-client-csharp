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

namespace Algolia.Search.Analytics.Models
{
  /// <summary>
  /// TopCountry
  /// </summary>
  [DataContract(Name = "topCountry")]
  public partial class TopCountry
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="TopCountry" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TopCountry() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TopCountry" /> class.
    /// </summary>
    /// <param name="country">Country. (required).</param>
    /// <param name="count">Number of occurrences. (required).</param>
    public TopCountry(string country = default(string), int count = default(int))
    {
      // to ensure "country" is required (not null)
      if (country == null)
      {
        throw new ArgumentNullException("country is a required property for TopCountry and cannot be null");
      }
      this.Country = country;
      this.Count = count;
    }

    /// <summary>
    /// Country.
    /// </summary>
    /// <value>Country.</value>
    [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = true)]
    public string Country { get; set; }

    /// <summary>
    /// Number of occurrences.
    /// </summary>
    /// <value>Number of occurrences.</value>
    [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = true)]
    public int Count { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class TopCountry {\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
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
