/*
* Query Suggestions API
*
* The Query Suggestions API lets you manage your Query Suggestions configurations. Query Suggestions add new indices to your Algolia application with popular search queries, external suggestions, or facet values. In your user interface, you can query the Query Suggestions indices like regular indices and add [suggested searches](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/query-suggestions/js/) to guide users and speed up their search.  ## Base URLs  The base URLs for requests to the Query Suggestions API are:  - `https://query-suggestions.us.algolia.com` - `https://query-suggestions.eu.algolia.com`  Use the URL that matches your [analytics region](https://dashboard.algolia.com/account/infrastructure/analytics).  **All requests must use HTTPS.**  ## Authentication  To authenticate your API requests, add these headers:  - `x-algolia-application-id`. Your Algolia application ID. - `x-algolia-api-key`. An API key with the necessary permissions to make the request.   The required access control list (ACL) to make a request is listed in each endpoint's reference.  You can find your application ID and API key in the [Algolia dashboard](https://dashboard.algolia.com/account).  ## Request format  Request bodies must be JSON objects.  ## Response status and errors  Response bodies are JSON objects. Deleting a user token returns an empty response body with rate-limiting information as headers.  Successful responses return a `2xx` status. Client errors return a `4xx` status. Server errors are indicated by a `5xx` status. Error responses have a `message` property with more information.  ## Version  The current version of the Query Suggestions API is version 1, as indicated by the `/1/` in each endpoint's URL. 
*
* The version of the OpenAPI document: 1.0.0
* Generated by: https://github.com/openapitools/openapi-generator.git
*/


using System;
using System.Collections.Generic;
using Algolia.Search.Models.Common;
using Algolia.Search.Transport;
using Algolia.Search.Utils;

namespace Algolia.Search.Clients;

/// <summary>
/// QuerySuggestions client configuration
/// </summary>
public sealed class QuerySuggestionsConfig : AlgoliaConfig
{
  /// <summary>
  /// The configuration of the QuerySuggestions client
  /// A client should have it's own configuration ie on configuration per client instance
  /// </summary>
  /// <param name="appId">Your application ID</param>
  /// <param name="apiKey">Your API Key</param>
  /// <param name="region">Targeted region </param>
  public QuerySuggestionsConfig(string appId, string apiKey, string region) : base(appId, apiKey, "QuerySuggestions", "7.4.1")
  {
    DefaultHosts = GetDefaultHosts(region);
    Compression = CompressionType.None;
  }
  private static List<StatefulHost> GetDefaultHosts(string region)
  {
    var regions = new List<string> { "eu", "us" };
    if (region == null || !regions.Contains(region))
    {
      throw new ArgumentException($"`region` is required and must be one of the following: {string.Join(", ", regions)}");
    }

    var selectedRegion = "query-suggestions.{region}.algolia.com".Replace("{region}", region);

    var hosts = new List<StatefulHost>
  {
    new()
    {
      Url = selectedRegion, Accept = CallType.Read | CallType.Write
    }
  };
    return hosts;
  }
}
