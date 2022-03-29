@Attachments
Feature: Attachments

#MOB-3248 , MOB-3250 , MOB-3251
Scenario: Take a Photo → Not Included in Service Report,Take a Video → Not Included in Service Report,Pick from Gallery → Photo
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When Attachment Added
	| Field | Value        |
	| Type  | Take a Photo |
	Then Verify Attachment Exists
	When Attachment Added
	| Field | Value        |
	| Type  | Take a Video |
	Then Verify Attachment Exists
	When Attachment Added
	| Field | Value             |
	| Type  | Pick from Gallery |
	Then Verify Attachment Exists

	