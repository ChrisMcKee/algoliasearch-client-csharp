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

namespace Algolia.Search.Models.Recommend;

/// <summary>
/// TrendingFacetsQuery
/// </summary>
public partial class TrendingFacetsQuery
{

  /// <summary>
  /// Gets or Sets Model
  /// </summary>
  [JsonPropertyName("model")]
  public TrendingFacetsModel? Model { get; set; }
  /// <summary>
  /// Initializes a new instance of the TrendingFacetsQuery class.
  /// </summary>
  [JsonConstructor]
  public TrendingFacetsQuery() { }
  /// <summary>
  /// Initializes a new instance of the TrendingFacetsQuery class.
  /// </summary>
  /// <param name="indexName">Algolia index name. (required).</param>
  /// <param name="facetName">Facet name for trending models. (required).</param>
  public TrendingFacetsQuery(string indexName, string facetName)
  {
    IndexName = indexName ?? throw new ArgumentNullException(nameof(indexName));
    FacetName = facetName ?? throw new ArgumentNullException(nameof(facetName));
  }

  /// <summary>
  /// Algolia index name.
  /// </summary>
  /// <value>Algolia index name.</value>
  [JsonPropertyName("indexName")]
  public string IndexName { get; set; }

  /// <summary>
  /// Recommendations with a confidence score lower than `threshold` won't appear in results. > **Note**: Each recommendation has a confidence score of 0 to 100. The closer the score is to 100, the more relevant the recommendations are. 
  /// </summary>
  /// <value>Recommendations with a confidence score lower than `threshold` won't appear in results. > **Note**: Each recommendation has a confidence score of 0 to 100. The closer the score is to 100, the more relevant the recommendations are. </value>
  [JsonPropertyName("threshold")]
  public int? Threshold { get; set; }

  /// <summary>
  /// Maximum number of recommendations to retrieve. If 0, all recommendations will be returned.
  /// </summary>
  /// <value>Maximum number of recommendations to retrieve. If 0, all recommendations will be returned.</value>
  [JsonPropertyName("maxRecommendations")]
  public int? MaxRecommendations { get; set; }

  /// <summary>
  /// Facet name for trending models.
  /// </summary>
  /// <value>Facet name for trending models.</value>
  [JsonPropertyName("facetName")]
  public string FacetName { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class TrendingFacetsQuery {\n");
    sb.Append("  IndexName: ").Append(IndexName).Append("\n");
    sb.Append("  Threshold: ").Append(Threshold).Append("\n");
    sb.Append("  MaxRecommendations: ").Append(MaxRecommendations).Append("\n");
    sb.Append("  FacetName: ").Append(FacetName).Append("\n");
    sb.Append("  Model: ").Append(Model).Append("\n");
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
    if (obj is not TrendingFacetsQuery input)
    {
      return false;
    }

    return
        (IndexName == input.IndexName || (IndexName != null && IndexName.Equals(input.IndexName))) &&
        (Threshold == input.Threshold || Threshold.Equals(input.Threshold)) &&
        (MaxRecommendations == input.MaxRecommendations || MaxRecommendations.Equals(input.MaxRecommendations)) &&
        (FacetName == input.FacetName || (FacetName != null && FacetName.Equals(input.FacetName))) &&
        (Model == input.Model || Model.Equals(input.Model));
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
      if (IndexName != null)
      {
        hashCode = (hashCode * 59) + IndexName.GetHashCode();
      }
      hashCode = (hashCode * 59) + Threshold.GetHashCode();
      hashCode = (hashCode * 59) + MaxRecommendations.GetHashCode();
      if (FacetName != null)
      {
        hashCode = (hashCode * 59) + FacetName.GetHashCode();
      }
      hashCode = (hashCode * 59) + Model.GetHashCode();
      return hashCode;
    }
  }

}

