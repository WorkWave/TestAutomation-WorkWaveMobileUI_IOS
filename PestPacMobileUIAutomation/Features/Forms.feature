@Forms
Feature: Forms
	
	# MOB-3220
Scenario: Add A Forms
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Form Added
	| Field    | Value       |
	| FormType | Simple 1    | 
	When Complete Form
	Then Verify Form Added

	# MOB-3217,MOB-3218
Scenario: Edit Form → Save Draft,Edit Form → Preview
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Form Added
	| Field    | Value       |
	| FormType | Simple 1    | 
	When Save Form As A Draft
	Then Verify Form Drafted
	When Drafted Form Opened
	When Preview Form
	Then Verify Preview Loaded

	# MOB-3213 , MOB-3212
Scenario: Add Form To Favorites,Unfavorite a Form Template
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Form Favorited
	| Field    | Value       |
	| FormType | Simple 1    | 
	Then Verify Form Favorited
	When Form Unfavorited
	Then Verify Form Unfavorited
	