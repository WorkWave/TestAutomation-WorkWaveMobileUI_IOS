@Services
Feature: Services

Scenario: Add Product On Service,Update Product On Service,Delete Product On Service
	Given Not Started Order Opened
	| Field    | Value                 |
	| DetailsNeeded    | true |
	When Navigate To Services View
	Given Product Tab Opened
	| Field    | Value |
	| ServiceType   | Cleaning Auto  |
	When Product Added
	| Field          | Value |
	| ServiceProduct | Cleaning Powder|
	| ServiceType    | Cleaning Auto  |
	Then Verify Product Exists
	Then Verify Service Total
	Given Product Tab Opened
	| Field    | Value |
	| ServiceType   | Cleaning Auto  |
	When Product Edited
	| Field | Value |
	| ServiceProduct | Cleaning Powder|
	| ServiceType    | Cleaning Auto  |
	Then Verify Product Exists
	Then Verify Service Total
	Given Product Tab Opened
	| Field    | Value |
	| ServiceType   | Cleaning Auto  |
	When Product Deleted
	| Field | Value |
	| ServiceProduct | Cleaning Powder|
	| ServiceType    | Cleaning Auto  |
	Then Verify Product Deleted
	Then Verify Service Total

Scenario: Add Material On Service,Edit Material On Service,Delete Material On Service
	Given Not Started Order Opened
	| Field    | Value                 |
	| DetailsNeeded    | true |
	When Navigate To Services View
	Given Material Tab Opened
	| Field    | Value |
	| ServiceType    | Cleaning Auto   |
	| RandomizePrice | false |
	When Material Added
	| Field | Value |
	| ServiceMaterial | Broom |
	Then Verify Material Exists
	When Material Edited
	| Field | Value |
	| ServiceMaterial | Broom |
	Then Verify Material Edited
	When Material Deleted
	| Field | Value |
	| ServiceMaterial | Broom |
	Then Verify Material Does Not Exist

Scenario: Add Value Discount On Service,Update Service offering Value Discount On Service,Delete Service Offering Value Discount
	Given Not Started Order Opened
	| Field    | Value                 |
	| DetailsNeeded    | true |
	When Navigate To Services View
	Given Discount Tab Opened
	| Field    | Value |
	| ServiceType    | Cleaning Auto   |
	When Discount Added
	| Field               | Value |
	| ServiceDiscountType | Value |
	Then Verify Discount Exists
	Then Verify Discount Applied
	Given Discount Tab Opened
	| Field    | Value |
	| ServiceType    | Cleaning Auto   |
	When Discount Edited
	| Field | Value |
	| ServiceDiscountType | Value |
	Then Verify Discount Exists
	Then Verify Discount Applied
	Given Discount Tab Opened
	| Field    | Value |
	| ServiceType    | Cleaning Auto   |
	When Discount Deleted
	| Field | Value |
	| ServiceDiscountType | Value |
	Then Verify Discount Does Not Exist
	Then Verify Discount Removed
	

Scenario: Add Percentage Discount On Service,Update Service offering Percentage Discount On Service,Delete Service Offering Percentage Discount
	Given Not Started Order Opened
	| Field    | Value                 |
	| DetailsNeeded    | true |
	When Navigate To Services View
	Given Discount Tab Opened
	| Field    | Value |
	| ServiceType    | Cleaning Auto   |
	When Discount Added
	| Field               | Value |
	| ServiceDiscountType | Percent |
	Then Verify Discount Exists
	Then Verify Discount Applied
	Given Discount Tab Opened
	| Field    | Value |
	| ServiceType    | Cleaning Auto   |
	When Discount Edited
	| Field | Value |
	| ServiceDiscountType | Percent |
	Then Verify Discount Exists
	Then Verify Discount Applied
	Given Discount Tab Opened
	| Field    | Value |
	| ServiceType    | Cleaning Auto   |
	When Discount Deleted
	| Field | Value |
	| ServiceDiscountType | Percent |
	Then Verify Discount Does Not Exist
	Then Verify Discount Removed

Scenario: Add Fixed Price Service Offering,Update Fixed Price Service Offering,Delete Fixed Price Service Offering
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | true  |
	When Navigate To Services View
	When Service Added
	| Field          | Value      |
	| ServiceType    | Cleaning Window |
	Then Verify Service Added
	When Service Edited
	| Field          | Value      |
	| ServiceType    | Cleaning Window |
	Then Verify Service Edited
	When Service Deleted
	| Field       | Value |
	| ServiceType | Cleaning Window   |
	Then Verify Service Deleted

Scenario: Add Unit of Measure Service Offering
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | true  |
	When Navigate To Services View
	When Service Added
	| Field          | Value      |
	| ServiceType    | Service UOM |
	Then Verify Service Added

Scenario: Add By Man Hour Service Offering
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | true  |
	When Navigate To Services View
	When Service Added
	| Field          | Value      |
	| ServiceType    | Service MH |
	Then Verify Service Added

Scenario: Add Service Offering with Customer Signature Required
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | true  |
	When Navigate To Services View
	When Service Added
	| Field          | Value      |
	| ServiceType    | Service Auto with Customer sign |
	Then Verify Service Added
	When Customer Signature Tab added
	When Order Started 
	Then Verify Order Started
	When Order Completion
	Then Verify Customer Signature Required