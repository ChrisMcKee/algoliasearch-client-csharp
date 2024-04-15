//
// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
//
using System;
using System.Text;
using System.Linq;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Algolia.Search.Serializer;
using System.Text.Json;

namespace Algolia.Search.Models.Insights;

/// <summary>
/// Use this event to track when users convert after a previous Algolia request. For example, a user clicks on an item in the search results to view the product detail page. Then, the user adds the item to their shopping cart.  If you're building your category pages with Algolia, you'll also use this event. 
/// </summary>
public partial class ConvertedObjectIDsAfterSearch
{

  /// <summary>
  /// Gets or Sets EventType
  /// </summary>
  [JsonPropertyName("eventType")]
  public ConversionEvent? EventType { get; set; }
  /// <summary>
  /// Initializes a new instance of the ConvertedObjectIDsAfterSearch class.
  /// </summary>
  [JsonConstructor]
  public ConvertedObjectIDsAfterSearch() { }
  /// <summary>
  /// Initializes a new instance of the ConvertedObjectIDsAfterSearch class.
  /// </summary>
  /// <param name="eventName">Event name, up to 64 ASCII characters.  Consider naming events consistently—for example, by adopting Segment&#39;s [object-action](https://segment.com/academy/collecting-data/naming-conventions-for-clean-data/#the-object-action-framework) framework.  (required).</param>
  /// <param name="eventType">eventType (required).</param>
  /// <param name="index">Index name (case-sensitive) to which the event&#39;s items belong. (required).</param>
  /// <param name="objectIDs">Object IDs of the records that are part of the event. (required).</param>
  /// <param name="queryID">Unique identifier for a search query.  The query ID is required for events related to search or browse requests. If you add &#x60;clickAnalytics: true&#x60; as a search request parameter, the query ID is included in the API response.  (required).</param>
  /// <param name="userToken">Anonymous or pseudonymous user identifier.  Don&#39;t use personally identifiable information in user tokens. For more information, see [User token](https://www.algolia.com/doc/guides/sending-events/concepts/usertoken/).  (required).</param>
  public ConvertedObjectIDsAfterSearch(string eventName, ConversionEvent? eventType, string index, List<string> objectIDs, string queryID, string userToken)
  {
    EventName = eventName ?? throw new ArgumentNullException(nameof(eventName));
    EventType = eventType;
    Index = index ?? throw new ArgumentNullException(nameof(index));
    ObjectIDs = objectIDs ?? throw new ArgumentNullException(nameof(objectIDs));
    QueryID = queryID ?? throw new ArgumentNullException(nameof(queryID));
    UserToken = userToken ?? throw new ArgumentNullException(nameof(userToken));
  }

  /// <summary>
  /// Event name, up to 64 ASCII characters.  Consider naming events consistently—for example, by adopting Segment's [object-action](https://segment.com/academy/collecting-data/naming-conventions-for-clean-data/#the-object-action-framework) framework. 
  /// </summary>
  /// <value>Event name, up to 64 ASCII characters.  Consider naming events consistently—for example, by adopting Segment's [object-action](https://segment.com/academy/collecting-data/naming-conventions-for-clean-data/#the-object-action-framework) framework. </value>
  [JsonPropertyName("eventName")]
  public string EventName { get; set; }

  /// <summary>
  /// Index name (case-sensitive) to which the event's items belong.
  /// </summary>
  /// <value>Index name (case-sensitive) to which the event's items belong.</value>
  [JsonPropertyName("index")]
  public string Index { get; set; }

  /// <summary>
  /// Object IDs of the records that are part of the event.
  /// </summary>
  /// <value>Object IDs of the records that are part of the event.</value>
  [JsonPropertyName("objectIDs")]
  public List<string> ObjectIDs { get; set; }

  /// <summary>
  /// Unique identifier for a search query.  The query ID is required for events related to search or browse requests. If you add `clickAnalytics: true` as a search request parameter, the query ID is included in the API response. 
  /// </summary>
  /// <value>Unique identifier for a search query.  The query ID is required for events related to search or browse requests. If you add `clickAnalytics: true` as a search request parameter, the query ID is included in the API response. </value>
  [JsonPropertyName("queryID")]
  public string QueryID { get; set; }

