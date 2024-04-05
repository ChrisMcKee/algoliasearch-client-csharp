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
/// GetConversionRateResponse
/// </summary>
public partial class GetConversionRateResponse
{
  /// <summary>
  /// Initializes a new instance of the GetConversionRateResponse class.
  /// </summary>
  [JsonConstructor]
  public GetConversionRateResponse() { }
  /// <summary>
  /// Initializes a new instance of the GetConversionRateResponse class.
  /// </summary>
  /// <param name="rate">Conversion rate, calculated as number of tracked searches with at least one conversion event divided by the number of tracked searches. If null, Algolia didn&#39;t receive any search requests with &#x60;clickAnalytics&#x60; set to true.  (required).</param>
  /// <param name="trackedSearchCount">Number of tracked searches. Tracked searches are search requests where the &#x60;clickAnalytics&#x60; parameter is true. (required) (default to 0).</param>
  /// <param name="conversionCount">Number of conversions from this search. (required) (default to 0).</param>
  /// <param name="dates">Daily conversion rates. (required).</param>
  public GetConversionRateResponse(double? rate, int trackedSearchCount, int conversionCount, List<DailyConversionRates> dates)
  {
    Rate = rate ?? throw new ArgumentNullException(nameof(rate));
    TrackedSearchCount = trackedSearchCount;
    ConversionCount = conversionCount;
    Dates = dates ?? throw new ArgumentNullException(nameof(dates));
  }

  /// <summary>
  /// Conversion rate, calculated as number of tracked searches with at least one conversion event divided by the number of tracked searches. If null, Algolia didn't receive any search requests with `clickAnalytics` set to true. 
  /// </summary>
  /// <value>Conversion rate, calculated as number of tracked searches with at least one conversion event divided by the number of tracked searches. If null, Algolia didn't receive any search requests with `clickAnalytics` set to true. </value>
  [JsonPropertyName("rate")]
  public double? Rate { get; set; }

  /// <summary>
  /// Number of tracked searches. Tracked searches are search requests where the `clickAnalytics` parameter is true.
  /// </summary>
  /// <value>Number of tracked searches. Tracked searches are search requests where the `clickAnalytics` parameter is true.</value>
  [JsonPropertyName("trackedSearchCount")]
  public int TrackedSearchCount { get; set; }

  /// <summary>
  /// Number of conversions from this search.
  /// </summary>
  /// <value>Number of conversions from this search.</value>
  [JsonPropertyName("conversionCount")]
  public int ConversionCount { get; set; }

  /// <summary>
  /// Daily conversion rates.
  /// </summary>
  /// <value>Daily conversion rates.</value>
  [JsonPropertyName("dates")]
  public List<DailyConversionRates> Dates { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class GetConversionRateResponse {\n");
    sb.Append("  Rate: ").Append(Rate).Append("\n");
    sb.Append("  TrackedSearchCount: ").Append(TrackedSearchCount).Append("\n");
    sb.Append("  ConversionCount: ").Append(ConversionCount).Append("\n");
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
    return JsonSerializer.Serialize(this, JsonConfig.Options);
  }

  /// <summary>
  /// Returns true if objects are equal
  /// </summary>
  /// <param name="obj">Object to be compared</param>
  /// <returns>Boolean</returns>
  public override bool Equals(object obj)
  {
    if (obj is not GetConversionRateResponse input)
    {
      return false;
    }

    return
        (Rate == input.Rate || (Rate != null && Rate.Equals(input.Rate))) &&
        (TrackedSearchCount == input.TrackedSearchCount || TrackedSearchCount.Equals(input.TrackedSearchCount)) &&
        (ConversionCount == input.ConversionCount || ConversionCount.Equals(input.ConversionCount)) &&
        (Dates == input.Dates || Dates != null && input.Dates != null && Dates.SequenceEqual(input.Dates));
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
      if (Rate != null)
      {
        hashCode = (hashCode * 59) + Rate.GetHashCode();
      }
      hashCode = (hashCode * 59) + TrackedSearchCount.GetHashCode();
      hashCode = (hashCode * 59) + ConversionCount.GetHashCode();
      if (Dates != null)
      {
        hashCode = (hashCode * 59) + Dates.GetHashCode();
      }
      return hashCode;
    }
  }

}
