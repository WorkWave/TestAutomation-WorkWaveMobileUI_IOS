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
        [NUnit.Framework.DescriptionAttribute("Update Service Location Custom Text,Date,Check Box,Quantity,Drop-Down,Multi Line " +
            "Field")]
        public virtual void UpdateServiceLocationCustomTextDateCheckBoxQuantityDrop_DownMultiLineField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update Service Location Custom Text,Date,Check Box,Quantity,Drop-Down,Multi Line " +
                    "Field", null, ((string[])(null)));
#line 16
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 17
 testRunner.Given("Viewing Service Location Custom Fields", ((string)(null)), table2, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "CustomFieldName",
                        "Text"});
#line 20
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
#line 23
 testRunner.When("Custom Field Edited", ((string)(null)), table4, "When ");
#line 27
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "CustomFieldName",
                        "Check Box"});
#line 28
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
#line 31
 testRunner.When("Custom Field Edited", ((string)(null)), table6, "When ");
#line 36
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "CustomFieldName",
                        "Drop-down"});
#line 37
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
#line 40
 testRunner.When("Custom Field Edited", ((string)(null)), table8, "When ");
#line 44
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "CustomFieldName",
                        "Quantity"});
#line 45
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
#line 48
 testRunner.When("Custom Field Edited", ((string)(null)), table10, "When ");
#line 52
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "CustomFieldName",
                        "Multi Line"});
            table11.AddRow(new string[] {
                        "CustomFieldType",
                        "Multi Line"});
#line 53
 testRunner.When("Custom Field Selected", ((string)(null)), table11, "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "CustomFieldName",
                        "Multi Line"});
            table12.AddRow(new string[] {
                        "CustomFieldType",
                        "Multi Line"});
#line 57
 testRunner.When("Custom Field Edited", ((string)(null)), table12, "When ");
#line 61
 testRunner.Then("Verify Edited Custom Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "CustomFieldName",
                        "Date"});
#line 62
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
#line 65
 testRunner.When("Custom Field Edited", ((string)(null)), table14, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update Work Order Custom Text,Date,Check Box,Quantity,Drop-Down Field")]
        public virtual void UpdateWorkOrderCustomTextDateCheckBoxQuantityDrop_DownField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update Work Order Custom Text,Date,Check Box,Quantity,Drop-Down Field", null, ((string[])(null)));
#line 72
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 73
 testRunner.Given("Viewing Work Order Custom Fields", ((string)(null)), table15, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "CustomFieldName",
                        "Text"});
#line 76
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
#line 79
 testRunner.When("Custom Field Edited", ((string)(null)), table17, "When ");
#line 83
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "CustomFieldName",
                        "Check Box"});
#line 84
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
#line 87
 testRunner.When("Custom Field Edited", ((string)(null)), table19, "When ");
#line 92
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table20.AddRow(new string[] {
                        "CustomFieldName",
                        "Drop-down"});
#line 93
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
#line 96
 testRunner.When("Custom Field Edited", ((string)(null)), table21, "When ");
#line 100
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table22.AddRow(new string[] {
                        "CustomFieldName",
                        "Quantity"});
#line 101
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
#line 104
 testRunner.When("Custom Field Edited", ((string)(null)), table23, "When ");
#line 108
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table24.AddRow(new string[] {
                        "CustomFieldName",
                        "Date"});
#line 109
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
#line 112
 testRunner.When("Custom Field Edited", ((string)(null)), table25, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update Service Location Property Trait")]
        public virtual void UpdateServiceLocationPropertyTrait()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update Service Location Property Trait", null, ((string[])(null)));
#line 119
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table26.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 120
 testRunner.Given("Viewing Service Location Custom Fields", ((string)(null)), table26, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table27.AddRow(new string[] {
                        "CustomFieldName",
                        "Number of Bedrooms"});
#line 123
 testRunner.When("Custom Field Selected", ((string)(null)), table27, "When ");
#line 126
 testRunner.When("Traits Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 127
 testRunner.Then("Verify Custom Field Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("View Service Location Contacts")]
        public virtual void ViewServiceLocationContacts()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("View Service Location Contacts", null, ((string[])(null)));
#line 130
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table28.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 131
 testRunner.Given("Viewing Service Location Custom Fields", ((string)(null)), table28, "Given ");
#line 134
 testRunner.When("View Service Location Contacts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
 testRunner.When("Access the phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 136
 testRunner.Then("Verify the Contact by Phone Opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 137
 testRunner.When("Access the Email", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 138
 testRunner.Then("Verify the Contact by Email Opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("View Service Location Memo")]
        public virtual void ViewServiceLocationMemo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("View Service Location Memo", null, ((string[])(null)));
#line 141
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table29.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 142
 testRunner.Given("Viewing Service Location Custom Fields", ((string)(null)), table29, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table30.AddRow(new string[] {
                        "CustomFieldValue",
                        "Sample service Memo"});
#line 145
 testRunner.When("View Location Memo", ((string)(null)), table30, "When ");
#line 148
 testRunner.Then("Verify Location Memo Not Editable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

