@TimeSheet
Feature: TimeSheet


	#MOB-3812,MOB-3822,MOB-3826,MOB-3829,MOB-3819,MOB-3825,MOB-3815,MOB-3816,#MOB-3824,MOB-3817,MOB-3821
Scenario: Time All In ,Time All Out,Add Team Lunch,End Team Lunch for All,Add Team Break,End Team Break for All,Add Team Travel Time,End Team Travel Time For All,Time Single Technician In,Time Single Technician Out,Add Lunch Event for Single Technician
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
	When Time Single Technician Out
	Then Verify Time Single Technician Out
	
