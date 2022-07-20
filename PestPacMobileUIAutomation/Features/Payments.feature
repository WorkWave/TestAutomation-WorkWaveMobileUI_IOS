@Payments
Feature: Payments

	#MOB-2963
Scenario: Cash Payment
	Given Logged Out
	When I Login
	| Field    | Value                    |
	| Email    | mdelgoda+qa@workwave.com |
	| Password | WorkWave1!               |
	Then Verify logged in
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
	Given Logged Out
	When I Login
	| Field    | Value                    |
	| Email    | mdelgoda+qa@workwave.com |
	| Password | WorkWave1!               |
	Then Verify logged in
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
Scenario: Credit Card Payment → No Payment Processor
	Given Logged Out
	When I Login
	| Field    | Value                    |
	| Email    | mdelgoda+qa@workwave.com |
	| Password | WorkWave1!               |
	Then Verify logged in
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

	#MOB-2955,MOB-2967,MOB-2968
Scenario: Record Credit Card Payment,and Store Card,with Stored Card → Vantiv
	Given Logged Out
	When I Login
	| Field    | Value                      |
	| Email    | mdelgoda+emp5@workwave.com |
	| Password | WorkWave1!                 |
	Then Verify logged in
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Navigate To Payment View
	Given Payments Opened
	When Select Payment Mode 
	| Field         | Value              |
	| PaymentType   | Credit Card        |
	| PayTotalDue   | true               |
	| Option        | Enter a new card.. |
	| SaveOption    | No                 |
	| CardNumber    | 6011000990139424   |
	| CVV           | 1234               |
	| PaymentAmount | 1.00               |
	Then Verify Payment Made
	Given Payments Opened
	When Select Payment Mode 
	| Field         | Value              |
	| PaymentType   | Credit Card        |
	| PayTotalDue   | true               |
	| Option        | Enter a new card.. |
	| SaveOption    | Yes                |
	| CardNumber    | 6011000990139424   |
	| CVV           | 1234               |
	| PaymentAmount | 1.00               |
	Then Verify Payment Made	
	Given Payments Opened
	When Select Payment Mode 
	| Field         | Value               |
	| PaymentType   | Credit Card         |
	| PayTotalDue   | true                |
	| Option        | Visa - 1111 (12/25) |
	| SaveOption    | Yes                 |
	| CardNumber    | 6011000990139424    |
	| CVV           | 1234                |
	| PaymentAmount | 1.00                |
	Then Verify Payment Made
	

	#MOB-2965,MOB-2966,MOB-2962
Scenario: Record Credit Card Payment,and Store Card,with Stored Card → OpenEdge
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
	| Field         | Value              |
	| PaymentType   | Credit Card        |
	| PayTotalDue   | true               |
	| Option        | Enter a new card.. |
	| SaveOption    | No                 |
	| CardNumber    | 5413330089604111   |
	| CVV           | 123                |
	| PaymentAmount | 13.17              |
	Then Verify Payment Made 
	Given Payments Opened
	When Select Payment Mode OpenEdge
	| Field         | Value              |
	| PaymentType   | Credit Card        |
	| PayTotalDue   | true               |
	| Option        | Enter a new card.. |
	| SaveOption    | Yes                |
	| CardNumber    | 5413330089604111   |
	| CVV           | 123                |
	| PaymentAmount | 13.17              |
	Then Verify Payment Made 
	Given Payments Opened
	When Select Payment Mode OpenEdge
	| Field         | Value               |
	| PaymentType   | Credit Card         |
	| PayTotalDue   | true                |
	| Option        | Visa - 0010 (12/25) |
	| SaveOption    | Yes                 |
	| CardNumber    | 5413330089604111    |
	| CVV           | 123                 |
	| PaymentAmount | 13.17               |
	Then Verify Payment Made 

	#MOB-2964
Scenario: Record Credit Card Payment,and Store Card,with Stored Card → WorkWave Payments
	Given Logged Out
	When I Login
	| Field    | Value                      |
	| Email    | mdelgoda+emp2@workwave.com |
	| Password | WorkWave1!                 |
	Then Verify logged in
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Navigate To Payment View
	Given Payments Opened
	When Select Payment Mode WWP
	| Field         | Value              |
	| PaymentType   | Credit Card        |
	| PayTotalDue   | true               |
	| Option        | Enter a new card.. |
	| SaveOption    | No                 |
	| CardNumber    | 5413330089010681   |
	| CVV           | 123                |
	| PaymentAmount | 43.17              |
	Then Verify Payment Made 
	Given Payments Opened
	When Select Payment Mode WWP
	| Field         | Value              |
	| PaymentType   | Credit Card        |
	| PayTotalDue   | true               |
	| Option        | Enter a new card.. |
	| SaveOption    | Yes                |
	| CardNumber    | 5413330089010681   |
	| CVV           | 123                |
	| PaymentAmount | 43.17              |
	Then Verify Payment Made
	Given Payments Opened
	When Select Payment Mode WWP
	| Field         | Value               |
	| PaymentType   | Credit Card         |
	| PayTotalDue   | true                |
	| Option        | Visa - 0006 (12/25) |
	| SaveOption    | Yes                 |
	| CardNumber    | 5413330089010681    |
	| CVV           | 123                 |
	| PaymentAmount | 43.17               |
	Then Verify Payment Made 
