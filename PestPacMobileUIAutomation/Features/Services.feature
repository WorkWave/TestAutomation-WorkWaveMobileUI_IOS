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

	# MOB-3365 MOB-3366
Scenario: Add Fixed Price Service Offering,Update Fixed Price Service Offering,Delete Fixed Price Service Offering,Toggle Do Not Charge for Service to OFF,Toggle Do Not Charge for Service to ON
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
	When Service Added with service charge
	| Field          | Value      |
	| ServiceType    | Cleaning Window |
	Then Verify Service Price
	When Service Added without service charge
	| Field          | Value      |
	| ServiceType    | Cleaning Window |
	Then Verify Service Price not added

	# MOB-3355 MOB-3338 MOB-3339
Scenario: Add Unit of Measure Service Offering,Update Unit of Measure Service Offering,Delete Unit of Measure Service Offering
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | true  |
	When Navigate To Services View
	When Service Added
	| Field       | Value       |
	| ServiceType | Service UOM |
	Then Verify Service Added
	When Service Edited
	| Field       | Value       |
	| ServiceType | Service UOM |
	Then Verify Service Edited
	When Service Deleted
	| Field       | Value       |
	| ServiceType | Service UOM |
	Then Verify Service Deleted

	# MOB-3370 MOB-3338 
Scenario: Add By Man Hour Service Offering
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | true  |
	When Navigate To Services View
	When Service Added
	| Field          | Value      |
	| ServiceType    | Service MH |
	Then Verify Service Added
	When Service Edited
	| Field       | Value       |
	| ServiceType | Service MH  |
	Then Verify Service Edited

	# MOB-3363
Scenario: Add Service Offering with Customer Signature Required
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | true  |
	When Navigate To Services View
	When Service Added
	| Field          | Value      |
	| ServiceType    | Service Offering with Customer sign |
	Then Verify Service Added
	When Customer Signature Tab added
	When Order Started 
	Then Verify Order Started
	When Order Completion
	Then Verify Customer Signature Required

	# MOB-3361
Scenario: Add Service Offering with Employee Signature Required
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | true  |
	When Navigate To Services View
	When Service Added
	| Field          | Value      |
	| ServiceType    | Service offering with Employee Signature |
	Then Verify Service Added
	When Employee Signature Tab added
	When Order Started 
	Then Verify Order Started
	When Order Completion
	Then Verify Employee Signature Required

	# MOB-3358
Scenario: Add Service Offering with Default Material
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | true  |
	When Navigate To Services View
	When Service Added
	| Field          | Value      |
	| ServiceType    | Service with default material |
	Then Verify Service with material Added
	| Field           | Value |
	| ServiceType    | Service with default material |
	| ServiceMaterial | Material Auto IOS |

	# MOB-3356
Scenario: Add Service Offering with Default Product
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | true  |
	When Navigate To Services View
	When Service Added
	| Field          | Value      |
	| ServiceType    | Service with default product |
	Then Verify Service with product Added
	| Field           | Value |
	| ServiceType    | Service with default product |
	| ServiceProduct | Product auto IOS |

	# MOB-3348 MOB-3359
Scenario: Add Target Pest,Delete Target Pest
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | true  |
	When Navigate To Services View
	Given Pest Tab Opened
	| Field       | Value         |
	| ServiceType | Cleaning Auto |
	When Pest Added
	| Field       | Value         |
	| Pest        | Ants          |
	| ServiceType | Cleaning Auto |
	Then Verify Pest Added
	When Delete Target Pest
	| Field       | Value         |
	| Pest        | Ants          |
	Then Verify Pest deleted

