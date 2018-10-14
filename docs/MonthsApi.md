# YNAB.Dotnet.Api.MonthsApi

All URIs are relative to *https://api.youneedabudget.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBudgetMonth**](MonthsApi.md#getbudgetmonth) | **GET** /budgets/{budget_id}/months/{month} | Single budget month
[**GetBudgetMonths**](MonthsApi.md#getbudgetmonths) | **GET** /budgets/{budget_id}/months | List budget months


<a name="getbudgetmonth"></a>
# **GetBudgetMonth**
> MonthDetailResponse GetBudgetMonth (Guid? budgetId, DateTime? month)

Single budget month

Returns a single budget month

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class GetBudgetMonthExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new MonthsApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)
            var month = 2013-10-20;  // DateTime? | The budget month in ISO format (e.g. 2016-12-30) (\"current\" can also be used to specify the current calendar month (UTC))

            try
            {
                // Single budget month
                MonthDetailResponse result = apiInstance.GetBudgetMonth(budgetId, month);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonthsApi.GetBudgetMonth: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **budgetId** | [**Guid?**](.md)| The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget) | 
 **month** | **DateTime?**| The budget month in ISO format (e.g. 2016-12-30) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC)) | 

### Return type

[**MonthDetailResponse**](MonthDetailResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbudgetmonths"></a>
# **GetBudgetMonths**
> MonthSummariesResponse GetBudgetMonths (Guid? budgetId)

List budget months

Returns all budget months

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class GetBudgetMonthsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new MonthsApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)

            try
            {
                // List budget months
                MonthSummariesResponse result = apiInstance.GetBudgetMonths(budgetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonthsApi.GetBudgetMonths: " + e.Message );
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

[**MonthSummariesResponse**](MonthSummariesResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

