@TimeSheet
Feature: TimeSheet


	#MOB-3812
Scenario: Time All In
	Given Logged Out
	When I Login
	| Field    | Value                     |
	| Email    | mdelgoda+tml@workwave.com |
	| Password | WorkWave1!                |
	Then Time All In
	| Field      | Value |
	| TeamCount | 3     |
	Then Verify Time All In
	