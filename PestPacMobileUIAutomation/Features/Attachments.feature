@Attachments
Feature: Attachments

Scenario: Add Photo,Video and pick from gallery Attachment
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

	Scenario: Edit Attachment
	Given Viewing Existing Attachments
	| Field    | Value                 |
	| DetailsNeeded | false |
	| Type    | Take Photo |
	When Attachment Edited
	Then Verify Attachment Exists