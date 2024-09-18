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

namespace Algolia.Search.Models.Ingestion;

/// <summary>
/// Authentication resource not tied to any ecommerce platform, used for filtering.
/// </summary>
/// <value>Authentication resource not tied to any ecommerce platform, used for filtering.</value>
[JsonConverter(typeof(Serializer.JsonStringEnumConverter<PlatformNone>))]
public enum PlatformNone
{
  /// <summary>
  /// Enum None for value: none
  /// </summary>
  [JsonPropertyName("none")]
  None = 1
}

