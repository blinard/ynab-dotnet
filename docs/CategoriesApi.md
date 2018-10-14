# YNAB.Dotnet.Api.CategoriesApi

All URIs are relative to *https://api.youneedabudget.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCategories**](CategoriesApi.md#getcategories) | **GET** /budgets/{budget_id}/categories | List categories
[**GetCategoryById**](CategoriesApi.md#getcategorybyid) | **GET** /budgets/{budget_id}/categories/{category_id} | Single category
[**GetMonthCategoryById**](CategoriesApi.md#getmonthcategorybyid) | **GET** /budgets/{budget_id}/months/{month}/categories/{category_id} | Single category for a specific budget month
[**UpdateMonthCategory**](CategoriesApi.md#updatemonthcategory) | **PATCH** /budgets/{budget_id}/months/{month}/categories/{category_id} | Update an existing month category


<a name="getcategories"></a>
# **GetCategories**
> CategoriesResponse GetCategories (Guid? budgetId)

List categories

Returns all categories grouped by category group.  Amounts (budgeted, activity, balance, etc.) are specific to the current budget month (UTC).

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class GetCategoriesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CategoriesApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)

            try
            {
                // List categories
                CategoriesResponse result = apiInstance.GetCategories(budgetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategories: " + e.Message );
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

[**CategoriesResponse**](CategoriesResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategorybyid"></a>
# **GetCategoryById**
> CategoryResponse GetCategoryById (Guid? budgetId, Guid? categoryId)

Single category

Returns a single category.  Amounts (budgeted, activity, balance, etc.) are specific to the current budget month (UTC).

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class GetCategoryByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CategoriesApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)
            var categoryId = new Guid?(); // Guid? | The id of the category

            try
            {
                // Single category
                CategoryResponse result = apiInstance.GetCategoryById(budgetId, categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoryById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **budgetId** | [**Guid?**](.md)| The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget) | 
 **categoryId** | [**Guid?**](.md)| The id of the category | 

### Return type

[**CategoryResponse**](CategoryResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmonthcategorybyid"></a>
# **GetMonthCategoryById**
> CategoryResponse GetMonthCategoryById (Guid? budgetId, DateTime? month, Guid? categoryId)

Single category for a specific budget month

Returns a single category for a specific budget month.  Amounts (budgeted, activity, balance, etc.) are specific to the current budget month (UTC).

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class GetMonthCategoryByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CategoriesApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)
            var month = 2013-10-20;  // DateTime? | The budget month in ISO format (e.g. 2016-12-30) (\"current\" can also be used to specify the current calendar month (UTC))
            var categoryId = new Guid?(); // Guid? | The id of the category

            try
            {
                // Single category for a specific budget month
                CategoryResponse result = apiInstance.GetMonthCategoryById(budgetId, month, categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetMonthCategoryById: " + e.Message );
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
 **categoryId** | [**Guid?**](.md)| The id of the category | 

### Return type

[**CategoryResponse**](CategoryResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemonthcategory"></a>
# **UpdateMonthCategory**
> CategoryResponse UpdateMonthCategory (Guid? budgetId, DateTime? month, Guid? categoryId, SaveMonthCategoryWrapper monthCategory)

Update an existing month category

Update an existing month category

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class UpdateMonthCategoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CategoriesApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)
            var month = 2013-10-20;  // DateTime? | The budget month in ISO format (e.g. 2016-12-30) (\"current\" can also be used to specify the current calendar month (UTC))
            var categoryId = new Guid?(); // Guid? | The id of the category
            var monthCategory = new SaveMonthCategoryWrapper(); // SaveMonthCategoryWrapper | The month category to update

            try
            {
                // Update an existing month category
                CategoryResponse result = apiInstance.UpdateMonthCategory(budgetId, month, categoryId, monthCategory);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.UpdateMonthCategory: " + e.Message );
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
 **categoryId** | [**Guid?**](.md)| The id of the category | 
 **monthCategory** | [**SaveMonthCategoryWrapper**](SaveMonthCategoryWrapper.md)| The month category to update | 

### Return type

[**CategoryResponse**](CategoryResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

