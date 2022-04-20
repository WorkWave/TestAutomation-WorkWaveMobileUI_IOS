@TimeSheet
Feature: TimeSheet


	#MOB-3812,MOB-3822
Scenario: Time All In ,Time All Out
	Given Logged Out
	When I Login
	| Field    | Value                     |
	| Email    | mdelgoda+tml@workwave.com |
	| Password | WorkWave1!                |
	When Time All In
	| Field      | Value |
	| TeamCount | 3     |
	Then Verify Time All In
	When Time All Out
	| Field      | Value |
	| TeamCount | 3     |
	Then Verify Time All Out