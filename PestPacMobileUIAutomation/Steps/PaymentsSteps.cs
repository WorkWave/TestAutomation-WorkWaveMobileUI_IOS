using System;
using TechTalk.SpecFlow;
using WorkWave.Workwave.Mobile.SharedData;

namespace WorkWave.Workwave.Mobile.Steps
{
    [Binding]
    public class PaymentsSteps
    {

        WorkwaveData WorkwaveData;
        private CommonSteps common;

        public PaymentsSteps(WorkwaveData WorkwaveData)
        {
            this.WorkwaveData = WorkwaveData;
            common = new CommonSteps(WorkwaveData);
        }

        [Given(@"Payments Opened")]
        public void GivenPaymentsOpened(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Payment Made")]
        public void WhenPaymentMade(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Verify Payment Made")]
        public void ThenVerifyPaymentMade()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
