@Sketch
Feature: Sketch

	#MOB-2992,MOB-3004
Scenario: Add Sketch → Objects,Delete Sketch
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
	Then Verify Sketch Added
	When Sketch Deleted
	Then Verify Sketch Deleted

	#MOB-3010,MOB-3009,MOB-3008
Scenario: Add Sketch → Text,Label,Arrow
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	#Given New Sketch Opened
	#| Field            | Value |
	#| SketchBackground | Grid  |
	#When Object Added To Sketch
	#| Field      | Value      |
	#| Tool       | Text       |
	#| SubTool    | Null       |
	#| SketchName | TextSketch |
	#When New Sketch Saved
	#| Field      | Value      |
	#| SketchName | TextSketch |
	#Then Verify Sketch Added
	#Given New Sketch Opened
	#| Field            | Value |
	#| SketchBackground | Grid  |
	#When Object Added To Sketch
	#| Field      | Value       |
	#| Tool       | Labels      |
	#| SubTool    | Null        |
	#| SketchName | LabelSketch |
	#When New Sketch Saved
	#| Field      | Value       |
	#| SketchName | LabelSketch |
	#Then Verify Sketch Added
	Given New Sketch Opened
	| Field            | Value |
	| SketchBackground | Grid  |
	When Object Added To Sketch
	| Field      | Value       |
	| Tool       | Draw        |
	| SubTool    | Arrow       |
	| SketchName | ArrowSketch |
	When New Sketch Saved
	| Field      | Value       |
	| SketchName | ArrowSketch |
	Then Verify Sketch Added
