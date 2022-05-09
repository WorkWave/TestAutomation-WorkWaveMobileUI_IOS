@Payments
Feature: Payments

	#MOB-2963
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
	When Process Payment
	Then Verify Payment Made

	#MOB-2960
Scenario: Check Payment
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Navigate To Payment View
	Given Payments Opened
	When Payment Made
	| Field       | Value |
	| PaymentType | Check |
	| PayTotalDue | true  |
	When Process Payment
	Then Verify Payment Made

	#MOB-2956
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
	When Process Payment
	Then Verify Payment Made

	#MOB-2955
Scenario: Record Credit Card Payment → Vantiv
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Navigate To Payment View
	Given Payments Opened
	When Select Payment Made 
	| Field       | Value              |
	| PaymentType | Credit Card        |
	| PayTotalDue | true               |
	| Option      | Enter a new card.. |
	| SaveOption  | No                 |
	| CardNumber  | 5610591081018250   |
	Then Verify Payment Made

	#MOB-2967
Scenario: Record Credit Card Payment and Store Card → Vantiv
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Navigate To Payment View
	Given Payments Opened
	When Select Payment Made 
	| Field       | Value              |
	| PaymentType | Credit Card        |
	| PayTotalDue | true               |
	| Option      | Enter a new card.. |
	| SaveOption  | Yes                |
	| CardNumber  | 5610591081018250   |
	Then Verify Payment Made

