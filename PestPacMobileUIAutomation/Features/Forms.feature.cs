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
        [NUnit.Framework.DescriptionAttribute("Add A Forms,Interact with Complete Form")]
        public virtual void AddAFormsInteractWithCompleteForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add A Forms,Interact with Complete Form", null, ((string[])(null)));
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
                        "Ios_Test Form"});
#line 9
 testRunner.When("Form Added", ((string)(null)), table2, "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "FieldName",
                        "Given Name Text Box"});
#line 12
 testRunner.When("Fill The Form", ((string)(null)), table3, "When ");
#line 15
 testRunner.When("Complete Form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("Verify Form Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Edit Form → Save Draft,Edit Form → Preview,Delete a Draft Form,Interact with Draf" +
            "t Form")]
        public virtual void EditFormSaveDraftEditFormPreviewDeleteADraftFormInteractWithDraftForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Form → Save Draft,Edit Form → Preview,Delete a Draft Form,Interact with Draf" +
                    "t Form", null, ((string[])(null)));
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 20
 testRunner.Given("Not Started Order Opened", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "FormType",
                        "Ios_Test Form"});
#line 23
 testRunner.When("Form Added", ((string)(null)), table5, "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "FieldName",
                        "Given Name Text Box"});
#line 26
 testRunner.When("Fill The Form", ((string)(null)), table6, "When ");
#line 29
 testRunner.When("Save Form As A Draft", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("Verify Form Drafted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.When("Drafted Form Opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.When("Preview Form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.Then("Verify Preview Loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
 testRunner.When("Draft Form Delete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("Verify Form Deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Form To Favorites,Unfavorite a Form Template")]
        public virtual void AddFormToFavoritesUnfavoriteAFormTemplate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Form To Favorites,Unfavorite a Form Template", null, ((string[])(null)));
#line 39
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 40
 testRunner.Given("Not Started Order Opened", ((string)(null)), table7, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "FormType",
                        "Ios_Test Form"});
#line 43
 testRunner.When("Form Favorited", ((string)(null)), table8, "When ");
#line 46
 testRunner.Then("Verify Form Favorited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
 testRunner.When("Form Unfavorited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
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
#line 51
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 52
 testRunner.Given("Not Started Order Opened", ((string)(null)), table9, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "DocumentType",
                        "Pick from Gallery"});
            table10.AddRow(new string[] {
                        "DocumentName",
                        "autoDoc"});
#line 55
 testRunner.When("Add Image To Media Gallery", ((string)(null)), table10, "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "FormType",
                        "Ios_Test Form"});
#line 59
 testRunner.When("Form Added", ((string)(null)), table11, "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "FieldName",
                        "Given Name Text Box"});
#line 62
 testRunner.When("Fill Form Fields", ((string)(null)), table12, "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "FormType",
                        "Ios_Test Form"});
            table13.AddRow(new string[] {
                        "DocumentType",
                        "Pick from Gallery"});
#line 65
 testRunner.When("Insert Image To Form", ((string)(null)), table13, "When ");
#line 69
 testRunner.Then("Verify Image Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "FormType",
                        "Ios_Test Form"});
            table14.AddRow(new string[] {
                        "DocumentType",
                        "Take a Photo"});
#line 70
 testRunner.When("Insert Image To Form", ((string)(null)), table14, "When ");
#line 74
 testRunner.Then("Verify Image Added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.When("All Form Fields Cleared", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.Then("Verify All Form Fields Cleared", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "FormType",
                        "Ios_Test Form"});
            table15.AddRow(new string[] {
                        "DocumentType",
                        "Location Images"});
#line 77
 testRunner.When("Insert Image To Form", ((string)(null)), table15, "When ");
#line 81
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
#line 84
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 85
 testRunner.Given("Not Started Order Opened", ((string)(null)), table16, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "FormType",
                        "Ios_Test Form"});
#line 88
 testRunner.When("Form Added", ((string)(null)), table17, "When ");
#line 91
 testRunner.When("Start Form Editing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "FieldName",
                        "Family Name Text Box"});
#line 92
 testRunner.When("Search For Field", ((string)(null)), table18, "When ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table19.AddRow(new string[] {
                        "Status",
                        "Readonly"});
#line 95
 testRunner.Then("Verify Search Result", ((string)(null)), table19, "Then ");
#line 98
 testRunner.Then("Verify ReadOnly Field Is Not Editable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table20.AddRow(new string[] {
                        "FieldName",
                        "Given Name Text Box"});
#line 99
 testRunner.When("Required Feilds Filled", ((string)(null)), table20, "When ");
#line 102
 testRunner.Then("Verify Required Fields Completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Edit Form → Interact with Fields Editable After Customer Signs")]
        public virtual void EditFormInteractWithFieldsEditableAfterCustomerSigns()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Form → Interact with Fields Editable After Customer Signs", null, ((string[])(null)));
