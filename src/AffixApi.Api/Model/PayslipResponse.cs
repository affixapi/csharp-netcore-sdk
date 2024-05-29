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
    /// PayslipResponse
    /// </summary>
    [DataContract(Name = "PayslipResponse")]
    public partial class PayslipResponse : IEquatable<PayslipResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayslipResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayslipResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayslipResponse" /> class.
        /// </summary>
        /// <param name="id">The Affix-assigned id of the payslip (required).</param>
        /// <param name="remoteId">the remote system-assigned id of the payrun (required).</param>
        /// <param name="employeeId">employeeId (required).</param>
        /// <param name="employeeRemoteId">employeeRemoteId (required).</param>
        /// <param name="payrunId">payrunId (required).</param>
        /// <param name="payrunRemoteId">payrunRemoteId (required).</param>
        /// <param name="payrunType">payrunType (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="grossPay">if USD/EUR/GBP, in cent (required).</param>
        /// <param name="netPay">if USD/EUR/GBP, in cent (required).</param>
        /// <param name="startDate">startDate (required).</param>
        /// <param name="endDate">endDate (required).</param>
        /// <param name="paymentDate">paymentDate (required).</param>
        /// <param name="earnings">earnings (required).</param>
        /// <param name="contributions">Items paid by the employer that are not included in gross pay, such as employer-paid portion of private health insurance  (required).</param>
        /// <param name="deductions">deductions (required).</param>
        /// <param name="taxes">taxes (required).</param>
        public PayslipResponse(string id = default(string), string remoteId = default(string), string employeeId = default(string), string employeeRemoteId = default(string), string payrunId = default(string), string payrunRemoteId = default(string), PayrunTypeResponse payrunType = default(PayrunTypeResponse), CurrencyNotNullResponse currency = default(CurrencyNotNullResponse), decimal? grossPay = default(decimal?), decimal? netPay = default(decimal?), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), DateTime paymentDate = default(DateTime), List<PayslipResponseEarnings> earnings = default(List<PayslipResponseEarnings>), List<PayslipResponseContributions> contributions = default(List<PayslipResponseContributions>), List<PayslipResponseDeductions> deductions = default(List<PayslipResponseDeductions>), List<PayslipResponseTaxes> taxes = default(List<PayslipResponseTaxes>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for PayslipResponse and cannot be null");
            // to ensure "remoteId" is required (not null)
            this.RemoteId = remoteId ?? throw new ArgumentNullException("remoteId is a required property for PayslipResponse and cannot be null");
            // to ensure "employeeId" is required (not null)
            this.EmployeeId = employeeId ?? throw new ArgumentNullException("employeeId is a required property for PayslipResponse and cannot be null");
            // to ensure "employeeRemoteId" is required (not null)
            this.EmployeeRemoteId = employeeRemoteId ?? throw new ArgumentNullException("employeeRemoteId is a required property for PayslipResponse and cannot be null");
            // to ensure "payrunId" is required (not null)
            this.PayrunId = payrunId ?? throw new ArgumentNullException("payrunId is a required property for PayslipResponse and cannot be null");
            // to ensure "payrunRemoteId" is required (not null)
            this.PayrunRemoteId = payrunRemoteId ?? throw new ArgumentNullException("payrunRemoteId is a required property for PayslipResponse and cannot be null");
            // to ensure "payrunType" is required (not null)
            this.PayrunType = payrunType;
            // to ensure "currency" is required (not null)
            this.Currency = currency;
            // to ensure "grossPay" is required (not null)
            this.GrossPay = grossPay ?? throw new ArgumentNullException("grossPay is a required property for PayslipResponse and cannot be null");
            // to ensure "netPay" is required (not null)
            this.NetPay = netPay ?? throw new ArgumentNullException("netPay is a required property for PayslipResponse and cannot be null");
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.PaymentDate = paymentDate;
            // to ensure "earnings" is required (not null)
            this.Earnings = earnings ?? throw new ArgumentNullException("earnings is a required property for PayslipResponse and cannot be null");
            // to ensure "contributions" is required (not null)
            this.Contributions = contributions ?? throw new ArgumentNullException("contributions is a required property for PayslipResponse and cannot be null");
            // to ensure "deductions" is required (not null)
            this.Deductions = deductions ?? throw new ArgumentNullException("deductions is a required property for PayslipResponse and cannot be null");
            // to ensure "taxes" is required (not null)
            this.Taxes = taxes ?? throw new ArgumentNullException("taxes is a required property for PayslipResponse and cannot be null");
        }

        /// <summary>
        /// The Affix-assigned id of the payslip
        /// </summary>
        /// <value>The Affix-assigned id of the payslip</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// the remote system-assigned id of the payrun
        /// </summary>
        /// <value>the remote system-assigned id of the payrun</value>
        [DataMember(Name = "remote_id", IsRequired = true, EmitDefaultValue = true)]
        public string RemoteId { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeId
        /// </summary>
        [DataMember(Name = "employee_id", IsRequired = true, EmitDefaultValue = false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeRemoteId
        /// </summary>
        [DataMember(Name = "employee_remote_id", IsRequired = true, EmitDefaultValue = false)]
        public string EmployeeRemoteId { get; set; }

        /// <summary>
        /// Gets or Sets PayrunId
        /// </summary>
        [DataMember(Name = "payrun_id", IsRequired = true, EmitDefaultValue = false)]
        public string PayrunId { get; set; }

        /// <summary>
        /// Gets or Sets PayrunRemoteId
        /// </summary>
        [DataMember(Name = "payrun_remote_id", IsRequired = true, EmitDefaultValue = false)]
        public string PayrunRemoteId { get; set; }

        /// <summary>
        /// Gets or Sets PayrunType
        /// </summary>
        [DataMember(Name = "payrun_type", IsRequired = true, EmitDefaultValue = true)]
        public PayrunTypeResponse PayrunType { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public CurrencyNotNullResponse Currency { get; set; }

        /// <summary>
        /// if USD/EUR/GBP, in cent
        /// </summary>
        /// <value>if USD/EUR/GBP, in cent</value>
        [DataMember(Name = "gross_pay", IsRequired = true, EmitDefaultValue = true)]
        public decimal? GrossPay { get; set; }

        /// <summary>
        /// if USD/EUR/GBP, in cent
        /// </summary>
        /// <value>if USD/EUR/GBP, in cent</value>
        [DataMember(Name = "net_pay", IsRequired = true, EmitDefaultValue = true)]
        public decimal? NetPay { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "start_date", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "end_date", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or Sets PaymentDate
        /// </summary>
        [DataMember(Name = "payment_date", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Gets or Sets Earnings
        /// </summary>
        [DataMember(Name = "earnings", IsRequired = true, EmitDefaultValue = true)]
        public List<PayslipResponseEarnings> Earnings { get; set; }

        /// <summary>
        /// Items paid by the employer that are not included in gross pay, such as employer-paid portion of private health insurance 
        /// </summary>
        /// <value>Items paid by the employer that are not included in gross pay, such as employer-paid portion of private health insurance </value>
        [DataMember(Name = "contributions", IsRequired = true, EmitDefaultValue = true)]
        public List<PayslipResponseContributions> Contributions { get; set; }

        /// <summary>
        /// Gets or Sets Deductions
        /// </summary>
        [DataMember(Name = "deductions", IsRequired = true, EmitDefaultValue = true)]
        public List<PayslipResponseDeductions> Deductions { get; set; }

        /// <summary>
        /// Gets or Sets Taxes
        /// </summary>
        [DataMember(Name = "taxes", IsRequired = true, EmitDefaultValue = true)]
        public List<PayslipResponseTaxes> Taxes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayslipResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  EmployeeRemoteId: ").Append(EmployeeRemoteId).Append("\n");
            sb.Append("  PayrunId: ").Append(PayrunId).Append("\n");
            sb.Append("  PayrunRemoteId: ").Append(PayrunRemoteId).Append("\n");
            sb.Append("  PayrunType: ").Append(PayrunType).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  GrossPay: ").Append(GrossPay).Append("\n");
            sb.Append("  NetPay: ").Append(NetPay).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  Earnings: ").Append(Earnings).Append("\n");
            sb.Append("  Contributions: ").Append(Contributions).Append("\n");
            sb.Append("  Deductions: ").Append(Deductions).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
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
            return this.Equals(input as PayslipResponse);
        }

        /// <summary>
        /// Returns true if PayslipResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PayslipResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayslipResponse input)
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
                    this.PayrunId == input.PayrunId ||
                    (this.PayrunId != null &&
                    this.PayrunId.Equals(input.PayrunId))
                ) && 
                (
                    this.PayrunRemoteId == input.PayrunRemoteId ||
                    (this.PayrunRemoteId != null &&
                    this.PayrunRemoteId.Equals(input.PayrunRemoteId))
                ) && 
                (
                    this.PayrunType == input.PayrunType ||
                    (this.PayrunType != null &&
                    this.PayrunType.Equals(input.PayrunType))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.GrossPay == input.GrossPay ||
                    (this.GrossPay != null &&
                    this.GrossPay.Equals(input.GrossPay))
                ) && 
                (
                    this.NetPay == input.NetPay ||
                    (this.NetPay != null &&
                    this.NetPay.Equals(input.NetPay))
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
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && 
                (
                    this.Earnings == input.Earnings ||
                    this.Earnings != null &&
                    input.Earnings != null &&
                    this.Earnings.SequenceEqual(input.Earnings)
                ) && 
                (
                    this.Contributions == input.Contributions ||
                    this.Contributions != null &&
                    input.Contributions != null &&
                    this.Contributions.SequenceEqual(input.Contributions)
                ) && 
                (
                    this.Deductions == input.Deductions ||
                    this.Deductions != null &&
                    input.Deductions != null &&
                    this.Deductions.SequenceEqual(input.Deductions)
                ) && 
                (
                    this.Taxes == input.Taxes ||
                    this.Taxes != null &&
                    input.Taxes != null &&
                    this.Taxes.SequenceEqual(input.Taxes)
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
                if (this.PayrunId != null)
                    hashCode = hashCode * 59 + this.PayrunId.GetHashCode();
                if (this.PayrunRemoteId != null)
                    hashCode = hashCode * 59 + this.PayrunRemoteId.GetHashCode();
                if (this.PayrunType != null)
                    hashCode = hashCode * 59 + this.PayrunType.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.GrossPay != null)
                    hashCode = hashCode * 59 + this.GrossPay.GetHashCode();
                if (this.NetPay != null)
                    hashCode = hashCode * 59 + this.NetPay.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.PaymentDate != null)
                    hashCode = hashCode * 59 + this.PaymentDate.GetHashCode();
                if (this.Earnings != null)
                    hashCode = hashCode * 59 + this.Earnings.GetHashCode();
                if (this.Contributions != null)
                    hashCode = hashCode * 59 + this.Contributions.GetHashCode();
                if (this.Deductions != null)
                    hashCode = hashCode * 59 + this.Deductions.GetHashCode();
                if (this.Taxes != null)
                    hashCode = hashCode * 59 + this.Taxes.GetHashCode();
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
