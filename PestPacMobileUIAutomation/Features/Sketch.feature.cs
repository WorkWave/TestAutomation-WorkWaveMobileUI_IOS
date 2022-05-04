﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace WorkWave.Workwave.Mobile.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Sketch")]
    [NUnit.Framework.CategoryAttribute("Sketch")]
    public partial class SketchFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Sketch.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Sketch", null, ProgrammingLanguage.CSharp, new string[] {
                        "Sketch"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Sketch → Objects,Delete Sketch")]
        public virtual void AddSketchObjectsDeleteSketch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Sketch → Objects,Delete Sketch", null, ((string[])(null)));
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 6
 testRunner.Given("Not Started Order Opened", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "SketchBackground",
                        "Grid"});
#line 9
 testRunner.Given("New Sketch Opened", ((string)(null)), table2, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Tool",
                        "Objects"});
            table3.AddRow(new string[] {
                        "SubTool",
                        "AC Unit"});
            table3.AddRow(new string[] {
                        "SketchName",
                        "autoMapSketch"});
#line 12
 testRunner.When("Object Added To Sketch", ((string)(null)), table3, "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "SketchName",
                        "autoMapSketch"});
#line 17
 testRunner.When("New Sketch Saved", ((string)(null)), table4, "When ");
#line 20
 testRunner.Then("Verify Sketch Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.When("Sketch Deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("Verify Sketch Deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Sketch → Text,Label,Arrow,Reactangle,Straight,Freehand,Polygon")]
        public virtual void AddSketchTextLabelArrowReactangleStraightFreehandPolygon()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Sketch → Text,Label,Arrow,Reactangle,Straight,Freehand,Polygon", null, ((string[])(null)));
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 26
 testRunner.Given("Not Started Order Opened", ((string)(null)), table5, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "SketchBackground",
                        "Grid"});
#line 29
 testRunner.Given("New Sketch Opened", ((string)(null)), table6, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "Tool",
                        "Text"});
            table7.AddRow(new string[] {
                        "SubTool",
                        "Null"});
            table7.AddRow(new string[] {
                        "SketchName",
                        "TextSketch"});
#line 32
 testRunner.When("Object Added To Sketch", ((string)(null)), table7, "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "SketchName",
                        "TextSketch"});
#line 37
 testRunner.When("New Sketch Saved", ((string)(null)), table8, "When ");
#line 40
 testRunner.Then("Verify Sketch Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "SketchBackground",
                        "Grid"});
#line 41
 testRunner.Given("New Sketch Opened", ((string)(null)), table9, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "Tool",
                        "Labels"});
            table10.AddRow(new string[] {
                        "SubTool",
                        "Null"});
            table10.AddRow(new string[] {
                        "SketchName",
                        "LabelSketch"});
#line 44
 testRunner.When("Object Added To Sketch", ((string)(null)), table10, "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "SketchName",
                        "LabelSketch"});
#line 49
 testRunner.When("New Sketch Saved", ((string)(null)), table11, "When ");
#line 52
 testRunner.Then("Verify Sketch Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "SketchBackground",
                        "Grid"});
#line 53
 testRunner.Given("New Sketch Opened", ((string)(null)), table12, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "Tool",
                        "Draw"});
            table13.AddRow(new string[] {
                        "SubTool",
                        "Arrow"});
            table13.AddRow(new string[] {
                        "SketchName",
                        "ArrowSketch"});
#line 56
 testRunner.When("Object Added To Sketch", ((string)(null)), table13, "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "SketchName",
                        "ArrowSketch"});
#line 61
 testRunner.When("New Sketch Saved", ((string)(null)), table14, "When ");
#line 64
 testRunner.Then("Verify Sketch Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "SketchBackground",
                        "Grid"});
#line 65
 testRunner.Given("New Sketch Opened", ((string)(null)), table15, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "Tool",
                        "Draw"});
            table16.AddRow(new string[] {
                        "SubTool",
                        "Rectangle"});
            table16.AddRow(new string[] {
                        "SketchName",
                        "RectSketch"});
#line 68
 testRunner.When("Object Added To Sketch", ((string)(null)), table16, "When ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "SketchName",
                        "RectSketch"});
#line 73
 testRunner.When("New Sketch Saved", ((string)(null)), table17, "When ");
#line 76
 testRunner.Then("Verify Sketch Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "SketchBackground",
                        "Grid"});
#line 77
 testRunner.Given("New Sketch Opened", ((string)(null)), table18, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table19.AddRow(new string[] {
                        "Tool",
                        "Draw"});
            table19.AddRow(new string[] {
                        "SubTool",
                        "Straight"});
            table19.AddRow(new string[] {
                        "SketchName",
                        "StraightSketch"});
#line 80
 testRunner.When("Object Added To Sketch", ((string)(null)), table19, "When ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table20.AddRow(new string[] {
                        "SketchName",
                        "StraightSketch"});
#line 85
 testRunner.When("New Sketch Saved", ((string)(null)), table20, "When ");
#line 88
 testRunner.Then("Verify Sketch Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table21.AddRow(new string[] {
                        "SketchBackground",
                        "Grid"});
#line 89
 testRunner.Given("New Sketch Opened", ((string)(null)), table21, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table22.AddRow(new string[] {
                        "Tool",
                        "Draw"});
            table22.AddRow(new string[] {
                        "SubTool",
                        "Freehand"});
            table22.AddRow(new string[] {
                        "SketchName",
                        "FreehandSketch"});
#line 92
 testRunner.When("Object Added To Sketch", ((string)(null)), table22, "When ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table23.AddRow(new string[] {
                        "SketchName",
                        "FreehandSketch"});
