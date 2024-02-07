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

namespace Algolia.Search.Models.Insights;

/// <summary>
/// ObjectData
/// </summary>
[DataContract(Name = "objectData")]
[JsonObject(MemberSerialization.OptOut)]
public partial class ObjectData
{
  /// <summary>
  /// Initializes a new instance of the ObjectData class.
  /// </summary>
  public ObjectData()
  {
  }

  /// <summary>
  /// Gets or Sets Price
  /// </summary>
  [DataMember(Name = "price")]
  public Price? Price { get; set; }

  /// <summary>
  /// The quantity of a product that has been purchased or added to the cart. The total value of a purchase is the sum of `quantity` multiplied with the `price` for each purchased item. 
  /// </summary>
  /// <value>The quantity of a product that has been purchased or added to the cart. The total value of a purchase is the sum of `quantity` multiplied with the `price` for each purchased item. </value>
  [DataMember(Name = "quantity")]
  public int? Quantity { get; set; }

  /// <summary>
  /// Gets or Sets Discount
  /// </summary>
  [DataMember(Name = "discount")]
  public Discount? Discount { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class ObjectData {\n");
    sb.Append("  Price: ").Append(Price).Append("\n");
    sb.Append("  Quantity: ").Append(Quantity).Append("\n");
    sb.Append("  Discount: ").Append(Discount).Append("\n");
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

