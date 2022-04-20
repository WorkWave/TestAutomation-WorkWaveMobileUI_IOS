﻿@TimeSheet
Feature: TimeSheet


	#MOB-3812,MOB-3822,MOB-3826
Scenario: Time All In ,Time All Out,Add Team Lunch
	Given Logged Out
	When I Login
	| Field    | Value                     |
	| Email    | mdelgoda+tml@workwave.com |
	| Password | WorkWave1!                |
	When Time All In
	| Field     | Value |
	| TeamCount | 3     |
	Then Verify Time All In
	When Add Team Lunch
	| Field     | Value |
	| TeamCount | 3     |
	Then Verify Team Lunch Added
	When Time All Out
	| Field     | Value |
	| TeamCount | 3     |
	Then Verify Time All Out