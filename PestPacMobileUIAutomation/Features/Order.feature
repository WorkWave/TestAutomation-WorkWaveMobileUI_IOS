@Order
Feature: Order

Scenario: Complete Work Order
	Given Not Started Order Opened
	| Field    | Value                 |
	| DetailsNeeded    | true |
	When Order Started
	Then Verify Order Started
	Then Verify Appointment Card Status
	When Order Completed
	Then Verify Order Completed
	Then Verify Appointment Card Status

	#MOB-3028,MOB-3025,MOB-3023,MOB-3020,MOB-3022,MOB-3026
Scenario: Update Service Location Custom Text,Date,Check Box,Quantity,Drop-Down,Multi Line Field
	Given Viewing Service Location Custom Fields
	| Field         | Value |
	| DetailsNeeded | false |
	When Custom Field Selected
	| Field                 | Value |
	| CustomFieldName       | Text  |
	When Custom Field Edited
	| Field           | Value |
	| CustomFieldName | Text  |
	| CustomFieldType | Text  |
	Then Verify Custom Field Edited
	When Custom Field Selected
	| Field           | Value     |
	| CustomFieldName | Check Box |
	When Custom Field Edited
	| Field                 | Value     |
	| CustomFieldType       | Check Box |
	| CustomFieldName       | Check Box |
	| WorkOrderCustomFields | No        |
	Then Verify Custom Field Edited
	When Custom Field Selected
	| Field           | Value     |
	| CustomFieldName | Drop-down |
	When Custom Field Edited
	| Field           | Value     |
	| CustomFieldName | Drop-down |
	| CustomFieldType | Drop-down |
	Then Verify Custom Field Edited
	When Custom Field Selected
	| Field           | Value |
	| CustomFieldName | Quantity  |
	When Custom Field Edited
	| Field           | Value    |
	| CustomFieldName | Quantity |
	| CustomFieldType | Quantity |
	Then Verify Custom Field Edited
	When Custom Field Selected
	| Field           | Value      |
	| CustomFieldName | Multi Line |
	| CustomFieldType | Multi Line |
	When Custom Field Edited
	| Field           | Value      |
	| CustomFieldName | Multi Line |
	| CustomFieldType | Multi Line |
	Then Verify Edited Custom Field
	When Custom Field Selected
	| Field           | Value |
	| CustomFieldName | Date  |
	When Custom Field Edited
	| Field           | Value |
	| CustomFieldName | Date  |
	| CustomFieldType | Date  |
	#Then Verify Custom Field Edited

	#MOB-3050,MOB-3048,MOB-3047,MOB-3045,MOB-3043,MOB-3042,MOB-3041
Scenario: Update Work Order Custom Text,Date,Check Box,Quantity,Drop-Down Field
	Given Viewing Work Order Custom Fields
	| Field         | Value |
	| DetailsNeeded | false |
	When Custom Field Selected
	| Field                 | Value |
	| CustomFieldName       | Text  |
	When Custom Field Edited
	| Field           | Value |
	| CustomFieldName | Text  |
	| CustomFieldType | Text  |
	Then Verify Custom Field Edited
	When Custom Field Selected
	| Field           | Value     |
	| CustomFieldName | Check Box |
	When Custom Field Edited
	| Field            | Value     |
	| CustomFieldType | Check Box  |
	| CustomFieldName | Check Box  |
	| WorkOrderCustomFields | No  |
	Then Verify Custom Field Edited
	When Custom Field Selected
	| Field           | Value     |
	| CustomFieldName | Drop-down |
	When Custom Field Edited
	| Field           | Value     |
	| CustomFieldName | Drop-down |
	| CustomFieldType | Drop-down |
	Then Verify Custom Field Edited
	When Custom Field Selected
	| Field           | Value    |
	| CustomFieldName | Quantity |
	When Custom Field Edited
	| Field            | Value    |
	| CustomFieldName | Quantity  |
	| CustomFieldType | Quantity  |
	Then Verify Custom Field Edited
	When Custom Field Selected
	| Field           | Value |
	| CustomFieldName | Date  |
	When Custom Field Edited
	| Field           | Value |
	| CustomFieldName | Date  |
	| CustomFieldType | Date  |
	#Then Verify Custom Field Edited

	#MOB-3019
Scenario: Update Service Location Property Trait
	Given Viewing Service Location Custom Fields
	| Field         | Value |
	| DetailsNeeded | false |
	When Custom Field Selected
	| Field           | Value              |
	| CustomFieldName | Number of Bedrooms |
	When Traits Field Edited
	Then Verify Custom Field Edited

	#MOB-3033
Scenario: View Service Location Contacts
	Given Viewing Service Location Custom Fields
	| Field         | Value |
	| DetailsNeeded | false |
	When View Service Location Contacts
	When Access the phone 
	Then Verify the Contact by Phone Opened
	When Access the Email 
	Then Verify the Contact by Email Opened
	
	