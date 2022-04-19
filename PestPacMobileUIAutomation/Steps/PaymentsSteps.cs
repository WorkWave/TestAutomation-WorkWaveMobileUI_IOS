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
            System.TimeSpan.FromSeconds(60);
            paymentView.SelectType(WorkwaveData.Order.PaymentType);
            System.TimeSpan.FromSeconds(60);
            paymentView.ClickOnText("Done");

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

            if ((WorkwaveData.Order.PaymentType).Equals("Check"))
            {
               
                WorkwaveData.Order.PaymentReference = WorkwaveMobileSupport.RandomInt(5);
                paymentView.EnterCheckNumber(WorkwaveData.Order.PaymentReference);
            }

            if ((WorkwaveData.Order.PaymentType).Equals("Credit Card"))
            {

                WorkwaveData.Order.PaymentReference = WorkwaveMobileSupport.RandomInt(5);
                paymentView.EnterReference(WorkwaveData.Order.PaymentReference);
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
            if ((WorkwaveData.Order.PaymentType).Equals("check"))
            {
                paymentView.VerifyViewLoadedByText(5, "Check # " + WorkwaveData.Order.PaymentReference);
            }
            paymentView.ClickOnText("Done");
            paymentView.ClickOnText("Back");
        }
    }
}
