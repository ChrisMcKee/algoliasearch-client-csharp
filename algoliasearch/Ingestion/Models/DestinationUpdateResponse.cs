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

namespace Algolia.Search.Models.Ingestion
{
  /// <summary>
  /// Response from the API when the Destination is successfully updated.
  /// </summary>
  [DataContract(Name = "DestinationUpdateResponse")]
  public partial class DestinationUpdateResponse
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="DestinationUpdateResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    public DestinationUpdateResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DestinationUpdateResponse" /> class.
    /// </summary>
    /// <param name="destinationID">The destination UUID. (required).</param>
    /// <param name="name">An human readable name describing the object. (required).</param>
    /// <param name="updatedAt">Date of last update (RFC3339 format). (required).</param>
    public DestinationUpdateResponse(string destinationID, string name, string updatedAt)
    {
      this.DestinationID = destinationID ?? throw new ArgumentNullException("destinationID is a required property for DestinationUpdateResponse and cannot be null");
      this.Name = name ?? throw new ArgumentNullException("name is a required property for DestinationUpdateResponse and cannot be null");
      this.UpdatedAt = updatedAt ?? throw new ArgumentNullException("updatedAt is a required property for DestinationUpdateResponse and cannot be null");
    }

    /// <summary>
    /// The destination UUID.
    /// </summary>
    /// <value>The destination UUID.</value>
    [DataMember(Name = "destinationID", IsRequired = true, EmitDefaultValue = true)]
    public string DestinationID { get; set; }

    /// <summary>
    /// An human readable name describing the object.
    /// </summary>
    /// <value>An human readable name describing the object.</value>
    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

    /// <summary>
    /// Date of last update (RFC3339 format).
    /// </summary>
    /// <value>Date of last update (RFC3339 format).</value>
    [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
    public string UpdatedAt { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class DestinationUpdateResponse {\n");
      sb.Append("  DestinationID: ").Append(DestinationID).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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