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

	#MOB-3010,MOB-3009,MOB-3008,MOB-3007,MOB-3006,MOB-3013,MOB-2993
Scenario: Add Sketch → Text,Label,Arrow,Reactangle,Straight,Freehand,Polygon
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	Given New Sketch Opened
	| Field            | Value |
	| SketchBackground | Grid  |
	When Object Added To Sketch
	| Field      | Value      |
	| Tool       | Text       |
	| SubTool    | Null       |
	| SketchName | TextSketch |
	When New Sketch Saved
	| Field      | Value      |
	| SketchName | TextSketch |
	Then Verify Sketch Added
	Given New Sketch Opened
	| Field            | Value |
	| SketchBackground | Grid  |
	When Object Added To Sketch
	| Field      | Value       |
	| Tool       | Labels      |
	| SubTool    | Null        |
	| SketchName | LabelSketch |
	When New Sketch Saved
	| Field      | Value       |
	| SketchName | LabelSketch |
	Then Verify Sketch Added
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
	Given New Sketch Opened
	| Field            | Value |
	| SketchBackground | Grid  |
	When Object Added To Sketch
	| Field      | Value      |
	| Tool       | Draw       |
	| SubTool    | Rectangle  |
	| SketchName | RectSketch |
	When New Sketch Saved
	| Field      | Value      |
	| SketchName | RectSketch |
	Then Verify Sketch Added
	Given New Sketch Opened
	| Field            | Value |
	| SketchBackground | Grid  |
	When Object Added To Sketch
	| Field      | Value          |
	| Tool       | Draw           |
	| SubTool    | Straight       |
	| SketchName | StraightSketch |
	When New Sketch Saved
	| Field      | Value          |
	| SketchName | StraightSketch |
	Then Verify Sketch Added
	Given New Sketch Opened
	| Field            | Value |
	| SketchBackground | Grid  |
	When Object Added To Sketch
	| Field      | Value          |
	| Tool       | Draw           |
	| SubTool    | Freehand       |
	| SketchName | FreehandSketch |
	When New Sketch Saved
	| Field      | Value          |
	| SketchName | FreehandSketch |
	Then Verify Sketch Added
	Given New Sketch Opened
	| Field            | Value |
	| SketchBackground | Grid  |
	When Object Added To Sketch
	| Field      | Value         |
	| Tool       | Draw          |
	| SubTool    | Polygon       |
	| SketchName | PolygonSketch |
	When New Sketch Saved
	| Field      | Value         |
	| SketchName | PolygonSketch |
	Then Verify Sketch Added

	#MOB-3012,MOB-3005
Scenario:Add Sketch → Treatment → Associate Material with Treatment Color,Change Sprayer Size
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	Given New Sketch Opened
	| Field            | Value |
	| SketchBackground | Grid  |
	When Object Added To Sketch
	| Field             | Value           |
	| Tool              | Treatment       |
	| SubTool           | No Material     |
	| SketchName        | TreatmentSketch |
	| TreatmentMaterial | Broom           |
	When New Sketch Saved
	| Field      | Value           |
	| SketchName | TreatmentSketch |
	Then Verify Sketch Added
	Given New Sketch Opened
	| Field            | Value |
	| SketchBackground | Grid  |
	When Object Added To Sketch
	| Field             | Value           |
	| Tool              | Treatment       |
	| SubTool           | Size            |
	| SketchName        | TreatmentSketch |
	When New Sketch Saved
	| Field      | Value           |
	| SketchName | TreatmentSketch |
	Then Verify Sketch Added

	#MOB-3002
Scenario: Add Sketch → Blank Background
	Given Not Started Order Opened
	| Field         | Value |
	| DetailsNeeded | false |
	Given New Sketch Opened
	| Field            | Value |
	| SketchBackground | Blank |
	When Object Added To Sketch
	| Field      | Value      |
	| Tool       | Text       |
	| SubTool    | Null       |
	| SketchName | TextSketch |
	When New Sketch Saved
	| Field      | Value      |
	| SketchName | TextSketch |
	Then Verify Sketch Added