//
// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
//
using System;
using System.Text;
using System.Linq;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Algolia.Search.Serializer;
using System.Text.Json;

namespace Algolia.Search.Models.Analytics;

/// <summary>
/// DailyRevenue
/// </summary>
public partial class DailyRevenue
{
  /// <summary>
  /// Initializes a new instance of the DailyRevenue class.
  /// </summary>
  [JsonConstructor]
  public DailyRevenue() { }
  /// <summary>
  /// Initializes a new instance of the DailyRevenue class.
  /// </summary>
  /// <param name="currencies">Revenue associated with this search, broken-down by currencies. (required).</param>
  /// <param name="date">Date in the format YYYY-MM-DD. (required).</param>
  public DailyRevenue(Dictionary<string, CurrenciesValue> currencies, string date)
  {
    Currencies = currencies ?? throw new ArgumentNullException(nameof(currencies));
    Date = date ?? throw new ArgumentNullException(nameof(date));
  }

  /// <summary>
  /// Revenue associated with this search, broken-down by currencies.
  /// </summary>
  /// <value>Revenue associated with this search, broken-down by currencies.</value>
  [JsonPropertyName("currencies")]
  public Dictionary<string, CurrenciesValue> Currencies { get; set; }

  /// <summary>
  /// Date in the format YYYY-MM-DD.
  /// </summary>
  /// <value>Date in the format YYYY-MM-DD.</value>
  [JsonPropertyName("date")]
  public string Date { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class DailyRevenue {\n");
    sb.Append("  Currencies: ").Append(Currencies).Append("\n");
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
    return JsonSerializer.Serialize(this, JsonConfig.Options);
  }

  /// <summary>
  /// Returns true if objects are equal
  /// </summary>
  /// <param name="obj">Object to be compared</param>
  /// <returns>Boolean</returns>
  public override bool Equals(object obj)
  {
    if (obj is not DailyRevenue input)
    {
      return false;
    }

    return
        (Currencies == input.Currencies || Currencies != null && input.Currencies != null && Currencies.SequenceEqual(input.Currencies)) &&
        (Date == input.Date || (Date != null && Date.Equals(input.Date)));
  }

  /// <summary>
  /// Gets the hash code
  /// </summary>
  /// <returns>Hash code</returns>
  public override int GetHashCode()
  {
    unchecked // Overflow is fine, just wrap
    {
      int hashCode = 41;
      if (Currencies != null)
      {
        hashCode = (hashCode * 59) + Currencies.GetHashCode();
      }
      if (Date != null)
      {
        hashCode = (hashCode * 59) + Date.GetHashCode();
      }
      return hashCode;
    }
  }

}
