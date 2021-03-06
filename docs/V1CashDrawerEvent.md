# Square.Connect.Model.V1CashDrawerEvent

### Description

V1CashDrawerEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The event&#39;s unique ID. | [optional] 
**EmployeeId** | **string** | The ID of the employee that created the event. | [optional] 
**EventType** | **EventTypeEnum** | The type of event that occurred. See [V1CashDrawerEventEventType](#type-v1cashdrawereventeventtype) for possible values | [optional] 
**EventMoney** | [**V1Money**](V1Money.md) | The amount of money that was added to or removed from the cash drawer because of the event. This value can be positive (for added money) or negative (for removed money). | [optional] 
**CreatedAt** | **string** | The time when the event occurred, in ISO 8601 format. | [optional] 
**Description** | **string** | An optional description of the event, entered by the employee that created it. | [optional] 


## EventTypeEnum

Name | Value
------------ | -------------
**NOSALE** | "NO_SALE"
**CASHTENDERPAYMENT** | "CASH_TENDER_PAYMENT"
**OTHERTENDERPAYMENT** | "OTHER_TENDER_PAYMENT"
**CASHTENDERCANCELEDPAYMENT** | "CASH_TENDER_CANCELED_PAYMENT"
**OTHERTENDERCANCELEDPAYMENT** | "OTHER_TENDER_CANCELED_PAYMENT"
**CASHTENDERREFUND** | "CASH_TENDER_REFUND"
**OTHERTENDERREFUND** | "OTHER_TENDER_REFUND"
**PAIDIN** | "PAID_IN"
**PAIDOUT** | "PAID_OUT"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

