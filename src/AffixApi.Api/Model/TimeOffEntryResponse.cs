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
        /// <param name="startDate">startDate (required).</param>
        /// <param name="endDate">endDate (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="unit">unit (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="employeeNote">employeeNote (required).</param>
        /// <param name="requestType">requestType (required).</param>
        /// <param name="remoteCreatedAt">remoteCreatedAt (required).</param>
        /// <param name="remoteModifiedAt">remoteModifiedAt (required).</param>
        public TimeOffEntryResponse(string id = default(string), string remoteId = default(string), string employeeId = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), decimal amount = default(decimal), UnitEnum unit = default(UnitEnum), StatusEnum status = default(StatusEnum), string employeeNote = default(string), string requestType = default(string), DateTime? remoteCreatedAt = default(DateTime?), DateTime? remoteModifiedAt = default(DateTime?))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for TimeOffEntryResponse and cannot be null");
            // to ensure "remoteId" is required (not null)
            this.RemoteId = remoteId ?? throw new ArgumentNullException("remoteId is a required property for TimeOffEntryResponse and cannot be null");
            // to ensure "employeeId" is required (not null)
            this.EmployeeId = employeeId ?? throw new ArgumentNullException("employeeId is a required property for TimeOffEntryResponse and cannot be null");
            // to ensure "startDate" is required (not null)
            this.StartDate = startDate ?? throw new ArgumentNullException("startDate is a required property for TimeOffEntryResponse and cannot be null");
            // to ensure "endDate" is required (not null)
            this.EndDate = endDate ?? throw new ArgumentNullException("endDate is a required property for TimeOffEntryResponse and cannot be null");
            this.Amount = amount;
            this.Unit = unit;
            this.Status = status;
            // to ensure "employeeNote" is required (not null)
            this.EmployeeNote = employeeNote ?? throw new ArgumentNullException("employeeNote is a required property for TimeOffEntryResponse and cannot be null");
            // to ensure "requestType" is required (not null)
            this.RequestType = requestType ?? throw new ArgumentNullException("requestType is a required property for TimeOffEntryResponse and cannot be null");
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
        /// Gets or Sets RequestType
        /// </summary>
        [DataMember(Name = "request_type", IsRequired = true, EmitDefaultValue = true)]
        public string RequestType { get; set; }

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
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EmployeeNote: ").Append(EmployeeNote).Append("\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
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
                    this.RequestType == input.RequestType ||
                    (this.RequestType != null &&
                    this.RequestType.Equals(input.RequestType))
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.Unit.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.EmployeeNote != null)
                    hashCode = hashCode * 59 + this.EmployeeNote.GetHashCode();
                if (this.RequestType != null)
                    hashCode = hashCode * 59 + this.RequestType.GetHashCode();
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
