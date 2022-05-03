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
        [NUnit.Framework.DescriptionAttribute("Add Sketch → Text,Label,Arrow,Reactangle,Straight,Freehand")]
        public virtual void AddSketchTextLabelArrowReactangleStraightFreehand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Sketch → Text,Label,Arrow,Reactangle,Straight,Freehand", null, ((string[])(null)));
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
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Sketch → Treatment → Associate Material with Treatment Color")]
        public virtual void AddSketchTreatmentAssociateMaterialWithTreatmentColor()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Sketch → Treatment → Associate Material with Treatment Color", null, ((string[])(null)));
#line 103
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table24.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 104
 testRunner.Given("Not Started Order Opened", ((string)(null)), table24, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table25.AddRow(new string[] {
                        "SketchBackground",
                        "Grid"});
#line 107
 testRunner.Given("New Sketch Opened", ((string)(null)), table25, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table26.AddRow(new string[] {
                        "Tool",
                        "Treatment"});
            table26.AddRow(new string[] {
                        "SubTool",
                        "No Material"});
            table26.AddRow(new string[] {
                        "SketchName",
                        "TreatmentSketch"});
            table26.AddRow(new string[] {
                        "TreatmentMaterial",
                        "Broom"});
#line 110
 testRunner.When("Object Added To Sketch", ((string)(null)), table26, "When ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table27.AddRow(new string[] {
                        "SketchName",
                        "TreatmentSketch"});
#line 116
 testRunner.When("New Sketch Saved", ((string)(null)), table27, "When ");
#line 119
 testRunner.Then("Verify Sketch Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

