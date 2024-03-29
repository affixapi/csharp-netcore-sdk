/*
 * Affix API
 *
 * The affixapi.com API documentation.  # Introduction Affix API is an OAuth 2.1 application that allows developers to access customer data, without developers needing to manage or maintain integrations; or collect login credentials or API keys from users for these third party systems.  # OAuth 2.1 Affix API follows the [OAuth 2.1 spec](https://datatracker.ietf.org/doc/html/draft-ietf-oauth-v2-1-08).  As an OAuth application, Affix API handles not only both the collection of sensitive user credentials or API keys, but also builds and maintains the integrations with the providers, so you don't have to.  # How to obtain an access token in order to get started, you must:   - register a `client_id`   - direct your user to the sign in flow  (`https://connect.affixapi.com`     [with the appropriate query     parameters](https://github.com/affixapi/starter-kit/tree/master/connect))   - capture `authorization_code` we will send to your redirect URI after     the sign in flow is complete and exchange that `authorization_code` for     a Bearer token  # Sandbox keys (xhr mode) ### dev ``` eyJhbGciOiJFUzI1NiIsImtpZCI6Ims5RmxwSFR1YklmZWNsUU5QRVZzeFcxazFZZ0Zfbk1BWllOSGVuOFQxdGciLCJ0eXAiOiJKV1MifQ.eyJwcm92aWRlciI6InNhbmRib3giLCJzY29wZXMiOlsiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL2NvbXBhbnkiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvZW1wbG95ZWUiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvZW1wbG95ZWVzIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL2lkZW50aXR5IiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3BheXJ1bnMiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvcGF5cnVucy86cGF5cnVuX2lkIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3RpbWUtb2ZmLWJhbGFuY2VzIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3RpbWUtb2ZmLWVudHJpZXMiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvdGltZXNoZWV0cyJdLCJ0b2tlbiI6ImQ1OTZhMmYzLWYzNzktNGE1ZC1hMmRhLTk4OWJmYWViYTg1ZCIsImlhdCI6MTcwMjkyMDkwMywiaXNzIjoicHVibGljYXBpLWludGVybWVkaWF0ZS5kZXYuZW5naW5lZXJpbmcuYWZmaXhhcGkuY29tIiwic3ViIjoiZGV2ZWxvcGVyIiwiYXVkIjoiM0ZEQUVERjktMURDQTRGNTQtODc5NDlGNkEtNDEwMjc2NDMifQ.VLWYjCQvBS0C3ZA6_J3-U-idZj5EYI2IlDdTjAWBxSIHGufp6cqaVodKsF2BeIqcIeB3P0lW-KL9mY3xGd7ckQ ```  #### `employees` endpoint sample: ``` curl - -fail \\   -X GET \\   -H 'Authorization: Bearer eyJhbGciOiJFUzI1NiIsImtpZCI6Ims5RmxwSFR1YklmZWNsUU5QRVZzeFcxazFZZ0Zfbk1BWllOSGVuOFQxdGciLCJ0eXAiOiJKV1MifQ.eyJwcm92aWRlciI6InNhbmRib3giLCJzY29wZXMiOlsiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL2NvbXBhbnkiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvZW1wbG95ZWUiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvZW1wbG95ZWVzIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL2lkZW50aXR5IiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3BheXJ1bnMiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvcGF5cnVucy86cGF5cnVuX2lkIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3RpbWUtb2ZmLWJhbGFuY2VzIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3RpbWUtb2ZmLWVudHJpZXMiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvdGltZXNoZWV0cyJdLCJ0b2tlbiI6ImQ1OTZhMmYzLWYzNzktNGE1ZC1hMmRhLTk4OWJmYWViYTg1ZCIsImlhdCI6MTcwMjkyMDkwMywiaXNzIjoicHVibGljYXBpLWludGVybWVkaWF0ZS5kZXYuZW5naW5lZXJpbmcuYWZmaXhhcGkuY29tIiwic3ViIjoiZGV2ZWxvcGVyIiwiYXVkIjoiM0ZEQUVERjktMURDQTRGNTQtODc5NDlGNkEtNDEwMjc2NDMifQ.VLWYjCQvBS0C3ZA6_J3-U-idZj5EYI2IlDdTjAWBxSIHGufp6cqaVodKsF2BeIqcIeB3P0lW-KL9mY3xGd7ckQ' \\   'https://dev.api.affixapi.com/2023-03-01/xhr/employees' ```  ### prod ``` eyJhbGciOiJFUzI1NiIsImtpZCI6Ims5RmxwSFR1YklmZWNsUU5QRVZzeFcxazFZZ0Zfbk1BWllOSGVuOFQxdGciLCJ0eXAiOiJKV1MifQ.eyJwcm92aWRlciI6InNhbmRib3giLCJzY29wZXMiOlsiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL2NvbXBhbnkiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvZW1wbG95ZWUiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvZW1wbG95ZWVzIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL2lkZW50aXR5IiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3BheXJ1bnMiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvcGF5cnVucy86cGF5cnVuX2lkIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3RpbWUtb2ZmLWJhbGFuY2VzIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3RpbWUtb2ZmLWVudHJpZXMiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvdGltZXNoZWV0cyJdLCJ0b2tlbiI6IjI5YjFjYTg4LWNlNjktNDgyZC1iNGZjLTkzMWMzZmJkYWM4ZSIsImlhdCI6MTcwMjkyMTA4MywiaXNzIjoicHVibGljYXBpLWludGVybWVkaWF0ZS5wcm9kLmVuZ2luZWVyaW5nLmFmZml4YXBpLmNvbSIsInN1YiI6ImRldmVsb3BlciIsImF1ZCI6IjA4QkIwODFFLUQ5QUI0RDE0LThERjk5MjMzLTY2NjE1Q0U5In0.2zdpFAmiyYiYk6MOcbXNUwwR4M1Fextnaac340x54AidiWXCyw-u9KeavbqfYF6q8a9kcDLrxhJ8Wc_3tIzuVw ```  #### `employees` endpoint sample: ``` curl - -fail \\   -X GET \\   -H 'Authorization: Bearer eyJhbGciOiJFUzI1NiIsImtpZCI6Ims5RmxwSFR1YklmZWNsUU5QRVZzeFcxazFZZ0Zfbk1BWllOSGVuOFQxdGciLCJ0eXAiOiJKV1MifQ.eyJwcm92aWRlciI6InNhbmRib3giLCJzY29wZXMiOlsiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL2NvbXBhbnkiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvZW1wbG95ZWUiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvZW1wbG95ZWVzIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL2lkZW50aXR5IiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3BheXJ1bnMiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvcGF5cnVucy86cGF5cnVuX2lkIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3RpbWUtb2ZmLWJhbGFuY2VzIiwiLzIwMjMtMDMtMDEvZGV2ZWxvcGVyL3RpbWUtb2ZmLWVudHJpZXMiLCIvMjAyMy0wMy0wMS9kZXZlbG9wZXIvdGltZXNoZWV0cyJdLCJ0b2tlbiI6IjI5YjFjYTg4LWNlNjktNDgyZC1iNGZjLTkzMWMzZmJkYWM4ZSIsImlhdCI6MTcwMjkyMTA4MywiaXNzIjoicHVibGljYXBpLWludGVybWVkaWF0ZS5wcm9kLmVuZ2luZWVyaW5nLmFmZml4YXBpLmNvbSIsInN1YiI6ImRldmVsb3BlciIsImF1ZCI6IjA4QkIwODFFLUQ5QUI0RDE0LThERjk5MjMzLTY2NjE1Q0U5In0.2zdpFAmiyYiYk6MOcbXNUwwR4M1Fextnaac340x54AidiWXCyw-u9KeavbqfYF6q8a9kcDLrxhJ8Wc_3tIzuVw' \\   'https://api.affixapi.com/2023-03-01/xhr/employees' ```  # Compression We support `brotli`, `gzip`, and `deflate` compression algorithms.  To enable, pass the `Accept-Encoding` header with one or all of the values: `br`, `gzip`, `deflate`, or `identity` (no compression)  In the response, you will receive the `Content-Encoding` response header indicating the compression algorithm used in the data payload to enable you to decompress the result. If the `Accept-Encoding: identity` header was passed, no `Content-Encoding` response header is sent back, as no compression algorithm was used.  # Webhooks An exciting feature for HR/Payroll modes are webhooks.  If enabled, your `webhook_uri` is set on your `client_id` for the respective environment: `dev | prod`  Webhooks are configured to make live requests to the underlying integration 1x/hr, and if a difference is detected since the last request, we will send a request to your `webhook_uri` with this shape:  ``` {    added: <api.v20230301.Employees>[     <api.v20230301.Employee>{       ...,       date_of_birth: '2010-08-06',       display_full_name: 'Daija Rogahn',       employee_number: '57993',       employment_status: 'pending',       employment_type: 'other',       employments: [         {           currency: 'eur',           effective_date: '2022-02-25',           employment_type: 'other',           job_title: 'Dynamic Implementation Manager',           pay_frequency: 'semimonthly',           pay_period: 'YEAR',           pay_rate: 96000,         },       ],       first_name: 'Daija',       ...     }   ],   removed: [],   updated: [     <api.v20230301.Employee>{       ...,       date_of_birth: '2009-11-09',       display_full_name: 'Lourdes Stiedemann',       employee_number: '63189',       employment_status: 'leave',       employment_type: 'full_time',       employments: [         {           currency: 'gbp',           effective_date: '2023-01-16',           employment_type: 'full_time',           job_title: 'Forward Brand Planner',           pay_frequency: 'semimonthly',           pay_period: 'YEAR',           pay_rate: 86000,         },       ],       first_name: 'Lourdes',     }   ] } ```  the following headers will be sent with webhook requests:  ``` x-affix-api-signature: ab8474e609db95d5df3adc39ea3add7a7544bd215c5c520a30a650ae93a2fba7  x-affix-api-origin:  webhooks-employees-webhook  user-agent:  affixapi.com ```  Before trusting the payload, you should sign the payload and verify the signature matches the signature sent by the `affixapi.com` service.  This secures that the data sent to your `webhook_uri` is from the `affixapi.com` server.  The signature is created by combining the signing secret (your `client_secret`) with the body of the request sent using a standard HMAC-SHA256 keyed hash.  The signature can be created via:   - create an `HMAC` with your `client_secret`   - update the `HMAC` with the payload   - get the hex digest -> this is the signature  Sample `typescript` code that follows this recipe:  ``` import { createHmac } from 'crypto';  export const computeSignature = ({   str,   signingSecret, }: {   signingSecret: string;   str: string; }): string => {   const hmac = createHmac('sha256', signingSecret);   hmac.update(str);   const signature = hmac.digest('hex');    return signature; }; ```  While verifying the Affix API signature header should be your primary method of confirming validity, you can also whitelist our outbound webhook static IP addresses.  ``` dev:   - 52.210.169.82   - 52.210.38.77   - 3.248.135.204  prod:   - 52.51.160.102   - 54.220.83.244   - 3.254.213.171 ```  ## Rate limits Open endpoints (not gated by an API key) (applied at endpoint level):   - 15 requests every 1 minute (by IP address)   - 25 requests every 5 minutes (by IP address)  Gated endpoints (require an API key) (applied at endpoint level):   - 40 requests every 1 minute (by IP address)   - 40 requests every 5 minutes (by `client_id`)  Things to keep in mind:   - Open endpoints (not gated by an API key) will likely be called by your     users, not you, so rate limits generally would not apply to you.   - As a developer, rate limits are applied at the endpoint granularity.     - For example, say the rate limits below are 10 requests per minute by ip.       from that same ip, within 1 minute, you get:       - 10 requests per minute on `/orders`,       - another 10 requests per minute on `/items`,       - and another 10 requests per minute on `/identity`,       - for a total of 30 requests per minute. 
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
    /// EmployeeResponse
    /// </summary>
    [DataContract(Name = "EmployeeResponse")]
    public partial class EmployeeResponse : IEquatable<EmployeeResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines Gender
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GenderEnum
        {
            /// <summary>
            /// Enum Male for value: male
            /// </summary>
            [EnumMember(Value = "male")]
            Male = 1,

            /// <summary>
            /// Enum Female for value: female
            /// </summary>
            [EnumMember(Value = "female")]
            Female = 2,

            /// <summary>
            /// Enum NotSpecified for value: not_specified
            /// </summary>
            [EnumMember(Value = "not_specified")]
            NotSpecified = 3,

            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 4

        }


        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "gender", IsRequired = true, EmitDefaultValue = true)]
        public GenderEnum Gender { get; set; }
        /// <summary>
        /// Defines Ethnicity
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EthnicityEnum
        {
            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 1,

            /// <summary>
            /// Enum Asian for value: asian
            /// </summary>
            [EnumMember(Value = "asian")]
            Asian = 2,

            /// <summary>
            /// Enum Black for value: black
            /// </summary>
            [EnumMember(Value = "black")]
            Black = 3,

            /// <summary>
            /// Enum Hispanic for value: hispanic
            /// </summary>
            [EnumMember(Value = "hispanic")]
            Hispanic = 4,

            /// <summary>
            /// Enum Mixed for value: mixed
            /// </summary>
            [EnumMember(Value = "mixed")]
            Mixed = 5,

            /// <summary>
            /// Enum NotSpecified for value: not_specified
            /// </summary>
            [EnumMember(Value = "not_specified")]
            NotSpecified = 6,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 7,

            /// <summary>
            /// Enum White for value: white
            /// </summary>
            [EnumMember(Value = "white")]
            White = 8

        }


        /// <summary>
        /// Gets or Sets Ethnicity
        /// </summary>
        [DataMember(Name = "ethnicity", IsRequired = true, EmitDefaultValue = true)]
        public EthnicityEnum Ethnicity { get; set; }
        /// <summary>
        /// Defines MaritalStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MaritalStatusEnum
        {
            /// <summary>
            /// Enum Single for value: single
            /// </summary>
            [EnumMember(Value = "single")]
            Single = 1,

            /// <summary>
            /// Enum Married for value: married
            /// </summary>
            [EnumMember(Value = "married")]
            Married = 2,

            /// <summary>
            /// Enum NotSpecified for value: not_specified
            /// </summary>
            [EnumMember(Value = "not_specified")]
            NotSpecified = 3,

            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 4

        }


        /// <summary>
        /// Gets or Sets MaritalStatus
        /// </summary>
        [DataMember(Name = "marital_status", IsRequired = true, EmitDefaultValue = true)]
        public MaritalStatusEnum MaritalStatus { get; set; }
        /// <summary>
        /// Defines EmploymentStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EmploymentStatusEnum
        {
            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 1,

            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 2,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 3,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 4,

            /// <summary>
            /// Enum Leave for value: leave
            /// </summary>
            [EnumMember(Value = "leave")]
            Leave = 5

        }


        /// <summary>
        /// Gets or Sets EmploymentStatus
        /// </summary>
        [DataMember(Name = "employment_status", IsRequired = true, EmitDefaultValue = true)]
        public EmploymentStatusEnum EmploymentStatus { get; set; }
        /// <summary>
        /// Defines EmploymentType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EmploymentTypeEnum
        {
            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 1,

            /// <summary>
            /// Enum FullTime for value: full_time
            /// </summary>
            [EnumMember(Value = "full_time")]
            FullTime = 2,

            /// <summary>
            /// Enum PartTime for value: part_time
            /// </summary>
            [EnumMember(Value = "part_time")]
            PartTime = 3,

            /// <summary>
            /// Enum Contractor for value: contractor
            /// </summary>
            [EnumMember(Value = "contractor")]
            Contractor = 4,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 5

        }


        /// <summary>
        /// Gets or Sets EmploymentType
        /// </summary>
        [DataMember(Name = "employment_type", IsRequired = true, EmitDefaultValue = true)]
        public EmploymentTypeEnum EmploymentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmployeeResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeResponse" /> class.
        /// </summary>
        /// <param name="employeeNumber">employeeNumber (required).</param>
        /// <param name="firstName">the first name of the individual (required).</param>
        /// <param name="lastName">the last name of the individual (required).</param>
        /// <param name="displayFullName">displayFullName (required).</param>
        /// <param name="nationality">nationality (required).</param>
        /// <param name="jobTitle">jobTitle (required).</param>
        /// <param name="workEmail">the work email of the individual (required).</param>
        /// <param name="personalEmail">the personal email of the individual (required).</param>
        /// <param name="mobilePhoneNumber">+1234567890 (required).</param>
        /// <param name="taxId">taxId (required).</param>
        /// <param name="gender">gender (required).</param>
        /// <param name="ethnicity">ethnicity (required).</param>
        /// <param name="maritalStatus">maritalStatus (required).</param>
        /// <param name="dateOfBirth">dateOfBirth (required).</param>
        /// <param name="employmentStatus">employmentStatus (required).</param>
        /// <param name="employmentType">employmentType (required).</param>
        /// <param name="startDate">startDate (required).</param>
        /// <param name="terminationDate">terminationDate (required).</param>
        /// <param name="avatar">avatar (required).</param>
        /// <param name="homeLocation">homeLocation (required).</param>
        /// <param name="workLocation">workLocation (required).</param>
        /// <param name="manager">manager (required).</param>
        /// <param name="bankAccount">bankAccount (required).</param>
        /// <param name="employments">employments (required).</param>
        /// <param name="customFields">customFields (required).</param>
        /// <param name="groups">groups (required).</param>
        public EmployeeResponse(string employeeNumber = default(string), string firstName = default(string), string lastName = default(string), string displayFullName = default(string), string nationality = default(string), string jobTitle = default(string), string workEmail = default(string), string personalEmail = default(string), string mobilePhoneNumber = default(string), string taxId = default(string), GenderEnum gender = default(GenderEnum), EthnicityEnum ethnicity = default(EthnicityEnum), MaritalStatusEnum maritalStatus = default(MaritalStatusEnum), DateTime? dateOfBirth = default(DateTime?), EmploymentStatusEnum employmentStatus = default(EmploymentStatusEnum), EmploymentTypeEnum employmentType = default(EmploymentTypeEnum), DateTime? startDate = default(DateTime?), DateTime? terminationDate = default(DateTime?), string avatar = default(string), AddressResponse homeLocation = default(AddressResponse), LocationResponse workLocation = default(LocationResponse), CreateEmployeeRequestManager manager = default(CreateEmployeeRequestManager), CreateEmployeeRequestBankAccount bankAccount = default(CreateEmployeeRequestBankAccount), List<EmploymentResponse> employments = default(List<EmploymentResponse>), Object customFields = default(Object), List<GroupResponse> groups = default(List<GroupResponse>))
        {
            // to ensure "employeeNumber" is required (not null)
            this.EmployeeNumber = employeeNumber ?? throw new ArgumentNullException("employeeNumber is a required property for EmployeeResponse and cannot be null");
            // to ensure "firstName" is required (not null)
            this.FirstName = firstName ?? throw new ArgumentNullException("firstName is a required property for EmployeeResponse and cannot be null");
            // to ensure "lastName" is required (not null)
            this.LastName = lastName ?? throw new ArgumentNullException("lastName is a required property for EmployeeResponse and cannot be null");
            // to ensure "displayFullName" is required (not null)
            this.DisplayFullName = displayFullName ?? throw new ArgumentNullException("displayFullName is a required property for EmployeeResponse and cannot be null");
            // to ensure "nationality" is required (not null)
            this.Nationality = nationality ?? throw new ArgumentNullException("nationality is a required property for EmployeeResponse and cannot be null");
            // to ensure "jobTitle" is required (not null)
            this.JobTitle = jobTitle ?? throw new ArgumentNullException("jobTitle is a required property for EmployeeResponse and cannot be null");
            // to ensure "workEmail" is required (not null)
            this.WorkEmail = workEmail ?? throw new ArgumentNullException("workEmail is a required property for EmployeeResponse and cannot be null");
            // to ensure "personalEmail" is required (not null)
            this.PersonalEmail = personalEmail ?? throw new ArgumentNullException("personalEmail is a required property for EmployeeResponse and cannot be null");
            // to ensure "mobilePhoneNumber" is required (not null)
            this.MobilePhoneNumber = mobilePhoneNumber ?? throw new ArgumentNullException("mobilePhoneNumber is a required property for EmployeeResponse and cannot be null");
            // to ensure "taxId" is required (not null)
            this.TaxId = taxId ?? throw new ArgumentNullException("taxId is a required property for EmployeeResponse and cannot be null");
            this.Gender = gender;
            this.Ethnicity = ethnicity;
            this.MaritalStatus = maritalStatus;
            // to ensure "dateOfBirth" is required (not null)
            this.DateOfBirth = dateOfBirth ?? throw new ArgumentNullException("dateOfBirth is a required property for EmployeeResponse and cannot be null");
            this.EmploymentStatus = employmentStatus;
            this.EmploymentType = employmentType;
            // to ensure "startDate" is required (not null)
            this.StartDate = startDate ?? throw new ArgumentNullException("startDate is a required property for EmployeeResponse and cannot be null");
            // to ensure "terminationDate" is required (not null)
            this.TerminationDate = terminationDate ?? throw new ArgumentNullException("terminationDate is a required property for EmployeeResponse and cannot be null");
            // to ensure "avatar" is required (not null)
            this.Avatar = avatar ?? throw new ArgumentNullException("avatar is a required property for EmployeeResponse and cannot be null");
            // to ensure "homeLocation" is required (not null)
            this.HomeLocation = homeLocation ?? throw new ArgumentNullException("homeLocation is a required property for EmployeeResponse and cannot be null");
            // to ensure "workLocation" is required (not null)
            this.WorkLocation = workLocation ?? throw new ArgumentNullException("workLocation is a required property for EmployeeResponse and cannot be null");
            // to ensure "manager" is required (not null)
            this.Manager = manager ?? throw new ArgumentNullException("manager is a required property for EmployeeResponse and cannot be null");
            // to ensure "bankAccount" is required (not null)
            this.BankAccount = bankAccount ?? throw new ArgumentNullException("bankAccount is a required property for EmployeeResponse and cannot be null");
            // to ensure "employments" is required (not null)
            this.Employments = employments ?? throw new ArgumentNullException("employments is a required property for EmployeeResponse and cannot be null");
            // to ensure "customFields" is required (not null)
            this.CustomFields = customFields ?? throw new ArgumentNullException("customFields is a required property for EmployeeResponse and cannot be null");
            // to ensure "groups" is required (not null)
            this.Groups = groups ?? throw new ArgumentNullException("groups is a required property for EmployeeResponse and cannot be null");
        }

        /// <summary>
        /// The Affix-assigned id of the individual
        /// </summary>
        /// <value>The Affix-assigned id of the individual</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }

        /// <summary>
        /// the remote system-assigned id of the individual
        /// </summary>
        /// <value>the remote system-assigned id of the individual</value>
        [DataMember(Name = "remote_id", IsRequired = true, EmitDefaultValue = false)]
        public string RemoteId { get; private set; }

        /// <summary>
        /// Returns false as RemoteId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRemoteId()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets EmployeeNumber
        /// </summary>
        [DataMember(Name = "employee_number", IsRequired = true, EmitDefaultValue = true)]
        public string EmployeeNumber { get; set; }

        /// <summary>
        /// the first name of the individual
        /// </summary>
        /// <value>the first name of the individual</value>
        [DataMember(Name = "first_name", IsRequired = true, EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// the last name of the individual
        /// </summary>
        /// <value>the last name of the individual</value>
        [DataMember(Name = "last_name", IsRequired = true, EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets DisplayFullName
        /// </summary>
        [DataMember(Name = "display_full_name", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayFullName { get; set; }

        /// <summary>
        /// Gets or Sets Nationality
        /// </summary>
        [DataMember(Name = "nationality", IsRequired = true, EmitDefaultValue = true)]
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or Sets JobTitle
        /// </summary>
        [DataMember(Name = "job_title", IsRequired = true, EmitDefaultValue = true)]
        public string JobTitle { get; set; }

        /// <summary>
        /// the work email of the individual
        /// </summary>
        /// <value>the work email of the individual</value>
        [DataMember(Name = "work_email", IsRequired = true, EmitDefaultValue = true)]
        public string WorkEmail { get; set; }

        /// <summary>
        /// the personal email of the individual
        /// </summary>
        /// <value>the personal email of the individual</value>
        [DataMember(Name = "personal_email", IsRequired = true, EmitDefaultValue = true)]
        public string PersonalEmail { get; set; }

        /// <summary>
        /// +1234567890
        /// </summary>
        /// <value>+1234567890</value>
        [DataMember(Name = "mobile_phone_number", IsRequired = true, EmitDefaultValue = true)]
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets TaxId
        /// </summary>
        [DataMember(Name = "tax_id", IsRequired = true, EmitDefaultValue = true)]
        public string TaxId { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name = "date_of_birth", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "start_date", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets RemoteCreatedAt
        /// </summary>
        [DataMember(Name = "remote_created_at", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? RemoteCreatedAt { get; private set; }

        /// <summary>
        /// Returns false as RemoteCreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRemoteCreatedAt()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets TerminationDate
        /// </summary>
        [DataMember(Name = "termination_date", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? TerminationDate { get; set; }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name = "avatar", IsRequired = true, EmitDefaultValue = true)]
        public string Avatar { get; set; }

        /// <summary>
        /// Gets or Sets HomeLocation
        /// </summary>
        [DataMember(Name = "home_location", IsRequired = true, EmitDefaultValue = true)]
        public AddressResponse HomeLocation { get; set; }

        /// <summary>
        /// Gets or Sets WorkLocation
        /// </summary>
        [DataMember(Name = "work_location", IsRequired = true, EmitDefaultValue = true)]
        public LocationResponse WorkLocation { get; set; }

        /// <summary>
        /// Gets or Sets Manager
        /// </summary>
        [DataMember(Name = "manager", IsRequired = true, EmitDefaultValue = true)]
        public CreateEmployeeRequestManager Manager { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name = "bank_account", IsRequired = true, EmitDefaultValue = true)]
        public CreateEmployeeRequestBankAccount BankAccount { get; set; }

        /// <summary>
        /// Gets or Sets Employments
        /// </summary>
        [DataMember(Name = "employments", IsRequired = true, EmitDefaultValue = true)]
        public List<EmploymentResponse> Employments { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields", IsRequired = true, EmitDefaultValue = true)]
        public Object CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", IsRequired = true, EmitDefaultValue = true)]
        public List<GroupResponse> Groups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  EmployeeNumber: ").Append(EmployeeNumber).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  DisplayFullName: ").Append(DisplayFullName).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  WorkEmail: ").Append(WorkEmail).Append("\n");
            sb.Append("  PersonalEmail: ").Append(PersonalEmail).Append("\n");
            sb.Append("  MobilePhoneNumber: ").Append(MobilePhoneNumber).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Ethnicity: ").Append(Ethnicity).Append("\n");
            sb.Append("  MaritalStatus: ").Append(MaritalStatus).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  EmploymentStatus: ").Append(EmploymentStatus).Append("\n");
            sb.Append("  EmploymentType: ").Append(EmploymentType).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  RemoteCreatedAt: ").Append(RemoteCreatedAt).Append("\n");
            sb.Append("  TerminationDate: ").Append(TerminationDate).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  HomeLocation: ").Append(HomeLocation).Append("\n");
            sb.Append("  WorkLocation: ").Append(WorkLocation).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  Employments: ").Append(Employments).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            return this.Equals(input as EmployeeResponse);
        }

        /// <summary>
        /// Returns true if EmployeeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeResponse input)
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
                    this.EmployeeNumber == input.EmployeeNumber ||
                    (this.EmployeeNumber != null &&
                    this.EmployeeNumber.Equals(input.EmployeeNumber))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.DisplayFullName == input.DisplayFullName ||
                    (this.DisplayFullName != null &&
                    this.DisplayFullName.Equals(input.DisplayFullName))
                ) && 
                (
                    this.Nationality == input.Nationality ||
                    (this.Nationality != null &&
                    this.Nationality.Equals(input.Nationality))
                ) && 
                (
                    this.JobTitle == input.JobTitle ||
                    (this.JobTitle != null &&
                    this.JobTitle.Equals(input.JobTitle))
                ) && 
                (
                    this.WorkEmail == input.WorkEmail ||
                    (this.WorkEmail != null &&
                    this.WorkEmail.Equals(input.WorkEmail))
                ) && 
                (
                    this.PersonalEmail == input.PersonalEmail ||
                    (this.PersonalEmail != null &&
                    this.PersonalEmail.Equals(input.PersonalEmail))
                ) && 
                (
                    this.MobilePhoneNumber == input.MobilePhoneNumber ||
                    (this.MobilePhoneNumber != null &&
                    this.MobilePhoneNumber.Equals(input.MobilePhoneNumber))
                ) && 
                (
                    this.TaxId == input.TaxId ||
                    (this.TaxId != null &&
                    this.TaxId.Equals(input.TaxId))
                ) && 
                (
                    this.Gender == input.Gender ||
                    this.Gender.Equals(input.Gender)
                ) && 
                (
                    this.Ethnicity == input.Ethnicity ||
                    this.Ethnicity.Equals(input.Ethnicity)
                ) && 
                (
                    this.MaritalStatus == input.MaritalStatus ||
                    this.MaritalStatus.Equals(input.MaritalStatus)
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.EmploymentStatus == input.EmploymentStatus ||
                    this.EmploymentStatus.Equals(input.EmploymentStatus)
                ) && 
                (
                    this.EmploymentType == input.EmploymentType ||
                    this.EmploymentType.Equals(input.EmploymentType)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.RemoteCreatedAt == input.RemoteCreatedAt ||
                    (this.RemoteCreatedAt != null &&
                    this.RemoteCreatedAt.Equals(input.RemoteCreatedAt))
                ) && 
                (
                    this.TerminationDate == input.TerminationDate ||
                    (this.TerminationDate != null &&
                    this.TerminationDate.Equals(input.TerminationDate))
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.HomeLocation == input.HomeLocation ||
                    (this.HomeLocation != null &&
                    this.HomeLocation.Equals(input.HomeLocation))
                ) && 
                (
                    this.WorkLocation == input.WorkLocation ||
                    (this.WorkLocation != null &&
                    this.WorkLocation.Equals(input.WorkLocation))
                ) && 
                (
                    this.Manager == input.Manager ||
                    (this.Manager != null &&
                    this.Manager.Equals(input.Manager))
                ) && 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.Employments == input.Employments ||
                    this.Employments != null &&
                    input.Employments != null &&
                    this.Employments.SequenceEqual(input.Employments)
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    (this.CustomFields != null &&
                    this.CustomFields.Equals(input.CustomFields))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
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
                if (this.EmployeeNumber != null)
                    hashCode = hashCode * 59 + this.EmployeeNumber.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.DisplayFullName != null)
                    hashCode = hashCode * 59 + this.DisplayFullName.GetHashCode();
                if (this.Nationality != null)
                    hashCode = hashCode * 59 + this.Nationality.GetHashCode();
                if (this.JobTitle != null)
                    hashCode = hashCode * 59 + this.JobTitle.GetHashCode();
                if (this.WorkEmail != null)
                    hashCode = hashCode * 59 + this.WorkEmail.GetHashCode();
                if (this.PersonalEmail != null)
                    hashCode = hashCode * 59 + this.PersonalEmail.GetHashCode();
                if (this.MobilePhoneNumber != null)
                    hashCode = hashCode * 59 + this.MobilePhoneNumber.GetHashCode();
                if (this.TaxId != null)
                    hashCode = hashCode * 59 + this.TaxId.GetHashCode();
                hashCode = hashCode * 59 + this.Gender.GetHashCode();
                hashCode = hashCode * 59 + this.Ethnicity.GetHashCode();
                hashCode = hashCode * 59 + this.MaritalStatus.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                hashCode = hashCode * 59 + this.EmploymentStatus.GetHashCode();
                hashCode = hashCode * 59 + this.EmploymentType.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.RemoteCreatedAt != null)
                    hashCode = hashCode * 59 + this.RemoteCreatedAt.GetHashCode();
                if (this.TerminationDate != null)
                    hashCode = hashCode * 59 + this.TerminationDate.GetHashCode();
                if (this.Avatar != null)
                    hashCode = hashCode * 59 + this.Avatar.GetHashCode();
                if (this.HomeLocation != null)
                    hashCode = hashCode * 59 + this.HomeLocation.GetHashCode();
                if (this.WorkLocation != null)
                    hashCode = hashCode * 59 + this.WorkLocation.GetHashCode();
                if (this.Manager != null)
                    hashCode = hashCode * 59 + this.Manager.GetHashCode();
                if (this.BankAccount != null)
                    hashCode = hashCode * 59 + this.BankAccount.GetHashCode();
                if (this.Employments != null)
                    hashCode = hashCode * 59 + this.Employments.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
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
