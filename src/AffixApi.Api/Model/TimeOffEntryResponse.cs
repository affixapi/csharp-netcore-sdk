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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AffixApi.Api.Client.OpenAPIDateConverter;

namespace AffixApi.Api.Model
{
    /// <summary>
    /// TimeOffEntryResponse
    /// </summary>
    [DataContract(Name = "TimeOffEntryResponse")]
    public partial class TimeOffEntryResponse : IEquatable<TimeOffEntryResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines Unit
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitEnum
        {
            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 1,

            /// <summary>
            /// Enum Hours for value: hours
            /// </summary>
            [EnumMember(Value = "hours")]
            Hours = 2,

            /// <summary>
            /// Enum Days for value: days
            /// </summary>
            [EnumMember(Value = "days")]
            Days = 3,

            /// <summary>
            /// Enum Months for value: months
            /// </summary>
            [EnumMember(Value = "months")]
            Months = 4

        }


        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "unit", IsRequired = true, EmitDefaultValue = false)]
        public UnitEnum Unit { get; set; }
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 1,

            /// <summary>
            /// Enum Approved for value: approved
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved = 2,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 3,

            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected = 4

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffEntryResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimeOffEntryResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffEntryResponse" /> class.
        /// </summary>
        /// <param name="id">The Affix-assigned id of the time off entry (required).</param>
        /// <param name="remoteId">the remote system-assigned id of the time off entry (required).</param>
        /// <param name="employeeId">the Affix-assigned id of the individual (required).</param>
        /// <param name="employeeRemoteId">the remote system-assigned id of the individual (required).</param>
        /// <param name="startDate">startDate (required).</param>
        /// <param name="endDate">endDate (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="unit">unit (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="employeeNote">employeeNote (required).</param>
        /// <param name="policyId">The Affix-assigned id of the policy (required).</param>
        /// <param name="policyRemoteId">The remote system-assigned id of the policy (required).</param>
        /// <param name="policyName">The name of the policy, as assigned by the remote system (required).</param>
        /// <param name="policyType">policyType (required).</param>
        /// <param name="remoteCreatedAt">remoteCreatedAt (required).</param>
        /// <param name="remoteModifiedAt">remoteModifiedAt (required).</param>
        public TimeOffEntryResponse(string id = default(string), string remoteId = default(string), string employeeId = default(string), string employeeRemoteId = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), decimal amount = default(decimal), UnitEnum unit = default(UnitEnum), StatusEnum status = default(StatusEnum), string employeeNote = default(string), string policyId = default(string), string policyRemoteId = default(string), string policyName = default(string), PolicyTypeResponse policyType = default(PolicyTypeResponse), DateTime? remoteCreatedAt = default(DateTime?), DateTime? remoteModifiedAt = default(DateTime?))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for TimeOffEntryResponse and cannot be null");
            // to ensure "remoteId" is required (not null)
            this.RemoteId = remoteId ?? throw new ArgumentNullException("remoteId is a required property for TimeOffEntryResponse and cannot be null");
            // to ensure "employeeId" is required (not null)
            this.EmployeeId = employeeId ?? throw new ArgumentNullException("employeeId is a required property for TimeOffEntryResponse and cannot be null");
            // to ensure "employeeRemoteId" is required (not null)
            this.EmployeeRemoteId = employeeRemoteId ?? throw new ArgumentNullException("employeeRemoteId is a required property for TimeOffEntryResponse and cannot be null");
            // to ensure "startDate" is required (not null)
            this.StartDate = startDate ?? throw new ArgumentNullException("startDate is a required property for TimeOffEntryResponse and cannot be null");
            // to ensure "endDate" is required (not null)
            this.EndDate = endDate ?? throw new ArgumentNullException("endDate is a required property for TimeOffEntryResponse and cannot be null");
            this.Amount = amount;
            this.Unit = unit;
            this.Status = status;
            // to ensure "employeeNote" is required (not null)
            this.EmployeeNote = employeeNote ?? throw new ArgumentNullException("employeeNote is a required property for TimeOffEntryResponse and cannot be null");
            // to ensure "policyId" is required (not null)
            this.PolicyId = policyId ?? throw new ArgumentNullException("policyId is a required property for TimeOffEntryResponse and cannot be null");
            // to ensure "policyRemoteId" is required (not null)
            this.PolicyRemoteId = policyRemoteId ?? throw new ArgumentNullException("policyRemoteId is a required property for TimeOffEntryResponse and cannot be null");
            // to ensure "policyName" is required (not null)
            this.PolicyName = policyName ?? throw new ArgumentNullException("policyName is a required property for TimeOffEntryResponse and cannot be null");
            // to ensure "policyType" is required (not null)
            this.PolicyType = policyType;
            // to ensure "remoteCreatedAt" is required (not null)
            this.RemoteCreatedAt = remoteCreatedAt ?? throw new ArgumentNullException("remoteCreatedAt is a required property for TimeOffEntryResponse and cannot be null");
            // to ensure "remoteModifiedAt" is required (not null)
            this.RemoteModifiedAt = remoteModifiedAt ?? throw new ArgumentNullException("remoteModifiedAt is a required property for TimeOffEntryResponse and cannot be null");
        }

        /// <summary>
        /// The Affix-assigned id of the time off entry
        /// </summary>
        /// <value>The Affix-assigned id of the time off entry</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// the remote system-assigned id of the time off entry
        /// </summary>
        /// <value>the remote system-assigned id of the time off entry</value>
        [DataMember(Name = "remote_id", IsRequired = true, EmitDefaultValue = false)]
        public string RemoteId { get; set; }

        /// <summary>
        /// the Affix-assigned id of the individual
        /// </summary>
        /// <value>the Affix-assigned id of the individual</value>
        [DataMember(Name = "employee_id", IsRequired = true, EmitDefaultValue = false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// the remote system-assigned id of the individual
        /// </summary>
        /// <value>the remote system-assigned id of the individual</value>
        [DataMember(Name = "employee_remote_id", IsRequired = true, EmitDefaultValue = false)]
        public string EmployeeRemoteId { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "start_date", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "end_date", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeNote
        /// </summary>
        [DataMember(Name = "employee_note", IsRequired = true, EmitDefaultValue = true)]
        public string EmployeeNote { get; set; }

        /// <summary>
        /// The Affix-assigned id of the policy
        /// </summary>
        /// <value>The Affix-assigned id of the policy</value>
        [DataMember(Name = "policy_id", IsRequired = true, EmitDefaultValue = true)]
        public string PolicyId { get; set; }

        /// <summary>
        /// The remote system-assigned id of the policy
        /// </summary>
        /// <value>The remote system-assigned id of the policy</value>
        [DataMember(Name = "policy_remote_id", IsRequired = true, EmitDefaultValue = true)]
        public string PolicyRemoteId { get; set; }

        /// <summary>
        /// The name of the policy, as assigned by the remote system
        /// </summary>
        /// <value>The name of the policy, as assigned by the remote system</value>
        [DataMember(Name = "policy_name", IsRequired = true, EmitDefaultValue = true)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Gets or Sets PolicyType
        /// </summary>
        [DataMember(Name = "policy_type", IsRequired = true, EmitDefaultValue = true)]
        public PolicyTypeResponse PolicyType { get; set; }

        /// <summary>
        /// Gets or Sets RemoteCreatedAt
        /// </summary>
        [DataMember(Name = "remote_created_at", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? RemoteCreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets RemoteModifiedAt
        /// </summary>
        [DataMember(Name = "remote_modified_at", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? RemoteModifiedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeOffEntryResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  EmployeeRemoteId: ").Append(EmployeeRemoteId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EmployeeNote: ").Append(EmployeeNote).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  PolicyRemoteId: ").Append(PolicyRemoteId).Append("\n");
            sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
            sb.Append("  PolicyType: ").Append(PolicyType).Append("\n");
            sb.Append("  RemoteCreatedAt: ").Append(RemoteCreatedAt).Append("\n");
            sb.Append("  RemoteModifiedAt: ").Append(RemoteModifiedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TimeOffEntryResponse);
        }

        /// <summary>
        /// Returns true if TimeOffEntryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeOffEntryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeOffEntryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RemoteId == input.RemoteId ||
                    (this.RemoteId != null &&
                    this.RemoteId.Equals(input.RemoteId))
                ) && 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.EmployeeRemoteId == input.EmployeeRemoteId ||
                    (this.EmployeeRemoteId != null &&
                    this.EmployeeRemoteId.Equals(input.EmployeeRemoteId))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Unit == input.Unit ||
                    this.Unit.Equals(input.Unit)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.EmployeeNote == input.EmployeeNote ||
                    (this.EmployeeNote != null &&
                    this.EmployeeNote.Equals(input.EmployeeNote))
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.PolicyRemoteId == input.PolicyRemoteId ||
                    (this.PolicyRemoteId != null &&
                    this.PolicyRemoteId.Equals(input.PolicyRemoteId))
                ) && 
                (
                    this.PolicyName == input.PolicyName ||
                    (this.PolicyName != null &&
                    this.PolicyName.Equals(input.PolicyName))
                ) && 
                (
                    this.PolicyType == input.PolicyType ||
                    (this.PolicyType != null &&
                    this.PolicyType.Equals(input.PolicyType))
                ) && 
                (
                    this.RemoteCreatedAt == input.RemoteCreatedAt ||
                    (this.RemoteCreatedAt != null &&
                    this.RemoteCreatedAt.Equals(input.RemoteCreatedAt))
                ) && 
                (
                    this.RemoteModifiedAt == input.RemoteModifiedAt ||
                    (this.RemoteModifiedAt != null &&
                    this.RemoteModifiedAt.Equals(input.RemoteModifiedAt))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RemoteId != null)
                    hashCode = hashCode * 59 + this.RemoteId.GetHashCode();
                if (this.EmployeeId != null)
                    hashCode = hashCode * 59 + this.EmployeeId.GetHashCode();
                if (this.EmployeeRemoteId != null)
                    hashCode = hashCode * 59 + this.EmployeeRemoteId.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.Unit.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.EmployeeNote != null)
                    hashCode = hashCode * 59 + this.EmployeeNote.GetHashCode();
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.PolicyRemoteId != null)
                    hashCode = hashCode * 59 + this.PolicyRemoteId.GetHashCode();
                if (this.PolicyName != null)
                    hashCode = hashCode * 59 + this.PolicyName.GetHashCode();
                if (this.PolicyType != null)
                    hashCode = hashCode * 59 + this.PolicyType.GetHashCode();
                if (this.RemoteCreatedAt != null)
                    hashCode = hashCode * 59 + this.RemoteCreatedAt.GetHashCode();
                if (this.RemoteModifiedAt != null)
                    hashCode = hashCode * 59 + this.RemoteModifiedAt.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
