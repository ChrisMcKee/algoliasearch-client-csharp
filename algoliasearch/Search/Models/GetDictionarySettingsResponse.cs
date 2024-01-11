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
  /// GetDictionarySettingsResponse
  /// </summary>
  [DataContract(Name = "getDictionarySettingsResponse")]
  public partial class GetDictionarySettingsResponse
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="GetDictionarySettingsResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    public GetDictionarySettingsResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="GetDictionarySettingsResponse" /> class.
    /// </summary>
    /// <param name="disableStandardEntries">disableStandardEntries (required).</param>
    public GetDictionarySettingsResponse(StandardEntries disableStandardEntries)
    {
      this.DisableStandardEntries = disableStandardEntries ?? throw new ArgumentNullException("disableStandardEntries is a required property for GetDictionarySettingsResponse and cannot be null");
    }

    /// <summary>
    /// Gets or Sets DisableStandardEntries
    /// </summary>
    [DataMember(Name = "disableStandardEntries", IsRequired = true, EmitDefaultValue = true)]
    public StandardEntries DisableStandardEntries { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class GetDictionarySettingsResponse {\n");
      sb.Append("  DisableStandardEntries: ").Append(DisableStandardEntries).Append("\n");
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