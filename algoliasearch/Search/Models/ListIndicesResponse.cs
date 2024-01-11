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

namespace Algolia.Search.Models.Search
{
  /// <summary>
  /// ListIndicesResponse
  /// </summary>
  [DataContract(Name = "listIndicesResponse")]
  public partial class ListIndicesResponse
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ListIndicesResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    public ListIndicesResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ListIndicesResponse" /> class.
    /// </summary>
    /// <param name="items">All indices in your Algolia application. (required).</param>
    public ListIndicesResponse(List<FetchedIndex> items)
    {
      this.Items = items ?? throw new ArgumentNullException("items is a required property for ListIndicesResponse and cannot be null");
    }

    /// <summary>
    /// All indices in your Algolia application.
    /// </summary>
    /// <value>All indices in your Algolia application.</value>
    [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
    public List<FetchedIndex> Items { get; set; }

    /// <summary>
    /// Number of pages.
    /// </summary>
    /// <value>Number of pages.</value>
    [DataMember(Name = "nbPages", EmitDefaultValue = false)]
    public int? NbPages { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class ListIndicesResponse {\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
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
      return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }

  }

}