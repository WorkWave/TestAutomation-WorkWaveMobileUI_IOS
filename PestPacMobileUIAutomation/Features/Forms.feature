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
	| FormType | WorkWave Test Automation Form Example |
	When Fill Form Fields
	| Field     | Value               |
	| FieldName | Text Field: Client Name|
	When Insert Image To Form
	| Field        | Value             |
	| FormType     | WorkWave Test Automation Form Example          |
	| DocumentType | Pick from Gallery |
	Then Verify Image Added
	When Insert Image To Form
	| Field        | Value        |
	| FormType     | WorkWave Test Automation Form Example     |
	| DocumentType | Take a Photo |
	Then Verify Image Added
	When All Form Fields Cleared
	Then Verify All Form Fields Cleared
	When Insert Image To Form
	| Field        | Value           |
	| FormType     | WorkWave Test Automation Form Example        |
	| DocumentType | Location Images |
	Then Verify Image Added
	Then ReturnsToHome
	
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
	Then ReturnsToHome
	
	#MOB-3157
Scenario: Edit Form → Interact with Fields Editable After Customer Signs
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Search Forms
	| Field  | Value  |
	| Status | Signed |
	Then Verify Fields Editable After Customer Signs
	| Field     | Value             |
	| FieldName | Country Combo Box |

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
	Then ReturnsToHome

	#MOB-3215,MOB-3201
Scenario: Edit Form → Send Form → Customer Role,Interact with Out for Signature Form
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
	| Email | mdelgoda+1@workwave.com |
	Then Verify Sending Successful
	| Field  | Value             |
	| Status | Out for Signature |
	Then Verify Form Interactable

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

	#MOB-3211,MOB-3182,MOB-3176,MOB-3174
Scenario: Edit Form → Populate Date field,Populate Dropdown from Options Defined in Adobe,Populate Text field, Populate Multi-line Text field
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Form Added
	| Field    | Value              |
	| FormType | Sample Global Form |
	When Start Form Editing
	When Filter Date Field
	| Field     | Value            |
	| FieldName | Text Field: Date |
	Then Verify Date Added
	When Enter Text To Multi-line Text Field
	| Field     | Value             |
	| FieldName | Text Field: Notes |
	| Value     | Test Multi Line   |
	Then Verify Value Selected
	When Select Value of DropDown
	| Field     | Value                   |
	| FieldName | Choice Field: YardSize  |
	| Value      | Small                   |
	Then Verify Value Selected
	When Enter Text To Text Field
	| Field     | Value            |
	| FieldName | Text Field: Name |
	| Value     | Test             |
	Then Verify Value Selected
	Then ReturnsToHome
	
	#MOB-3192
Scenario:  Interact with Declined Form
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Search Forms
	| Field  | Value    |
	| Status | Declined |
	Then Verify Form Editor Displaying


	#MOB-3186,MOB-3170,MOB-3183
Scenario: Edit Form → Populate Multi-line Text field from Mapped Lookup Values,Populate Text field from Mapped Lookup Values,Populate Dropdown from Mapped Lookup Values
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Form Added
	| Field    | Value                                 |
	| FormType | WorkWave Test Automation Form Example |
	When Start Form Editing
	When Enter Text To Multi-line Text Field From Mapped Lookup Values
	| Field     | Value             |
	| FieldName | Text Field: Notes |
	| Value     | Towel             |
	Then Verify Value Added
	When Enter Text To Text Field From Mapped Lookup Values
	| Field     | Value                   |
	| FieldName | Text Field: Client Name |
	| Value     | Cleaning Auto           |
	Then Verify Value Added
	When Select Value of DropDown From Mapped Lookup Values
	| Field     | Value                    |
	| FieldName | Choice Field: Technician |
	| Value     | Maheshika Delgoda        |
	Then Verify Value Selected
	Then ReturnsToHome

	#MOB-3193
Scenario: Edit Form → Manipulate Radio Buttons
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Form Added
	| Field    | Value                                 |
	| FormType | WorkWave Test Automation Form Example |
	When Start Form Editing
	When Manipulate Radio Button
	| Field     | Value |
	| FieldName | Yes   |
	Then Verify Radio Button Clicked
	Then ReturnsToHome

	#MOB-3200
Scenario: Edit Form → Insert Image → Sketches
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	Given New Sketch Opened
	| Field            | Value |
	| SketchBackground | Grid  |
	When Object Added To Sketch
	| Field      | Value         |
	| Tool       | Objects       |
	| SubTool    | AC Unit       |
	| SketchName | autoMapSketch |
	When New Sketch Saved
	| Field      | Value         |
	| SketchName | autoMapSketch |
	When Form Added
	| Field    | Value                                 |
	| FormType | WorkWave Test Automation Form Example |
	When Start Form Editing
	When Resize The Screen
	When Insert Sketch To Form
	| Field        | Value                                 |
	| FormType     | WorkWave Test Automation Form Example |
	| DocumentType | Sketches                              |
	| SketchName   | autoMapSketch                         |
	Then Verify Image Added
	Then ReturnsToHome

	#MOB-3199,MOB-3191
Scenario: Edit Form → Capture Signature,Manipulate Checkbox
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Form Added
	| Field    | Value                                 |
	| FormType | WorkWave Test Automation Form Example |
	When Start Form Editing
	When Resize The Screen
	When Capture The Signature
	Then Verify Signature Captured
	When Manipulate CheckBox
	| Field     | Value     |
	| FieldName | Recurring |
	Then Verify CheckBox Selected
	Then ReturnsToHome
