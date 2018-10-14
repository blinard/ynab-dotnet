# YNAB.Dotnet.Model.SaveTransactionsResponseData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionIds** | **List&lt;string&gt;** | The transaction ids that were saved | 
**Transaction** | [**TransactionDetail**](TransactionDetail.md) | If a single transaction was specified, the transaction that was saved | [optional] 
**Transactions** | [**List&lt;TransactionDetail&gt;**](TransactionDetail.md) | If multiple transactions were specified, the transactions that were saved | [optional] 
**DuplicateImportIds** | **List&lt;string&gt;** | If multiple transactions were specified, a list of import_ids that were not were created because of an existing import_id found on the same account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

