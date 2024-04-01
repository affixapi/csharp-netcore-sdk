/*
 * Affix API
 *
 * The affixapi.com API documentation.  # Introduction Affix API is an OAuth 2.1 application that allows developers to access customer data, without developers needing to manage or maintain integrations; or collect login credentials or API keys from users for these third party systems.  # OAuth 2.1 Affix API follows the [OAuth 2.1 spec](https://datatracker.ietf.org/doc/html/draft-ietf-oauth-v2-1-08).  As an OAuth application, Affix API handles not only both the collection of sensitive user credentials or API keys, but also builds and maintains the integrations with the providers, so you don't have to.  # How to obtain an access token in order to get started, you must:   - register a `client_id`   - direct your user to the sign in flow  (`https://connect.affixapi.com`     [with the appropriate query     parameters](https://github.com/affixapi/starter-kit/tree/master/connect))   - capture `authorization_code` we will send to your redirect URI after     the sign in flow is complete and exchange that `authorization_code` for     a Bearer token  # Sandbox keys (xhr mode) ### dev ``` eyJhbGciOiJFUzI1NiIsImtpZCI6Ims5RmxwSFR1YklmZWNsUU5QRVZzeFcxazFZZ0Zfbk1BWllOSGVuOFQxdGciLCJ0eXAiOiJKV1MifQ.eyJwcm92aWRlciI6InNhbmRib3giLCJzY29wZXMiOlsiLzIwMjMtMDMtMDEveGhyL2NvbXBhbnkiLCIvMjAyMy0wMy0wMS94aHIvZW1wbG95ZWUiLCIvMjAyMy0wMy0wMS94aHIvZW1wbG95ZWVzIiwiLzIwMjMtMDMtMDEveGhyL2dyb3VwcyIsIi8yMDIzLTAzLTAxL3hoci9pZGVudGl0eSIsIi8yMDIzLTAzLTAxL3hoci9wYXlydW5zIiwiLzIwMjMtMDMtMDEveGhyL3BheXJ1bnMvOnBheXJ1bl9pZCIsIi8yMDIzLTAzLTAxL3hoci90aW1lLW9mZi1iYWxhbmNlcyIsIi8yMDIzLTAzLTAxL3hoci90aW1lLW9mZi1lbnRyaWVzIiwiLzIwMjMtMDMtMDEveGhyL3RpbWVzaGVldHMiLCIvMjAyMy0wMy0wMS94aHIvd29yay1sb2NhdGlvbnMiXSwidG9rZW4iOiIzODIzNTNlMi05N2ZiLTRmMWEtOTYxYy0zZDI5OTViNzYxMTUiLCJpYXQiOjE3MTE4MTA3MTQsImlzcyI6InB1YmxpY2FwaS1pbnRlcm1lZGlhdGUuZGV2LmVuZ2luZWVyaW5nLmFmZml4YXBpLmNvbSIsInN1YiI6InhociIsImF1ZCI6IjNGREFFREY5LTFEQ0E0RjU0LTg3OTQ5RjZBLTQxMDI3NjQzIn0.zUJPaT6IxcIdr8b9iO6u-Rr5I-ohTHPYTrQGrgOFghbEbovItiwr9Wk479GnJVJc3WR8bxAwUMAE4Ul6Okdk6Q ```  #### `employees` endpoint sample: ``` curl - -fail \\   -X GET \\   -H 'Authorization: Bearer eyJhbGciOiJFUzI1NiIsImtpZCI6Ims5RmxwSFR1YklmZWNsUU5QRVZzeFcxazFZZ0Zfbk1BWllOSGVuOFQxdGciLCJ0eXAiOiJKV1MifQ.eyJwcm92aWRlciI6InNhbmRib3giLCJzY29wZXMiOlsiLzIwMjMtMDMtMDEveGhyL2NvbXBhbnkiLCIvMjAyMy0wMy0wMS94aHIvZW1wbG95ZWUiLCIvMjAyMy0wMy0wMS94aHIvZW1wbG95ZWVzIiwiLzIwMjMtMDMtMDEveGhyL2dyb3VwcyIsIi8yMDIzLTAzLTAxL3hoci9pZGVudGl0eSIsIi8yMDIzLTAzLTAxL3hoci9wYXlydW5zIiwiLzIwMjMtMDMtMDEveGhyL3BheXJ1bnMvOnBheXJ1bl9pZCIsIi8yMDIzLTAzLTAxL3hoci90aW1lLW9mZi1iYWxhbmNlcyIsIi8yMDIzLTAzLTAxL3hoci90aW1lLW9mZi1lbnRyaWVzIiwiLzIwMjMtMDMtMDEveGhyL3RpbWVzaGVldHMiLCIvMjAyMy0wMy0wMS94aHIvd29yay1sb2NhdGlvbnMiXSwidG9rZW4iOiIzODIzNTNlMi05N2ZiLTRmMWEtOTYxYy0zZDI5OTViNzYxMTUiLCJpYXQiOjE3MTE4MTA3MTQsImlzcyI6InB1YmxpY2FwaS1pbnRlcm1lZGlhdGUuZGV2LmVuZ2luZWVyaW5nLmFmZml4YXBpLmNvbSIsInN1YiI6InhociIsImF1ZCI6IjNGREFFREY5LTFEQ0E0RjU0LTg3OTQ5RjZBLTQxMDI3NjQzIn0.zUJPaT6IxcIdr8b9iO6u-Rr5I-ohTHPYTrQGrgOFghbEbovItiwr9Wk479GnJVJc3WR8bxAwUMAE4Ul6Okdk6Q' \\   'https://dev.api.affixapi.com/2023-03-01/xhr/employees' ```  ### prod ``` eyJhbGciOiJFUzI1NiIsImtpZCI6Ims5RmxwSFR1YklmZWNsUU5QRVZzeFcxazFZZ0Zfbk1BWllOSGVuOFQxdGciLCJ0eXAiOiJKV1MifQ.eyJwcm92aWRlciI6InNhbmRib3giLCJzY29wZXMiOlsiLzIwMjMtMDMtMDEveGhyL2NvbXBhbnkiLCIvMjAyMy0wMy0wMS94aHIvZW1wbG95ZWUiLCIvMjAyMy0wMy0wMS94aHIvZW1wbG95ZWVzIiwiLzIwMjMtMDMtMDEveGhyL2dyb3VwcyIsIi8yMDIzLTAzLTAxL3hoci9pZGVudGl0eSIsIi8yMDIzLTAzLTAxL3hoci9wYXlydW5zIiwiLzIwMjMtMDMtMDEveGhyL3BheXJ1bnMvOnBheXJ1bl9pZCIsIi8yMDIzLTAzLTAxL3hoci90aW1lLW9mZi1iYWxhbmNlcyIsIi8yMDIzLTAzLTAxL3hoci90aW1lLW9mZi1lbnRyaWVzIiwiLzIwMjMtMDMtMDEveGhyL3RpbWVzaGVldHMiLCIvMjAyMy0wMy0wMS94aHIvd29yay1sb2NhdGlvbnMiXSwidG9rZW4iOiIzYjg4MDc2NC1kMGFmLTQ5ZDAtOGM5OS00YzIwYjE2MTJjOTMiLCJpYXQiOjE3MTE4MTA4NTgsImlzcyI6InB1YmxpY2FwaS1pbnRlcm1lZGlhdGUucHJvZC5lbmdpbmVlcmluZy5hZmZpeGFwaS5jb20iLCJzdWIiOiJ4aHIiLCJhdWQiOiIwOEJCMDgxRS1EOUFCNEQxNC04REY5OTIzMy02NjYxNUNFOSJ9.n3pJmmfegU21Tko_TyUyCHi4ITvfd75T8NFFTHmf1r8AI8yCUYTWdfNjyZZWcZD6z50I3Wsk2rAd8GDWXn4vlg ```  #### `employees` endpoint sample: ``` curl - -fail \\   -X GET \\   -H 'Authorization: Bearer eyJhbGciOiJFUzI1NiIsImtpZCI6Ims5RmxwSFR1YklmZWNsUU5QRVZzeFcxazFZZ0Zfbk1BWllOSGVuOFQxdGciLCJ0eXAiOiJKV1MifQ.eyJwcm92aWRlciI6InNhbmRib3giLCJzY29wZXMiOlsiLzIwMjMtMDMtMDEveGhyL2NvbXBhbnkiLCIvMjAyMy0wMy0wMS94aHIvZW1wbG95ZWUiLCIvMjAyMy0wMy0wMS94aHIvZW1wbG95ZWVzIiwiLzIwMjMtMDMtMDEveGhyL2dyb3VwcyIsIi8yMDIzLTAzLTAxL3hoci9pZGVudGl0eSIsIi8yMDIzLTAzLTAxL3hoci9wYXlydW5zIiwiLzIwMjMtMDMtMDEveGhyL3BheXJ1bnMvOnBheXJ1bl9pZCIsIi8yMDIzLTAzLTAxL3hoci90aW1lLW9mZi1iYWxhbmNlcyIsIi8yMDIzLTAzLTAxL3hoci90aW1lLW9mZi1lbnRyaWVzIiwiLzIwMjMtMDMtMDEveGhyL3RpbWVzaGVldHMiLCIvMjAyMy0wMy0wMS94aHIvd29yay1sb2NhdGlvbnMiXSwidG9rZW4iOiIzYjg4MDc2NC1kMGFmLTQ5ZDAtOGM5OS00YzIwYjE2MTJjOTMiLCJpYXQiOjE3MTE4MTA4NTgsImlzcyI6InB1YmxpY2FwaS1pbnRlcm1lZGlhdGUucHJvZC5lbmdpbmVlcmluZy5hZmZpeGFwaS5jb20iLCJzdWIiOiJ4aHIiLCJhdWQiOiIwOEJCMDgxRS1EOUFCNEQxNC04REY5OTIzMy02NjYxNUNFOSJ9.n3pJmmfegU21Tko_TyUyCHi4ITvfd75T8NFFTHmf1r8AI8yCUYTWdfNjyZZWcZD6z50I3Wsk2rAd8GDWXn4vlg' \\   'https://api.affixapi.com/2023-03-01/xhr/employees' ```  # Compression We support `brotli`, `gzip`, and `deflate` compression algorithms.  To enable, pass the `Accept-Encoding` header with one or all of the values: `br`, `gzip`, `deflate`, or `identity` (no compression)  In the response, you will receive the `Content-Encoding` response header indicating the compression algorithm used in the data payload to enable you to decompress the result. If the `Accept-Encoding: identity` header was passed, no `Content-Encoding` response header is sent back, as no compression algorithm was used.  # Webhooks An exciting feature for HR/Payroll modes are webhooks.  If enabled, your `webhook_uri` is set on your `client_id` for the respective environment: `dev | prod`  Webhooks are configured to make live requests to the underlying integration 1x/hr, and if a difference is detected since the last request, we will send a request to your `webhook_uri` with this shape:  ``` {    added: <api.v20230301.Employees>[     <api.v20230301.Employee>{       ...,       date_of_birth: '2010-08-06',       display_full_name: 'Daija Rogahn',       employee_number: '57993',       employment_status: 'pending',       employment_type: 'other',       employments: [         {           currency: 'eur',           effective_date: '2022-02-25',           employment_type: 'other',           job_title: 'Dynamic Implementation Manager',           pay_frequency: 'semimonthly',           pay_period: 'YEAR',           pay_rate: 96000,         },       ],       first_name: 'Daija',       ...     }   ],   removed: [],   updated: [     <api.v20230301.Employee>{       ...,       date_of_birth: '2009-11-09',       display_full_name: 'Lourdes Stiedemann',       employee_number: '63189',       employment_status: 'leave',       employment_type: 'full_time',       employments: [         {           currency: 'gbp',           effective_date: '2023-01-16',           employment_type: 'full_time',           job_title: 'Forward Brand Planner',           pay_frequency: 'semimonthly',           pay_period: 'YEAR',           pay_rate: 86000,         },       ],       first_name: 'Lourdes',     }   ] } ```  the following headers will be sent with webhook requests:  ``` x-affix-api-signature: ab8474e609db95d5df3adc39ea3add7a7544bd215c5c520a30a650ae93a2fba7  x-affix-api-origin:  webhooks-employees-webhook  user-agent:  affixapi.com ```  Before trusting the payload, you should sign the payload and verify the signature matches the signature sent by the `affixapi.com` service.  This secures that the data sent to your `webhook_uri` is from the `affixapi.com` server.  The signature is created by combining the signing secret (your `client_secret`) with the body of the request sent using a standard HMAC-SHA256 keyed hash.  The signature can be created via:   - create an `HMAC` with your `client_secret`   - update the `HMAC` with the payload   - get the hex digest -> this is the signature  Sample `typescript` code that follows this recipe:  ``` import { createHmac } from 'crypto';  export const computeSignature = ({   str,   signingSecret, }: {   signingSecret: string;   str: string; }): string => {   const hmac = createHmac('sha256', signingSecret);   hmac.update(str);   const signature = hmac.digest('hex');    return signature; }; ```  While verifying the Affix API signature header should be your primary method of confirming validity, you can also whitelist our outbound webhook static IP addresses.  ``` dev:   - 52.210.169.82   - 52.210.38.77   - 3.248.135.204  prod:   - 52.51.160.102   - 54.220.83.244   - 3.254.213.171 ```  ## Rate limits Open endpoints (not gated by an API key) (applied at endpoint level):   - 15 requests every 1 minute (by IP address)   - 25 requests every 5 minutes (by IP address)  Gated endpoints (require an API key) (applied at endpoint level):   - 40 requests every 1 minute (by IP address)   - 40 requests every 5 minutes (by `client_id`)  Things to keep in mind:   - Open endpoints (not gated by an API key) will likely be called by your     users, not you, so rate limits generally would not apply to you.   - As a developer, rate limits are applied at the endpoint granularity.     - For example, say the rate limits below are 10 requests per minute by ip.       from that same ip, within 1 minute, you get:       - 10 requests per minute on `/orders`,       - another 10 requests per minute on `/items`,       - and another 10 requests per minute on `/identity`,       - for a total of 30 requests per minute. 
 *
 * The version of the OpenAPI document: 2023-03-01
 * Contact: developers@affixapi.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using AffixApi.Api.Client;
using AffixApi.Api.Model;

namespace AffixApi.Api.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IManagementApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Client
        /// </summary>
        /// <remarks>
        /// View client attributes 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ClientResponse</returns>
        ClientResponse CallClient();

        /// <summary>
        /// Client
        /// </summary>
        /// <remarks>
        /// View client attributes 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ClientResponse</returns>
        ApiResponse<ClientResponse> CallClientWithHttpInfo();
        /// <summary>
        /// Disconnect token
        /// </summary>
        /// <remarks>
        /// Disconnect the token. A disconnected token will no longer return data. Data requests with a disconnected token will return a 403 Forbidden 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DisconnectResponse</returns>
        DisconnectResponse Disconnect();

        /// <summary>
        /// Disconnect token
        /// </summary>
        /// <remarks>
        /// Disconnect the token. A disconnected token will no longer return data. Data requests with a disconnected token will return a 403 Forbidden 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DisconnectResponse</returns>
        ApiResponse<DisconnectResponse> DisconnectWithHttpInfo();
        /// <summary>
        /// Inspect token
        /// </summary>
        /// <remarks>
        /// Retrieve data about the token, such as &#x60;scopes&#x60;, &#x60;mode&#x60;, &#x60;provider&#x60;, and if it is active 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IntrospectResponse</returns>
        IntrospectResponse Introspect();

        /// <summary>
        /// Inspect token
        /// </summary>
        /// <remarks>
        /// Retrieve data about the token, such as &#x60;scopes&#x60;, &#x60;mode&#x60;, &#x60;provider&#x60;, and if it is active 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IntrospectResponse</returns>
        ApiResponse<IntrospectResponse> IntrospectWithHttpInfo();
        /// <summary>
        /// Create token
        /// </summary>
        /// <remarks>
        /// Exchange an &#x60;authorization_code&#x60; for an &#x60;access_token&#x60; after receiving on from the &#x60;redirect_uri&#x60; you specifiy after a successful user connection 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenRequest"></param>
        /// <returns>TokenResponse</returns>
        TokenResponse Token(TokenRequest tokenRequest);

        /// <summary>
        /// Create token
        /// </summary>
        /// <remarks>
        /// Exchange an &#x60;authorization_code&#x60; for an &#x60;access_token&#x60; after receiving on from the &#x60;redirect_uri&#x60; you specifiy after a successful user connection 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenRequest"></param>
        /// <returns>ApiResponse of TokenResponse</returns>
        ApiResponse<TokenResponse> TokenWithHttpInfo(TokenRequest tokenRequest);
        /// <summary>
        /// Tokens
        /// </summary>
        /// <remarks>
        /// View tokens and token status for respective client 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> Tokens();

        /// <summary>
        /// Tokens
        /// </summary>
        /// <remarks>
        /// View tokens and token status for respective client 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> TokensWithHttpInfo();
        /// <summary>
        /// Update client
        /// </summary>
        /// <remarks>
        /// Update attributes of the client.  Update the &#x60;name&#x60;, &#x60;client_secret&#x60;, or &#x60;webhook_uri&#x60; of the client 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientRequest"></param>
        /// <returns>ClientResponse</returns>
        ClientResponse UpdateClient(ClientRequest clientRequest);

        /// <summary>
        /// Update client
        /// </summary>
        /// <remarks>
        /// Update attributes of the client.  Update the &#x60;name&#x60;, &#x60;client_secret&#x60;, or &#x60;webhook_uri&#x60; of the client 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientRequest"></param>
        /// <returns>ApiResponse of ClientResponse</returns>
        ApiResponse<ClientResponse> UpdateClientWithHttpInfo(ClientRequest clientRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IManagementApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Client
        /// </summary>
        /// <remarks>
        /// View client attributes 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ClientResponse</returns>
        System.Threading.Tasks.Task<ClientResponse> CallClientAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Client
        /// </summary>
        /// <remarks>
        /// View client attributes 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ClientResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClientResponse>> CallClientWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Disconnect token
        /// </summary>
        /// <remarks>
        /// Disconnect the token. A disconnected token will no longer return data. Data requests with a disconnected token will return a 403 Forbidden 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DisconnectResponse</returns>
        System.Threading.Tasks.Task<DisconnectResponse> DisconnectAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Disconnect token
        /// </summary>
        /// <remarks>
        /// Disconnect the token. A disconnected token will no longer return data. Data requests with a disconnected token will return a 403 Forbidden 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DisconnectResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DisconnectResponse>> DisconnectWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Inspect token
        /// </summary>
        /// <remarks>
        /// Retrieve data about the token, such as &#x60;scopes&#x60;, &#x60;mode&#x60;, &#x60;provider&#x60;, and if it is active 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IntrospectResponse</returns>
        System.Threading.Tasks.Task<IntrospectResponse> IntrospectAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Inspect token
        /// </summary>
        /// <remarks>
        /// Retrieve data about the token, such as &#x60;scopes&#x60;, &#x60;mode&#x60;, &#x60;provider&#x60;, and if it is active 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IntrospectResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntrospectResponse>> IntrospectWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Create token
        /// </summary>
        /// <remarks>
        /// Exchange an &#x60;authorization_code&#x60; for an &#x60;access_token&#x60; after receiving on from the &#x60;redirect_uri&#x60; you specifiy after a successful user connection 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TokenResponse</returns>
        System.Threading.Tasks.Task<TokenResponse> TokenAsync(TokenRequest tokenRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create token
        /// </summary>
        /// <remarks>
        /// Exchange an &#x60;authorization_code&#x60; for an &#x60;access_token&#x60; after receiving on from the &#x60;redirect_uri&#x60; you specifiy after a successful user connection 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TokenResponse>> TokenWithHttpInfoAsync(TokenRequest tokenRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Tokens
        /// </summary>
        /// <remarks>
        /// View tokens and token status for respective client 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> TokensAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Tokens
        /// </summary>
        /// <remarks>
        /// View tokens and token status for respective client 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> TokensWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Update client
        /// </summary>
        /// <remarks>
        /// Update attributes of the client.  Update the &#x60;name&#x60;, &#x60;client_secret&#x60;, or &#x60;webhook_uri&#x60; of the client 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ClientResponse</returns>
        System.Threading.Tasks.Task<ClientResponse> UpdateClientAsync(ClientRequest clientRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update client
        /// </summary>
        /// <remarks>
        /// Update attributes of the client.  Update the &#x60;name&#x60;, &#x60;client_secret&#x60;, or &#x60;webhook_uri&#x60; of the client 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ClientResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClientResponse>> UpdateClientWithHttpInfoAsync(ClientRequest clientRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IManagementApi : IManagementApiSync, IManagementApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ManagementApi : IManagementApi
    {
        private AffixApi.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ManagementApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ManagementApi(String basePath)
        {
            this.Configuration = AffixApi.Api.Client.Configuration.MergeConfigurations(
                AffixApi.Api.Client.GlobalConfiguration.Instance,
                new AffixApi.Api.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AffixApi.Api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new AffixApi.Api.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AffixApi.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ManagementApi(AffixApi.Api.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = AffixApi.Api.Client.Configuration.MergeConfigurations(
                AffixApi.Api.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new AffixApi.Api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new AffixApi.Api.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = AffixApi.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ManagementApi(AffixApi.Api.Client.ISynchronousClient client, AffixApi.Api.Client.IAsynchronousClient asyncClient, AffixApi.Api.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = AffixApi.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public AffixApi.Api.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public AffixApi.Api.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AffixApi.Api.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AffixApi.Api.Client.ExceptionFactory ExceptionFactory
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
        /// Client View client attributes 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ClientResponse</returns>
        public ClientResponse CallClient()
        {
            AffixApi.Api.Client.ApiResponse<ClientResponse> localVarResponse = CallClientWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Client View client attributes 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ClientResponse</returns>
        public AffixApi.Api.Client.ApiResponse<ClientResponse> CallClientWithHttpInfo()
        {
            AffixApi.Api.Client.RequestOptions localVarRequestOptions = new AffixApi.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = AffixApi.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AffixApi.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (basic) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ClientResponse>("/2023-03-01/management/client", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CallClient", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Client View client attributes 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ClientResponse</returns>
        public async System.Threading.Tasks.Task<ClientResponse> CallClientAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<ClientResponse> localVarResponse = await CallClientWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Client View client attributes 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ClientResponse)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<ClientResponse>> CallClientWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            AffixApi.Api.Client.RequestOptions localVarRequestOptions = new AffixApi.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = AffixApi.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AffixApi.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (basic) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ClientResponse>("/2023-03-01/management/client", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CallClient", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Disconnect token Disconnect the token. A disconnected token will no longer return data. Data requests with a disconnected token will return a 403 Forbidden 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DisconnectResponse</returns>
        public DisconnectResponse Disconnect()
        {
            AffixApi.Api.Client.ApiResponse<DisconnectResponse> localVarResponse = DisconnectWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Disconnect token Disconnect the token. A disconnected token will no longer return data. Data requests with a disconnected token will return a 403 Forbidden 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DisconnectResponse</returns>
        public AffixApi.Api.Client.ApiResponse<DisconnectResponse> DisconnectWithHttpInfo()
        {
            AffixApi.Api.Client.RequestOptions localVarRequestOptions = new AffixApi.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = AffixApi.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AffixApi.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (access-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<DisconnectResponse>("/2023-03-01/management/disconnect", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Disconnect", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Disconnect token Disconnect the token. A disconnected token will no longer return data. Data requests with a disconnected token will return a 403 Forbidden 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DisconnectResponse</returns>
        public async System.Threading.Tasks.Task<DisconnectResponse> DisconnectAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<DisconnectResponse> localVarResponse = await DisconnectWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Disconnect token Disconnect the token. A disconnected token will no longer return data. Data requests with a disconnected token will return a 403 Forbidden 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DisconnectResponse)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<DisconnectResponse>> DisconnectWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            AffixApi.Api.Client.RequestOptions localVarRequestOptions = new AffixApi.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = AffixApi.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AffixApi.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (access-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<DisconnectResponse>("/2023-03-01/management/disconnect", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Disconnect", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Inspect token Retrieve data about the token, such as &#x60;scopes&#x60;, &#x60;mode&#x60;, &#x60;provider&#x60;, and if it is active 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IntrospectResponse</returns>
        public IntrospectResponse Introspect()
        {
            AffixApi.Api.Client.ApiResponse<IntrospectResponse> localVarResponse = IntrospectWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Inspect token Retrieve data about the token, such as &#x60;scopes&#x60;, &#x60;mode&#x60;, &#x60;provider&#x60;, and if it is active 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IntrospectResponse</returns>
        public AffixApi.Api.Client.ApiResponse<IntrospectResponse> IntrospectWithHttpInfo()
        {
            AffixApi.Api.Client.RequestOptions localVarRequestOptions = new AffixApi.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = AffixApi.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AffixApi.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (access-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<IntrospectResponse>("/2023-03-01/management/introspect", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Introspect", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Inspect token Retrieve data about the token, such as &#x60;scopes&#x60;, &#x60;mode&#x60;, &#x60;provider&#x60;, and if it is active 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IntrospectResponse</returns>
        public async System.Threading.Tasks.Task<IntrospectResponse> IntrospectAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<IntrospectResponse> localVarResponse = await IntrospectWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Inspect token Retrieve data about the token, such as &#x60;scopes&#x60;, &#x60;mode&#x60;, &#x60;provider&#x60;, and if it is active 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IntrospectResponse)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<IntrospectResponse>> IntrospectWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            AffixApi.Api.Client.RequestOptions localVarRequestOptions = new AffixApi.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = AffixApi.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AffixApi.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (access-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<IntrospectResponse>("/2023-03-01/management/introspect", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Introspect", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create token Exchange an &#x60;authorization_code&#x60; for an &#x60;access_token&#x60; after receiving on from the &#x60;redirect_uri&#x60; you specifiy after a successful user connection 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenRequest"></param>
        /// <returns>TokenResponse</returns>
        public TokenResponse Token(TokenRequest tokenRequest)
        {
            AffixApi.Api.Client.ApiResponse<TokenResponse> localVarResponse = TokenWithHttpInfo(tokenRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create token Exchange an &#x60;authorization_code&#x60; for an &#x60;access_token&#x60; after receiving on from the &#x60;redirect_uri&#x60; you specifiy after a successful user connection 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenRequest"></param>
        /// <returns>ApiResponse of TokenResponse</returns>
        public AffixApi.Api.Client.ApiResponse<TokenResponse> TokenWithHttpInfo(TokenRequest tokenRequest)
        {
            // verify the required parameter 'tokenRequest' is set
            if (tokenRequest == null)
                throw new AffixApi.Api.Client.ApiException(400, "Missing required parameter 'tokenRequest' when calling ManagementApi->Token");

            AffixApi.Api.Client.RequestOptions localVarRequestOptions = new AffixApi.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = AffixApi.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AffixApi.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = tokenRequest;


            // make the HTTP request
            var localVarResponse = this.Client.Post<TokenResponse>("/2023-03-01/management/token", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Token", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create token Exchange an &#x60;authorization_code&#x60; for an &#x60;access_token&#x60; after receiving on from the &#x60;redirect_uri&#x60; you specifiy after a successful user connection 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TokenResponse</returns>
        public async System.Threading.Tasks.Task<TokenResponse> TokenAsync(TokenRequest tokenRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<TokenResponse> localVarResponse = await TokenWithHttpInfoAsync(tokenRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create token Exchange an &#x60;authorization_code&#x60; for an &#x60;access_token&#x60; after receiving on from the &#x60;redirect_uri&#x60; you specifiy after a successful user connection 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TokenResponse)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<TokenResponse>> TokenWithHttpInfoAsync(TokenRequest tokenRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'tokenRequest' is set
            if (tokenRequest == null)
                throw new AffixApi.Api.Client.ApiException(400, "Missing required parameter 'tokenRequest' when calling ManagementApi->Token");


            AffixApi.Api.Client.RequestOptions localVarRequestOptions = new AffixApi.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = AffixApi.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AffixApi.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = tokenRequest;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<TokenResponse>("/2023-03-01/management/token", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Token", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Tokens View tokens and token status for respective client 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> Tokens()
        {
            AffixApi.Api.Client.ApiResponse<List<Object>> localVarResponse = TokensWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Tokens View tokens and token status for respective client 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public AffixApi.Api.Client.ApiResponse<List<Object>> TokensWithHttpInfo()
        {
            AffixApi.Api.Client.RequestOptions localVarRequestOptions = new AffixApi.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = AffixApi.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AffixApi.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (basic) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<Object>>("/2023-03-01/management/tokens", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Tokens", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Tokens View tokens and token status for respective client 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> TokensAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<List<Object>> localVarResponse = await TokensWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Tokens View tokens and token status for respective client 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<List<Object>>> TokensWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            AffixApi.Api.Client.RequestOptions localVarRequestOptions = new AffixApi.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = AffixApi.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AffixApi.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (basic) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Object>>("/2023-03-01/management/tokens", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Tokens", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update client Update attributes of the client.  Update the &#x60;name&#x60;, &#x60;client_secret&#x60;, or &#x60;webhook_uri&#x60; of the client 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientRequest"></param>
        /// <returns>ClientResponse</returns>
        public ClientResponse UpdateClient(ClientRequest clientRequest)
        {
            AffixApi.Api.Client.ApiResponse<ClientResponse> localVarResponse = UpdateClientWithHttpInfo(clientRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update client Update attributes of the client.  Update the &#x60;name&#x60;, &#x60;client_secret&#x60;, or &#x60;webhook_uri&#x60; of the client 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientRequest"></param>
        /// <returns>ApiResponse of ClientResponse</returns>
        public AffixApi.Api.Client.ApiResponse<ClientResponse> UpdateClientWithHttpInfo(ClientRequest clientRequest)
        {
            // verify the required parameter 'clientRequest' is set
            if (clientRequest == null)
                throw new AffixApi.Api.Client.ApiException(400, "Missing required parameter 'clientRequest' when calling ManagementApi->UpdateClient");

            AffixApi.Api.Client.RequestOptions localVarRequestOptions = new AffixApi.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = AffixApi.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AffixApi.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = clientRequest;

            // authentication (basic) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ClientResponse>("/2023-03-01/management/client", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateClient", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update client Update attributes of the client.  Update the &#x60;name&#x60;, &#x60;client_secret&#x60;, or &#x60;webhook_uri&#x60; of the client 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ClientResponse</returns>
        public async System.Threading.Tasks.Task<ClientResponse> UpdateClientAsync(ClientRequest clientRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<ClientResponse> localVarResponse = await UpdateClientWithHttpInfoAsync(clientRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update client Update attributes of the client.  Update the &#x60;name&#x60;, &#x60;client_secret&#x60;, or &#x60;webhook_uri&#x60; of the client 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ClientResponse)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<ClientResponse>> UpdateClientWithHttpInfoAsync(ClientRequest clientRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'clientRequest' is set
            if (clientRequest == null)
                throw new AffixApi.Api.Client.ApiException(400, "Missing required parameter 'clientRequest' when calling ManagementApi->UpdateClient");


            AffixApi.Api.Client.RequestOptions localVarRequestOptions = new AffixApi.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = AffixApi.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AffixApi.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = clientRequest;

            // authentication (basic) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<ClientResponse>("/2023-03-01/management/client", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateClient", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