#line 97
 testRunner.When("New Sketch Saved", ((string)(null)), table23, "When ");
#line 100
 testRunner.Then("Verify Sketch Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table24.AddRow(new string[] {
                        "SketchBackground",
                        "Grid"});
#line 101
 testRunner.Given("New Sketch Opened", ((string)(null)), table24, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table25.AddRow(new string[] {
                        "Tool",
                        "Draw"});
            table25.AddRow(new string[] {
                        "SubTool",
                        "Polygon"});
            table25.AddRow(new string[] {
                        "SketchName",
                        "PolygonSketch"});
#line 104
 testRunner.When("Object Added To Sketch", ((string)(null)), table25, "When ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table26.AddRow(new string[] {
                        "SketchName",
                        "PolygonSketch"});
#line 109
 testRunner.When("New Sketch Saved", ((string)(null)), table26, "When ");
#line 112
 testRunner.Then("Verify Sketch Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Sketch → Treatment → Associate Material with Treatment Color,Change Sprayer S" +
            "ize")]
        public virtual void AddSketchTreatmentAssociateMaterialWithTreatmentColorChangeSprayerSize()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Sketch → Treatment → Associate Material with Treatment Color,Change Sprayer S" +
                    "ize", null, ((string[])(null)));
#line 115
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table27.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 116
 testRunner.Given("Not Started Order Opened", ((string)(null)), table27, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table28.AddRow(new string[] {
                        "SketchBackground",
                        "Grid"});
#line 119
 testRunner.Given("New Sketch Opened", ((string)(null)), table28, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table29.AddRow(new string[] {
                        "Tool",
                        "Treatment"});
            table29.AddRow(new string[] {
                        "SubTool",
                        "No Material"});
            table29.AddRow(new string[] {
                        "SketchName",
                        "TreatmentSketch"});
            table29.AddRow(new string[] {
                        "TreatmentMaterial",
                        "Broom"});
#line 122
 testRunner.When("Object Added To Sketch", ((string)(null)), table29, "When ");
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table30.AddRow(new string[] {
                        "SketchName",
                        "TreatmentSketch"});
#line 128
 testRunner.When("New Sketch Saved", ((string)(null)), table30, "When ");
#line 131
 testRunner.Then("Verify Sketch Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table31.AddRow(new string[] {
                        "SketchBackground",
                        "Grid"});
#line 132
 testRunner.Given("New Sketch Opened", ((string)(null)), table31, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table32.AddRow(new string[] {
                        "Tool",
                        "Treatment"});
            table32.AddRow(new string[] {
                        "SubTool",
                        "Size"});
            table32.AddRow(new string[] {
                        "SketchName",
                        "TreatmentSketch"});
#line 135
 testRunner.When("Object Added To Sketch", ((string)(null)), table32, "When ");
#line hidden
            TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table33.AddRow(new string[] {
                        "SketchName",
                        "TreatmentSketch"});
#line 140
 testRunner.When("New Sketch Saved", ((string)(null)), table33, "When ");
#line 143
 testRunner.Then("Verify Sketch Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Sketch → Blank Background,Location Image Background")]
        public virtual void AddSketchBlankBackgroundLocationImageBackground()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Sketch → Blank Background,Location Image Background", null, ((string[])(null)));
#line 146
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table34.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 147
 testRunner.Given("Not Started Order Opened", ((string)(null)), table34, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table35.AddRow(new string[] {
                        "SketchBackground",
                        "Blank"});
#line 150
 testRunner.Given("New Sketch Opened", ((string)(null)), table35, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table36.AddRow(new string[] {
                        "Tool",
                        "Text"});
            table36.AddRow(new string[] {
                        "SubTool",
                        "Null"});
            table36.AddRow(new string[] {
                        "SketchName",
                        "TextSketch"});
#line 153
 testRunner.When("Object Added To Sketch", ((string)(null)), table36, "When ");
#line hidden
            TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table37.AddRow(new string[] {
                        "SketchName",
                        "TextSketch"});
#line 158
 testRunner.When("New Sketch Saved", ((string)(null)), table37, "When ");
#line 161
 testRunner.Then("Verify Sketch Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Sketch →Location Image Background")]
        public virtual void AddSketchLocationImageBackground()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Sketch →Location Image Background", null, ((string[])(null)));
#line 164
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table38.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 165
 testRunner.Given("Not Started Order Opened", ((string)(null)), table38, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table39.AddRow(new string[] {
                        "Type",
                        "Take a Photo"});
#line 168
 testRunner.When("Capture Location Image", ((string)(null)), table39, "When ");
#line hidden
            TechTalk.SpecFlow.Table table40 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table40.AddRow(new string[] {
                        "SketchBackground",
                        "Location Images"});
#line 171
 testRunner.Given("New Sketch Opened", ((string)(null)), table40, "Given ");
#line 174
 testRunner.When("Location Image Added To Sketch", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table41 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table41.AddRow(new string[] {
                        "Tool",
                        "Text"});
            table41.AddRow(new string[] {
                        "SubTool",
                        "Null"});
            table41.AddRow(new string[] {
                        "SketchName",
                        "TextSketch"});
#line 175
 testRunner.When("Object Added To Sketch", ((string)(null)), table41, "When ");
#line hidden
            TechTalk.SpecFlow.Table table42 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table42.AddRow(new string[] {
                        "SketchName",
                        "TextSketch"});
#line 180
 testRunner.When("New Sketch Saved", ((string)(null)), table42, "When ");
#line 183
 testRunner.Then("Verify Sketch Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

