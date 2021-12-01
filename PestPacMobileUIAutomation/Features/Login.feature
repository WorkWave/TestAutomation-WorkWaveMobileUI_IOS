﻿@Login
Feature: Login
	Log into mobile app as a tech
	Log out mobile app as a tech


Scenario: Successful Login
	Given Logged Out
	When I Login
	| Field    | Value                |
	| Email    | mdelgoda@workwave.com|
	| Password | WorkWave1!           |
	Then Verify logged in

Scenario: Invalid Login
	When I Login
	| Field    | Value                 |
	| Email    | mdelgoda@workwave.com |
	| Password | asdfasdfasdf          |
	Then Verify invalid email
