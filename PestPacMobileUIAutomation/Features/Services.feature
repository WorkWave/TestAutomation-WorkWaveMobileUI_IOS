@Services
Feature: Services

Scenario: Add Product On Service,Update Product On Service,Delete Product On Service
	Given Not Started Order Opened
	| Field    | Value                 |
	| DetailsNeeded    | true |
	When Navigate To Services View
	Given Product Tab Opened
	| Field    | Value |
	| ServiceType   | Cleaning Garden  |
	When Product Added
	| Field          | Value |
	| ServiceProduct | Cleaning Powder|
	| ServiceType    | Cleaning Garden  |
	Then Verify Product Exists
	Then Verify Service Total
	Given Product Tab Opened
	| Field    | Value |
	| ServiceType   | Cleaning Garden  |
	When Product Edited
	| Field | Value |
	| ServiceProduct | Cleaning Powder|
	| ServiceType    | Cleaning Garden  |
	Then Verify Product Exists
	Then Verify Service Total
	Given Product Tab Opened
	| Field    | Value |
	| ServiceType   | Cleaning Garden  |
	When Product Deleted
	| Field | Value |
	| ServiceProduct | Cleaning Powder|
	| ServiceType    | Cleaning Garden  |
	Then Verify Product Deleted
	Then Verify Service Total

Scenario: Add Material On Service,Edit Material On Service
	Given Not Started Order Opened
	| Field    | Value                 |
	| DetailsNeeded    | true |
	When Navigate To Services View
	Given Material Tab Opened
	| Field    | Value |
	| ServiceType    | Cleaning Garden   |
	| RandomizePrice | false |
	When Material Added
	| Field | Value |
	| ServiceMaterial | Broom |
	Then Verify Material Exists
	When Material Edited
	| Field | Value |
	| ServiceMaterial | Broom |
	Then Verify Material Edited