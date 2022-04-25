﻿@TimeSheet
Feature: TimeSheet


	#MOB-3812,MOB-3822,MOB-3826,MOB-3829,MOB-3819,MOB-3825,MOB-3815
Scenario: Time All In ,Time All Out,Add Team Lunch,End Team Lunch for All,Add Team Break,End Team Break for All,Add Team Travel Time
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
	When Time All Out
	| Field     | Value |
	| TeamCount | 3     |
	Then Verify Time All Out
	