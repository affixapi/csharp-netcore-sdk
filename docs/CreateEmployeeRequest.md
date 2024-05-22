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
**MaritalStatus** | **string** | &#x60;other&#x60; option can include co-habitating, civil partnership, separated, widowed, etc  | [optional] 
**DateOfBirth** | **DateTime?** |  | [optional] 
**EmploymentStatus** | [**EmploymentStatusNotNullRequest**](EmploymentStatusNotNullRequest.md) |  | [optional] 
**EmploymentType** | **string** |  | [optional] 
**StartDate** | **DateTime?** |  | [optional] 
**TerminationDate** | **DateTime?** |  | [optional] 
**Avatar** | **string** |  | [optional] 
**HomeLocation** | [**AddressNoNonNullRequest**](AddressNoNonNullRequest.md) |  | [optional] 
**WorkLocation** | [**LocationNoNonNullRequest**](LocationNoNonNullRequest.md) |  | [optional] 
**Manager** | [**CreateEmployeeRequestManager**](CreateEmployeeRequestManager.md) |  | [optional] 
**BankAccount** | [**CreateEmployeeRequestBankAccount**](CreateEmployeeRequestBankAccount.md) |  | [optional] 
**EmploymentHistory** | [**List&lt;EmploymentHistoryNoNonNullRequest&gt;**](EmploymentHistoryNoNonNullRequest.md) |  | [optional] 
**CompensationHistory** | [**List&lt;CompensationHistoryNoNonNullRequest&gt;**](CompensationHistoryNoNonNullRequest.md) |  | [optional] 
**CustomFields** | **Object** |  | [optional] 
**Groups** | [**List&lt;GroupNoNullEnumRequest&gt;**](GroupNoNullEnumRequest.md) |  | [optional] 
**Dependents** | [**List&lt;CreateEmployeeRequestDependents&gt;**](CreateEmployeeRequestDependents.md) |  | [optional] 
**EmergencyContacts** | [**List&lt;CreateEmployeeRequestEmergencyContacts&gt;**](CreateEmployeeRequestEmergencyContacts.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

