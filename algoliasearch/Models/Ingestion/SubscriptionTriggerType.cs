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
/// A task which is triggered by an external subscription (e.g. Webhook).
/// </summary>
/// <value>A task which is triggered by an external subscription (e.g. Webhook).</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum SubscriptionTriggerType
{
  /// <summary>
  /// Enum Subscription for value: subscription
  /// </summary>
  [EnumMember(Value = "subscription")]
  Subscription = 1
}