  /// <summary>
  /// Anonymous or pseudonymous user identifier.  Don't use personally identifiable information in user tokens. For more information, see [User token](https://www.algolia.com/doc/guides/sending-events/concepts/usertoken/). 
  /// </summary>
  /// <value>Anonymous or pseudonymous user identifier.  Don't use personally identifiable information in user tokens. For more information, see [User token](https://www.algolia.com/doc/guides/sending-events/concepts/usertoken/). </value>
  [JsonPropertyName("userToken")]
  public string UserToken { get; set; }

  /// <summary>
  /// Identifier for authenticated users.  When the user signs in, you can get an identifier from your system and send it as `authenticatedUserToken`. This lets you keep using the `userToken` from before the user signed in, while providing a reliable way to identify users across sessions. Don't use personally identifiable information in user tokens. For more information, see [User token](https://www.algolia.com/doc/guides/sending-events/concepts/usertoken/). 
  /// </summary>
  /// <value>Identifier for authenticated users.  When the user signs in, you can get an identifier from your system and send it as `authenticatedUserToken`. This lets you keep using the `userToken` from before the user signed in, while providing a reliable way to identify users across sessions. Don't use personally identifiable information in user tokens. For more information, see [User token](https://www.algolia.com/doc/guides/sending-events/concepts/usertoken/). </value>
  [JsonPropertyName("authenticatedUserToken")]
  public string AuthenticatedUserToken { get; set; }

  /// <summary>
  /// Timestamp of the event, measured in milliseconds since the Unix epoch. By default, the Insights API uses the time it receives an event as its timestamp. 
  /// </summary>
  /// <value>Timestamp of the event, measured in milliseconds since the Unix epoch. By default, the Insights API uses the time it receives an event as its timestamp. </value>
  [JsonPropertyName("timestamp")]
  public long? Timestamp { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class ConvertedObjectIDsAfterSearch {\n");
    sb.Append("  EventName: ").Append(EventName).Append("\n");
    sb.Append("  EventType: ").Append(EventType).Append("\n");
    sb.Append("  Index: ").Append(Index).Append("\n");
    sb.Append("  ObjectIDs: ").Append(ObjectIDs).Append("\n");
    sb.Append("  QueryID: ").Append(QueryID).Append("\n");
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
    return JsonSerializer.Serialize(this, JsonConfig.Options);
  }

  /// <summary>
  /// Returns true if objects are equal
  /// </summary>
  /// <param name="obj">Object to be compared</param>
  /// <returns>Boolean</returns>
  public override bool Equals(object obj)
  {
    if (obj is not ConvertedObjectIDsAfterSearch input)
    {
      return false;
    }

    return
        (EventName == input.EventName || (EventName != null && EventName.Equals(input.EventName))) &&
        (EventType == input.EventType || EventType.Equals(input.EventType)) &&
        (Index == input.Index || (Index != null && Index.Equals(input.Index))) &&
        (ObjectIDs == input.ObjectIDs || ObjectIDs != null && input.ObjectIDs != null && ObjectIDs.SequenceEqual(input.ObjectIDs)) &&
        (QueryID == input.QueryID || (QueryID != null && QueryID.Equals(input.QueryID))) &&
        (UserToken == input.UserToken || (UserToken != null && UserToken.Equals(input.UserToken))) &&
        (AuthenticatedUserToken == input.AuthenticatedUserToken || (AuthenticatedUserToken != null && AuthenticatedUserToken.Equals(input.AuthenticatedUserToken))) &&
        (Timestamp == input.Timestamp || Timestamp.Equals(input.Timestamp));
  }

  /// <summary>
  /// Gets the hash code
  /// </summary>
  /// <returns>Hash code</returns>
  public override int GetHashCode()
  {
    unchecked // Overflow is fine, just wrap
    {
      int hashCode = 41;
      if (EventName != null)
      {
        hashCode = (hashCode * 59) + EventName.GetHashCode();
      }
      hashCode = (hashCode * 59) + EventType.GetHashCode();
      if (Index != null)
      {
        hashCode = (hashCode * 59) + Index.GetHashCode();
      }
      if (ObjectIDs != null)
      {
        hashCode = (hashCode * 59) + ObjectIDs.GetHashCode();
      }
      if (QueryID != null)
      {
        hashCode = (hashCode * 59) + QueryID.GetHashCode();
      }
      if (UserToken != null)
      {
        hashCode = (hashCode * 59) + UserToken.GetHashCode();
      }
      if (AuthenticatedUserToken != null)
      {
        hashCode = (hashCode * 59) + AuthenticatedUserToken.GetHashCode();
      }
      hashCode = (hashCode * 59) + Timestamp.GetHashCode();
      return hashCode;
    }
  }

}

