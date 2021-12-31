@Payments
Feature: Payments

Scenario: Cash Payment
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	Given Payments Opened
	| Field        | Value |
	| DetailsNeeded| false |
	When Payment Made
	| Field       | Value |
	| PaymentType | Cash  |
	| PayTotalDue | true  |
	Then Verify Payment Made