#line 105
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table21.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 106
 testRunner.Given("Not Started Order Opened", ((string)(null)), table21, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table22.AddRow(new string[] {
                        "FormType",
                        "Customer Signed Form"});
#line 109
 testRunner.When("Search Form", ((string)(null)), table22, "When ");
#line 112
 testRunner.Then("Verify Fields Editable After Customer Signs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Edit Form → Clear Non-Auto Fields")]
        public virtual void EditFormClearNon_AutoFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Form → Clear Non-Auto Fields", null, ((string[])(null)));
#line 115
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table23.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 116
 testRunner.Given("Not Started Order Opened", ((string)(null)), table23, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table24.AddRow(new string[] {
                        "FormType",
                        "Mapped QA"});
#line 119
 testRunner.When("Form Added", ((string)(null)), table24, "When ");
#line 122
 testRunner.When("Start Form Editing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
 testRunner.When("Clear Non Auto Fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
 testRunner.Then("Verify Non Auto Fields Cleared", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Edit Form → Send Form → Customer Role,Interact with Out for Signature Form")]
        public virtual void EditFormSendFormCustomerRoleInteractWithOutForSignatureForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Form → Send Form → Customer Role,Interact with Out for Signature Form", null, ((string[])(null)));
#line 127
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table25.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 128
 testRunner.Given("Not Started Order Opened", ((string)(null)), table25, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table26.AddRow(new string[] {
                        "FormType",
                        "Ios_Test Form"});
#line 131
 testRunner.When("Form Added", ((string)(null)), table26, "When ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table27.AddRow(new string[] {
                        "FieldName",
                        "Given Name Text Box"});
#line 134
 testRunner.When("Fill The Form", ((string)(null)), table27, "When ");
#line 137
 testRunner.Then("Verify Required Fields Completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table28.AddRow(new string[] {
                        "Role",
                        "Customer"});
            table28.AddRow(new string[] {
                        "Email",
                        "mdelgoda@workwave.com"});
#line 138
 testRunner.When("Send The Form", ((string)(null)), table28, "When ");
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table29.AddRow(new string[] {
                        "Status",
                        "Out for Signature"});
#line 142
 testRunner.Then("Verify Sending Successful", ((string)(null)), table29, "Then ");
#line 145
 testRunner.Then("Verify Form Interactable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Edit Form → Send Form → Internal Role,Interact with In Progress Form")]
        public virtual void EditFormSendFormInternalRoleInteractWithInProgressForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Form → Send Form → Internal Role,Interact with In Progress Form", null, ((string[])(null)));
#line 148
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table30.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 149
 testRunner.Given("Not Started Order Opened", ((string)(null)), table30, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table31.AddRow(new string[] {
                        "FormType",
                        "Ios_Test Form"});
#line 152
 testRunner.When("Form Added", ((string)(null)), table31, "When ");
#line hidden
            TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table32.AddRow(new string[] {
                        "FieldName",
                        "Given Name Text Box"});
#line 155
 testRunner.When("Fill The Form", ((string)(null)), table32, "When ");
#line 158
 testRunner.Then("Verify Required Fields Completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table33.AddRow(new string[] {
                        "Role",
                        "Administrator"});
            table33.AddRow(new string[] {
                        "Name",
                        "Maheshika Delgoda"});
            table33.AddRow(new string[] {
                        "Email",
                        "mdelgoda+qa@workwave.com"});
#line 159
 testRunner.When("Send The Form", ((string)(null)), table33, "When ");
#line hidden
            TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table34.AddRow(new string[] {
                        "Status",
                        "In Progress"});
#line 164
 testRunner.Then("Verify Sending Successful", ((string)(null)), table34, "Then ");
#line 167
 testRunner.Then("Verify Form Interactable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Interact with Signed Form")]
        public virtual void InteractWithSignedForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Interact with Signed Form", null, ((string[])(null)));
#line 170
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table35.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 171
 testRunner.Given("Not Started Order Opened", ((string)(null)), table35, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table36.AddRow(new string[] {
                        "Status",
                        "Signed"});
#line 174
 testRunner.When("Search Forms", ((string)(null)), table36, "When ");
#line 177
 testRunner.Then("Verify Form Editor Displaying", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Interact with Canceled Form")]
        public virtual void InteractWithCanceledForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Interact with Canceled Form", null, ((string[])(null)));
#line 180
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table37.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 181
 testRunner.Given("Not Started Order Opened", ((string)(null)), table37, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table38.AddRow(new string[] {
                        "Status",
                        "Canceled"});
#line 184
 testRunner.When("Search Forms", ((string)(null)), table38, "When ");
#line 187
 testRunner.Then("Verify Form Editor Not Displaying", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

