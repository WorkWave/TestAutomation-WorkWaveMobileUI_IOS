@Sketch
Feature: Sketch

Scenario: Add Sketch
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	Given New Sketch Opened
	| Field            | Value |
	| SketchBackground | Grid  |
	When Object Added To Sketch
	| Field   | Value   |
	| Tool    | Objects |
	| SubTool | AC Unit |
	| SketchName | autoMapSketch |
	When New Sketch Saved
	Then Verify Sketch Added