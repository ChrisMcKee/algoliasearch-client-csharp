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
/// Use this method to capture active filters. For example, when browsing a category page, users see content filtered on that specific category. 
/// </summary>
[DataContract(Name = "ViewedFilters")]
[JsonObject(MemberSerialization.OptOut)]
public partial class ViewedFilters
{

  /// <summary>
  /// Gets or Sets EventType
  /// </summary>
  [DataMember(Name = "eventType")]
  public ViewEvent EventType { get; set; }
  /// <summary>
  /// Initializes a new instance of the ViewedFilters class.
  /// </summary>
  [JsonConstructor]
  public ViewedFilters() { }
  /// <summary>
  /// Initializes a new instance of the ViewedFilters class.
  /// </summary>
  /// <param name="eventName">The name of the event, up to 64 ASCII characters.  Consider naming events consistently—for example, by adopting Segment&#39;s [object-action](https://segment.com/academy/collecting-data/naming-conventions-for-clean-data/#the-object-action-framework) framework.  (required).</param>
  /// <param name="eventType">eventType (required).</param>
  /// <param name="index">The name of an Algolia index. (required).</param>
  /// <param name="filters">Facet filters.  Each facet filter string must be URL-encoded, such as, &#x60;discount:10%25&#x60;.  (required).</param>
  /// <param name="userToken">An anonymous or pseudonymous user identifier.  &gt; **Note**: Never include personally identifiable information in user tokens.  (required).</param>
  public ViewedFilters(string eventName, ViewEvent eventType, string index, List<string> filters, string userToken)
  {
    EventName = eventName ?? throw new ArgumentNullException(nameof(eventName));
    EventType = eventType;
    Index = index ?? throw new ArgumentNullException(nameof(index));
    Filters = filters ?? throw new ArgumentNullException(nameof(filters));
    UserToken = userToken ?? throw new ArgumentNullException(nameof(userToken));
  }

  /// <summary>
  /// The name of the event, up to 64 ASCII characters.  Consider naming events consistently—for example, by adopting Segment's [object-action](https://segment.com/academy/collecting-data/naming-conventions-for-clean-data/#the-object-action-framework) framework. 
  /// </summary>
  /// <value>The name of the event, up to 64 ASCII characters.  Consider naming events consistently—for example, by adopting Segment's [object-action](https://segment.com/academy/collecting-data/naming-conventions-for-clean-data/#the-object-action-framework) framework. </value>
  [DataMember(Name = "eventName")]
  public string EventName { get; set; }

  /// <summary>
  /// The name of an Algolia index.
  /// </summary>
  /// <value>The name of an Algolia index.</value>
  [DataMember(Name = "index")]
  public string Index { get; set; }

  /// <summary>
  /// Facet filters.  Each facet filter string must be URL-encoded, such as, `discount:10%25`. 
  /// </summary>
  /// <value>Facet filters.  Each facet filter string must be URL-encoded, such as, `discount:10%25`. </value>
  [DataMember(Name = "filters")]
  public List<string> Filters { get; set; }

  /// <summary>
  /// An anonymous or pseudonymous user identifier.  > **Note**: Never include personally identifiable information in user tokens. 
  /// </summary>
  /// <value>An anonymous or pseudonymous user identifier.  > **Note**: Never include personally identifiable information in user tokens. </value>
  [DataMember(Name = "userToken")]
  public string UserToken { get; set; }

  /// <summary>
  /// An identifier for authenticated users.  > **Note**: Never include personally identifiable information in user tokens. 
  /// </summary>
  /// <value>An identifier for authenticated users.  > **Note**: Never include personally identifiable information in user tokens. </value>
  [DataMember(Name = "authenticatedUserToken")]
  public string AuthenticatedUserToken { get; set; }

  /// <summary>
  /// The timestamp of the event in milliseconds in [Unix epoch time](https://wikipedia.org/wiki/Unix_time). By default, the Insights API uses the time it receives an event as its timestamp. 
  /// </summary>
  /// <value>The timestamp of the event in milliseconds in [Unix epoch time](https://wikipedia.org/wiki/Unix_time). By default, the Insights API uses the time it receives an event as its timestamp. </value>
  [DataMember(Name = "timestamp")]
  public long? Timestamp { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class ViewedFilters {\n");
    sb.Append("  EventName: ").Append(EventName).Append("\n");
    sb.Append("  EventType: ").Append(EventType).Append("\n");
    sb.Append("  Index: ").Append(Index).Append("\n");
    sb.Append("  Filters: ").Append(Filters).Append("\n");
    sb.Append("  UserToken: ").Append(UserToken).Append("\n");
    sb.Append("  AuthenticatedUserToken: ").Append(AuthenticatedUserToken).Append("\n");
    sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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

