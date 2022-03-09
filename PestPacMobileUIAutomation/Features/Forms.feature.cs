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
    [NUnit.Framework.DescriptionAttribute("Forms")]
    [NUnit.Framework.CategoryAttribute("Forms")]
    public partial class FormsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Forms.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Forms", null, ProgrammingLanguage.CSharp, new string[] {
                        "Forms"});
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
        [NUnit.Framework.DescriptionAttribute("Add A Forms")]
        public virtual void AddAForms()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add A Forms", null, ((string[])(null)));
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
                        "FormType",
                        "Simple 1"});
#line 9
 testRunner.When("Form Added", ((string)(null)), table2, "When ");
#line 12
 testRunner.When("Fill Form Fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.When("Complete Form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("Verify Form Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Edit Form → Save Draft,Edit Form → Preview,Delete a Draft Form")]
        public virtual void EditFormSaveDraftEditFormPreviewDeleteADraftForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Form → Save Draft,Edit Form → Preview,Delete a Draft Form", null, ((string[])(null)));
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 18
 testRunner.Given("Not Started Order Opened", ((string)(null)), table3, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "FormType",
                        "Simple 1"});
#line 21
 testRunner.When("Form Added", ((string)(null)), table4, "When ");
#line 24
 testRunner.When("Fill Form Fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.When("Save Form As A Draft", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("Verify Form Drafted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.When("Drafted Form Opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.When("Preview Form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("Verify Preview Loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.When("Draft Form Delete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then("Verify Form Deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Form To Favorites,Unfavorite a Form Template")]
        public virtual void AddFormToFavoritesUnfavoriteAFormTemplate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Form To Favorites,Unfavorite a Form Template", null, ((string[])(null)));
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 36
 testRunner.Given("Not Started Order Opened", ((string)(null)), table5, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "FormType",
                        "Simple 1"});
#line 39
 testRunner.When("Form Favorited", ((string)(null)), table6, "When ");
#line 42
 testRunner.Then("Verify Form Favorited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.When("Form Unfavorited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then("Verify Form Unfavorited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Edit Form → Insert Image → Pick from Gallery,Edit Form → Insert Image → Take a Ph" +
            "oto,Edit Form → Clear All Fields,Edit Form → Insert Image → Location Images,Inse" +
            "rt Image → Location Images")]
        public virtual void EditFormInsertImagePickFromGalleryEditFormInsertImageTakeAPhotoEditFormClearAllFieldsEditFormInsertImageLocationImagesInsertImageLocationImages()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Form → Insert Image → Pick from Gallery,Edit Form → Insert Image → Take a Ph" +
                    "oto,Edit Form → Clear All Fields,Edit Form → Insert Image → Location Images,Inse" +
                    "rt Image → Location Images", null, ((string[])(null)));
#line 47
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 48
 testRunner.Given("Not Started Order Opened", ((string)(null)), table7, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "DocumentType",
                        "Pick from Gallery"});
            table8.AddRow(new string[] {
                        "DocumentName",
                        "autoDoc"});
#line 51
 testRunner.When("Add Image To Media Gallery", ((string)(null)), table8, "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "FormType",
                        "Simple 1"});
#line 55
 testRunner.When("Form Added", ((string)(null)), table9, "When ");
#line 58
 testRunner.When("Fill Form Fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "FormType",
                        "Simple 1"});
            table10.AddRow(new string[] {
                        "DocumentType",
                        "Pick from Gallery"});
#line 59
 testRunner.When("Insert Image To Form", ((string)(null)), table10, "When ");
#line 63
 testRunner.Then("Verify Image Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "FormType",
                        "Simple 1"});
            table11.AddRow(new string[] {
                        "DocumentType",
                        "Take a Photo"});
#line 64
 testRunner.When("Insert Image To Form", ((string)(null)), table11, "When ");
#line 68
 testRunner.Then("Verify Image Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.When("All Form Fields Cleared", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.Then("Verify All Form Fields Cleared", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "FormType",
                        "Simple 1"});
            table12.AddRow(new string[] {
                        "DocumentType",
                        "Location Images"});
#line 71
 testRunner.When("Insert Image To Form", ((string)(null)), table12, "When ");
#line 75
 testRunner.Then("Verify Image Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Edit Form → Interact with Read-only Fields,Edit Form → Interact with Required Fie" +
            "lds")]
        public virtual void EditFormInteractWithRead_OnlyFieldsEditFormInteractWithRequiredFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Form → Interact with Read-only Fields,Edit Form → Interact with Required Fie" +
                    "lds", null, ((string[])(null)));
#line 78
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 79
 testRunner.Given("Not Started Order Opened", ((string)(null)), table13, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "FormType",
                        "Ios_Test Form"});
#line 82
 testRunner.When("Form Added", ((string)(null)), table14, "When ");
#line 85
 testRunner.When("Start Form Editing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "FieldName",
                        "Family Name Text Box"});
#line 86
 testRunner.When("Search For Field", ((string)(null)), table15, "When ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "Status",
                        "Readonly"});
#line 89
 testRunner.Then("Verify Search Result", ((string)(null)), table16, "Then ");
#line 92
 testRunner.Then("Verify ReadOnly Field Is Not Editable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "FieldName",
                        "Given Name Text Box"});
#line 93
 testRunner.When("Required Feilds Filled", ((string)(null)), table17, "When ");
#line 96
 testRunner.Then("Verify Required Fields Completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Edit Form → Interact with Fields Editable After Customer Signs")]
        public virtual void EditFormInteractWithFieldsEditableAfterCustomerSigns()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Form → Interact with Fields Editable After Customer Signs", null, ((string[])(null)));
#line 99
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 100
 testRunner.Given("Not Started Order Opened", ((string)(null)), table18, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table19.AddRow(new string[] {
                        "FormType",
                        "Customer Signed Form"});
#line 103
 testRunner.When("Search Form", ((string)(null)), table19, "When ");
#line 106
 testRunner.Then("Verify Fields Editable After Customer Signs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

