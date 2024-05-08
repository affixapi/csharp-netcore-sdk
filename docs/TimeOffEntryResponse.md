# AffixApi.Api.Model.TimeOffEntryResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The Affix-assigned id of the time off entry | 
**RemoteId** | **string** | the remote system-assigned id of the time off entry | 
**EmployeeId** | **string** | the Affix-assigned id of the individual | 
**EmployeeRemoteId** | **string** | the remote system-assigned id of the individual | 
**StartDate** | **DateTime?** |  | 
**EndDate** | **DateTime?** |  | 
**Amount** | **decimal** |  | 
**Unit** | **string** |  | 
**Status** | **string** |  | 
**EmployeeNote** | **string** |  | 
**PolicyId** | **string** | The Affix-assigned id of the policy | 
**PolicyRemoteId** | **string** | The remote system-assigned id of the policy | 
**PolicyName** | **string** | The name of the policy, as assigned by the remote system | 
**PolicyType** | [**PolicyTypeResponse**](PolicyTypeResponse.md) |  | 
**RemoteCreatedAt** | **DateTime?** |  | 
**RemoteModifiedAt** | **DateTime?** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

