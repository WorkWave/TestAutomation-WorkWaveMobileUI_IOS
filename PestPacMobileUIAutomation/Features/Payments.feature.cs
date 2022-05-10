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
    [NUnit.Framework.DescriptionAttribute("Payments")]
    [NUnit.Framework.CategoryAttribute("Payments")]
    public partial class PaymentsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Payments.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Payments", null, ProgrammingLanguage.CSharp, new string[] {
                        "Payments"});
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
        [NUnit.Framework.DescriptionAttribute("Cash Payment")]
        public virtual void CashPayment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cash Payment", null, ((string[])(null)));
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
#line 9
 testRunner.When("Navigate To Payment View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Given("Payments Opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "PaymentType",
                        "Cash"});
            table2.AddRow(new string[] {
                        "PayTotalDue",
                        "true"});
#line 11
 testRunner.When("Payment Made", ((string)(null)), table2, "When ");
#line 15
 testRunner.When("Process Payment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("Verify Payment Made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check Payment")]
        public virtual void CheckPayment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check Payment", null, ((string[])(null)));
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 20
 testRunner.Given("Not Started Order Opened", ((string)(null)), table3, "Given ");
#line 23
 testRunner.When("Navigate To Payment View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Given("Payments Opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "PaymentType",
                        "Check"});
            table4.AddRow(new string[] {
                        "PayTotalDue",
                        "true"});
#line 25
 testRunner.When("Payment Made", ((string)(null)), table4, "When ");
#line 29
 testRunner.When("Process Payment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("Verify Payment Made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Credit Card Payment")]
        public virtual void CreditCardPayment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Credit Card Payment", null, ((string[])(null)));
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 34
 testRunner.Given("Not Started Order Opened", ((string)(null)), table5, "Given ");
#line 37
 testRunner.When("Navigate To Payment View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Given("Payments Opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "PaymentType",
                        "Credit Card"});
            table6.AddRow(new string[] {
                        "PayTotalDue",
                        "true"});
#line 39
 testRunner.When("Payment Made", ((string)(null)), table6, "When ");
#line 43
 testRunner.When("Process Payment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then("Verify Payment Made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Record Credit Card Payment → Vantiv")]
        public virtual void RecordCreditCardPaymentVantiv()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Record Credit Card Payment → Vantiv", null, ((string[])(null)));
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
#line 51
 testRunner.When("Navigate To Payment View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Given("Payments Opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "PaymentType",
                        "Credit Card"});
            table8.AddRow(new string[] {
                        "PayTotalDue",
                        "true"});
            table8.AddRow(new string[] {
                        "Option",
                        "Enter a new card.."});
            table8.AddRow(new string[] {
                        "SaveOption",
                        "No"});
            table8.AddRow(new string[] {
                        "CardNumber",
                        "5610591081018250"});
#line 53
 testRunner.When("Select Payment Mode", ((string)(null)), table8, "When ");
#line 60
 testRunner.Then("Verify Payment Made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Record Credit Card Payment and Store Card → Vantiv,Record Credit Card Payment wit" +
            "h Stored Card → Vantiv")]
        public virtual void RecordCreditCardPaymentAndStoreCardVantivRecordCreditCardPaymentWithStoredCardVantiv()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Record Credit Card Payment and Store Card → Vantiv,Record Credit Card Payment wit" +
                    "h Stored Card → Vantiv", null, ((string[])(null)));
#line 63
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 64
 testRunner.Given("Not Started Order Opened", ((string)(null)), table9, "Given ");
#line 67
 testRunner.When("Navigate To Payment View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.Given("Payments Opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "PaymentType",
                        "Credit Card"});
            table10.AddRow(new string[] {
                        "PayTotalDue",
                        "true"});
            table10.AddRow(new string[] {
                        "Option",
                        "Enter a new card.."});
            table10.AddRow(new string[] {
                        "SaveOption",
                        "Yes"});
            table10.AddRow(new string[] {
                        "CardNumber",
                        "4111111111111111"});
#line 69
 testRunner.When("Select Payment Mode", ((string)(null)), table10, "When ");
#line 76
 testRunner.Then("Verify Payment Made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.Given("Payments Opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "PaymentType",
                        "Credit Card"});
            table11.AddRow(new string[] {
                        "PayTotalDue",
                        "true"});
            table11.AddRow(new string[] {
                        "Option",
                        "Visa - 1111 (12/25)"});
            table11.AddRow(new string[] {
                        "SaveOption",
                        "Yes"});
            table11.AddRow(new string[] {
                        "CardNumber",
                        "4111111111111111"});
            table11.AddRow(new string[] {
                        "CVV",
                        "1234"});
#line 78
 testRunner.When("Select Payment Mode", ((string)(null)), table11, "When ");
#line 86
 testRunner.Then("Verify Payment Made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Record Credit Card Payment,and Store Card,with Stored Card → OpenEdge")]
        public virtual void RecordCreditCardPaymentAndStoreCardWithStoredCardOpenEdge()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Record Credit Card Payment,and Store Card,with Stored Card → OpenEdge", null, ((string[])(null)));
#line 89
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 90
 testRunner.Given("Logged Out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "Email",
                        "mdelgoda+emp1@workwave.com"});
            table12.AddRow(new string[] {
                        "Password",
                        "WorkWave1!"});
#line 91
 testRunner.When("I Login", ((string)(null)), table12, "When ");
#line 95
 testRunner.Then("Verify logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "DetailsNeeded",
                        "false"});
#line 96
 testRunner.Given("Not Started Order Opened", ((string)(null)), table13, "Given ");
#line 99
 testRunner.When("Navigate To Payment View", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.Given("Payments Opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "PaymentType",
                        "Credit Card"});
            table14.AddRow(new string[] {
                        "PayTotalDue",
                        "true"});
            table14.AddRow(new string[] {
                        "Option",
                        "Enter a new card.."});
            table14.AddRow(new string[] {
                        "SaveOption",
                        "No"});
            table14.AddRow(new string[] {
                        "CardNumber",
                        "4761739001010010"});
            table14.AddRow(new string[] {
                        "CVV",
                        "123"});
#line 101
 testRunner.When("Select Payment Mode OpenEdge", ((string)(null)), table14, "When ");
#line 109
 testRunner.Then("Verify Payment Made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
 testRunner.Given("Payments Opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "PaymentType",
                        "Credit Card"});
            table15.AddRow(new string[] {
                        "PayTotalDue",
                        "true"});
            table15.AddRow(new string[] {
                        "Option",
                        "Enter a new card.."});
            table15.AddRow(new string[] {
                        "SaveOption",
                        "Yes"});
            table15.AddRow(new string[] {
                        "CardNumber",
                        "4761739001010010"});
            table15.AddRow(new string[] {
                        "CVV",
                        "123"});
#line 111
 testRunner.When("Select Payment Mode OpenEdge", ((string)(null)), table15, "When ");
#line 119
 testRunner.Then("Verify Payment Made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 120
 testRunner.Given("Payments Opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "PaymentType",
                        "Credit Card"});
            table16.AddRow(new string[] {
                        "PayTotalDue",
                        "true"});
            table16.AddRow(new string[] {
                        "Option",
                        "Visa - 0010 (12/25)"});
            table16.AddRow(new string[] {
                        "SaveOption",
                        "Yes"});
            table16.AddRow(new string[] {
                        "CardNumber",
                        "4761739001010010"});
            table16.AddRow(new string[] {
                        "CVV",
                        "123"});
#line 121
 testRunner.When("Select Payment Mode OpenEdge", ((string)(null)), table16, "When ");
#line 129
 testRunner.Then("Verify Payment Made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

