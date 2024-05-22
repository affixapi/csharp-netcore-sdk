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
    /// CreateEmployeeRequest
    /// </summary>
    [DataContract(Name = "CreateEmployeeRequest")]
    public partial class CreateEmployeeRequest : IEquatable<CreateEmployeeRequest>, IValidatableObject
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
            NotSpecified = 3

        }


        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "gender", EmitDefaultValue = true)]
        public GenderEnum? Gender { get; set; }
        /// <summary>
        /// Defines Ethnicity
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EthnicityEnum
        {
            /// <summary>
            /// Enum Asian for value: asian
            /// </summary>
            [EnumMember(Value = "asian")]
            Asian = 1,

            /// <summary>
            /// Enum Black for value: black
            /// </summary>
            [EnumMember(Value = "black")]
            Black = 2,

            /// <summary>
            /// Enum Hispanic for value: hispanic
            /// </summary>
            [EnumMember(Value = "hispanic")]
            Hispanic = 3,

            /// <summary>
            /// Enum Mixed for value: mixed
            /// </summary>
            [EnumMember(Value = "mixed")]
            Mixed = 4,

            /// <summary>
            /// Enum NotSpecified for value: not_specified
            /// </summary>
            [EnumMember(Value = "not_specified")]
            NotSpecified = 5,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 6,

            /// <summary>
            /// Enum White for value: white
            /// </summary>
            [EnumMember(Value = "white")]
            White = 7

        }


        /// <summary>
        /// Gets or Sets Ethnicity
        /// </summary>
        [DataMember(Name = "ethnicity", EmitDefaultValue = true)]
        public EthnicityEnum? Ethnicity { get; set; }
        /// <summary>
        /// &#x60;other&#x60; option can include co-habitating, civil partnership, separated, widowed, etc 
        /// </summary>
        /// <value>&#x60;other&#x60; option can include co-habitating, civil partnership, separated, widowed, etc </value>
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
            /// Enum Divorced for value: divorced
            /// </summary>
            [EnumMember(Value = "divorced")]
            Divorced = 3,

            /// <summary>
            /// Enum NotSpecified for value: not_specified
            /// </summary>
            [EnumMember(Value = "not_specified")]
            NotSpecified = 4,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 5

        }


        /// <summary>
        /// &#x60;other&#x60; option can include co-habitating, civil partnership, separated, widowed, etc 
        /// </summary>
        /// <value>&#x60;other&#x60; option can include co-habitating, civil partnership, separated, widowed, etc </value>
        [DataMember(Name = "marital_status", EmitDefaultValue = true)]
        public MaritalStatusEnum? MaritalStatus { get; set; }
        /// <summary>
        /// Defines EmploymentType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EmploymentTypeEnum
        {
            /// <summary>
            /// Enum FullTime for value: full_time
            /// </summary>
            [EnumMember(Value = "full_time")]
            FullTime = 1,

            /// <summary>
            /// Enum PartTime for value: part_time
            /// </summary>
            [EnumMember(Value = "part_time")]
            PartTime = 2,

            /// <summary>
            /// Enum Contractor for value: contractor
            /// </summary>
            [EnumMember(Value = "contractor")]
            Contractor = 3,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 4

        }


        /// <summary>
        /// Gets or Sets EmploymentType
        /// </summary>
        [DataMember(Name = "employment_type", EmitDefaultValue = true)]
        public EmploymentTypeEnum? EmploymentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmployeeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateEmployeeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmployeeRequest" /> class.
        /// </summary>
        /// <param name="employeeNumber">employeeNumber.</param>
        /// <param name="firstName">the first name of the individual (required).</param>
        /// <param name="lastName">the last name of the individual (required).</param>
        /// <param name="displayFullName">displayFullName.</param>
        /// <param name="nationality">nationality.</param>
        /// <param name="jobTitle">jobTitle.</param>
        /// <param name="workEmail">the work email of the individual.</param>
        /// <param name="personalEmail">the personal email of the individual.</param>
        /// <param name="mobilePhoneNumber">+1234567890.</param>
        /// <param name="taxId">taxId.</param>
        /// <param name="gender">gender.</param>
        /// <param name="ethnicity">ethnicity.</param>
        /// <param name="maritalStatus">&#x60;other&#x60; option can include co-habitating, civil partnership, separated, widowed, etc .</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="employmentStatus">employmentStatus.</param>
        /// <param name="employmentType">employmentType.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="terminationDate">terminationDate.</param>
        /// <param name="avatar">avatar.</param>
        /// <param name="homeLocation">homeLocation.</param>
        /// <param name="workLocation">workLocation.</param>
        /// <param name="manager">manager.</param>
        /// <param name="bankAccount">bankAccount.</param>
        /// <param name="employmentHistory">employmentHistory.</param>
        /// <param name="compensationHistory">compensationHistory.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="groups">groups.</param>
        /// <param name="dependents">dependents.</param>
        /// <param name="emergencyContacts">emergencyContacts.</param>
        public CreateEmployeeRequest(string employeeNumber = default(string), string firstName = default(string), string lastName = default(string), string displayFullName = default(string), string nationality = default(string), string jobTitle = default(string), string workEmail = default(string), string personalEmail = default(string), string mobilePhoneNumber = default(string), string taxId = default(string), GenderEnum? gender = default(GenderEnum?), EthnicityEnum? ethnicity = default(EthnicityEnum?), MaritalStatusEnum? maritalStatus = default(MaritalStatusEnum?), DateTime? dateOfBirth = default(DateTime?), EmploymentStatusNotNullRequest employmentStatus = default(EmploymentStatusNotNullRequest), EmploymentTypeEnum? employmentType = default(EmploymentTypeEnum?), DateTime? startDate = default(DateTime?), DateTime? terminationDate = default(DateTime?), string avatar = default(string), AddressNoNonNullRequest homeLocation = default(AddressNoNonNullRequest), LocationNoNonNullRequest workLocation = default(LocationNoNonNullRequest), CreateEmployeeRequestManager manager = default(CreateEmployeeRequestManager), CreateEmployeeRequestBankAccount bankAccount = default(CreateEmployeeRequestBankAccount), List<EmploymentHistoryNoNonNullRequest> employmentHistory = default(List<EmploymentHistoryNoNonNullRequest>), List<CompensationHistoryNoNonNullRequest> compensationHistory = default(List<CompensationHistoryNoNonNullRequest>), Object customFields = default(Object), List<GroupNoNullEnumRequest> groups = default(List<GroupNoNullEnumRequest>), List<CreateEmployeeRequestDependents> dependents = default(List<CreateEmployeeRequestDependents>), List<CreateEmployeeRequestEmergencyContacts> emergencyContacts = default(List<CreateEmployeeRequestEmergencyContacts>))
        {
            // to ensure "firstName" is required (not null)
            this.FirstName = firstName ?? throw new ArgumentNullException("firstName is a required property for CreateEmployeeRequest and cannot be null");
            // to ensure "lastName" is required (not null)
            this.LastName = lastName ?? throw new ArgumentNullException("lastName is a required property for CreateEmployeeRequest and cannot be null");
            this.EmployeeNumber = employeeNumber;
            this.DisplayFullName = displayFullName;
            this.Nationality = nationality;
            this.JobTitle = jobTitle;
            this.WorkEmail = workEmail;
            this.PersonalEmail = personalEmail;
            this.MobilePhoneNumber = mobilePhoneNumber;
            this.TaxId = taxId;
            this.Gender = gender;
            this.Ethnicity = ethnicity;
            this.MaritalStatus = maritalStatus;
            this.DateOfBirth = dateOfBirth;
            this.EmploymentStatus = employmentStatus;
            this.EmploymentType = employmentType;
            this.StartDate = startDate;
            this.TerminationDate = terminationDate;
            this.Avatar = avatar;
            this.HomeLocation = homeLocation;
            this.WorkLocation = workLocation;
            this.Manager = manager;
            this.BankAccount = bankAccount;
            this.EmploymentHistory = employmentHistory;
            this.CompensationHistory = compensationHistory;
            this.CustomFields = customFields;
            this.Groups = groups;
            this.Dependents = dependents;
            this.EmergencyContacts = emergencyContacts;
        }

        /// <summary>
        /// Gets or Sets EmployeeNumber
        /// </summary>
        [DataMember(Name = "employee_number", EmitDefaultValue = true)]
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
        [DataMember(Name = "display_full_name", EmitDefaultValue = true)]
        public string DisplayFullName { get; set; }

        /// <summary>
        /// Gets or Sets Nationality
        /// </summary>
        [DataMember(Name = "nationality", EmitDefaultValue = true)]
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or Sets JobTitle
        /// </summary>
        [DataMember(Name = "job_title", EmitDefaultValue = true)]
        public string JobTitle { get; set; }

        /// <summary>
        /// the work email of the individual
        /// </summary>
        /// <value>the work email of the individual</value>
        [DataMember(Name = "work_email", EmitDefaultValue = true)]
        public string WorkEmail { get; set; }

        /// <summary>
        /// the personal email of the individual
        /// </summary>
        /// <value>the personal email of the individual</value>
        [DataMember(Name = "personal_email", EmitDefaultValue = true)]
        public string PersonalEmail { get; set; }

        /// <summary>
        /// +1234567890
        /// </summary>
        /// <value>+1234567890</value>
        [DataMember(Name = "mobile_phone_number", EmitDefaultValue = true)]
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets TaxId
        /// </summary>
        [DataMember(Name = "tax_id", EmitDefaultValue = true)]
        public string TaxId { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name = "date_of_birth", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets EmploymentStatus
        /// </summary>
        [DataMember(Name = "employment_status", EmitDefaultValue = true)]
        public EmploymentStatusNotNullRequest EmploymentStatus { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "start_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets TerminationDate
        /// </summary>
        [DataMember(Name = "termination_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? TerminationDate { get; set; }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name = "avatar", EmitDefaultValue = true)]
        public string Avatar { get; set; }

        /// <summary>
        /// Gets or Sets HomeLocation
        /// </summary>
        [DataMember(Name = "home_location", EmitDefaultValue = true)]
        public AddressNoNonNullRequest HomeLocation { get; set; }

        /// <summary>
        /// Gets or Sets WorkLocation
        /// </summary>
        [DataMember(Name = "work_location", EmitDefaultValue = true)]
        public LocationNoNonNullRequest WorkLocation { get; set; }

        /// <summary>
        /// Gets or Sets Manager
        /// </summary>
        [DataMember(Name = "manager", EmitDefaultValue = true)]
        public CreateEmployeeRequestManager Manager { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name = "bank_account", EmitDefaultValue = true)]
        public CreateEmployeeRequestBankAccount BankAccount { get; set; }

        /// <summary>
        /// Gets or Sets EmploymentHistory
        /// </summary>
        [DataMember(Name = "employment_history", EmitDefaultValue = true)]
        public List<EmploymentHistoryNoNonNullRequest> EmploymentHistory { get; set; }

        /// <summary>
        /// Gets or Sets CompensationHistory
        /// </summary>
        [DataMember(Name = "compensation_history", EmitDefaultValue = true)]
        public List<CompensationHistoryNoNonNullRequest> CompensationHistory { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields", EmitDefaultValue = true)]
        public Object CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", EmitDefaultValue = true)]
        public List<GroupNoNullEnumRequest> Groups { get; set; }

        /// <summary>
        /// Gets or Sets Dependents
        /// </summary>
        [DataMember(Name = "dependents", EmitDefaultValue = true)]
        public List<CreateEmployeeRequestDependents> Dependents { get; set; }

        /// <summary>
        /// Gets or Sets EmergencyContacts
        /// </summary>
        [DataMember(Name = "emergency_contacts", EmitDefaultValue = true)]
        public List<CreateEmployeeRequestEmergencyContacts> EmergencyContacts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateEmployeeRequest {\n");
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
            sb.Append("  TerminationDate: ").Append(TerminationDate).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  HomeLocation: ").Append(HomeLocation).Append("\n");
            sb.Append("  WorkLocation: ").Append(WorkLocation).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  EmploymentHistory: ").Append(EmploymentHistory).Append("\n");
            sb.Append("  CompensationHistory: ").Append(CompensationHistory).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Dependents: ").Append(Dependents).Append("\n");
            sb.Append("  EmergencyContacts: ").Append(EmergencyContacts).Append("\n");
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
            return this.Equals(input as CreateEmployeeRequest);
        }

        /// <summary>
        /// Returns true if CreateEmployeeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateEmployeeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateEmployeeRequest input)
        {
            if (input == null)
                return false;

            return 
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
                    (this.EmploymentStatus != null &&
                    this.EmploymentStatus.Equals(input.EmploymentStatus))
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
                    this.EmploymentHistory == input.EmploymentHistory ||
                    this.EmploymentHistory != null &&
                    input.EmploymentHistory != null &&
                    this.EmploymentHistory.SequenceEqual(input.EmploymentHistory)
                ) && 
                (
                    this.CompensationHistory == input.CompensationHistory ||
                    this.CompensationHistory != null &&
                    input.CompensationHistory != null &&
                    this.CompensationHistory.SequenceEqual(input.CompensationHistory)
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
                ) && 
                (
                    this.Dependents == input.Dependents ||
                    this.Dependents != null &&
                    input.Dependents != null &&
                    this.Dependents.SequenceEqual(input.Dependents)
                ) && 
                (
                    this.EmergencyContacts == input.EmergencyContacts ||
                    this.EmergencyContacts != null &&
                    input.EmergencyContacts != null &&
                    this.EmergencyContacts.SequenceEqual(input.EmergencyContacts)
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
                if (this.EmploymentStatus != null)
                    hashCode = hashCode * 59 + this.EmploymentStatus.GetHashCode();
                hashCode = hashCode * 59 + this.EmploymentType.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
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
                if (this.EmploymentHistory != null)
                    hashCode = hashCode * 59 + this.EmploymentHistory.GetHashCode();
                if (this.CompensationHistory != null)
                    hashCode = hashCode * 59 + this.CompensationHistory.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Dependents != null)
                    hashCode = hashCode * 59 + this.Dependents.GetHashCode();
                if (this.EmergencyContacts != null)
                    hashCode = hashCode * 59 + this.EmergencyContacts.GetHashCode();
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
