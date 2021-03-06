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

	#MOB-3284 , MOB-3285
Scenario: Tag Users On Note,Remove Tagged Users from a Note
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When New Note Opened
	When Users Tagged On Note
	| Field       | Value     |
	| TaggedUsers | John |
	Then Verify Users Tagged On Note
	When Note Added
	| Field      | Value       |
	| NoteStatus | Public      |
	| NoteText   | newAutoNote |
	Then Verify Note Exists
	When Existing Note Selected
	When Users Tagged On Note
	| Field       | Value |
	| TaggedUsers | John  |
	Then Verify Tagged User Removed On Note

	#MOB-3288
Scenario: Add Private Note
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When New Note Opened
	When Note Added
	| Field      | Value              |
	| NoteStatus | Private            |
	| NoteText   | newAutoNotePrivate |
	Then Verify Note Exists

	#MOB-3286
Scenario: Add Canned Note
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	When New Note Opened
	When Canned Note Added
	| Field      | Value                                 |
	| NoteStatus | Private                               |
	| NoteHeader | IOS Automation Note - Test automation |
	| NoteText   | Test automation                       |
	Then Verify Note Exists   