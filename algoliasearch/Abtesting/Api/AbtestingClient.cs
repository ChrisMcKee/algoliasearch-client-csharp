//
// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
//

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Algolia.Search.Clients;
using Algolia.Search.Models;
using Algolia.Search.Models.Abtesting;
using Algolia.Search.Transport;
using Algolia.Search.Http;

namespace Algolia.Search.Clients
{
  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public interface IAbtestingClient
  {
    /// <summary>
    /// Create an A/B test.
    /// </summary>
    /// <remarks>
    /// Creates an A/B test.
    /// </remarks>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="addABTestsRequest"></param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ABTestResponse</returns>
    Task<ABTestResponse> AddABTestsAsync(AddABTestsRequest addABTestsRequest, RequestOptions options = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Send requests to the Algolia REST API.
    /// </summary>
    /// <remarks>
    /// This method allow you to send requests to the Algolia REST API.
    /// </remarks>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="path">Path of the endpoint, anything after \"/1\" must be specified.</param>
    /// <param name="parameters">Query parameters to apply to the current query. (optional)</param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Object</returns>
    Task<Object> CustomDeleteAsync(string path, Dictionary<string, Object> parameters = default, RequestOptions options = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Send requests to the Algolia REST API.
    /// </summary>
    /// <remarks>
    /// This method allow you to send requests to the Algolia REST API.
    /// </remarks>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="path">Path of the endpoint, anything after \"/1\" must be specified.</param>
    /// <param name="parameters">Query parameters to apply to the current query. (optional)</param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Object</returns>
    Task<Object> CustomGetAsync(string path, Dictionary<string, Object> parameters = default, RequestOptions options = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Send requests to the Algolia REST API.
    /// </summary>
    /// <remarks>
    /// This method allow you to send requests to the Algolia REST API.
    /// </remarks>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="path">Path of the endpoint, anything after \"/1\" must be specified.</param>
    /// <param name="parameters">Query parameters to apply to the current query. (optional)</param>
    /// <param name="body">Parameters to send with the custom request. (optional)</param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Object</returns>
    Task<Object> CustomPostAsync(string path, Dictionary<string, Object> parameters = default, Object body = default, RequestOptions options = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Send requests to the Algolia REST API.
    /// </summary>
    /// <remarks>
    /// This method allow you to send requests to the Algolia REST API.
    /// </remarks>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="path">Path of the endpoint, anything after \"/1\" must be specified.</param>
    /// <param name="parameters">Query parameters to apply to the current query. (optional)</param>
    /// <param name="body">Parameters to send with the custom request. (optional)</param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Object</returns>
    Task<Object> CustomPutAsync(string path, Dictionary<string, Object> parameters = default, Object body = default, RequestOptions options = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Delete an A/B test.
    /// </summary>
    /// <remarks>
    /// Delete an A/B test. To determine the `id` for an A/B test, use the [`listABTests` operation](#tag/abtest/operation/listABTests). 
    /// </remarks>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Unique A/B test ID.</param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ABTestResponse</returns>
    Task<ABTestResponse> DeleteABTestAsync(int id, RequestOptions options = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get A/B test details.
    /// </summary>
    /// <remarks>
    /// Get specific details for an A/B test. To determine the `id` for an A/B test, use the [`listABTests` operation](#tag/abtest/operation/listABTests). 
    /// </remarks>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Unique A/B test ID.</param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ABTest</returns>
    Task<ABTest> GetABTestAsync(int id, RequestOptions options = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// List all A/B tests.
    /// </summary>
    /// <remarks>
    /// List all A/B tests.
    /// </remarks>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="offset">Position of the starting record. Used for paging. 0 is the first record. (optional, default to 0)</param>
    /// <param name="limit">Number of records to return (page size). (optional, default to 10)</param>
    /// <param name="indexPrefix">Only return A/B tests for indices starting with this prefix. (optional)</param>
    /// <param name="indexSuffix">Only return A/B tests for indices ending with this suffix. (optional)</param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ListABTestsResponse</returns>
    Task<ListABTestsResponse> ListABTestsAsync(int? offset = default, int? limit = default, string indexPrefix = default, string indexSuffix = default, RequestOptions options = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Stop an A/B test.
    /// </summary>
    /// <remarks>
    /// If stopped, the test is over and can't be restarted. There is now only one index, receiving 100% of all search requests. The data gathered for stopped A/B tests is retained. To determine the `id` for an A/B test, use the [`listABTests` operation](#tag/abtest/operation/listABTests). 
    /// </remarks>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Unique A/B test ID.</param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ABTestResponse</returns>
    Task<ABTestResponse> StopABTestAsync(int id, RequestOptions options = null, CancellationToken cancellationToken = default);
  }


  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public partial class AbtestingClient : IAbtestingClient
  {
    private readonly HttpTransport _transport;
    private readonly AlgoliaConfig _config;

    /// <summary>
    /// Create a new Abtesting client for the given appID and apiKey.
    /// </summary>
    /// <param name="applicationId">Your application</param>
    /// <param name="apiKey">Your API key</param>
    /// <param name="region">The targeted region</param>
    public AbtestingClient(string applicationId, string apiKey, string region = null) : this(new AbtestingConfig(applicationId, apiKey, region), new AlgoliaHttpRequester())
    {
    }

    /// <summary>
    /// Initialize a client with custom config
    /// </summary>
    /// <param name="config">Algolia configuration</param>
    public AbtestingClient(AbtestingConfig config) : this(config, new AlgoliaHttpRequester())
    {
    }

    /// <summary>
    /// Initialize the client with custom config and custom Requester
    /// </summary>
    /// <param name="config">Algolia Config</param>
    /// <param name="httpRequester">Your Http requester implementation of <see cref="IHttpRequester"/></param>
    public AbtestingClient(AbtestingConfig config, IHttpRequester httpRequester)
    {
      if (httpRequester == null)
      {
        throw new ArgumentNullException(nameof(httpRequester), "An httpRequester is required");
      }
      if (config == null)
      {
        throw new ArgumentNullException(nameof(config), "A config is required");
      }
      if (string.IsNullOrWhiteSpace(config.AppId))
      {
        throw new ArgumentNullException(nameof(config.AppId), "Application ID is required");
      }
      if (string.IsNullOrWhiteSpace(config.ApiKey))
      {
        throw new ArgumentNullException(nameof(config.ApiKey), "An API key is required");
      }

      _config = config;
      _transport = new HttpTransport(config, httpRequester);
    }


    /// <summary>
    /// Create an A/B test. Creates an A/B test.
    /// </summary>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="addABTestsRequest"></param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ABTestResponse</returns>
    public async Task<ABTestResponse> AddABTestsAsync(AddABTestsRequest addABTestsRequest, RequestOptions options = null, CancellationToken cancellationToken = default)
    {
      if (addABTestsRequest == null)
        throw new ApiException(400, "Missing required parameter 'addABTestsRequest' when calling AbtestingClient->AddABTests");

      var requestOptions = new InternalRequestOptions(options);


      requestOptions.Data = addABTestsRequest;
      return await _transport.ExecuteRequestAsync<ABTestResponse>(new HttpMethod("POST"), "/2/abtests", requestOptions, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Send requests to the Algolia REST API. This method allow you to send requests to the Algolia REST API.
    /// </summary>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="path">Path of the endpoint, anything after \&quot;/1\&quot; must be specified.</param>
    /// <param name="parameters">Query parameters to apply to the current query. (optional)</param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Object</returns>
    public async Task<Object> CustomDeleteAsync(string path, Dictionary<string, Object> parameters = default, RequestOptions options = null, CancellationToken cancellationToken = default)
    {
      if (path == null)
        throw new ApiException(400, "Missing required parameter 'path' when calling AbtestingClient->CustomDelete");

      var requestOptions = new InternalRequestOptions(options);
      requestOptions.CustomPathParameters.Add("path", ClientUtils.ParameterToString(path));

      requestOptions.AddCustomQueryParameters(parameters);
      return await _transport.ExecuteRequestAsync<Object>(new HttpMethod("DELETE"), "/1{path}", requestOptions, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Send requests to the Algolia REST API. This method allow you to send requests to the Algolia REST API.
    /// </summary>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="path">Path of the endpoint, anything after \&quot;/1\&quot; must be specified.</param>
    /// <param name="parameters">Query parameters to apply to the current query. (optional)</param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Object</returns>
    public async Task<Object> CustomGetAsync(string path, Dictionary<string, Object> parameters = default, RequestOptions options = null, CancellationToken cancellationToken = default)
    {
      if (path == null)
        throw new ApiException(400, "Missing required parameter 'path' when calling AbtestingClient->CustomGet");

      var requestOptions = new InternalRequestOptions(options);
      requestOptions.CustomPathParameters.Add("path", ClientUtils.ParameterToString(path));

      requestOptions.AddCustomQueryParameters(parameters);
      return await _transport.ExecuteRequestAsync<Object>(new HttpMethod("GET"), "/1{path}", requestOptions, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Send requests to the Algolia REST API. This method allow you to send requests to the Algolia REST API.
    /// </summary>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="path">Path of the endpoint, anything after \&quot;/1\&quot; must be specified.</param>
    /// <param name="parameters">Query parameters to apply to the current query. (optional)</param>
    /// <param name="body">Parameters to send with the custom request. (optional)</param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Object</returns>
    public async Task<Object> CustomPostAsync(string path, Dictionary<string, Object> parameters = default, Object body = default, RequestOptions options = null, CancellationToken cancellationToken = default)
    {
      if (path == null)
        throw new ApiException(400, "Missing required parameter 'path' when calling AbtestingClient->CustomPost");

      var requestOptions = new InternalRequestOptions(options);
      requestOptions.CustomPathParameters.Add("path", ClientUtils.ParameterToString(path));

      requestOptions.AddCustomQueryParameters(parameters);
      requestOptions.Data = body;
      return await _transport.ExecuteRequestAsync<Object>(new HttpMethod("POST"), "/1{path}", requestOptions, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Send requests to the Algolia REST API. This method allow you to send requests to the Algolia REST API.
    /// </summary>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="path">Path of the endpoint, anything after \&quot;/1\&quot; must be specified.</param>
    /// <param name="parameters">Query parameters to apply to the current query. (optional)</param>
    /// <param name="body">Parameters to send with the custom request. (optional)</param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Object</returns>
    public async Task<Object> CustomPutAsync(string path, Dictionary<string, Object> parameters = default, Object body = default, RequestOptions options = null, CancellationToken cancellationToken = default)
    {
      if (path == null)
        throw new ApiException(400, "Missing required parameter 'path' when calling AbtestingClient->CustomPut");

      var requestOptions = new InternalRequestOptions(options);
      requestOptions.CustomPathParameters.Add("path", ClientUtils.ParameterToString(path));

      requestOptions.AddCustomQueryParameters(parameters);
      requestOptions.Data = body;
      return await _transport.ExecuteRequestAsync<Object>(new HttpMethod("PUT"), "/1{path}", requestOptions, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete an A/B test. Delete an A/B test. To determine the &#x60;id&#x60; for an A/B test, use the [&#x60;listABTests&#x60; operation](#tag/abtest/operation/listABTests). 
    /// </summary>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Unique A/B test ID.</param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ABTestResponse</returns>
    public async Task<ABTestResponse> DeleteABTestAsync(int id, RequestOptions options = null, CancellationToken cancellationToken = default)
    {
      var requestOptions = new InternalRequestOptions(options);

      requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id));

      return await _transport.ExecuteRequestAsync<ABTestResponse>(new HttpMethod("DELETE"), "/2/abtests/{id}", requestOptions, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Get A/B test details. Get specific details for an A/B test. To determine the &#x60;id&#x60; for an A/B test, use the [&#x60;listABTests&#x60; operation](#tag/abtest/operation/listABTests). 
    /// </summary>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Unique A/B test ID.</param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ABTest</returns>
    public async Task<ABTest> GetABTestAsync(int id, RequestOptions options = null, CancellationToken cancellationToken = default)
    {
      var requestOptions = new InternalRequestOptions(options);

      requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id));

      return await _transport.ExecuteRequestAsync<ABTest>(new HttpMethod("GET"), "/2/abtests/{id}", requestOptions, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// List all A/B tests. List all A/B tests.
    /// </summary>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="offset">Position of the starting record. Used for paging. 0 is the first record. (optional, default to 0)</param>
    /// <param name="limit">Number of records to return (page size). (optional, default to 10)</param>
    /// <param name="indexPrefix">Only return A/B tests for indices starting with this prefix. (optional)</param>
    /// <param name="indexSuffix">Only return A/B tests for indices ending with this suffix. (optional)</param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ListABTestsResponse</returns>
    public async Task<ListABTestsResponse> ListABTestsAsync(int? offset = default, int? limit = default, string indexPrefix = default, string indexSuffix = default, RequestOptions options = null, CancellationToken cancellationToken = default)
    {
      var requestOptions = new InternalRequestOptions(options);


      requestOptions.AddQueryParameter("offset", offset);
      requestOptions.AddQueryParameter("limit", limit);
      requestOptions.AddQueryParameter("indexPrefix", indexPrefix);
      requestOptions.AddQueryParameter("indexSuffix", indexSuffix);
      return await _transport.ExecuteRequestAsync<ListABTestsResponse>(new HttpMethod("GET"), "/2/abtests", requestOptions, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Stop an A/B test. If stopped, the test is over and can&#39;t be restarted. There is now only one index, receiving 100% of all search requests. The data gathered for stopped A/B tests is retained. To determine the &#x60;id&#x60; for an A/B test, use the [&#x60;listABTests&#x60; operation](#tag/abtest/operation/listABTests). 
    /// </summary>
    /// <exception cref="Algolia.Search.Abtesting.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Unique A/B test ID.</param>
    /// <param name="options">Add extra http header or query parameters to Algolia.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ABTestResponse</returns>
    public async Task<ABTestResponse> StopABTestAsync(int id, RequestOptions options = null, CancellationToken cancellationToken = default)
    {
      var requestOptions = new InternalRequestOptions(options);

      requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id));

      return await _transport.ExecuteRequestAsync<ABTestResponse>(new HttpMethod("POST"), "/2/abtests/{id}/stop", requestOptions, cancellationToken).ConfigureAwait(false);
    }
  }
}