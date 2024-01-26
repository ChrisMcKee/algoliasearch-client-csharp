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

namespace Algolia.Search.Models.Monitoring;

/// <summary>
/// Status of the cluster.
/// </summary>
/// <value>Status of the cluster.</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum Status
{
  /// <summary>
  /// Enum Operational for value: operational
  /// </summary>
  [EnumMember(Value = "operational")]
  Operational = 1,

  /// <summary>
  /// Enum DegradedPerformance for value: degraded_performance
  /// </summary>
  [EnumMember(Value = "degraded_performance")]
  DegradedPerformance = 2,

  /// <summary>
  /// Enum PartialOutage for value: partial_outage
  /// </summary>
  [EnumMember(Value = "partial_outage")]
  PartialOutage = 3,

  /// <summary>
  /// Enum MajorOutage for value: major_outage
  /// </summary>
  [EnumMember(Value = "major_outage")]
  MajorOutage = 4
}

