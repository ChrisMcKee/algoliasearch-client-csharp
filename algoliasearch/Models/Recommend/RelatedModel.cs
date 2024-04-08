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

namespace Algolia.Search.Models.Recommend;

/// <summary>
/// Related products or similar content model.  This model recommends items that are similar to the item with the ID `objectID`. Similarity is determined from the user interactions and attributes. 
/// </summary>
/// <value>Related products or similar content model.  This model recommends items that are similar to the item with the ID `objectID`. Similarity is determined from the user interactions and attributes. </value>
public enum RelatedModel
{
  /// <summary>
  /// Enum RelatedProducts for value: related-products
  /// </summary>
  [JsonPropertyName("related-products")]
  RelatedProducts = 1
}

