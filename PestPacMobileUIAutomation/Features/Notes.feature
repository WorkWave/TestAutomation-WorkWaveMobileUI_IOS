@Notes
Feature: Notes

Scenario: Add Public Note,Note Edited
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When New Note Opened
	When Note Added
	| Field      | Value       |
	| NoteStatus | Public      |
	| NoteText   | newAutoNote |
	Then Verify Note Exists
	When Existing Note Selected
	When Note Modified
	| Field      | Value    |
	| NoteStatus | Private  |
	| NoteText   | editNote |
	Then Verify Note Exists