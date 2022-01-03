using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WorkWave.Workwave.Mobile.Model;
using WorkWave.Workwave.Mobile.SharedData;

namespace WorkWave.Workwave.Mobile.Steps
{
    [Binding]
    public class PaymentsSteps
    {

        WorkwaveData WorkwaveData;
        private CommonSteps common;
        PaymentView paymentView = new PaymentView();

        public PaymentsSteps(WorkwaveData WorkwaveData)
        {
            this.WorkwaveData = WorkwaveData;
            common = new CommonSteps(WorkwaveData);
        }

        [When(@"Navigate To Payment View")]
        public void WhenNavigateToPaymentView()
        {
            WorkwaveMobileSupport.SwipeDownIOS("Collect Payment");
        }

        [Given(@"Payments Opened")]
        public void GivenPaymentsOpened()
        {
            paymentView.ClickOnStaticText("Collect Payment");
            if(!paymentView.VerifyPaymentsViewLoaded(5))
            {
                paymentView.ClickOnStaticText("Collect Payment");
            }
            Assert.True(paymentView.VerifyViewLoadedByHeader(5, "Payments"));
        }
        
        [When(@"Payment Made")]
        public void WhenPaymentMade(Table data)
        {
            WorkwaveData.Order = data.CreateInstance<Order>();
            paymentView.PaymentTypeClick();
            paymentView.SelectType(WorkwaveData.Order.PaymentType);

            if ((WorkwaveData.Order.PayTotalDue).Equals("Total Due"))
            {
                paymentView.ClickOnButton("Total Due");
                Assert.True(paymentView.getAmountFieldText().Equals(paymentView.getTotalDue().Replace("$", string.Empty).Replace(",", string.Empty)));
                WorkwaveData.Order.PaymentAmount = paymentView.getTotalDue();
            }
            else
            {
                WorkwaveData.Order.PaymentAmount = WorkwaveMobileSupport.RandomDouble(2);
                paymentView.EnterAmount(WorkwaveData.Order.PaymentAmount);
                WorkwaveData.Order.PaymentAmount = "$" + WorkwaveData.Order.PaymentAmount;
            }

            paymentView.ClickOnButton("Process");
            System.TimeSpan.FromSeconds(60);
            paymentView.VerifyViewLoadedByText(5,"Payment History");
            System.TimeSpan.FromSeconds(60);
        }
        
        [Then(@"Verify Payment Made")]
        public void ThenVerifyPaymentMade()
        {
            paymentView.VerifyViewLoadedByText(5, WorkwaveData.Order.PaymentAmount);
            paymentView.ClickOnText("Done");
        }
    }
}
