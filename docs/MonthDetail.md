# YNAB.Dotnet.Model.MonthDetail
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Month** | **DateTime?** |  | 
**Note** | **string** |  | 
**Income** | **int?** | The total amount in transactions categorized to &#39;Inflow: To be Budgeted&#39; in the month | 
**Budgeted** | **int?** | The total amount budgeted in the month | 
**Activity** | **int?** | The total amount in transactions in the month, excluding those categorized to &#39;Inflow: To be Budgeted&#39; | 
**ToBeBudgeted** | **int?** | The available amount for &#39;To be Budgeted&#39; | 
**AgeOfMoney** | **int?** | The Age of Money as of the month | 
**Categories** | [**List&lt;Category&gt;**](Category.md) | The budget month categories.  Amounts (budgeted, activity, balance, etc.) are specific to the {month} parameter specified. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

