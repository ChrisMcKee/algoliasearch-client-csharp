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
/// API key object.
/// </summary>
[DataContract(Name = "apiKey")]
[JsonObject(MemberSerialization.OptOut)]
public partial class ApiKey
{
  /// <summary>
  /// Initializes a new instance of the ApiKey class.
  /// </summary>
  [JsonConstructor]
  public ApiKey() { }
  /// <summary>
  /// Initializes a new instance of the ApiKey class.
  /// </summary>
  /// <param name="acl">[Permissions](https://www.algolia.com/doc/guides/security/api-keys/#access-control-list-acl) associated with the key.  (required).</param>
  public ApiKey(List<Acl> acl)
  {
    Acl = acl ?? throw new ArgumentNullException(nameof(acl));
  }

  /// <summary>
  /// [Permissions](https://www.algolia.com/doc/guides/security/api-keys/#access-control-list-acl) associated with the key. 
  /// </summary>
  /// <value>[Permissions](https://www.algolia.com/doc/guides/security/api-keys/#access-control-list-acl) associated with the key. </value>
  [DataMember(Name = "acl")]
  public List<Acl> Acl { get; set; }

  /// <summary>
  /// Description of an API key for you and your team members.
  /// </summary>
  /// <value>Description of an API key for you and your team members.</value>
  [DataMember(Name = "description")]
  public string Description { get; set; }

  /// <summary>
  /// Restricts this API key to a list of indices or index patterns. If the list is empty, all indices are allowed. Specify either an exact index name or a pattern with a leading or trailing wildcard character (or both). For example: - `dev_*` matches all indices starting with \"dev_\" - `*_dev` matches all indices ending with \"_dev\" - `*_products_*` matches all indices containing \"_products_\". 
  /// </summary>
  /// <value>Restricts this API key to a list of indices or index patterns. If the list is empty, all indices are allowed. Specify either an exact index name or a pattern with a leading or trailing wildcard character (or both). For example: - `dev_*` matches all indices starting with \"dev_\" - `*_dev` matches all indices ending with \"_dev\" - `*_products_*` matches all indices containing \"_products_\". </value>
  [DataMember(Name = "indexes")]
  public List<string> Indexes { get; set; }

  /// <summary>
  /// Maximum number of hits this API key can retrieve in one query. If zero, no limit is enforced. > **Note**: Use this parameter to protect you from third-party attempts to retrieve your entire content by massively querying the index. 
  /// </summary>
  /// <value>Maximum number of hits this API key can retrieve in one query. If zero, no limit is enforced. > **Note**: Use this parameter to protect you from third-party attempts to retrieve your entire content by massively querying the index. </value>
  [DataMember(Name = "maxHitsPerQuery")]
  public int? MaxHitsPerQuery { get; set; }

  /// <summary>
  /// Maximum number of API calls per hour allowed from a given IP address or [user token](https://www.algolia.com/doc/guides/sending-events/concepts/usertoken/). Each time an API call is performed with this key, a check is performed. If there were more than the specified number of calls within the last hour, the API returns an error with the status code `429` (Too Many Requests).  > **Note**: Use this parameter to protect you from third-party attempts to retrieve your entire content by massively querying the index. 
  /// </summary>
  /// <value>Maximum number of API calls per hour allowed from a given IP address or [user token](https://www.algolia.com/doc/guides/sending-events/concepts/usertoken/). Each time an API call is performed with this key, a check is performed. If there were more than the specified number of calls within the last hour, the API returns an error with the status code `429` (Too Many Requests).  > **Note**: Use this parameter to protect you from third-party attempts to retrieve your entire content by massively querying the index. </value>
  [DataMember(Name = "maxQueriesPerIPPerHour")]
  public int? MaxQueriesPerIPPerHour { get; set; }

  /// <summary>
  /// Force some [query parameters](https://www.algolia.com/doc/api-reference/api-parameters/) to be applied for each query made with this API key. It's a URL-encoded query string. 
  /// </summary>
  /// <value>Force some [query parameters](https://www.algolia.com/doc/api-reference/api-parameters/) to be applied for each query made with this API key. It's a URL-encoded query string. </value>
  [DataMember(Name = "queryParameters")]
  public string QueryParameters { get; set; }

  /// <summary>
  /// Restrict this API key to specific [referrers](https://www.algolia.com/doc/guides/security/api-keys/in-depth/api-key-restrictions/#http-referrers). If empty, all referrers are allowed. For example: - `https://algolia.com/_*` matches all referrers starting with \"https://algolia.com/\" - `*.algolia.com` matches all referrers ending with \".algolia.com\" - `*algolia.com*` allows everything in the domain \"algolia.com\". 
  /// </summary>
  /// <value>Restrict this API key to specific [referrers](https://www.algolia.com/doc/guides/security/api-keys/in-depth/api-key-restrictions/#http-referrers). If empty, all referrers are allowed. For example: - `https://algolia.com/_*` matches all referrers starting with \"https://algolia.com/\" - `*.algolia.com` matches all referrers ending with \".algolia.com\" - `*algolia.com*` allows everything in the domain \"algolia.com\". </value>
  [DataMember(Name = "referers")]
  public List<string> Referers { get; set; }

  /// <summary>
  /// Validity duration of a key (in seconds).  The key will automatically be removed after this time has expired. The default value of 0 never expires. Short-lived API keys are useful to grant temporary access to your data. For example, in mobile apps, you can't [control when users update your app](https://www.algolia.com/doc/guides/security/security-best-practices/#use-secured-api-keys-in-mobile-apps). So instead of encoding keys into your app as you would for a web app, you should dynamically fetch them from your mobile app's backend. 
  /// </summary>
  /// <value>Validity duration of a key (in seconds).  The key will automatically be removed after this time has expired. The default value of 0 never expires. Short-lived API keys are useful to grant temporary access to your data. For example, in mobile apps, you can't [control when users update your app](https://www.algolia.com/doc/guides/security/security-best-practices/#use-secured-api-keys-in-mobile-apps). So instead of encoding keys into your app as you would for a web app, you should dynamically fetch them from your mobile app's backend. </value>
  [DataMember(Name = "validity")]
  public int? Validity { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class ApiKey {\n");
    sb.Append("  Acl: ").Append(Acl).Append("\n");
    sb.Append("  Description: ").Append(Description).Append("\n");
    sb.Append("  Indexes: ").Append(Indexes).Append("\n");
    sb.Append("  MaxHitsPerQuery: ").Append(MaxHitsPerQuery).Append("\n");
    sb.Append("  MaxQueriesPerIPPerHour: ").Append(MaxQueriesPerIPPerHour).Append("\n");
    sb.Append("  QueryParameters: ").Append(QueryParameters).Append("\n");
    sb.Append("  Referers: ").Append(Referers).Append("\n");
    sb.Append("  Validity: ").Append(Validity).Append("\n");
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

