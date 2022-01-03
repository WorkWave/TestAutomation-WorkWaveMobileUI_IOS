@Payments
Feature: Payments

Scenario: Cash Payment
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Navigate To Payment View
	Given Payments Opened
	When Payment Made
	| Field       | Value |
	| PaymentType | Cash  |
	| PayTotalDue | true  |
	Then Verify Payment Made