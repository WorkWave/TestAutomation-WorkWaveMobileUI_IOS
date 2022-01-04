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


Scenario: Check Payment
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Navigate To Payment View
	Given Payments Opened
	When Payment Made
	| Field       | Value |
	| PaymentType | Check  |
	| PayTotalDue | true  |
	Then Verify Payment Made

Scenario: Credit Card Payment
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Navigate To Payment View
	Given Payments Opened
	When Payment Made
	| Field       | Value |
	| PaymentType | Credit Card  |
	| PayTotalDue | true  |
	Then Verify Payment Made

