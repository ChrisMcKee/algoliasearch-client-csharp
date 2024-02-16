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

namespace Algolia.Search.Models.Monitoring;

/// <summary>
/// Status of the cluster.
/// </summary>
/// <value>Status of the cluster.</value>
public enum Status
{
  /// <summary>
  /// Enum Operational for value: operational
  /// </summary>
  [JsonPropertyName("operational")]
  Operational = 1,

  /// <summary>
  /// Enum DegradedPerformance for value: degraded_performance
  /// </summary>
  [JsonPropertyName("degraded_performance")]
  DegradedPerformance = 2,

  /// <summary>
  /// Enum PartialOutage for value: partial_outage
  /// </summary>
  [JsonPropertyName("partial_outage")]
  PartialOutage = 3,

  /// <summary>
  /// Enum MajorOutage for value: major_outage
  /// </summary>
  [JsonPropertyName("major_outage")]
  MajorOutage = 4
}

