# YNAB.Dotnet.Api.PayeesApi

All URIs are relative to *https://api.youneedabudget.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPayeeById**](PayeesApi.md#getpayeebyid) | **GET** /budgets/{budget_id}/payees/{payee_id} | Single payee
[**GetPayees**](PayeesApi.md#getpayees) | **GET** /budgets/{budget_id}/payees | List payees


<a name="getpayeebyid"></a>
# **GetPayeeById**
> PayeeResponse GetPayeeById (Guid? budgetId, Guid? payeeId)

Single payee

Returns single payee

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class GetPayeeByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PayeesApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)
            var payeeId = new Guid?(); // Guid? | The id of the payee

            try
            {
                // Single payee
                PayeeResponse result = apiInstance.GetPayeeById(budgetId, payeeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayeesApi.GetPayeeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **budgetId** | [**Guid?**](.md)| The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget) | 
 **payeeId** | [**Guid?**](.md)| The id of the payee | 

### Return type

[**PayeeResponse**](PayeeResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayees"></a>
# **GetPayees**
> PayeesResponse GetPayees (Guid? budgetId)

List payees

Returns all payees

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class GetPayeesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PayeesApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)

            try
            {
                // List payees
                PayeesResponse result = apiInstance.GetPayees(budgetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayeesApi.GetPayees: " + e.Message );
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

[**PayeesResponse**](PayeesResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

