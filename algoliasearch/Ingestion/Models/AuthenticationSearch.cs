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
  /// Payload to search for multiple authentications, based on the given &#x60;authenticationIDs&#x60;.
  /// </summary>
  [DataContract(Name = "AuthenticationSearch")]
  public partial class AuthenticationSearch
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthenticationSearch" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    public AuthenticationSearch() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthenticationSearch" /> class.
    /// </summary>
    /// <param name="authenticationIDs">authenticationIDs (required).</param>
    public AuthenticationSearch(List<string> authenticationIDs)
    {
      this.AuthenticationIDs = authenticationIDs ?? throw new ArgumentNullException("authenticationIDs is a required property for AuthenticationSearch and cannot be null");
    }

    /// <summary>
    /// Gets or Sets AuthenticationIDs
    /// </summary>
    [DataMember(Name = "authenticationIDs", IsRequired = true, EmitDefaultValue = true)]
    public List<string> AuthenticationIDs { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class AuthenticationSearch {\n");
      sb.Append("  AuthenticationIDs: ").Append(AuthenticationIDs).Append("\n");
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