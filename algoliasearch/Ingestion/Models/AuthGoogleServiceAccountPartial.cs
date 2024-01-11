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
  /// Authentication input to connect to a Google service (e.g. BigQuery).
  /// </summary>
  [DataContract(Name = "AuthGoogleServiceAccountPartial")]
  public partial class AuthGoogleServiceAccountPartial
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthGoogleServiceAccountPartial" /> class.
    /// </summary>
    public AuthGoogleServiceAccountPartial()
    {
    }

    /// <summary>
    /// Email address of the Service Account.
    /// </summary>
    /// <value>Email address of the Service Account.</value>
    [DataMember(Name = "clientEmail", EmitDefaultValue = false)]
    public string ClientEmail { get; set; }

    /// <summary>
    /// Private key of the Service Account.
    /// </summary>
    /// <value>Private key of the Service Account.</value>
    [DataMember(Name = "privateKey", EmitDefaultValue = false)]
    public string PrivateKey { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class AuthGoogleServiceAccountPartial {\n");
      sb.Append("  ClientEmail: ").Append(ClientEmail).Append("\n");
      sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
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