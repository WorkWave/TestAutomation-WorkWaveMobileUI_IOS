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
    [NUnit.Framework.DescriptionAttribute("Services")]
    [NUnit.Framework.CategoryAttribute("Services")]
    public partial class ServicesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Services.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Services", null, ProgrammingLanguage.CSharp, new string[] {
                        "Services"});
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
        [NUnit.Framework.DescriptionAttribute("Add Product On Service,Update Product On Service,Delete Product On Service")]
        public virtual void AddProductOnServiceUpdateProductOnServiceDeleteProductOnService()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Product On Service,Update Product On Service,Delete Product On Service", null, ((string[])(null)));
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
 testRunner.When("Navigate To Services View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Auto"});
#line 9
 testRunner.Given("Product Tab Opened", ((string)(null)), table2, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "ServiceProduct",
                        "Cleaning Powder"});
            table3.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Auto"});
#line 12
 testRunner.When("Product Added", ((string)(null)), table3, "When ");
#line 16
 testRunner.Then("Verify Product Exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.Then("Verify Service Total", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Auto"});
#line 18
 testRunner.Given("Product Tab Opened", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "ServiceProduct",
                        "Cleaning Powder"});
            table5.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Auto"});
#line 21
 testRunner.When("Product Edited", ((string)(null)), table5, "When ");
#line 25
 testRunner.Then("Verify Product Exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.Then("Verify Service Total", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Auto"});
#line 27
 testRunner.Given("Product Tab Opened", ((string)(null)), table6, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "ServiceProduct",
                        "Cleaning Powder"});
            table7.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Auto"});
#line 30
 testRunner.When("Product Deleted", ((string)(null)), table7, "When ");
#line 34
 testRunner.Then("Verify Product Deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.Then("Verify Service Total", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Material On Service,Edit Material On Service,Delete Material On Service")]
        public virtual void AddMaterialOnServiceEditMaterialOnServiceDeleteMaterialOnService()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Material On Service,Edit Material On Service,Delete Material On Service", null, ((string[])(null)));
#line 37
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "DetailsNeeded",
                        "true"});
#line 38
 testRunner.Given("Not Started Order Opened", ((string)(null)), table8, "Given ");
#line 41
 testRunner.When("Navigate To Services View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Auto"});
            table9.AddRow(new string[] {
                        "RandomizePrice",
                        "false"});
#line 42
 testRunner.Given("Material Tab Opened", ((string)(null)), table9, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "ServiceMaterial",
                        "Broom"});
#line 46
 testRunner.When("Material Added", ((string)(null)), table10, "When ");
#line 49
 testRunner.Then("Verify Material Exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "ServiceMaterial",
                        "Broom"});
#line 50
 testRunner.When("Material Edited", ((string)(null)), table11, "When ");
#line 53
 testRunner.Then("Verify Material Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "ServiceMaterial",
                        "Broom"});
#line 54
 testRunner.When("Material Deleted", ((string)(null)), table12, "When ");
#line 57
 testRunner.Then("Verify Material Does Not Exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Value Discount On Service,Update Service offering Value Discount On Service,D" +
            "elete Service Offering Value Discount")]
        public virtual void AddValueDiscountOnServiceUpdateServiceOfferingValueDiscountOnServiceDeleteServiceOfferingValueDiscount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Value Discount On Service,Update Service offering Value Discount On Service,D" +
                    "elete Service Offering Value Discount", null, ((string[])(null)));
#line 59
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "DetailsNeeded",
                        "true"});
#line 60
 testRunner.Given("Not Started Order Opened", ((string)(null)), table13, "Given ");
#line 63
 testRunner.When("Navigate To Services View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Auto"});
#line 64
 testRunner.Given("Discount Tab Opened", ((string)(null)), table14, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "ServiceDiscountType",
                        "Value"});
#line 67
 testRunner.When("Discount Added", ((string)(null)), table15, "When ");
#line 70
 testRunner.Then("Verify Discount Exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 71
 testRunner.Then("Verify Discount Applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Auto"});
#line 72
 testRunner.Given("Discount Tab Opened", ((string)(null)), table16, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "ServiceDiscountType",
                        "Value"});
#line 75
 testRunner.When("Discount Edited", ((string)(null)), table17, "When ");
#line 78
 testRunner.Then("Verify Discount Exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 79
 testRunner.Then("Verify Discount Applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Auto"});
#line 80
 testRunner.Given("Discount Tab Opened", ((string)(null)), table18, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table19.AddRow(new string[] {
                        "ServiceDiscountType",
                        "Value"});
#line 83
 testRunner.When("Discount Deleted", ((string)(null)), table19, "When ");
#line 86
 testRunner.Then("Verify Discount Does Not Exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 87
 testRunner.Then("Verify Discount Removed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Percentage Discount On Service,Update Service offering Percentage Discount On" +
            " Service")]
        public virtual void AddPercentageDiscountOnServiceUpdateServiceOfferingPercentageDiscountOnService()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Percentage Discount On Service,Update Service offering Percentage Discount On" +
                    " Service", null, ((string[])(null)));
#line 90
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table20.AddRow(new string[] {
                        "DetailsNeeded",
                        "true"});
#line 91
 testRunner.Given("Not Started Order Opened", ((string)(null)), table20, "Given ");
#line 94
 testRunner.When("Navigate To Services View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table21.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Auto"});
#line 95
 testRunner.Given("Discount Tab Opened", ((string)(null)), table21, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table22.AddRow(new string[] {
                        "ServiceDiscountType",
                        "Percent"});
#line 98
 testRunner.When("Discount Added", ((string)(null)), table22, "When ");
#line 101
 testRunner.Then("Verify Discount Exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.Then("Verify Discount Applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table23.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Auto"});
#line 103
 testRunner.Given("Discount Tab Opened", ((string)(null)), table23, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table24.AddRow(new string[] {
                        "ServiceDiscountType",
                        "Percent"});
#line 106
 testRunner.When("Discount Edited", ((string)(null)), table24, "When ");
#line 109
 testRunner.Then("Verify Discount Exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
 testRunner.Then("Verify Discount Applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Fixed Price Service Offering,Update Fixed Price Service Offering")]
        public virtual void AddFixedPriceServiceOfferingUpdateFixedPriceServiceOffering()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Fixed Price Service Offering,Update Fixed Price Service Offering", null, ((string[])(null)));
#line 112
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table25.AddRow(new string[] {
                        "DetailsNeeded",
                        "true"});
#line 113
 testRunner.Given("Not Started Order Opened", ((string)(null)), table25, "Given ");
#line 116
 testRunner.When("Navigate To Services View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table26.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Window"});
#line 117
 testRunner.When("Service Added", ((string)(null)), table26, "When ");
#line 120
 testRunner.Then("Verify Service Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table27.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Window"});
#line 121
 testRunner.When("Service Edited", ((string)(null)), table27, "When ");
#line 124
 testRunner.Then("Verify Service Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

