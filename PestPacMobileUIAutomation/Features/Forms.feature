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

	# MOB-3217,MOB-3218.MOB-3154
Scenario: Edit Form → Save Draft,Edit Form → Preview,Delete a Draft Form
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
	When Draft Form Delete
	Then Verify Form Deleted


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

	# MOB-3209,MOB-3206,MOB-3234,# MOB-3205
Scenario: Edit Form → Insert Image → Pick from Gallery,Edit Form → Insert Image → Take a Photo,Edit Form → Clear All Fields,Edit Form → Insert Image → Location Images,Insert Image → Location Images
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Add Image To Media Gallery
	| Field        | Value             |
	| DocumentType | Pick from Gallery |
	| DocumentName | autoDoc           |
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
	When All Form Fields Cleared
	Then Verify All Form Fields Cleared
	When Insert Image To Form
	| Field        | Value           |
	| FormType     | Simple 1        |
	| DocumentType | Location Images |
	Then Verify Image Added
	

	
	