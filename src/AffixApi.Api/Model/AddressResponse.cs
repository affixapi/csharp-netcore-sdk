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
    /// AddressResponse
    /// </summary>
    [DataContract(Name = "addressResponse")]
    public partial class AddressResponse : IEquatable<AddressResponse>, IValidatableObject
    {
        /// <summary>
        /// The ISO-3166-2 two-letter abbreviation of the country. Reference https://en.wikipedia.org/wiki/ISO_3166-2 for more details 
        /// </summary>
        /// <value>The ISO-3166-2 two-letter abbreviation of the country. Reference https://en.wikipedia.org/wiki/ISO_3166-2 for more details </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CountryEnum
        {
            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 1,

            /// <summary>
            /// Enum BZ for value: BZ
            /// </summary>
            [EnumMember(Value = "BZ")]
            BZ = 2,

            /// <summary>
            /// Enum CA for value: CA
            /// </summary>
            [EnumMember(Value = "CA")]
            CA = 3,

            /// <summary>
            /// Enum CR for value: CR
            /// </summary>
            [EnumMember(Value = "CR")]
            CR = 4,

            /// <summary>
            /// Enum GT for value: GT
            /// </summary>
            [EnumMember(Value = "GT")]
            GT = 5,

            /// <summary>
            /// Enum MX for value: MX
            /// </summary>
            [EnumMember(Value = "MX")]
            MX = 6,

            /// <summary>
            /// Enum PA for value: PA
            /// </summary>
            [EnumMember(Value = "PA")]
            PA = 7,

            /// <summary>
            /// Enum SV for value: SV
            /// </summary>
            [EnumMember(Value = "SV")]
            SV = 8,

            /// <summary>
            /// Enum US for value: US
            /// </summary>
            [EnumMember(Value = "US")]
            US = 9,

            /// <summary>
            /// Enum AR for value: AR
            /// </summary>
            [EnumMember(Value = "AR")]
            AR = 10,

            /// <summary>
            /// Enum BR for value: BR
            /// </summary>
            [EnumMember(Value = "BR")]
            BR = 11,

            /// <summary>
            /// Enum CL for value: CL
            /// </summary>
            [EnumMember(Value = "CL")]
            CL = 12,

            /// <summary>
            /// Enum PE for value: PE
            /// </summary>
            [EnumMember(Value = "PE")]
            PE = 13,

            /// <summary>
            /// Enum AT for value: AT
            /// </summary>
            [EnumMember(Value = "AT")]
            AT = 14,

            /// <summary>
            /// Enum AU for value: AU
            /// </summary>
            [EnumMember(Value = "AU")]
            AU = 15,

            /// <summary>
            /// Enum BE for value: BE
            /// </summary>
            [EnumMember(Value = "BE")]
            BE = 16,

            /// <summary>
            /// Enum CH for value: CH
            /// </summary>
            [EnumMember(Value = "CH")]
            CH = 17,

            /// <summary>
            /// Enum CY for value: CY
            /// </summary>
            [EnumMember(Value = "CY")]
            CY = 18,

            /// <summary>
            /// Enum CZ for value: CZ
            /// </summary>
            [EnumMember(Value = "CZ")]
            CZ = 19,

            /// <summary>
            /// Enum DE for value: DE
            /// </summary>
            [EnumMember(Value = "DE")]
            DE = 20,

            /// <summary>
            /// Enum DK for value: DK
            /// </summary>
            [EnumMember(Value = "DK")]
            DK = 21,

            /// <summary>
            /// Enum EE for value: EE
            /// </summary>
            [EnumMember(Value = "EE")]
            EE = 22,

            /// <summary>
            /// Enum ES for value: ES
            /// </summary>
            [EnumMember(Value = "ES")]
            ES = 23,

            /// <summary>
            /// Enum FI for value: FI
            /// </summary>
            [EnumMember(Value = "FI")]
            FI = 24,

            /// <summary>
            /// Enum FR for value: FR
            /// </summary>
            [EnumMember(Value = "FR")]
            FR = 25,

            /// <summary>
            /// Enum GB for value: GB
            /// </summary>
            [EnumMember(Value = "GB")]
            GB = 26,

            /// <summary>
            /// Enum GR for value: GR
            /// </summary>
            [EnumMember(Value = "GR")]
            GR = 27,

            /// <summary>
            /// Enum IE for value: IE
            /// </summary>
            [EnumMember(Value = "IE")]
            IE = 28,

            /// <summary>
            /// Enum IM for value: IM
            /// </summary>
            [EnumMember(Value = "IM")]
            IM = 29,

            /// <summary>
            /// Enum IS for value: IS
            /// </summary>
            [EnumMember(Value = "IS")]
            IS = 30,

            /// <summary>
            /// Enum IT for value: IT
            /// </summary>
            [EnumMember(Value = "IT")]
            IT = 31,

            /// <summary>
            /// Enum LI for value: LI
            /// </summary>
            [EnumMember(Value = "LI")]
            LI = 32,

            /// <summary>
            /// Enum LT for value: LT
            /// </summary>
            [EnumMember(Value = "LT")]
            LT = 33,

            /// <summary>
            /// Enum LU for value: LU
            /// </summary>
            [EnumMember(Value = "LU")]
            LU = 34,

            /// <summary>
            /// Enum LV for value: LV
            /// </summary>
            [EnumMember(Value = "LV")]
            LV = 35,

            /// <summary>
            /// Enum NL for value: NL
            /// </summary>
            [EnumMember(Value = "NL")]
            NL = 36,

            /// <summary>
            /// Enum NO for value: NO
            /// </summary>
            [EnumMember(Value = "NO")]
            NO = 37,

            /// <summary>
            /// Enum PH for value: PH
            /// </summary>
            [EnumMember(Value = "PH")]
            PH = 38,

            /// <summary>
            /// Enum PL for value: PL
            /// </summary>
            [EnumMember(Value = "PL")]
            PL = 39,

            /// <summary>
            /// Enum RO for value: RO
            /// </summary>
            [EnumMember(Value = "RO")]
            RO = 40,

            /// <summary>
            /// Enum RU for value: RU
            /// </summary>
            [EnumMember(Value = "RU")]
            RU = 41,

            /// <summary>
            /// Enum SE for value: SE
            /// </summary>
            [EnumMember(Value = "SE")]
            SE = 42,

            /// <summary>
            /// Enum SK for value: SK
            /// </summary>
            [EnumMember(Value = "SK")]
            SK = 43,

            /// <summary>
            /// Enum CN for value: CN
            /// </summary>
            [EnumMember(Value = "CN")]
            CN = 44,

            /// <summary>
            /// Enum HK for value: HK
            /// </summary>
            [EnumMember(Value = "HK")]
            HK = 45,

            /// <summary>
            /// Enum ID for value: ID
            /// </summary>
            [EnumMember(Value = "ID")]
            ID = 46,

            /// <summary>
            /// Enum IL for value: IL
            /// </summary>
            [EnumMember(Value = "IL")]
            IL = 47,

            /// <summary>
            /// Enum IN for value: IN
            /// </summary>
            [EnumMember(Value = "IN")]
            IN = 48,

            /// <summary>
            /// Enum JP for value: JP
            /// </summary>
            [EnumMember(Value = "JP")]
            JP = 49,

            /// <summary>
            /// Enum KR for value: KR
            /// </summary>
            [EnumMember(Value = "KR")]
            KR = 50,

            /// <summary>
            /// Enum MO for value: MO
            /// </summary>
            [EnumMember(Value = "MO")]
            MO = 51,

            /// <summary>
            /// Enum MY for value: MY
            /// </summary>
            [EnumMember(Value = "MY")]
            MY = 52,

            /// <summary>
            /// Enum PH for value: PH
            /// </summary>
            [EnumMember(Value = "PH")]
            PH = 53,

            /// <summary>
            /// Enum PS for value: PS
            /// </summary>
            [EnumMember(Value = "PS")]
            PS = 54,

            /// <summary>
            /// Enum SG for value: SG
            /// </summary>
            [EnumMember(Value = "SG")]
            SG = 55,

            /// <summary>
            /// Enum TH for value: TH
            /// </summary>
            [EnumMember(Value = "TH")]
            TH = 56,

            /// <summary>
            /// Enum TR for value: TR
            /// </summary>
            [EnumMember(Value = "TR")]
            TR = 57,

            /// <summary>
            /// Enum TW for value: TW
            /// </summary>
            [EnumMember(Value = "TW")]
            TW = 58,

            /// <summary>
            /// Enum VN for value: VN
            /// </summary>
            [EnumMember(Value = "VN")]
            VN = 59,

            /// <summary>
            /// Enum ZA for value: ZA
            /// </summary>
            [EnumMember(Value = "ZA")]
            ZA = 60,

            /// <summary>
            /// Enum AU for value: AU
            /// </summary>
            [EnumMember(Value = "AU")]
            AU = 61,

            /// <summary>
            /// Enum NZ for value: NZ
            /// </summary>
            [EnumMember(Value = "NZ")]
            NZ = 62

        }


        /// <summary>
        /// The ISO-3166-2 two-letter abbreviation of the country. Reference https://en.wikipedia.org/wiki/ISO_3166-2 for more details 
        /// </summary>
        /// <value>The ISO-3166-2 two-letter abbreviation of the country. Reference https://en.wikipedia.org/wiki/ISO_3166-2 for more details </value>
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = true)]
        public CountryEnum Country { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddressResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressResponse" /> class.
        /// </summary>
        /// <param name="streetAddress">streetAddress (required).</param>
        /// <param name="locality">locality (required).</param>
        /// <param name="administrativeArea">The administrative area of the address. If US or CA, the two-letter state or province abbreviation. Else, the province / administrative area; such as, &#x60;Dublin 2&#x60; or &#x60;County Cork&#x60;  (required).</param>
        /// <param name="country">The ISO-3166-2 two-letter abbreviation of the country. Reference https://en.wikipedia.org/wiki/ISO_3166-2 for more details  (required).</param>
        /// <param name="postCode">postCode (required).</param>
        public AddressResponse(string streetAddress = default(string), string locality = default(string), string administrativeArea = default(string), CountryEnum country = default(CountryEnum), string postCode = default(string))
        {
            // to ensure "streetAddress" is required (not null)
            this.StreetAddress = streetAddress ?? throw new ArgumentNullException("streetAddress is a required property for AddressResponse and cannot be null");
            // to ensure "locality" is required (not null)
            this.Locality = locality ?? throw new ArgumentNullException("locality is a required property for AddressResponse and cannot be null");
            // to ensure "administrativeArea" is required (not null)
            this.AdministrativeArea = administrativeArea ?? throw new ArgumentNullException("administrativeArea is a required property for AddressResponse and cannot be null");
            this.Country = country;
            // to ensure "postCode" is required (not null)
            this.PostCode = postCode ?? throw new ArgumentNullException("postCode is a required property for AddressResponse and cannot be null");
        }

        /// <summary>
        /// Gets or Sets StreetAddress
        /// </summary>
        [DataMember(Name = "street_address", IsRequired = true, EmitDefaultValue = true)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or Sets Locality
        /// </summary>
        [DataMember(Name = "locality", IsRequired = true, EmitDefaultValue = true)]
        public string Locality { get; set; }

        /// <summary>
        /// The administrative area of the address. If US or CA, the two-letter state or province abbreviation. Else, the province / administrative area; such as, &#x60;Dublin 2&#x60; or &#x60;County Cork&#x60; 
        /// </summary>
        /// <value>The administrative area of the address. If US or CA, the two-letter state or province abbreviation. Else, the province / administrative area; such as, &#x60;Dublin 2&#x60; or &#x60;County Cork&#x60; </value>
        [DataMember(Name = "administrative_area", IsRequired = true, EmitDefaultValue = true)]
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// Gets or Sets PostCode
        /// </summary>
        [DataMember(Name = "post_code", IsRequired = true, EmitDefaultValue = true)]
        public string PostCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressResponse {\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  AdministrativeArea: ").Append(AdministrativeArea).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
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
            return this.Equals(input as AddressResponse);
        }

        /// <summary>
        /// Returns true if AddressResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StreetAddress == input.StreetAddress ||
                    (this.StreetAddress != null &&
                    this.StreetAddress.Equals(input.StreetAddress))
                ) && 
                (
                    this.Locality == input.Locality ||
                    (this.Locality != null &&
                    this.Locality.Equals(input.Locality))
                ) && 
                (
                    this.AdministrativeArea == input.AdministrativeArea ||
                    (this.AdministrativeArea != null &&
                    this.AdministrativeArea.Equals(input.AdministrativeArea))
                ) && 
                (
                    this.Country == input.Country ||
                    this.Country.Equals(input.Country)
                ) && 
                (
                    this.PostCode == input.PostCode ||
                    (this.PostCode != null &&
                    this.PostCode.Equals(input.PostCode))
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
                if (this.StreetAddress != null)
                    hashCode = hashCode * 59 + this.StreetAddress.GetHashCode();
                if (this.Locality != null)
                    hashCode = hashCode * 59 + this.Locality.GetHashCode();
                if (this.AdministrativeArea != null)
                    hashCode = hashCode * 59 + this.AdministrativeArea.GetHashCode();
                hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.PostCode != null)
                    hashCode = hashCode * 59 + this.PostCode.GetHashCode();
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
