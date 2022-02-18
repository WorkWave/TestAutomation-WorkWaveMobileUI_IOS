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
            " Service,Delete Service Offering Percentage Discount")]
        public virtual void AddPercentageDiscountOnServiceUpdateServiceOfferingPercentageDiscountOnServiceDeleteServiceOfferingPercentageDiscount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Percentage Discount On Service,Update Service offering Percentage Discount On" +
                    " Service,Delete Service Offering Percentage Discount", null, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table25.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Auto"});
#line 111
 testRunner.Given("Discount Tab Opened", ((string)(null)), table25, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table26.AddRow(new string[] {
                        "ServiceDiscountType",
                        "Percent"});
#line 114
 testRunner.When("Discount Deleted", ((string)(null)), table26, "When ");
#line 117
 testRunner.Then("Verify Discount Does Not Exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 118
 testRunner.Then("Verify Discount Removed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Fixed Price Service Offering,Update Fixed Price Service Offering,Delete Fixed" +
            " Price Service Offering,Toggle Do Not Charge for Service to OFF,Toggle Do Not Ch" +
            "arge for Service to ON")]
        public virtual void AddFixedPriceServiceOfferingUpdateFixedPriceServiceOfferingDeleteFixedPriceServiceOfferingToggleDoNotChargeForServiceToOFFToggleDoNotChargeForServiceToON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Fixed Price Service Offering,Update Fixed Price Service Offering,Delete Fixed" +
                    " Price Service Offering,Toggle Do Not Charge for Service to OFF,Toggle Do Not Ch" +
                    "arge for Service to ON", null, ((string[])(null)));
#line 121
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table27.AddRow(new string[] {
                        "DetailsNeeded",
                        "true"});
#line 122
 testRunner.Given("Not Started Order Opened", ((string)(null)), table27, "Given ");
#line 125
 testRunner.When("Navigate To Services View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table28.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Window"});
#line 126
 testRunner.When("Service Added", ((string)(null)), table28, "When ");
#line 129
 testRunner.Then("Verify Service Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table29.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Window"});
#line 130
 testRunner.When("Service Edited", ((string)(null)), table29, "When ");
#line 133
 testRunner.Then("Verify Service Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table30.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Window"});
#line 134
 testRunner.When("Service Deleted", ((string)(null)), table30, "When ");
#line 137
 testRunner.Then("Verify Service Deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table31.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Window"});
#line 138
 testRunner.When("Service Added with service charge", ((string)(null)), table31, "When ");
#line 141
 testRunner.Then("Verify Service Price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table32.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Window"});
#line 142
 testRunner.When("Service Added without service charge", ((string)(null)), table32, "When ");
#line 145
 testRunner.Then("Verify Service Price not added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Unit of Measure Service Offering,Update Unit of Measure Service Offering,Dele" +
            "te Unit of Measure Service Offering")]
        public virtual void AddUnitOfMeasureServiceOfferingUpdateUnitOfMeasureServiceOfferingDeleteUnitOfMeasureServiceOffering()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Unit of Measure Service Offering,Update Unit of Measure Service Offering,Dele" +
                    "te Unit of Measure Service Offering", null, ((string[])(null)));
#line 148
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table33.AddRow(new string[] {
                        "DetailsNeeded",
                        "true"});
#line 149
 testRunner.Given("Not Started Order Opened", ((string)(null)), table33, "Given ");
#line 152
 testRunner.When("Navigate To Services View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table34.AddRow(new string[] {
                        "ServiceType",
                        "Service UOM"});
#line 153
 testRunner.When("Service Added", ((string)(null)), table34, "When ");
#line 156
 testRunner.Then("Verify Service Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table35.AddRow(new string[] {
                        "ServiceType",
                        "Service UOM"});
#line 157
 testRunner.When("Service Edited", ((string)(null)), table35, "When ");
#line 160
 testRunner.Then("Verify Service Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table36.AddRow(new string[] {
                        "ServiceType",
                        "Service UOM"});
#line 161
 testRunner.When("Service Deleted", ((string)(null)), table36, "When ");
#line 164
 testRunner.Then("Verify Service Deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add By Man Hour Service Offering,Update By Man-Hour Service Offering,Delete By Ma" +
            "n-Hour Service Offering")]
        public virtual void AddByManHourServiceOfferingUpdateByMan_HourServiceOfferingDeleteByMan_HourServiceOffering()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add By Man Hour Service Offering,Update By Man-Hour Service Offering,Delete By Ma" +
                    "n-Hour Service Offering", null, ((string[])(null)));
#line 167
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table37.AddRow(new string[] {
                        "DetailsNeeded",
                        "true"});
#line 168
 testRunner.Given("Not Started Order Opened", ((string)(null)), table37, "Given ");
#line 171
 testRunner.When("Navigate To Services View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table38.AddRow(new string[] {
                        "ServiceType",
                        "Service MH"});
#line 172
 testRunner.When("Service Added", ((string)(null)), table38, "When ");
#line 175
 testRunner.Then("Verify Service Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table39.AddRow(new string[] {
                        "ServiceType",
                        "Service MH"});
#line 176
 testRunner.When("Service Edited", ((string)(null)), table39, "When ");
