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
  /// Enable or turn off the built-in Algolia stop words for a specific language.
  /// </summary>
  [DataContract(Name = "dictionarySettingsParams")]
  public partial class DictionarySettingsParams
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="DictionarySettingsParams" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DictionarySettingsParams() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DictionarySettingsParams" /> class.
    /// </summary>
    /// <param name="disableStandardEntries">disableStandardEntries (required).</param>
    public DictionarySettingsParams(StandardEntries disableStandardEntries = default(StandardEntries))
    {
      // to ensure "disableStandardEntries" is required (not null)
      if (disableStandardEntries == null)
      {
        throw new ArgumentNullException("disableStandardEntries is a required property for DictionarySettingsParams and cannot be null");
      }
      this.DisableStandardEntries = disableStandardEntries;
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
      sb.Append("class DictionarySettingsParams {\n");
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
