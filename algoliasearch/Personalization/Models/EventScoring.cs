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

namespace Algolia.Search.Personalization.Models
{
  /// <summary>
  /// EventScoring
  /// </summary>
  [DataContract(Name = "eventScoring")]
  public partial class EventScoring
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="EventScoring" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EventScoring() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EventScoring" /> class.
    /// </summary>
    /// <param name="score">The score for the event. (required).</param>
    /// <param name="eventName">The name of the event. (required).</param>
    /// <param name="eventType">The type of the event. (required).</param>
    public EventScoring(int score = default(int), string eventName = default(string), string eventType = default(string))
    {
      this.Score = score;
      // to ensure "eventName" is required (not null)
      if (eventName == null)
      {
        throw new ArgumentNullException("eventName is a required property for EventScoring and cannot be null");
      }
      this.EventName = eventName;
      // to ensure "eventType" is required (not null)
      if (eventType == null)
      {
        throw new ArgumentNullException("eventType is a required property for EventScoring and cannot be null");
      }
      this.EventType = eventType;
    }

    /// <summary>
    /// The score for the event.
    /// </summary>
    /// <value>The score for the event.</value>
    [DataMember(Name = "score", IsRequired = true, EmitDefaultValue = true)]
    public int Score { get; set; }

    /// <summary>
    /// The name of the event.
    /// </summary>
    /// <value>The name of the event.</value>
    [DataMember(Name = "eventName", IsRequired = true, EmitDefaultValue = true)]
    public string EventName { get; set; }

    /// <summary>
    /// The type of the event.
    /// </summary>
    /// <value>The type of the event.</value>
    [DataMember(Name = "eventType", IsRequired = true, EmitDefaultValue = true)]
    public string EventType { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class EventScoring {\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  EventName: ").Append(EventName).Append("\n");
      sb.Append("  EventType: ").Append(EventType).Append("\n");
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
