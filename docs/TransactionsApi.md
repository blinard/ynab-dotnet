# YNAB.Dotnet.Api.TransactionsApi

All URIs are relative to *https://api.youneedabudget.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTransaction**](TransactionsApi.md#createtransaction) | **POST** /budgets/{budget_id}/transactions | Create a single transaction or multiple transactions
[**GetTransactionById**](TransactionsApi.md#gettransactionbyid) | **GET** /budgets/{budget_id}/transactions/{transaction_id} | Single transaction
[**GetTransactions**](TransactionsApi.md#gettransactions) | **GET** /budgets/{budget_id}/transactions | List transactions
[**GetTransactionsByAccount**](TransactionsApi.md#gettransactionsbyaccount) | **GET** /budgets/{budget_id}/accounts/{account_id}/transactions | List account transactions
[**GetTransactionsByCategory**](TransactionsApi.md#gettransactionsbycategory) | **GET** /budgets/{budget_id}/categories/{category_id}/transactions | List category transactions
[**GetTransactionsByPayee**](TransactionsApi.md#gettransactionsbypayee) | **GET** /budgets/{budget_id}/payees/{payee_id}/transactions | List payee transactions
[**UpdateTransaction**](TransactionsApi.md#updatetransaction) | **PUT** /budgets/{budget_id}/transactions/{transaction_id} | Updates an existing transaction


<a name="createtransaction"></a>
# **CreateTransaction**
> SaveTransactionsResponse CreateTransaction (Guid? budgetId, SaveTransactionsWrapper saveTransactions)

Create a single transaction or multiple transactions

Creates a single transaction or multiple transactions.  If you provide a body containing a 'transaction' object, a single transaction will be created and if you provide a body containing a 'transactions' array, multiple transactions will be created.

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class CreateTransactionExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new TransactionsApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)
            var saveTransactions = new SaveTransactionsWrapper(); // SaveTransactionsWrapper | The transaction or transactions to create

            try
            {
                // Create a single transaction or multiple transactions
                SaveTransactionsResponse result = apiInstance.CreateTransaction(budgetId, saveTransactions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **budgetId** | [**Guid?**](.md)| The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget) | 
 **saveTransactions** | [**SaveTransactionsWrapper**](SaveTransactionsWrapper.md)| The transaction or transactions to create | 

### Return type

[**SaveTransactionsResponse**](SaveTransactionsResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionbyid"></a>
# **GetTransactionById**
> TransactionResponse GetTransactionById (Guid? budgetId, Guid? transactionId)

Single transaction

Returns a single transaction

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class GetTransactionByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new TransactionsApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)
            var transactionId = new Guid?(); // Guid? | The id of the transaction

            try
            {
                // Single transaction
                TransactionResponse result = apiInstance.GetTransactionById(budgetId, transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **budgetId** | [**Guid?**](.md)| The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget) | 
 **transactionId** | [**Guid?**](.md)| The id of the transaction | 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactions"></a>
# **GetTransactions**
> TransactionsResponse GetTransactions (Guid? budgetId, DateTime? sinceDate, string type)

List transactions

Returns budget transactions

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class GetTransactionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new TransactionsApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)
            var sinceDate = 2013-10-20;  // DateTime? | Only return transactions on or after this date (optional) 
            var type = type_example;  // string | Only return transactions of a certain type ('uncategorized' and 'unapproved' are currently supported) (optional) 

            try
            {
                // List transactions
                TransactionsResponse result = apiInstance.GetTransactions(budgetId, sinceDate, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **budgetId** | [**Guid?**](.md)| The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget) | 
 **sinceDate** | **DateTime?**| Only return transactions on or after this date | [optional] 
 **type** | **string**| Only return transactions of a certain type (&#39;uncategorized&#39; and &#39;unapproved&#39; are currently supported) | [optional] 

### Return type

[**TransactionsResponse**](TransactionsResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionsbyaccount"></a>
# **GetTransactionsByAccount**
> TransactionsResponse GetTransactionsByAccount (Guid? budgetId, Guid? accountId, DateTime? sinceDate, string type)

List account transactions

Returns all transactions for a specified account

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class GetTransactionsByAccountExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new TransactionsApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)
            var accountId = new Guid?(); // Guid? | The id of the account
            var sinceDate = 2013-10-20;  // DateTime? | Only return transactions on or after this date (optional) 
            var type = type_example;  // string | Only return transactions of a certain type (i.e. 'uncategorized', 'unapproved') (optional) 

            try
            {
                // List account transactions
                TransactionsResponse result = apiInstance.GetTransactionsByAccount(budgetId, accountId, sinceDate, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactionsByAccount: " + e.Message );
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
 **sinceDate** | **DateTime?**| Only return transactions on or after this date | [optional] 
 **type** | **string**| Only return transactions of a certain type (i.e. &#39;uncategorized&#39;, &#39;unapproved&#39;) | [optional] 

### Return type

[**TransactionsResponse**](TransactionsResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionsbycategory"></a>
# **GetTransactionsByCategory**
> HybridTransactionsResponse GetTransactionsByCategory (Guid? budgetId, Guid? categoryId, DateTime? sinceDate, string type)

List category transactions

Returns all transactions for a specified category

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class GetTransactionsByCategoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new TransactionsApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)
            var categoryId = new Guid?(); // Guid? | The id of the category
            var sinceDate = 2013-10-20;  // DateTime? | Only return transactions on or after this date (optional) 
            var type = type_example;  // string | Only return transactions of a certain type (i.e. 'uncategorized', 'unapproved') (optional) 

            try
            {
                // List category transactions
                HybridTransactionsResponse result = apiInstance.GetTransactionsByCategory(budgetId, categoryId, sinceDate, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactionsByCategory: " + e.Message );
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
 **sinceDate** | **DateTime?**| Only return transactions on or after this date | [optional] 
 **type** | **string**| Only return transactions of a certain type (i.e. &#39;uncategorized&#39;, &#39;unapproved&#39;) | [optional] 

### Return type

[**HybridTransactionsResponse**](HybridTransactionsResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionsbypayee"></a>
# **GetTransactionsByPayee**
> HybridTransactionsResponse GetTransactionsByPayee (Guid? budgetId, Guid? payeeId, DateTime? sinceDate, string type)

List payee transactions

Returns all transactions for a specified payee

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class GetTransactionsByPayeeExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new TransactionsApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)
            var payeeId = new Guid?(); // Guid? | The id of the payee
            var sinceDate = 2013-10-20;  // DateTime? | Only return transactions on or after this date (optional) 
            var type = type_example;  // string | Only return transactions of a certain type (i.e. 'uncategorized', 'unapproved') (optional) 

            try
            {
                // List payee transactions
                HybridTransactionsResponse result = apiInstance.GetTransactionsByPayee(budgetId, payeeId, sinceDate, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactionsByPayee: " + e.Message );
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
 **sinceDate** | **DateTime?**| Only return transactions on or after this date | [optional] 
 **type** | **string**| Only return transactions of a certain type (i.e. &#39;uncategorized&#39;, &#39;unapproved&#39;) | [optional] 

### Return type

[**HybridTransactionsResponse**](HybridTransactionsResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetransaction"></a>
# **UpdateTransaction**
> TransactionResponse UpdateTransaction (Guid? budgetId, Guid? transactionId, SaveTransactionWrapper transaction)

Updates an existing transaction

Updates a transaction

### Example
```csharp
using System;
using System.Diagnostics;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Client;
using YNAB.Dotnet.Model;

namespace Example
{
    public class UpdateTransactionExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new TransactionsApi();
            var budgetId = new Guid?(); // Guid? | The id of the budget (\"last-used\" can also be used to specify the last used budget)
            var transactionId = new Guid?(); // Guid? | The id of the transaction
            var transaction = new SaveTransactionWrapper(); // SaveTransactionWrapper | The transaction to update

            try
            {
                // Updates an existing transaction
                TransactionResponse result = apiInstance.UpdateTransaction(budgetId, transactionId, transaction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.UpdateTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **budgetId** | [**Guid?**](.md)| The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget) | 
 **transactionId** | [**Guid?**](.md)| The id of the transaction | 
 **transaction** | [**SaveTransactionWrapper**](SaveTransactionWrapper.md)| The transaction to update | 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

