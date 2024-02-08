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
/// SearchRulesResponse
/// </summary>
[DataContract(Name = "searchRulesResponse")]
public partial class SearchRulesResponse
{
  /// <summary>
  /// Initializes a new instance of the SearchRulesResponse class.
  /// </summary>
  [JsonConstructor]
  public SearchRulesResponse() { }
  /// <summary>
  /// Initializes a new instance of the SearchRulesResponse class.
  /// </summary>
  /// <param name="hits">Fetched rules. (required).</param>
  /// <param name="nbHits">Number of fetched rules. (required).</param>
  /// <param name="page">Current page. (required).</param>
  /// <param name="nbPages">Number of pages. (required).</param>
  public SearchRulesResponse(List<Rule> hits, int nbHits, int page, int nbPages)
  {
    Hits = hits ?? throw new ArgumentNullException(nameof(hits));
    NbHits = nbHits;
    Page = page;
    NbPages = nbPages;
  }

  /// <summary>
  /// Fetched rules.
  /// </summary>
  /// <value>Fetched rules.</value>
  [DataMember(Name = "hits")]
  public List<Rule> Hits { get; set; }

  /// <summary>
  /// Number of fetched rules.
  /// </summary>
  /// <value>Number of fetched rules.</value>
  [DataMember(Name = "nbHits")]
  public int NbHits { get; set; }

  /// <summary>
  /// Current page.
  /// </summary>
  /// <value>Current page.</value>
  [DataMember(Name = "page")]
  public int Page { get; set; }

  /// <summary>
  /// Number of pages.
  /// </summary>
  /// <value>Number of pages.</value>
  [DataMember(Name = "nbPages")]
  public int NbPages { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class SearchRulesResponse {\n");
    sb.Append("  Hits: ").Append(Hits).Append("\n");
    sb.Append("  NbHits: ").Append(NbHits).Append("\n");
    sb.Append("  Page: ").Append(Page).Append("\n");
    sb.Append("  NbPages: ").Append(NbPages).Append("\n");
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

