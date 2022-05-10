﻿@Payments
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

	#MOB-2967,MOB-2968
Scenario: Record Credit Card Payment and Store Card → Vantiv,Record Credit Card Payment with Stored Card → Vantiv
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Navigate To Payment View
	Given Payments Opened
	When Select Payment Mode 
	| Field       | Value              |
	| PaymentType | Credit Card        |
	| PayTotalDue | true               |
	| Option      | Enter a new card.. |
	| SaveOption  | Yes                |
	| CardNumber  | 4111111111111111   |
	Then Verify Payment Mode	
	Given Payments Opened
	When Select Payment Mode 
	| Field       | Value               |
	| PaymentType | Credit Card         |
	| PayTotalDue | true                |
	| Option      | Visa - 1111 (12/25) |
	| SaveOption  | Yes                 |
	| CardNumber  | 4111111111111111    |
	| CVV         | 1234                |
	Then Verify Payment Mode

	#MOB-2965,MOB-2966
Scenario: Record Credit Card Payment,Store Card → OpenEdge
	Given Logged Out
	When I Login
	| Field    | Value                      |
	| Email    | mdelgoda+emp1@workwave.com |
	| Password | WorkWave1!                 |
	Then Verify logged in
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Navigate To Payment View
	Given Payments Opened
	When Select Payment Mode OpenEdge
	| Field       | Value              |
	| PaymentType | Credit Card        |
	| PayTotalDue | true               |
	| Option      | Enter a new card.. |
	| SaveOption  | No                 |
	| CardNumber  | 4761739001010010   |
	| CVV         | 123                |
	Then Verify Payment Mode 
	Given Payments Opened
	When Select Payment Mode OpenEdge
	| Field       | Value              |
	| PaymentType | Credit Card        |
	| PayTotalDue | true               |
	| Option      | Enter a new card.. |
	| SaveOption  | Yes                |
	| CardNumber  | 4761739001010010   |
	| CVV         | 123                |
	Then Verify Payment Mode 

	

