@Forms
Feature: Forms
	
	# MOB-3220,MOB-3195
Scenario: Add A Forms,Interact with Complete Form
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Form Added
	| Field    | Value         |
	| FormType | Ios_Test Form |
	When Fill The Form
	| Field     | Value               |
	| FieldName | Given Name Text Box |
	When Complete Form
	Then Verify Form Added

	# MOB-3217,MOB-3218.MOB-3154,MOB-3181
Scenario: Edit Form → Save Draft,Edit Form → Preview,Delete a Draft Form,Interact with Draft Form
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Form Added
	| Field    | Value         |
	| FormType | Ios_Test Form |
	When Fill The Form
	| Field     | Value               |
	| FieldName | Given Name Text Box |
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
	| Field    | Value         |
	| FormType | Ios_Test Form |
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
	| Field    | Value         |
	| FormType | Ios_Test Form |
	When Fill Form Fields
	| Field     | Value               |
	| FieldName | Given Name Text Box |
	When Insert Image To Form
	| Field        | Value             |
	| FormType     | Ios_Test Form          |
	| DocumentType | Pick from Gallery |
	Then Verify Image Added
	When Insert Image To Form
	| Field        | Value        |
	| FormType     | Ios_Test Form     |
	| DocumentType | Take a Photo |
	Then Verify Image Added
	When All Form Fields Cleared
	Then Verify All Form Fields Cleared
	When Insert Image To Form
	| Field        | Value           |
	| FormType     | Ios_Test Form        |
	| DocumentType | Location Images |
	Then Verify Image Added
	
	#MOB-3159,MOB-3158
Scenario: Edit Form → Interact with Read-only Fields,Edit Form → Interact with Required Fields
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Form Added
	| Field    | Value         |
	| FormType | Ios_Test Form |
	When Start Form Editing
	When Search For Field
	| Field     | Value                |
	| FieldName | Family Name Text Box |
	Then Verify Search Result 
	| Field  | Value    |
	| Status | Readonly |
	Then Verify ReadOnly Field Is Not Editable
	When Required Feilds Filled
	| Field     | Value               |
	| FieldName | Given Name Text Box |
	Then Verify Required Fields Completed
	
	#MOB-3157
Scenario: Edit Form → Interact with Fields Editable After Customer Signs
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Search Form
	| Field    | Value                |
	| FormType | Customer Signed Form |
	Then Verify Fields Editable After Customer Signs

	#MOB-3184
Scenario: Edit Form → Clear Non-Auto Fields
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Form Added
	| Field    | Value     |
	| FormType | Mapped QA |
	When Start Form Editing
	When Clear Non Auto Fields
	Then Verify Non Auto Fields Cleared

	#MOB-3215
Scenario: Edit Form → Send Form → Customer Role
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Form Added
	| Field    | Value         |
	| FormType | Ios_Test Form |
	When Fill The Form
	| Field     | Value               |
	| FieldName | Given Name Text Box |
	Then Verify Required Fields Completed
	When Send The Form
	| Field | Value                 |
	| Role  | Customer              |
	| Email | mdelgoda@workwave.com |
	Then Verify Sending Successful
	| Field  | Value             |
	| Status | Out for Signature |

	#MOB-3216,MOB-3180
Scenario: Edit Form → Send Form → Internal Role,Interact with In Progress Form
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Form Added
	| Field    | Value         |
	| FormType | Ios_Test Form |
	When Fill The Form
	| Field     | Value               |
	| FieldName | Given Name Text Box |
	Then Verify Required Fields Completed
	When Send The Form
	| Field | Value                    |
	| Role  | Administrator            |
	| Name  | Maheshika Delgoda        |
	| Email | mdelgoda+qa@workwave.com |
	Then Verify Sending Successful
	| Field  | Value       |
	| Status | In Progress |
	Then Verify Form Interactable

	#MOB-3198
Scenario:  Interact with Signed Form
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Search Forms
	| Field    | Value  |
	| Status | Signed |
	Then Verify Form Editor Displaying

	#MOB-3214
Scenario:  Interact with Canceled Form
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Search Forms
	| Field    | Value  |
	| Status | Canceled |
	Then Verify Form Editor Not Displaying