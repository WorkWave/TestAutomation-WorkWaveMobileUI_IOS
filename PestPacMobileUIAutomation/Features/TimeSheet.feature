@TimeSheet
Feature: TimeSheet


	#MOB-3812,MOB-3822,MOB-3826,MOB-3829,MOB-3819,MOB-3825,MOB-3815,MOB-3816,MOB-3824,MOB-3817,MOB-3821,MOB-3823,MOB-3818,MOB-3820,MOB-3813,MOB-3814
Scenario: Time All In ,Time All Out,Add Team Break/Travel/Lunch,End Team Break/Travel/Lunch for All,Time Single Technician In,Time Single Technician Out,Add Lunch/Travel/Break Event for Single Technician,End Lunch/Travel/Break Event for Single Technician
	Given Logged Out
	When I Login
	| Field    | Value                     |
	| Email    | mdelgoda+tml@workwave.com |
	| Password | WorkWave1!                |
	When Time All In
	| Field     | Value |
	| TeamCount | 3     |
	Then Verify Time All In
	When Add Team Event
	| Field     | Value      |
	| TeamCount | 3          |
	| Event     | Team Lunch |
	Then  Verify Team Event Added
	When End Team Event for All
	| Field     | Value |
	| TeamCount | 3     |
	| Event     | Team Lunch |
	Then Verify End Team Event 
	When Add Team Event
	| Field     | Value      |
	| TeamCount | 3          |
	| Event     | Team Break |
	Then Verify Team Event Added
	When End Team Event for All
	| Field     | Value      |
	| TeamCount | 3          |
	| Event     | Team Break |
	Then Verify End Team Event 
	When Add Team Event
	| Field     | Value            |
	| TeamCount | 3                |
	| Event     | Team Travel Time |
	Then Verify Team Event Added
	When End Team Event for All
	| Field     | Value            |
	| TeamCount | 3                |
	| Event     | Team Travel Time |
	Then Verify End Team Event 
	When Time All Out
	| Field     | Value |
	| TeamCount | 3     |
	Then Verify Time All Out
	When Time Single Technician In
	| Field          | Value         |
	| TeamCount      | 3             |
	| TeamMemberName | Team Member 1 |
	Then Verify Time Single Technician In	
	When Add Event for Single Technician
	| Field          | Value         |
	| TeamCount      | 3             |
	| TeamMemberName | Team Member 1 |
	| Event          | Lunch         |  
	Then Verify Add Event for Single Technician
	When End Event for Single Technician
	Then Verify End Event for Single Technician
	When Add Event for Single Technician
	| Field          | Value         |
	| TeamCount      | 3             |
	| TeamMemberName | Team Member 1 |
	| Event          | Travel Time   |  
	Then Verify Add Event for Single Technician	
	When End Event for Single Technician
	Then Verify End Event for Single Technician
	When Add Event for Single Technician
	| Field          | Value         |
	| TeamCount      | 3             |
	| TeamMemberName | Team Member 1 |
	| Event          | Break         |  
	Then Verify Add Event for Single Technician	
	When End Event for Single Technician
	Then Verify End Event for Single Technician
	When Time Single Technician Out
	Then Verify Time Single Technician Out
	
