/*
 * Affix API
 *
 * The affixapi.com API documentation.  # Introduction Affix API is an OAuth 2.1 application that allows developers to access customer data, without developers needing to manage or maintain integrations; or collect login credentials or API keys from users for these third party systems.  # OAuth 2.1 Affix API follows the [OAuth 2.1 spec](https://datatracker.ietf.org/doc/html/draft-ietf-oauth-v2-1-08).  As an OAuth application, Affix API handles not only both the collection of sensitive user credentials or API keys, but also builds and maintains the integrations with the providers, so you don't have to.  # How to obtain an access token in order to get started, you must:   - register a `client_id`   - direct your user to the sign in flow  (`https://connect.affixapi.com`     [with the appropriate query     parameters](https://github.com/affixapi/starter-kit/tree/master/connect))   - capture `authorization_code` we will send to your redirect URI after     the sign in flow is complete and exchange that `authorization_code` for     a Bearer token  # Sandbox keys (developer mode) ### dev ``` eyJhbGciOiJFUzI1NiIsImtpZCI6Ims5RmxwSFR1YklmZWNsUU5QRVZzeFcxazFZZ0Zfbk1BWllOSGVuOFQxdGciLCJ0eXAiOiJKV1MifQ.eyJwcm92aWRlciI6InNhbmRib3giLCJzY29wZXMiOlsiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL2NvbXBhbnkiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvZW1wbG95ZWUiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvZW1wbG95ZWVzIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL2lkZW50aXR5IiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3BheXJ1bnMiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvcGF5cnVucy86cGF5cnVuX2lkIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3RpbWUtb2ZmLWJhbGFuY2VzIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3RpbWUtb2ZmLWVudHJpZXMiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvdGltZXNoZWV0cyJdLCJ0b2tlbiI6ImQ1OTZhMmYzLWYzNzktNGE1ZC1hMmRhLTk4OWJmYWViYTg1ZCIsImlhdCI6MTcwMjkyMDkwMywiaXNzIjoicHVibGljYXBpLWludGVybWVkaWF0ZS5kZXYuZW5naW5lZXJpbmcuYWZmaXhhcGkuY29tIiwic3ViIjoiZGV2ZWxvcGVyIiwiYXVkIjoiM0ZEQUVERjktMURDQTRGNTQtODc5NDlGNkEtNDEwMjc2NDMifQ.VLWYjCQvBS0C3ZA6_J3-U-idZj5EYI2IlDdTjAWBxSIHGufp6cqaVodKsF2BeIqcIeB3P0lW-KL9mY3xGd7ckQ ```  #### `employees` endpoint sample: ``` curl - -fail \\   -X GET \\   -H 'Authorization: Bearer eyJhbGciOiJFUzI1NiIsImtpZCI6Ims5RmxwSFR1YklmZWNsUU5QRVZzeFcxazFZZ0Zfbk1BWllOSGVuOFQxdGciLCJ0eXAiOiJKV1MifQ.eyJwcm92aWRlciI6InNhbmRib3giLCJzY29wZXMiOlsiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL2NvbXBhbnkiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvZW1wbG95ZWUiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvZW1wbG95ZWVzIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL2lkZW50aXR5IiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3BheXJ1bnMiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvcGF5cnVucy86cGF5cnVuX2lkIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3RpbWUtb2ZmLWJhbGFuY2VzIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3RpbWUtb2ZmLWVudHJpZXMiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvdGltZXNoZWV0cyJdLCJ0b2tlbiI6ImQ1OTZhMmYzLWYzNzktNGE1ZC1hMmRhLTk4OWJmYWViYTg1ZCIsImlhdCI6MTcwMjkyMDkwMywiaXNzIjoicHVibGljYXBpLWludGVybWVkaWF0ZS5kZXYuZW5naW5lZXJpbmcuYWZmaXhhcGkuY29tIiwic3ViIjoiZGV2ZWxvcGVyIiwiYXVkIjoiM0ZEQUVERjktMURDQTRGNTQtODc5NDlGNkEtNDEwMjc2NDMifQ.VLWYjCQvBS0C3ZA6_J3-U-idZj5EYI2IlDdTjAWBxSIHGufp6cqaVodKsF2BeIqcIeB3P0lW-KL9mY3xGd7ckQ' \\   'https://dev.api.affixapi.com/2023-03-01/developer/employees' ```  ### prod ``` eyJhbGciOiJFUzI1NiIsImtpZCI6Ims5RmxwSFR1YklmZWNsUU5QRVZzeFcxazFZZ0Zfbk1BWllOSGVuOFQxdGciLCJ0eXAiOiJKV1MifQ.eyJwcm92aWRlciI6InNhbmRib3giLCJzY29wZXMiOlsiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL2NvbXBhbnkiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvZW1wbG95ZWUiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvZW1wbG95ZWVzIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL2lkZW50aXR5IiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3BheXJ1bnMiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvcGF5cnVucy86cGF5cnVuX2lkIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3RpbWUtb2ZmLWJhbGFuY2VzIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3RpbWUtb2ZmLWVudHJpZXMiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvdGltZXNoZWV0cyJdLCJ0b2tlbiI6IjI5YjFjYTg4LWNlNjktNDgyZC1iNGZjLTkzMWMzZmJkYWM4ZSIsImlhdCI6MTcwMjkyMTA4MywiaXNzIjoicHVibGljYXBpLWludGVybWVkaWF0ZS5wcm9kLmVuZ2luZWVyaW5nLmFmZml4YXBpLmNvbSIsInN1YiI6ImRldmVsb3BlciIsImF1ZCI6IjA4QkIwODFFLUQ5QUI0RDE0LThERjk5MjMzLTY2NjE1Q0U5In0.2zdpFAmiyYiYk6MOcbXNUwwR4M1Fextnaac340x54AidiWXCyw-u9KeavbqfYF6q8a9kcDLrxhJ8Wc_3tIzuVw ```  #### `employees` endpoint sample: ``` curl - -fail \\   -X GET \\   -H 'Authorization: Bearer eyJhbGciOiJFUzI1NiIsImtpZCI6Ims5RmxwSFR1YklmZWNsUU5QRVZzeFcxazFZZ0Zfbk1BWllOSGVuOFQxdGciLCJ0eXAiOiJKV1MifQ.eyJwcm92aWRlciI6InNhbmRib3giLCJzY29wZXMiOlsiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL2NvbXBhbnkiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvZW1wbG95ZWUiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvZW1wbG95ZWVzIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL2lkZW50aXR5IiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3BheXJ1bnMiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvcGF5cnVucy86cGF5cnVuX2lkIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3RpbWUtb2ZmLWJhbGFuY2VzIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3RpbWUtb2ZmLWVudHJpZXMiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvdGltZXNoZWV0cyJdLCJ0b2tlbiI6IjI5YjFjYTg4LWNlNjktNDgyZC1iNGZjLTkzMWMzZmJkYWM4ZSIsImlhdCI6MTcwMjkyMTA4MywiaXNzIjoicHVibGljYXBpLWludGVybWVkaWF0ZS5wcm9kLmVuZ2luZWVyaW5nLmFmZml4YXBpLmNvbSIsInN1YiI6ImRldmVsb3BlciIsImF1ZCI6IjA4QkIwODFFLUQ5QUI0RDE0LThERjk5MjMzLTY2NjE1Q0U5In0.2zdpFAmiyYiYk6MOcbXNUwwR4M1Fextnaac340x54AidiWXCyw-u9KeavbqfYF6q8a9kcDLrxhJ8Wc_3tIzuVw' \\   'https://api.affixapi.com/2023-03-01/developer/employees' ```  # Compression We support `brotli`, `gzip`, and `deflate` compression algorithms.  To enable, pass the `Accept-Encoding` header with one or all of the values: `br`, `gzip`, `deflate`, or `identity` (no compression)  In the response, you will receive the `Content-Encoding` response header indicating the compression algorithm used in the data payload to enable you to decompress the result. If the `Accept-Encoding: identity` header was passed, no `Content-Encoding` response header is sent back, as no compression algorithm was used.  # Webhooks An exciting feature for HR/Payroll modes are webhooks.  If enabled, your `webhook_uri` is set on your `client_id` for the respective environment: `dev | prod`  Webhooks are configured to make live requests to the underlying integration 1x/hr, and if a difference is detected since the last request, we will send a request to your `webhook_uri` with this shape:  ``` {    added: <api.v20230301.Employees>[     <api.v20230301.Employee>{       ...,       date_of_birth: '2010-08-06',       display_full_name: 'Daija Rogahn',       employee_number: '57993',       employment_status: 'pending',       employment_type: 'other',       employments: [         {           currency: 'eur',           effective_date: '2022-02-25',           employment_type: 'other',           job_title: 'Dynamic Implementation Manager',           pay_frequency: 'semimonthly',           pay_period: 'YEAR',           pay_rate: 96000,         },       ],       first_name: 'Daija',       ...     }   ],   removed: [],   updated: [     <api.v20230301.Employee>{       ...,       date_of_birth: '2009-11-09',       display_full_name: 'Lourdes Stiedemann',       employee_number: '63189',       employment_status: 'leave',       employment_type: 'full_time',       employments: [         {           currency: 'gbp',           effective_date: '2023-01-16',           employment_type: 'full_time',           job_title: 'Forward Brand Planner',           pay_frequency: 'semimonthly',           pay_period: 'YEAR',           pay_rate: 86000,         },       ],       first_name: 'Lourdes',     }   ] } ```  the following headers will be sent with webhook requests:  ``` x-affix-api-signature: ab8474e609db95d5df3adc39ea3add7a7544bd215c5c520a30a650ae93a2fba7  x-affix-api-origin:  webhooks-employees-webhook  user-agent:  affixapi.com ```  Before trusting the payload, you should sign the payload and verify the signature matches the signature sent by the `affixapi.com` service.  This secures that the data sent to your `webhook_uri` is from the `affixapi.com` server.  The signature is created by combining the signing secret (your `client_secret`) with the body of the request sent using a standard HMAC-SHA256 keyed hash.  The signature can be created via:   - create an `HMAC` with your `client_secret`   - update the `HMAC` with the payload   - get the hex digest -> this is the signature  Sample `typescript` code that follows this recipe:  ``` import { createHmac } from 'crypto';  export const computeSignature = ({   str,   signingSecret, }: {   signingSecret: string;   str: string; }): string => {   const hmac = createHmac('sha256', signingSecret);   hmac.update(str);   const signature = hmac.digest('hex');    return signature; }; ```  While verifying the Affix API signature header should be your primary method of confirming validity, you can also whitelist our outbound webhook static IP addresses.  ``` dev:   - 52.210.169.82   - 52.210.38.77   - 3.248.135.204  prod:   - 52.51.160.102   - 54.220.83.244   - 3.254.213.171 ```  ## Rate limits Open endpoints (not gated by an API key) (applied at endpoint level):   - 15 requests every 1 minute (by IP address)   - 25 requests every 5 minutes (by IP address)  Gated endpoints (require an API key) (applied at endpoint level):   - 40 requests every 1 minute (by IP address)   - 40 requests every 5 minutes (by `client_id`)  Things to keep in mind:   - Open endpoints (not gated by an API key) will likely be called by your     users, not you, so rate limits generally would not apply to you.   - As a developer, rate limits are applied at the endpoint granularity.     - For example, say the rate limits below are 10 requests per minute by ip.       from that same ip, within 1 minute, you get:       - 10 requests per minute on `/orders`,       - another 10 requests per minute on `/items`,       - and another 10 requests per minute on `/identity`,       - for a total of 30 requests per minute. 
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
    public interface IDeveloperApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Company
        /// </summary>
        /// <remarks>
        /// Retrieve company information 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CompanyResponse&gt;</returns>
        List<CompanyResponse> DeveloperCompanies20230301();

        /// <summary>
        /// Company
        /// </summary>
        /// <remarks>
        /// Retrieve company information 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CompanyResponse&gt;</returns>
        ApiResponse<List<CompanyResponse>> DeveloperCompanies20230301WithHttpInfo();
        /// <summary>
        /// Create employee
        /// </summary>
        /// <remarks>
        /// Creates a new Employee 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createEmployeeRequest"></param>
        /// <returns>EmployeeResponse</returns>
        EmployeeResponse DeveloperCreateEmployee20230301(CreateEmployeeRequest createEmployeeRequest);

        /// <summary>
        /// Create employee
        /// </summary>
        /// <remarks>
        /// Creates a new Employee 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createEmployeeRequest"></param>
        /// <returns>ApiResponse of EmployeeResponse</returns>
        ApiResponse<EmployeeResponse> DeveloperCreateEmployee20230301WithHttpInfo(CreateEmployeeRequest createEmployeeRequest);
        /// <summary>
        /// Employees
        /// </summary>
        /// <remarks>
        /// List the individuals (employees, contractors, accountants, and others) listed in the HRIS/Payroll software 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;EmployeeResponse&gt;</returns>
        List<EmployeeResponse> DeveloperEmployees20230301();

        /// <summary>
        /// Employees
        /// </summary>
        /// <remarks>
        /// List the individuals (employees, contractors, accountants, and others) listed in the HRIS/Payroll software 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;EmployeeResponse&gt;</returns>
        ApiResponse<List<EmployeeResponse>> DeveloperEmployees20230301WithHttpInfo();
        /// <summary>
        /// Groups
        /// </summary>
        /// <remarks>
        /// The Group object is used to represent any subset of employees, such as PayGroup, Team, or Department. Employees can be in multiple Groups. 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;GroupResponse&gt;</returns>
        List<GroupResponse> DeveloperGroups20230301();

        /// <summary>
        /// Groups
        /// </summary>
        /// <remarks>
        /// The Group object is used to represent any subset of employees, such as PayGroup, Team, or Department. Employees can be in multiple Groups. 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;GroupResponse&gt;</returns>
        ApiResponse<List<GroupResponse>> DeveloperGroups20230301WithHttpInfo();
        /// <summary>
        /// Identity
        /// </summary>
        /// <remarks>
        /// List information of the user for the respective account 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IdentityResponse</returns>
        IdentityResponse DeveloperIdentity20230301();

        /// <summary>
        /// Identity
        /// </summary>
        /// <remarks>
        /// List information of the user for the respective account 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IdentityResponse</returns>
        ApiResponse<IdentityResponse> DeveloperIdentity20230301WithHttpInfo();
        /// <summary>
        /// Payruns
        /// </summary>
        /// <remarks>
        /// List all the pay runs that occurred during the respective period.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The start date of the search period</param>
        /// <param name="endDate">The end date of the search period</param>
        /// <returns>List&lt;PayrunResponse&gt;</returns>
        List<PayrunResponse> DeveloperPayruns20230301(DateTime startDate, DateTime endDate);

        /// <summary>
        /// Payruns
        /// </summary>
        /// <remarks>
        /// List all the pay runs that occurred during the respective period.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The start date of the search period</param>
        /// <param name="endDate">The end date of the search period</param>
        /// <returns>ApiResponse of List&lt;PayrunResponse&gt;</returns>
        ApiResponse<List<PayrunResponse>> DeveloperPayruns20230301WithHttpInfo(DateTime startDate, DateTime endDate);
        /// <summary>
        /// Payslips
        /// </summary>
        /// <remarks>
        /// Retrieves payslips from a specific payrun.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payrunId">The id of the payrun.</param>
        /// <returns>List&lt;PayslipResponse&gt;</returns>
        List<PayslipResponse> DeveloperPayslips20230301(string payrunId);

        /// <summary>
        /// Payslips
        /// </summary>
        /// <remarks>
        /// Retrieves payslips from a specific payrun.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payrunId">The id of the payrun.</param>
        /// <returns>ApiResponse of List&lt;PayslipResponse&gt;</returns>
        ApiResponse<List<PayslipResponse>> DeveloperPayslips20230301WithHttpInfo(string payrunId);
        /// <summary>
        /// Time off balances
        /// </summary>
        /// <remarks>
        /// Retrieve all time off balances. 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;TimeOffBalanceResponse&gt;</returns>
        List<TimeOffBalanceResponse> DeveloperTimeOffBalances20230301();

        /// <summary>
        /// Time off balances
        /// </summary>
        /// <remarks>
        /// Retrieve all time off balances. 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;TimeOffBalanceResponse&gt;</returns>
        ApiResponse<List<TimeOffBalanceResponse>> DeveloperTimeOffBalances20230301WithHttpInfo();
        /// <summary>
        /// Time off entries
        /// </summary>
        /// <remarks>
        /// Retrieve time off / absence entries 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;TimeOffEntryResponse&gt;</returns>
        List<TimeOffEntryResponse> DeveloperTimeOffEntries20230301();

        /// <summary>
        /// Time off entries
        /// </summary>
        /// <remarks>
        /// Retrieve time off / absence entries 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;TimeOffEntryResponse&gt;</returns>
        ApiResponse<List<TimeOffEntryResponse>> DeveloperTimeOffEntries20230301WithHttpInfo();
        /// <summary>
        /// Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieve Timesheets 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;TimesheetResponse&gt;</returns>
        List<TimesheetResponse> DeveloperTimesheets20230301();

        /// <summary>
        /// Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieve Timesheets 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;TimesheetResponse&gt;</returns>
        ApiResponse<List<TimesheetResponse>> DeveloperTimesheets20230301WithHttpInfo();
        /// <summary>
        /// Work locations
        /// </summary>
        /// <remarks>
        /// The Location object is used to represent an address that can be associated with an employee 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;LocationResponse&gt;</returns>
        List<LocationResponse> DeveloperWorkLocations20230301();

        /// <summary>
        /// Work locations
        /// </summary>
        /// <remarks>
        /// The Location object is used to represent an address that can be associated with an employee 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;LocationResponse&gt;</returns>
        ApiResponse<List<LocationResponse>> DeveloperWorkLocations20230301WithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeveloperApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Company
        /// </summary>
        /// <remarks>
        /// Retrieve company information 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;CompanyResponse&gt;</returns>
        System.Threading.Tasks.Task<List<CompanyResponse>> DeveloperCompanies20230301Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Company
        /// </summary>
        /// <remarks>
        /// Retrieve company information 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;CompanyResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CompanyResponse>>> DeveloperCompanies20230301WithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Create employee
        /// </summary>
        /// <remarks>
        /// Creates a new Employee 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createEmployeeRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmployeeResponse</returns>
        System.Threading.Tasks.Task<EmployeeResponse> DeveloperCreateEmployee20230301Async(CreateEmployeeRequest createEmployeeRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create employee
        /// </summary>
        /// <remarks>
        /// Creates a new Employee 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createEmployeeRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmployeeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmployeeResponse>> DeveloperCreateEmployee20230301WithHttpInfoAsync(CreateEmployeeRequest createEmployeeRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Employees
        /// </summary>
        /// <remarks>
        /// List the individuals (employees, contractors, accountants, and others) listed in the HRIS/Payroll software 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;EmployeeResponse&gt;</returns>
        System.Threading.Tasks.Task<List<EmployeeResponse>> DeveloperEmployees20230301Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Employees
        /// </summary>
        /// <remarks>
        /// List the individuals (employees, contractors, accountants, and others) listed in the HRIS/Payroll software 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;EmployeeResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<EmployeeResponse>>> DeveloperEmployees20230301WithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Groups
        /// </summary>
        /// <remarks>
        /// The Group object is used to represent any subset of employees, such as PayGroup, Team, or Department. Employees can be in multiple Groups. 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;GroupResponse&gt;</returns>
        System.Threading.Tasks.Task<List<GroupResponse>> DeveloperGroups20230301Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Groups
        /// </summary>
        /// <remarks>
        /// The Group object is used to represent any subset of employees, such as PayGroup, Team, or Department. Employees can be in multiple Groups. 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;GroupResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<GroupResponse>>> DeveloperGroups20230301WithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Identity
        /// </summary>
        /// <remarks>
        /// List information of the user for the respective account 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IdentityResponse</returns>
        System.Threading.Tasks.Task<IdentityResponse> DeveloperIdentity20230301Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Identity
        /// </summary>
        /// <remarks>
        /// List information of the user for the respective account 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IdentityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IdentityResponse>> DeveloperIdentity20230301WithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Payruns
        /// </summary>
        /// <remarks>
        /// List all the pay runs that occurred during the respective period.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The start date of the search period</param>
        /// <param name="endDate">The end date of the search period</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PayrunResponse&gt;</returns>
        System.Threading.Tasks.Task<List<PayrunResponse>> DeveloperPayruns20230301Async(DateTime startDate, DateTime endDate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Payruns
        /// </summary>
        /// <remarks>
        /// List all the pay runs that occurred during the respective period.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The start date of the search period</param>
        /// <param name="endDate">The end date of the search period</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PayrunResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PayrunResponse>>> DeveloperPayruns20230301WithHttpInfoAsync(DateTime startDate, DateTime endDate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Payslips
        /// </summary>
        /// <remarks>
        /// Retrieves payslips from a specific payrun.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payrunId">The id of the payrun.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PayslipResponse&gt;</returns>
        System.Threading.Tasks.Task<List<PayslipResponse>> DeveloperPayslips20230301Async(string payrunId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Payslips
        /// </summary>
        /// <remarks>
        /// Retrieves payslips from a specific payrun.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payrunId">The id of the payrun.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PayslipResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PayslipResponse>>> DeveloperPayslips20230301WithHttpInfoAsync(string payrunId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Time off balances
        /// </summary>
        /// <remarks>
        /// Retrieve all time off balances. 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;TimeOffBalanceResponse&gt;</returns>
        System.Threading.Tasks.Task<List<TimeOffBalanceResponse>> DeveloperTimeOffBalances20230301Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Time off balances
        /// </summary>
        /// <remarks>
        /// Retrieve all time off balances. 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;TimeOffBalanceResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TimeOffBalanceResponse>>> DeveloperTimeOffBalances20230301WithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Time off entries
        /// </summary>
        /// <remarks>
        /// Retrieve time off / absence entries 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;TimeOffEntryResponse&gt;</returns>
        System.Threading.Tasks.Task<List<TimeOffEntryResponse>> DeveloperTimeOffEntries20230301Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Time off entries
        /// </summary>
        /// <remarks>
        /// Retrieve time off / absence entries 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;TimeOffEntryResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TimeOffEntryResponse>>> DeveloperTimeOffEntries20230301WithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieve Timesheets 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;TimesheetResponse&gt;</returns>
        System.Threading.Tasks.Task<List<TimesheetResponse>> DeveloperTimesheets20230301Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieve Timesheets 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;TimesheetResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TimesheetResponse>>> DeveloperTimesheets20230301WithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Work locations
        /// </summary>
        /// <remarks>
        /// The Location object is used to represent an address that can be associated with an employee 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;LocationResponse&gt;</returns>
        System.Threading.Tasks.Task<List<LocationResponse>> DeveloperWorkLocations20230301Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Work locations
        /// </summary>
        /// <remarks>
        /// The Location object is used to represent an address that can be associated with an employee 
        /// </remarks>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;LocationResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LocationResponse>>> DeveloperWorkLocations20230301WithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeveloperApi : IDeveloperApiSync, IDeveloperApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DeveloperApi : IDeveloperApi
    {
        private AffixApi.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeveloperApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeveloperApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeveloperApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeveloperApi(String basePath)
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
        /// Initializes a new instance of the <see cref="DeveloperApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DeveloperApi(AffixApi.Api.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="DeveloperApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DeveloperApi(AffixApi.Api.Client.ISynchronousClient client, AffixApi.Api.Client.IAsynchronousClient asyncClient, AffixApi.Api.Client.IReadableConfiguration configuration)
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
        /// Company Retrieve company information 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CompanyResponse&gt;</returns>
        public List<CompanyResponse> DeveloperCompanies20230301()
        {
            AffixApi.Api.Client.ApiResponse<List<CompanyResponse>> localVarResponse = DeveloperCompanies20230301WithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Company Retrieve company information 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CompanyResponse&gt;</returns>
        public AffixApi.Api.Client.ApiResponse<List<CompanyResponse>> DeveloperCompanies20230301WithHttpInfo()
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
            var localVarResponse = this.Client.Get<List<CompanyResponse>>("/2023-03-01/developer/company", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperCompanies20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Company Retrieve company information 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;CompanyResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<CompanyResponse>> DeveloperCompanies20230301Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<List<CompanyResponse>> localVarResponse = await DeveloperCompanies20230301WithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Company Retrieve company information 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;CompanyResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<List<CompanyResponse>>> DeveloperCompanies20230301WithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<CompanyResponse>>("/2023-03-01/developer/company", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperCompanies20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create employee Creates a new Employee 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createEmployeeRequest"></param>
        /// <returns>EmployeeResponse</returns>
        public EmployeeResponse DeveloperCreateEmployee20230301(CreateEmployeeRequest createEmployeeRequest)
        {
            AffixApi.Api.Client.ApiResponse<EmployeeResponse> localVarResponse = DeveloperCreateEmployee20230301WithHttpInfo(createEmployeeRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create employee Creates a new Employee 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createEmployeeRequest"></param>
        /// <returns>ApiResponse of EmployeeResponse</returns>
        public AffixApi.Api.Client.ApiResponse<EmployeeResponse> DeveloperCreateEmployee20230301WithHttpInfo(CreateEmployeeRequest createEmployeeRequest)
        {
            // verify the required parameter 'createEmployeeRequest' is set
            if (createEmployeeRequest == null)
                throw new AffixApi.Api.Client.ApiException(400, "Missing required parameter 'createEmployeeRequest' when calling DeveloperApi->DeveloperCreateEmployee20230301");

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

            localVarRequestOptions.Data = createEmployeeRequest;

            // authentication (access-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<EmployeeResponse>("/2023-03-01/developer/employee", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperCreateEmployee20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create employee Creates a new Employee 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createEmployeeRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmployeeResponse</returns>
        public async System.Threading.Tasks.Task<EmployeeResponse> DeveloperCreateEmployee20230301Async(CreateEmployeeRequest createEmployeeRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<EmployeeResponse> localVarResponse = await DeveloperCreateEmployee20230301WithHttpInfoAsync(createEmployeeRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create employee Creates a new Employee 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createEmployeeRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmployeeResponse)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<EmployeeResponse>> DeveloperCreateEmployee20230301WithHttpInfoAsync(CreateEmployeeRequest createEmployeeRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'createEmployeeRequest' is set
            if (createEmployeeRequest == null)
                throw new AffixApi.Api.Client.ApiException(400, "Missing required parameter 'createEmployeeRequest' when calling DeveloperApi->DeveloperCreateEmployee20230301");


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

            localVarRequestOptions.Data = createEmployeeRequest;

            // authentication (access-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<EmployeeResponse>("/2023-03-01/developer/employee", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperCreateEmployee20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Employees List the individuals (employees, contractors, accountants, and others) listed in the HRIS/Payroll software 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;EmployeeResponse&gt;</returns>
        public List<EmployeeResponse> DeveloperEmployees20230301()
        {
            AffixApi.Api.Client.ApiResponse<List<EmployeeResponse>> localVarResponse = DeveloperEmployees20230301WithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Employees List the individuals (employees, contractors, accountants, and others) listed in the HRIS/Payroll software 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;EmployeeResponse&gt;</returns>
        public AffixApi.Api.Client.ApiResponse<List<EmployeeResponse>> DeveloperEmployees20230301WithHttpInfo()
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
            var localVarResponse = this.Client.Get<List<EmployeeResponse>>("/2023-03-01/developer/employees", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperEmployees20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Employees List the individuals (employees, contractors, accountants, and others) listed in the HRIS/Payroll software 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;EmployeeResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<EmployeeResponse>> DeveloperEmployees20230301Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<List<EmployeeResponse>> localVarResponse = await DeveloperEmployees20230301WithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Employees List the individuals (employees, contractors, accountants, and others) listed in the HRIS/Payroll software 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;EmployeeResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<List<EmployeeResponse>>> DeveloperEmployees20230301WithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<EmployeeResponse>>("/2023-03-01/developer/employees", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperEmployees20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Groups The Group object is used to represent any subset of employees, such as PayGroup, Team, or Department. Employees can be in multiple Groups. 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;GroupResponse&gt;</returns>
        public List<GroupResponse> DeveloperGroups20230301()
        {
            AffixApi.Api.Client.ApiResponse<List<GroupResponse>> localVarResponse = DeveloperGroups20230301WithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Groups The Group object is used to represent any subset of employees, such as PayGroup, Team, or Department. Employees can be in multiple Groups. 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;GroupResponse&gt;</returns>
        public AffixApi.Api.Client.ApiResponse<List<GroupResponse>> DeveloperGroups20230301WithHttpInfo()
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
            var localVarResponse = this.Client.Get<List<GroupResponse>>("/2023-03-01/developer/groups", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperGroups20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Groups The Group object is used to represent any subset of employees, such as PayGroup, Team, or Department. Employees can be in multiple Groups. 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;GroupResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<GroupResponse>> DeveloperGroups20230301Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<List<GroupResponse>> localVarResponse = await DeveloperGroups20230301WithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Groups The Group object is used to represent any subset of employees, such as PayGroup, Team, or Department. Employees can be in multiple Groups. 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;GroupResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<List<GroupResponse>>> DeveloperGroups20230301WithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<GroupResponse>>("/2023-03-01/developer/groups", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperGroups20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Identity List information of the user for the respective account 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IdentityResponse</returns>
        public IdentityResponse DeveloperIdentity20230301()
        {
            AffixApi.Api.Client.ApiResponse<IdentityResponse> localVarResponse = DeveloperIdentity20230301WithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Identity List information of the user for the respective account 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IdentityResponse</returns>
        public AffixApi.Api.Client.ApiResponse<IdentityResponse> DeveloperIdentity20230301WithHttpInfo()
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
            var localVarResponse = this.Client.Get<IdentityResponse>("/2023-03-01/developer/identity", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperIdentity20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Identity List information of the user for the respective account 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IdentityResponse</returns>
        public async System.Threading.Tasks.Task<IdentityResponse> DeveloperIdentity20230301Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<IdentityResponse> localVarResponse = await DeveloperIdentity20230301WithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Identity List information of the user for the respective account 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IdentityResponse)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<IdentityResponse>> DeveloperIdentity20230301WithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<IdentityResponse>("/2023-03-01/developer/identity", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperIdentity20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Payruns List all the pay runs that occurred during the respective period.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The start date of the search period</param>
        /// <param name="endDate">The end date of the search period</param>
        /// <returns>List&lt;PayrunResponse&gt;</returns>
        public List<PayrunResponse> DeveloperPayruns20230301(DateTime startDate, DateTime endDate)
        {
            AffixApi.Api.Client.ApiResponse<List<PayrunResponse>> localVarResponse = DeveloperPayruns20230301WithHttpInfo(startDate, endDate);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Payruns List all the pay runs that occurred during the respective period.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The start date of the search period</param>
        /// <param name="endDate">The end date of the search period</param>
        /// <returns>ApiResponse of List&lt;PayrunResponse&gt;</returns>
        public AffixApi.Api.Client.ApiResponse<List<PayrunResponse>> DeveloperPayruns20230301WithHttpInfo(DateTime startDate, DateTime endDate)
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

            localVarRequestOptions.QueryParameters.Add(AffixApi.Api.Client.ClientUtils.ParameterToMultiMap("", "start_date", startDate));
            localVarRequestOptions.QueryParameters.Add(AffixApi.Api.Client.ClientUtils.ParameterToMultiMap("", "end_date", endDate));

            // authentication (access-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<PayrunResponse>>("/2023-03-01/developer/payruns", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperPayruns20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Payruns List all the pay runs that occurred during the respective period.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The start date of the search period</param>
        /// <param name="endDate">The end date of the search period</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PayrunResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<PayrunResponse>> DeveloperPayruns20230301Async(DateTime startDate, DateTime endDate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<List<PayrunResponse>> localVarResponse = await DeveloperPayruns20230301WithHttpInfoAsync(startDate, endDate, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Payruns List all the pay runs that occurred during the respective period.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The start date of the search period</param>
        /// <param name="endDate">The end date of the search period</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PayrunResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<List<PayrunResponse>>> DeveloperPayruns20230301WithHttpInfoAsync(DateTime startDate, DateTime endDate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.QueryParameters.Add(AffixApi.Api.Client.ClientUtils.ParameterToMultiMap("", "start_date", startDate));
            localVarRequestOptions.QueryParameters.Add(AffixApi.Api.Client.ClientUtils.ParameterToMultiMap("", "end_date", endDate));

            // authentication (access-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<PayrunResponse>>("/2023-03-01/developer/payruns", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperPayruns20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Payslips Retrieves payslips from a specific payrun.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payrunId">The id of the payrun.</param>
        /// <returns>List&lt;PayslipResponse&gt;</returns>
        public List<PayslipResponse> DeveloperPayslips20230301(string payrunId)
        {
            AffixApi.Api.Client.ApiResponse<List<PayslipResponse>> localVarResponse = DeveloperPayslips20230301WithHttpInfo(payrunId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Payslips Retrieves payslips from a specific payrun.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payrunId">The id of the payrun.</param>
        /// <returns>ApiResponse of List&lt;PayslipResponse&gt;</returns>
        public AffixApi.Api.Client.ApiResponse<List<PayslipResponse>> DeveloperPayslips20230301WithHttpInfo(string payrunId)
        {
            // verify the required parameter 'payrunId' is set
            if (payrunId == null)
                throw new AffixApi.Api.Client.ApiException(400, "Missing required parameter 'payrunId' when calling DeveloperApi->DeveloperPayslips20230301");

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

            localVarRequestOptions.PathParameters.Add("payrun_id", AffixApi.Api.Client.ClientUtils.ParameterToString(payrunId)); // path parameter

            // authentication (access-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<PayslipResponse>>("/2023-03-01/developer/payruns/{payrun_id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperPayslips20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Payslips Retrieves payslips from a specific payrun.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payrunId">The id of the payrun.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PayslipResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<PayslipResponse>> DeveloperPayslips20230301Async(string payrunId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<List<PayslipResponse>> localVarResponse = await DeveloperPayslips20230301WithHttpInfoAsync(payrunId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Payslips Retrieves payslips from a specific payrun.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payrunId">The id of the payrun.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PayslipResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<List<PayslipResponse>>> DeveloperPayslips20230301WithHttpInfoAsync(string payrunId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'payrunId' is set
            if (payrunId == null)
                throw new AffixApi.Api.Client.ApiException(400, "Missing required parameter 'payrunId' when calling DeveloperApi->DeveloperPayslips20230301");


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

            localVarRequestOptions.PathParameters.Add("payrun_id", AffixApi.Api.Client.ClientUtils.ParameterToString(payrunId)); // path parameter

            // authentication (access-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<PayslipResponse>>("/2023-03-01/developer/payruns/{payrun_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperPayslips20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Time off balances Retrieve all time off balances. 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;TimeOffBalanceResponse&gt;</returns>
        public List<TimeOffBalanceResponse> DeveloperTimeOffBalances20230301()
        {
            AffixApi.Api.Client.ApiResponse<List<TimeOffBalanceResponse>> localVarResponse = DeveloperTimeOffBalances20230301WithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Time off balances Retrieve all time off balances. 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;TimeOffBalanceResponse&gt;</returns>
        public AffixApi.Api.Client.ApiResponse<List<TimeOffBalanceResponse>> DeveloperTimeOffBalances20230301WithHttpInfo()
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
            var localVarResponse = this.Client.Get<List<TimeOffBalanceResponse>>("/2023-03-01/developer/time-off-balances", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperTimeOffBalances20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Time off balances Retrieve all time off balances. 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;TimeOffBalanceResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<TimeOffBalanceResponse>> DeveloperTimeOffBalances20230301Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<List<TimeOffBalanceResponse>> localVarResponse = await DeveloperTimeOffBalances20230301WithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Time off balances Retrieve all time off balances. 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;TimeOffBalanceResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<List<TimeOffBalanceResponse>>> DeveloperTimeOffBalances20230301WithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<TimeOffBalanceResponse>>("/2023-03-01/developer/time-off-balances", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperTimeOffBalances20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Time off entries Retrieve time off / absence entries 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;TimeOffEntryResponse&gt;</returns>
        public List<TimeOffEntryResponse> DeveloperTimeOffEntries20230301()
        {
            AffixApi.Api.Client.ApiResponse<List<TimeOffEntryResponse>> localVarResponse = DeveloperTimeOffEntries20230301WithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Time off entries Retrieve time off / absence entries 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;TimeOffEntryResponse&gt;</returns>
        public AffixApi.Api.Client.ApiResponse<List<TimeOffEntryResponse>> DeveloperTimeOffEntries20230301WithHttpInfo()
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
            var localVarResponse = this.Client.Get<List<TimeOffEntryResponse>>("/2023-03-01/developer/time-off-entries", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperTimeOffEntries20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Time off entries Retrieve time off / absence entries 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;TimeOffEntryResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<TimeOffEntryResponse>> DeveloperTimeOffEntries20230301Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<List<TimeOffEntryResponse>> localVarResponse = await DeveloperTimeOffEntries20230301WithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Time off entries Retrieve time off / absence entries 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;TimeOffEntryResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<List<TimeOffEntryResponse>>> DeveloperTimeOffEntries20230301WithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<TimeOffEntryResponse>>("/2023-03-01/developer/time-off-entries", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperTimeOffEntries20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Timesheets Retrieve Timesheets 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;TimesheetResponse&gt;</returns>
        public List<TimesheetResponse> DeveloperTimesheets20230301()
        {
            AffixApi.Api.Client.ApiResponse<List<TimesheetResponse>> localVarResponse = DeveloperTimesheets20230301WithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Timesheets Retrieve Timesheets 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;TimesheetResponse&gt;</returns>
        public AffixApi.Api.Client.ApiResponse<List<TimesheetResponse>> DeveloperTimesheets20230301WithHttpInfo()
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
            var localVarResponse = this.Client.Get<List<TimesheetResponse>>("/2023-03-01/developer/timesheets", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperTimesheets20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Timesheets Retrieve Timesheets 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;TimesheetResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<TimesheetResponse>> DeveloperTimesheets20230301Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<List<TimesheetResponse>> localVarResponse = await DeveloperTimesheets20230301WithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Timesheets Retrieve Timesheets 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;TimesheetResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<List<TimesheetResponse>>> DeveloperTimesheets20230301WithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<TimesheetResponse>>("/2023-03-01/developer/timesheets", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperTimesheets20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Work locations The Location object is used to represent an address that can be associated with an employee 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;LocationResponse&gt;</returns>
        public List<LocationResponse> DeveloperWorkLocations20230301()
        {
            AffixApi.Api.Client.ApiResponse<List<LocationResponse>> localVarResponse = DeveloperWorkLocations20230301WithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Work locations The Location object is used to represent an address that can be associated with an employee 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;LocationResponse&gt;</returns>
        public AffixApi.Api.Client.ApiResponse<List<LocationResponse>> DeveloperWorkLocations20230301WithHttpInfo()
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
            var localVarResponse = this.Client.Get<List<LocationResponse>>("/2023-03-01/developer/work-locations", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperWorkLocations20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Work locations The Location object is used to represent an address that can be associated with an employee 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;LocationResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<LocationResponse>> DeveloperWorkLocations20230301Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AffixApi.Api.Client.ApiResponse<List<LocationResponse>> localVarResponse = await DeveloperWorkLocations20230301WithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Work locations The Location object is used to represent an address that can be associated with an employee 
        /// </summary>
        /// <exception cref="AffixApi.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;LocationResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<AffixApi.Api.Client.ApiResponse<List<LocationResponse>>> DeveloperWorkLocations20230301WithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<LocationResponse>>("/2023-03-01/developer/work-locations", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeveloperWorkLocations20230301", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
