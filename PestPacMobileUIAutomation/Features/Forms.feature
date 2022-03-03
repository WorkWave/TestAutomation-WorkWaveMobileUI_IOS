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

	# MOB-3209,MOB-3206
Scenario: Edit Form → Insert Image → Pick from Gallery,Edit Form → Insert Image → Take a Photo
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Form Added
	| Field    | Value       |
	| FormType | Simple 1    |
	When Insert Image To Form
	| Field        | Value             |
	| FormType     | Simple 1          |
	| DocumentType | Pick from Gallery |
	Then Verify Image Added
	When Insert Image To Form
	| Field        | Value        |
	| FormType     | Simple 1     |
	| DocumentType | Take a Photo |
	Then Verify Image Added
	