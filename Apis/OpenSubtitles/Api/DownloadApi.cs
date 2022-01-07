/*
 * OpenSubtitles API
 *
 * Explore subtitles API here
 *
 * The version of the OpenAPI document: 1.0.1
 * Contact: support@opensubtitles.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using OpenSubtitles.Client;
using OpenSubtitles.Model;

namespace OpenSubtitles.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDownloadApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Download
        /// </summary>
        /// <remarks>
        /// Request a download url for a subtitle.    &gt; The download count is calculated on this action, not the file download itself  &gt; IN and OUT FPS must be indicated for subtitle conversions, we want to make sure you know what you are doing, and therefore collected the current FPS from the subtitle search result, or calculated it somehow.  &lt;!- - theme: warning - -&gt;  &gt; The download URL is temporary, and cannot be used more than 3 hours, so do not cache it, but you can download the file more than once if needed.
        /// </remarks>
        /// <exception cref="OpenSubtitles.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">application/json</param>
        /// <param name="body"> (optional)</param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 Download (string contentType, InlineObject1 body = default(InlineObject1));

        /// <summary>
        /// Download
        /// </summary>
        /// <remarks>
        /// Request a download url for a subtitle.    &gt; The download count is calculated on this action, not the file download itself  &gt; IN and OUT FPS must be indicated for subtitle conversions, we want to make sure you know what you are doing, and therefore collected the current FPS from the subtitle search result, or calculated it somehow.  &lt;!- - theme: warning - -&gt;  &gt; The download URL is temporary, and cannot be used more than 3 hours, so do not cache it, but you can download the file more than once if needed.
        /// </remarks>
        /// <exception cref="OpenSubtitles.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">application/json</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of InlineResponse2008</returns>
        ApiResponse<InlineResponse2008> DownloadWithHttpInfo (string contentType, InlineObject1 body = default(InlineObject1));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Download
        /// </summary>
        /// <remarks>
        /// Request a download url for a subtitle.    &gt; The download count is calculated on this action, not the file download itself  &gt; IN and OUT FPS must be indicated for subtitle conversions, we want to make sure you know what you are doing, and therefore collected the current FPS from the subtitle search result, or calculated it somehow.  &lt;!- - theme: warning - -&gt;  &gt; The download URL is temporary, and cannot be used more than 3 hours, so do not cache it, but you can download the file more than once if needed.
        /// </remarks>
        /// <exception cref="OpenSubtitles.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">application/json</param>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InlineResponse2008</returns>
        System.Threading.Tasks.Task<InlineResponse2008> DownloadAsync (string contentType, InlineObject1 body = default(InlineObject1), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Download
        /// </summary>
        /// <remarks>
        /// Request a download url for a subtitle.    &gt; The download count is calculated on this action, not the file download itself  &gt; IN and OUT FPS must be indicated for subtitle conversions, we want to make sure you know what you are doing, and therefore collected the current FPS from the subtitle search result, or calculated it somehow.  &lt;!- - theme: warning - -&gt;  &gt; The download URL is temporary, and cannot be used more than 3 hours, so do not cache it, but you can download the file more than once if needed.
        /// </remarks>
        /// <exception cref="OpenSubtitles.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">application/json</param>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InlineResponse2008)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2008>> DownloadWithHttpInfoAsync (string contentType, InlineObject1 body = default(InlineObject1), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DownloadApi : IDownloadApi
    {
        private OpenSubtitles.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DownloadApi(String basePath)
        {
            this.Configuration = new OpenSubtitles.Client.Configuration { BasePath = basePath };

            ExceptionFactory = OpenSubtitles.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadApi"/> class
        /// </summary>
        /// <returns></returns>
        public DownloadApi()
        {
            this.Configuration = OpenSubtitles.Client.Configuration.Default;

            ExceptionFactory = OpenSubtitles.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DownloadApi(OpenSubtitles.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = OpenSubtitles.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = OpenSubtitles.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public OpenSubtitles.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public OpenSubtitles.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Download Request a download url for a subtitle.    &gt; The download count is calculated on this action, not the file download itself  &gt; IN and OUT FPS must be indicated for subtitle conversions, we want to make sure you know what you are doing, and therefore collected the current FPS from the subtitle search result, or calculated it somehow.  &lt;!- - theme: warning - -&gt;  &gt; The download URL is temporary, and cannot be used more than 3 hours, so do not cache it, but you can download the file more than once if needed.
        /// </summary>
        /// <exception cref="OpenSubtitles.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">application/json</param>
        /// <param name="body"> (optional)</param>
        /// <returns>InlineResponse2008</returns>
        public InlineResponse2008 Download (string contentType, InlineObject1 body = default(InlineObject1))
        {
             ApiResponse<InlineResponse2008> localVarResponse = DownloadWithHttpInfo(contentType, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Download Request a download url for a subtitle.    &gt; The download count is calculated on this action, not the file download itself  &gt; IN and OUT FPS must be indicated for subtitle conversions, we want to make sure you know what you are doing, and therefore collected the current FPS from the subtitle search result, or calculated it somehow.  &lt;!- - theme: warning - -&gt;  &gt; The download URL is temporary, and cannot be used more than 3 hours, so do not cache it, but you can download the file more than once if needed.
        /// </summary>
        /// <exception cref="OpenSubtitles.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">application/json</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of InlineResponse2008</returns>
        public ApiResponse<InlineResponse2008> DownloadWithHttpInfo (string contentType, InlineObject1 body = default(InlineObject1))
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling DownloadApi->Download");

            var localVarPath = "/download";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (Api-Key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Api-Key")))
            {
                localVarHeaderParams["Api-Key"] = this.Configuration.GetApiKeyWithPrefix("Api-Key");
            }
            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Download", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2008>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2008) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2008)));
        }

        /// <summary>
        /// Download Request a download url for a subtitle.    &gt; The download count is calculated on this action, not the file download itself  &gt; IN and OUT FPS must be indicated for subtitle conversions, we want to make sure you know what you are doing, and therefore collected the current FPS from the subtitle search result, or calculated it somehow.  &lt;!- - theme: warning - -&gt;  &gt; The download URL is temporary, and cannot be used more than 3 hours, so do not cache it, but you can download the file more than once if needed.
        /// </summary>
        /// <exception cref="OpenSubtitles.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">application/json</param>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InlineResponse2008</returns>
        public async System.Threading.Tasks.Task<InlineResponse2008> DownloadAsync (string contentType, InlineObject1 body = default(InlineObject1), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<InlineResponse2008> localVarResponse = await DownloadWithHttpInfoAsync(contentType, body, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Download Request a download url for a subtitle.    &gt; The download count is calculated on this action, not the file download itself  &gt; IN and OUT FPS must be indicated for subtitle conversions, we want to make sure you know what you are doing, and therefore collected the current FPS from the subtitle search result, or calculated it somehow.  &lt;!- - theme: warning - -&gt;  &gt; The download URL is temporary, and cannot be used more than 3 hours, so do not cache it, but you can download the file more than once if needed.
        /// </summary>
        /// <exception cref="OpenSubtitles.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">application/json</param>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InlineResponse2008)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2008>> DownloadWithHttpInfoAsync (string contentType, InlineObject1 body = default(InlineObject1), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling DownloadApi->Download");

            var localVarPath = "/download";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (Api-Key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Api-Key")))
            {
                localVarHeaderParams["Api-Key"] = this.Configuration.GetApiKeyWithPrefix("Api-Key");
            }
            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Download", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2008>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2008) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2008)));
        }

    }
}