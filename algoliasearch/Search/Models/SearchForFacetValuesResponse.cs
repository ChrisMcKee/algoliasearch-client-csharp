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

namespace Algolia.Search.Search.Models
{
  /// <summary>
  /// SearchForFacetValuesResponse
  /// </summary>
  [DataContract(Name = "searchForFacetValuesResponse")]
  public partial class SearchForFacetValuesResponse
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="SearchForFacetValuesResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SearchForFacetValuesResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SearchForFacetValuesResponse" /> class.
    /// </summary>
    /// <param name="facetHits">facetHits (required).</param>
    public SearchForFacetValuesResponse(List<FacetHits> facetHits = default(List<FacetHits>))
    {
      // to ensure "facetHits" is required (not null)
      if (facetHits == null)
      {
        throw new ArgumentNullException("facetHits is a required property for SearchForFacetValuesResponse and cannot be null");
      }
      this.FacetHits = facetHits;
    }

    /// <summary>
    /// Gets or Sets FacetHits
    /// </summary>
    [DataMember(Name = "facetHits", IsRequired = true, EmitDefaultValue = true)]
    public List<FacetHits> FacetHits { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class SearchForFacetValuesResponse {\n");
      sb.Append("  FacetHits: ").Append(FacetHits).Append("\n");
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
