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
/// Type of authentication. This determines the type of credentials required in the `input` object.
/// </summary>
/// <value>Type of authentication. This determines the type of credentials required in the `input` object.</value>
public enum AuthenticationType
{
  /// <summary>
  /// Enum GoogleServiceAccount for value: googleServiceAccount
  /// </summary>
  [JsonPropertyName("googleServiceAccount")]
  GoogleServiceAccount = 1,

  /// <summary>
  /// Enum Basic for value: basic
  /// </summary>
  [JsonPropertyName("basic")]
  Basic = 2,

  /// <summary>
  /// Enum ApiKey for value: apiKey
  /// </summary>
  [JsonPropertyName("apiKey")]
  ApiKey = 3,

  /// <summary>
  /// Enum Oauth for value: oauth
  /// </summary>
  [JsonPropertyName("oauth")]
  Oauth = 4,

  /// <summary>
  /// Enum Algolia for value: algolia
  /// </summary>
  [JsonPropertyName("algolia")]
  Algolia = 5
}

