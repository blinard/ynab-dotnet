# YNAB.Dotnet.Model.TransactionDetail
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** |  | 
**Date** | **DateTime?** |  | 
**Amount** | **int?** | The transaction amount in milliunits format | 
**Memo** | **string** |  | 
**Cleared** | **string** | The cleared status of the transaction | 
**Approved** | **bool?** | Whether or not the transaction is approved | 
**FlagColor** | **string** | The transaction flag | 
**AccountId** | **Guid?** |  | 
**PayeeId** | **Guid?** |  | 
**CategoryId** | **Guid?** |  | 
**TransferAccountId** | **Guid?** | If a transfer transaction, the account to which it transfers | 
**TransferTransactionId** | **Guid?** | If a transfer transaction, the id of transaction on the other side of the transfer | 
**ImportId** | **string** | If the Transaction was imported, this field is a unique (by account) import identifier.  If this transaction was imported through File Based Import or Direct Import and not through the API, the import_id will have the format: &#39;YNAB:[milliunit_amount]:[iso_date]:[occurrence]&#39;.  For example, a transaction dated 2015-12-30 in the amount of -$294.23 USD would have an import_id of &#39;YNAB:-294230:2015-12-30:1&#39;.  If a second transaction on the same account was imported and had the same date and same amount, its import_id would be &#39;YNAB:-294230:2015-12-30:2&#39;. | 
**Deleted** | **bool?** | Whether or not the transaction has been deleted.  Deleted transactions will only be included in delta requests. | 
**AccountName** | **string** |  | 
**PayeeName** | **string** |  | 
**CategoryName** | **string** |  | 
**Subtransactions** | [**List&lt;SubTransaction&gt;**](SubTransaction.md) | If a split transaction, the subtransactions. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

