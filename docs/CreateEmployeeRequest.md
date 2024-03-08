# AffixApi.Api.Model.CreateEmployeeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmployeeNumber** | **string** |  | [optional] 
**FirstName** | **string** | the first name of the individual | 
**LastName** | **string** | the last name of the individual | 
**DisplayFullName** | **string** |  | [optional] 
**Nationality** | **string** |  | [optional] 
**JobTitle** | **string** |  | [optional] 
**WorkEmail** | **string** | the work email of the individual | [optional] 
**PersonalEmail** | **string** | the personal email of the individual | [optional] 
**MobilePhoneNumber** | **string** | +1234567890 | [optional] 
**TaxId** | **string** |  | [optional] 
**Gender** | **string** |  | [optional] 
**Ethnicity** | **string** |  | [optional] 
**MaritalStatus** | **string** |  | [optional] 
**DateOfBirth** | **DateTime?** |  | [optional] 
**EmploymentStatus** | **string** |  | [optional] 
**EmploymentType** | **string** |  | [optional] 
**StartDate** | **DateTime?** |  | [optional] 
**TerminationDate** | **DateTime?** |  | [optional] 
**Avatar** | **string** |  | [optional] 
**HomeLocation** | [**AddressNoNonNullRequest**](AddressNoNonNullRequest.md) |  | [optional] 
**WorkLocation** | [**LocationNoNonNullRequest**](LocationNoNonNullRequest.md) |  | [optional] 
**Manager** | [**CreateEmployeeRequestManager**](CreateEmployeeRequestManager.md) |  | [optional] 
**BankAccount** | [**CreateEmployeeRequestBankAccount**](CreateEmployeeRequestBankAccount.md) |  | [optional] 
**Employments** | [**List&lt;EmploymentNoNullEnumRequest&gt;**](EmploymentNoNullEnumRequest.md) |  | [optional] 
**CustomFields** | **Object** |  | [optional] 
**Groups** | [**List&lt;GroupNoNullEnumRequest&gt;**](GroupNoNullEnumRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

