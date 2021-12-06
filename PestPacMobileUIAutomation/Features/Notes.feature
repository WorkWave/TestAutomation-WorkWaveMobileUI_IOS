@Notes
Feature: Notes

Scenario: Add Public Note
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When New Note Opened
	When Note Modified
	| Field      | Value       |
	| NoteStatus | Public      |
	| NoteText   | newAutoNote |
	Then Verify Note Exists