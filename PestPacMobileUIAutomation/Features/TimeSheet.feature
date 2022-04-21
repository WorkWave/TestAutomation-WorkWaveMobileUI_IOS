@TimeSheet
Feature: TimeSheet


	#MOB-3812,MOB-3822,MOB-3826,MOB-3829
Scenario: Time All In ,Time All Out,Add Team Lunch,End Team Lunch for All
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
	When Time All Out
	| Field     | Value |
	| TeamCount | 3     |
	Then Verify Time All Out
	