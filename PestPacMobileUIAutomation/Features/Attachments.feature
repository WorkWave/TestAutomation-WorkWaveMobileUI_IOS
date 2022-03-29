@Attachments
Feature: Attachments

Scenario: Take a Photo → Not Included in Service Report,Video,Pick from Gallery → Photo
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

	