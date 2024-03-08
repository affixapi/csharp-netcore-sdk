# AffixApi.Api.Model.TokenResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessToken** | **string** | The issued access_token | [readonly] 
**Mode** | **ModeResponse** |  | 
**Provider** | **ProviderResponse** |  | 
**Scopes** | [**List&lt;ScopesResponse&gt;**](ScopesResponse.md) | One or more scope values indicating which parts of the user&#39;s account you wish to access.  Note, slight deviation from the OAuth 2.1 spec in that the param is scopes (plural) is used vs scope (singular)  | [readonly] 
**TokenType** | **string** | The token type to pass in the &#x60;Authorization&#x60; header | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

