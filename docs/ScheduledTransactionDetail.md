# YNAB.Dotnet.Model.ScheduledTransactionDetail
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** |  | 
**DateFirst** | **DateTime?** | The first date for which the Scheduled Transaction was scheduled. | 
**DateNext** | **DateTime?** | The next date for which the Scheduled Transaction is scheduled. | 
**Frequency** | **string** |  | 
**Amount** | **int?** | The scheduled transaction amount in milliunits format | 
**Memo** | **string** |  | 
**FlagColor** | **string** | The scheduled transaction flag | 
**AccountId** | **Guid?** |  | 
**PayeeId** | **Guid?** |  | 
**CategoryId** | **Guid?** |  | 
**TransferAccountId** | **Guid?** | If a transfer, the account_id which the scheduled transaction transfers to | 
**Deleted** | **bool?** | Whether or not the scheduled transaction has been deleted.  Deleted scheduled transactions will only be included in delta requests. | 
**AccountName** | **string** |  | 
**PayeeName** | **string** |  | 
**CategoryName** | **string** |  | 
**Subtransactions** | [**List&lt;ScheduledSubTransaction&gt;**](ScheduledSubTransaction.md) | If a split scheduled transaction, the subtransactions. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

