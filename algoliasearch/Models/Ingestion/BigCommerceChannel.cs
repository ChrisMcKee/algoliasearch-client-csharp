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

namespace Algolia.Search.Models.Ingestion;

/// <summary>
/// BigCommerceChannel
/// </summary>
[DataContract(Name = "BigCommerceChannel")]
[JsonObject(MemberSerialization.OptOut)]
public partial class BigCommerceChannel
{
  /// <summary>
  /// Initializes a new instance of the BigCommerceChannel class.
  /// </summary>
  [JsonConstructor]
  public BigCommerceChannel() { }
  /// <summary>
  /// Initializes a new instance of the BigCommerceChannel class.
  /// </summary>
  /// <param name="id">The ID of the bigcommerce channel. (required).</param>
  public BigCommerceChannel(int? id)
  {
    Id = id;
  }

  /// <summary>
  /// The ID of the bigcommerce channel.
  /// </summary>
  /// <value>The ID of the bigcommerce channel.</value>
  [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
  public int? Id { get; set; }

  /// <summary>
  /// An array of currencies for the given channel `ID`, a currency is a trigram string that represents the currency code.
  /// </summary>
  /// <value>An array of currencies for the given channel `ID`, a currency is a trigram string that represents the currency code.</value>
  [DataMember(Name = "currencies", EmitDefaultValue = false)]
  public List<string> Currencies { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class BigCommerceChannel {\n");
    sb.Append("  Id: ").Append(Id).Append("\n");
    sb.Append("  Currencies: ").Append(Currencies).Append("\n");
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