#line 179
 testRunner.Then("Verify Service Edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table40 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table40.AddRow(new string[] {
                        "ServiceType",
                        "Service MH"});
#line 180
 testRunner.When("Service Deleted", ((string)(null)), table40, "When ");
#line 183
 testRunner.Then("Verify Service Deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Service Offering with Customer Signature Required")]
        public virtual void AddServiceOfferingWithCustomerSignatureRequired()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Service Offering with Customer Signature Required", null, ((string[])(null)));
#line 186
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table41 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table41.AddRow(new string[] {
                        "DetailsNeeded",
                        "true"});
#line 187
 testRunner.Given("Not Started Order Opened", ((string)(null)), table41, "Given ");
#line 190
 testRunner.When("Navigate To Services View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table42 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table42.AddRow(new string[] {
                        "ServiceType",
                        "Service Offering with Customer sign"});
#line 191
 testRunner.When("Service Added", ((string)(null)), table42, "When ");
#line 194
 testRunner.Then("Verify Service Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 195
 testRunner.When("Customer Signature Tab added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 196
 testRunner.When("Order Started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 197
 testRunner.Then("Verify Order Started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 198
 testRunner.When("Order Completion", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 199
 testRunner.Then("Verify Customer Signature Required", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Service Offering with Employee Signature Required")]
        public virtual void AddServiceOfferingWithEmployeeSignatureRequired()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Service Offering with Employee Signature Required", null, ((string[])(null)));
#line 202
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table43 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table43.AddRow(new string[] {
                        "DetailsNeeded",
                        "true"});
#line 203
 testRunner.Given("Not Started Order Opened", ((string)(null)), table43, "Given ");
#line 206
 testRunner.When("Navigate To Services View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table44 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table44.AddRow(new string[] {
                        "ServiceType",
                        "Service offering with Employee Signature"});
#line 207
 testRunner.When("Service Added", ((string)(null)), table44, "When ");
#line 210
 testRunner.Then("Verify Service Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 211
 testRunner.When("Employee Signature Tab added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 212
 testRunner.When("Order Started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 213
 testRunner.Then("Verify Order Started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 214
 testRunner.When("Order Completion", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 215
 testRunner.Then("Verify Employee Signature Required", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Service Offering with Default Material")]
        public virtual void AddServiceOfferingWithDefaultMaterial()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Service Offering with Default Material", null, ((string[])(null)));
#line 218
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table45 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table45.AddRow(new string[] {
                        "DetailsNeeded",
                        "true"});
#line 219
 testRunner.Given("Not Started Order Opened", ((string)(null)), table45, "Given ");
#line 222
 testRunner.When("Navigate To Services View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table46 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table46.AddRow(new string[] {
                        "ServiceType",
                        "Service with default material"});
#line 223
 testRunner.When("Service Added", ((string)(null)), table46, "When ");
#line hidden
            TechTalk.SpecFlow.Table table47 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table47.AddRow(new string[] {
                        "ServiceType",
                        "Service with default material"});
            table47.AddRow(new string[] {
                        "ServiceMaterial",
                        "Material Auto IOS"});
#line 226
 testRunner.Then("Verify Service with material Added", ((string)(null)), table47, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Service Offering with Default Product")]
        public virtual void AddServiceOfferingWithDefaultProduct()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Service Offering with Default Product", null, ((string[])(null)));
#line 232
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table48 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table48.AddRow(new string[] {
                        "DetailsNeeded",
                        "true"});
#line 233
 testRunner.Given("Not Started Order Opened", ((string)(null)), table48, "Given ");
#line 236
 testRunner.When("Navigate To Services View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table49 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table49.AddRow(new string[] {
                        "ServiceType",
                        "Service with default product"});
#line 237
 testRunner.When("Service Added", ((string)(null)), table49, "When ");
#line hidden
            TechTalk.SpecFlow.Table table50 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table50.AddRow(new string[] {
                        "ServiceType",
                        "Service with default product"});
            table50.AddRow(new string[] {
                        "ServiceProduct",
                        "Product auto IOS"});
#line 240
 testRunner.Then("Verify Service with product Added", ((string)(null)), table50, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Target Pest,Delete Target Pest")]
        public virtual void AddTargetPestDeleteTargetPest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Target Pest,Delete Target Pest", null, ((string[])(null)));
#line 246
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table51 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table51.AddRow(new string[] {
                        "DetailsNeeded",
                        "true"});
#line 247
 testRunner.Given("Not Started Order Opened", ((string)(null)), table51, "Given ");
#line 250
 testRunner.When("Navigate To Services View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table52 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table52.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Auto"});
#line 251
 testRunner.Given("Pest Tab Opened", ((string)(null)), table52, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table53 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table53.AddRow(new string[] {
                        "Pest",
                        "Ants"});
            table53.AddRow(new string[] {
                        "ServiceType",
                        "Cleaning Auto"});
#line 254
 testRunner.When("Pest Added", ((string)(null)), table53, "When ");
#line 258
 testRunner.Then("Verify Pest Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table54 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table54.AddRow(new string[] {
                        "Pest",
                        "Ants"});
#line 259
 testRunner.When("Delete Target Pest", ((string)(null)), table54, "When ");
#line 262
 testRunner.Then("Verify Pest deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

