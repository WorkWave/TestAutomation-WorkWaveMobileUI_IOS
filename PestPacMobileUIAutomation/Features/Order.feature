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

Scenario: Update Service Location Custom Text,Date,Check Box,Quantity,Drop-Down,Trait Field
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
	| Field           | Value  |
	| CustomFieldName | Trait1 |
	| CustomFieldType | Trait  |
	When Custom Field Edited
	| Field           | Value  |
	| CustomFieldName | Trait1 |
	| CustomFieldType | Trait  |
	Then Verify Edited Custom Field
	When Custom Field Selected
	| Field           | Value |
	| CustomFieldName | Date  |
	When Custom Field Edited
	| Field           | Value |
	| CustomFieldName | Date  |
	| CustomFieldType | Date  |
	#Then Verify Custom Field Edited

	#MOB-3050
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
	