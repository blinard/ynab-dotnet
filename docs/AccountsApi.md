# YNAB.Dotnet.Api.AccountsApi

All URIs are relative to *https://api.youneedabudget.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccountById**](AccountsApi.md#getaccountbyid) | **GET** /budgets/{budget_id}/accounts/{account_id} | Single account
[**GetAccounts**](AccountsApi.md#getaccounts) | **GET** /budgets/{budget_id}/accounts | Account list


<a name="getaccountbyid"></a>
# **GetAccountById**
> AccountResponse GetAccountById (Guid? budgetId, Guid? accountId)

Single account

Returns a single account

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class GetAccountByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)
            var accountId = new Guid?(); // Guid? | The id of the account

            try
            {
                // Single account
                AccountResponse result = apiInstance.GetAccountById(budgetId, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccountById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **budgetId** | [**Guid?**](.md)| The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget) | 
 **accountId** | [**Guid?**](.md)| The id of the account | 

### Return type

[**AccountResponse**](AccountResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccounts"></a>
# **GetAccounts**
> AccountsResponse GetAccounts (Guid? budgetId)

Account list

Returns all accounts

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class GetAccountsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)

            try
            {
                // Account list
                AccountsResponse result = apiInstance.GetAccounts(budgetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **budgetId** | [**Guid?**](.md)| The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget) | 

### Return type

[**AccountsResponse**](AccountsResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

