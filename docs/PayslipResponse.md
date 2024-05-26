# AffixApi.Api.Model.PayslipResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The Affix-assigned id of the payslip | 
**RemoteId** | **string** | the remote system-assigned id of the payrun | 
**EmployeeId** | **string** |  | 
**PayrunId** | **string** |  | 
**Currency** | **string** |  | 
**GrossPay** | **decimal?** | if USD/EUR/GBP, in cent | 
**NetPay** | **decimal?** | if USD/EUR/GBP, in cent | 
**StartDate** | **DateTime** |  | 
**EndDate** | **DateTime** |  | 
**PaymentDate** | **DateTime** |  | 
**Earnings** | [**List&lt;PayslipResponseEarnings&gt;**](PayslipResponseEarnings.md) |  | 
**Contributions** | [**List&lt;PayslipResponseContributions&gt;**](PayslipResponseContributions.md) | Items paid by the employer that are not included in gross pay, such as employer-paid portion of private health insurance  | 
**Deductions** | [**List&lt;PayslipResponseDeductions&gt;**](PayslipResponseDeductions.md) |  | 
**Taxes** | [**List&lt;PayslipResponseTaxes&gt;**](PayslipResponseTaxes.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

