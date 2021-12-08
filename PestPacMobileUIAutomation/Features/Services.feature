@Services
Feature: Services

Scenario: Add Product On Service
	#Given No Service Discounts Exist
	#| Field          | Value |
	#| ServiceType    | ANY   |
	#| RandomizePrice | false |
	Given Product Tab Opened
	| Field    | Value |
	| ServiceType   | Cleaning Garden  |
	When Product Added
	| Field          | Value |
	| ServiceProduct | Cleaning Powder|
	| ServiceType    | Cleaning Garden  |
	Then Verify Product Exists
	Then Verify Service Total