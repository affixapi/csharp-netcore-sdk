# AffixApi.Api.Model.EmployeeResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The Affix-assigned id of the individual | [readonly] 
**RemoteId** | **string** | the remote system-assigned id of the individual | [readonly] 
**EmployeeNumber** | **string** |  | 
**FirstName** | **string** | the first name of the individual | 
**LastName** | **string** | the last name of the individual | 
**DisplayFullName** | **string** |  | 
**Nationality** | **string** |  | 
**JobTitle** | **string** |  | 
**WorkEmail** | **string** | the work email of the individual | 
**PersonalEmail** | **string** | the personal email of the individual | 
**MobilePhoneNumber** | **string** | +1234567890 | 
**TaxId** | **string** |  | 
**Gender** | **string** |  | 
**Ethnicity** | **string** |  | 
**MaritalStatus** | **string** | &#x60;other&#x60; option can include co-habitating, civil partnership, separated, widowed, etc  | 
**DateOfBirth** | **DateTime?** |  | 
**EmploymentStatus** | [**EmploymentStatusResponse**](EmploymentStatusResponse.md) |  | 
**EmploymentType** | **string** |  | 
**StartDate** | **DateTime?** |  | 
**RemoteCreatedAt** | **DateTime?** |  | [readonly] 
**TerminationDate** | **DateTime?** |  | 
**Avatar** | **string** |  | 
**HomeLocation** | [**AddressResponse**](AddressResponse.md) |  | 
**WorkLocation** | [**LocationResponse**](LocationResponse.md) |  | 
**Manager** | [**EmployeeResponseManager**](EmployeeResponseManager.md) |  | 
**BankAccount** | [**CreateEmployeeRequestBankAccount**](CreateEmployeeRequestBankAccount.md) |  | 
**EmploymentHistory** | [**List&lt;EmploymentHistoryResponse&gt;**](EmploymentHistoryResponse.md) |  | 
**CompensationHistory** | [**List&lt;CompensationHistoryResponse&gt;**](CompensationHistoryResponse.md) |  | 
**CustomFields** | **Object** |  | 
**Groups** | [**List&lt;GroupResponse&gt;**](GroupResponse.md) |  | 
**Dependents** | [**List&lt;CreateEmployeeRequestDependents&gt;**](CreateEmployeeRequestDependents.md) |  | 
**EmergencyContacts** | [**List&lt;CreateEmployeeRequestEmergencyContacts&gt;**](CreateEmployeeRequestEmergencyContacts.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

