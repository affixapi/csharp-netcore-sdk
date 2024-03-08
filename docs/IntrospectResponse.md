# AffixApi.Api.Model.IntrospectResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | The client ID you received when you first created the application | [readonly] 
**Mode** | **ModeResponse** |  | 
**Provider** | **ProviderResponse** |  | 
**Scopes** | [**List&lt;ScopesResponse&gt;**](ScopesResponse.md) | One or more scope values indicating which parts of the user&#39;s account you wish to access.  Note, slight deviation from the OAuth 2.1 spec in that the param is scopes (plural) is used vs scope (singular)  | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

