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
    [NUnit.Framework.DescriptionAttribute("Order")]
    [NUnit.Framework.CategoryAttribute("Order")]
    public partial class OrderFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Order.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Order", null, ProgrammingLanguage.CSharp, new string[] {
                        "Order"});
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
        [NUnit.Framework.DescriptionAttribute("Complete Work Order")]
        public virtual void CompleteWorkOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Complete Work Order", null, ((string[])(null)));
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "DetailsNeeded",
                        "true"});
#line 5
 testRunner.Given("Not Started Order Opened", ((string)(null)), table1, "Given ");
#line 8
 testRunner.When("Order Started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then("Verify Order Started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
 testRunner.Then("Verify Appointment Card Status", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.When("Order Completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("Verify Order Completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.Then("Verify Appointment Card Status", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update Service Location Custom Text,Date,Check Box,Quantity,Drop-Down,Trait Field" +
            "")]
        public virtual void UpdateServiceLocationCustomTextDateCheckBoxQuantityDrop_DownTraitField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update Service Location Custom Text,Date,Check Box,Quantity,Drop-Down,Trait Field" +
                    "", null, ((string[])(null)));
#line 15
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 16
 testRunner.Given("Viewing Service Location Custom Fields", ((string)(null)), table2, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "CustomFieldName",
                        "Text"});
#line 19
 testRunner.When("Custom Field Selected", ((string)(null)), table3, "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "CustomFieldName",
                        "Text"});
            table4.AddRow(new string[] {
                        "CustomFieldType",
                        "Text"});
#line 22
 testRunner.When("Custom Field Edited", ((string)(null)), table4, "When ");
#line 26
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "CustomFieldName",
                        "Check Box"});
#line 27
 testRunner.When("Custom Field Selected", ((string)(null)), table5, "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "CustomFieldType",
                        "Check Box"});
            table6.AddRow(new string[] {
                        "CustomFieldName",
                        "Check Box"});
            table6.AddRow(new string[] {
                        "WorkOrderCustomFields",
                        "No"});
#line 30
 testRunner.When("Custom Field Edited", ((string)(null)), table6, "When ");
#line 35
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "CustomFieldName",
                        "Drop-down"});
#line 36
 testRunner.When("Custom Field Selected", ((string)(null)), table7, "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "CustomFieldName",
                        "Drop-down"});
            table8.AddRow(new string[] {
                        "CustomFieldType",
                        "Drop-down"});
#line 39
 testRunner.When("Custom Field Edited", ((string)(null)), table8, "When ");
#line 43
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "CustomFieldName",
                        "Quantity"});
#line 44
 testRunner.When("Custom Field Selected", ((string)(null)), table9, "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "CustomFieldName",
                        "Quantity"});
            table10.AddRow(new string[] {
                        "CustomFieldType",
                        "Quantity"});
#line 47
 testRunner.When("Custom Field Edited", ((string)(null)), table10, "When ");
#line 51
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "CustomFieldName",
                        "Trait1"});
            table11.AddRow(new string[] {
                        "CustomFieldType",
                        "Trait"});
#line 52
 testRunner.When("Custom Field Selected", ((string)(null)), table11, "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "CustomFieldName",
                        "Trait1"});
            table12.AddRow(new string[] {
                        "CustomFieldType",
                        "Trait"});
#line 56
 testRunner.When("Custom Field Edited", ((string)(null)), table12, "When ");
#line 60
 testRunner.Then("Verify Edited Custom Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "CustomFieldName",
                        "Date"});
#line 61
 testRunner.When("Custom Field Selected", ((string)(null)), table13, "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "CustomFieldName",
                        "Date"});
            table14.AddRow(new string[] {
                        "CustomFieldType",
                        "Date"});
#line 64
 testRunner.When("Custom Field Edited", ((string)(null)), table14, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update Work Order Custom Text,Date,Check Box,Quantity,Drop-Down Field")]
        public virtual void UpdateWorkOrderCustomTextDateCheckBoxQuantityDrop_DownField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update Work Order Custom Text,Date,Check Box,Quantity,Drop-Down Field", null, ((string[])(null)));
#line 70
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 71
 testRunner.Given("Viewing Work Order Custom Fields", ((string)(null)), table15, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "CustomFieldName",
                        "Text"});
#line 74
 testRunner.When("Custom Field Selected", ((string)(null)), table16, "When ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "CustomFieldName",
                        "Text"});
            table17.AddRow(new string[] {
                        "CustomFieldType",
                        "Text"});
#line 77
 testRunner.When("Custom Field Edited", ((string)(null)), table17, "When ");
#line 81
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "CustomFieldName",
                        "Check Box"});
#line 82
 testRunner.When("Custom Field Selected", ((string)(null)), table18, "When ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table19.AddRow(new string[] {
                        "CustomFieldType",
                        "Check Box"});
            table19.AddRow(new string[] {
                        "CustomFieldName",
                        "Check Box"});
            table19.AddRow(new string[] {
                        "WorkOrderCustomFields",
                        "No"});
#line 85
 testRunner.When("Custom Field Edited", ((string)(null)), table19, "When ");
#line 90
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table20.AddRow(new string[] {
                        "CustomFieldName",
                        "Drop-down"});
#line 91
 testRunner.When("Custom Field Selected", ((string)(null)), table20, "When ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table21.AddRow(new string[] {
                        "CustomFieldName",
                        "Drop-down"});
            table21.AddRow(new string[] {
                        "CustomFieldType",
                        "Drop-down"});
#line 94
 testRunner.When("Custom Field Edited", ((string)(null)), table21, "When ");
#line 98
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table22.AddRow(new string[] {
                        "CustomFieldName",
                        "Quantity"});
#line 99
 testRunner.When("Custom Field Selected", ((string)(null)), table22, "When ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table23.AddRow(new string[] {
                        "CustomFieldName",
                        "Quantity"});
            table23.AddRow(new string[] {
                        "CustomFieldType",
                        "Quantity"});
#line 102
 testRunner.When("Custom Field Edited", ((string)(null)), table23, "When ");
#line 106
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table24.AddRow(new string[] {
                        "CustomFieldName",
                        "Date"});
#line 107
 testRunner.When("Custom Field Selected", ((string)(null)), table24, "When ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table25.AddRow(new string[] {
                        "CustomFieldName",
                        "Date"});
            table25.AddRow(new string[] {
                        "CustomFieldType",
                        "Date"});
#line 110
 testRunner.When("Custom Field Edited", ((string)(null)), table25, "When ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

