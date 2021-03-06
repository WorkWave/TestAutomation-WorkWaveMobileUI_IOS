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
        string Name=null;

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
            WorkwaveData.Payments = data.CreateInstance<Payments>();
            paymentView.PaymentTypeClick();
            System.TimeSpan.FromSeconds(60);
            paymentView.SelectType(WorkwaveData.Payments.PaymentType);
            System.TimeSpan.FromSeconds(60);
            paymentView.ClickOnText("Done");

            if ((WorkwaveData.Payments.PayTotalDue).Equals("Total Due"))
            {
                paymentView.ClickOnButton("Total Due");
                Assert.True(paymentView.getAmountFieldText().Equals(paymentView.getTotalDue().Replace("$", string.Empty).Replace(",", string.Empty)));
                WorkwaveData.Payments.PaymentAmount = paymentView.getTotalDue();
            }
            else
            {
                WorkwaveData.Payments.PaymentAmount = WorkwaveMobileSupport.RandomDouble(2);
                paymentView.EnterAmount(WorkwaveData.Payments.PaymentAmount);
                WorkwaveData.Payments.PaymentAmount = "$" + WorkwaveData.Payments.PaymentAmount;
            }

            if ((WorkwaveData.Payments.PaymentType).Equals("Check"))
            {
               
                WorkwaveData.Payments.PaymentReference = WorkwaveMobileSupport.RandomInt(5);
                paymentView.EnterCheckNumber(WorkwaveData.Payments.PaymentReference);
            }

            if ((WorkwaveData.Payments.PaymentType).Equals("Credit Card"))
            {

                WorkwaveData.Payments.PaymentReference = WorkwaveMobileSupport.RandomInt(5);
                paymentView.EnterReference(WorkwaveData.Payments.PaymentReference);
            }

         
        }

        [When(@"Process Payment")]
        public void WhenProcessPayment()
        {
            // paymentView.ClickOnButton("Process");
            WorkwaveMobileSupport.TapTargetNoWait(553, 1644);
            System.TimeSpan.FromSeconds(60);
            paymentView.VerifyViewLoadedByText(5, "Payment History");
            System.TimeSpan.FromSeconds(60);
        }


        [Then(@"Verify Payment Made")]
        public void ThenVerifyPaymentMade()
        {
            paymentView.VerifyViewLoadedByText(5, WorkwaveData.Payments.PaymentAmount);
            if ((WorkwaveData.Payments.PaymentType).Equals("check"))
            {
                paymentView.VerifyViewLoadedByText(5, "Check # " + WorkwaveData.Payments.PaymentReference);
            }
            paymentView.ClickOnText("Done");
           
        }

        [When(@"Select Payment Mode")]
        public void WhenSelectPaymentMode(Table data)
        {
            WorkwaveData.Payments = data.CreateInstance<Payments>();
            paymentView.PaymentTypeClick();
            System.TimeSpan.FromSeconds(60);
            paymentView.SelectType(WorkwaveData.Payments.PaymentType);
            System.TimeSpan.FromSeconds(60);
            paymentView.ClickOnText("Done");
            if ((WorkwaveData.Payments.PayTotalDue).Equals("Total Due"))
            {
                paymentView.ClickOnButton("Total Due");
                Assert.True(paymentView.getAmountFieldText().Equals(paymentView.getTotalDue().Replace("$", string.Empty).Replace(",", string.Empty)));
                WorkwaveData.Payments.PaymentAmount = paymentView.getTotalDue();
            }
            else
            {
                //WorkwaveData.Payments.PaymentAmount = WorkwaveMobileSupport.RandomDouble(2);
                paymentView.EnterAmount(WorkwaveData.Payments.PaymentAmount);
                WorkwaveData.Payments.PaymentAmount = "$" + WorkwaveData.Payments.PaymentAmount;
            }
            paymentView.ClickOnText("Please select a credit card");
            Name = WorkwaveMobileSupport.RandomString(5);
            if ((WorkwaveData.Payments.Option).Equals("Enter a new card.."))
            {
                paymentView.SelectType(WorkwaveData.Payments.Option);
                paymentView.ClickOnText("Done");
                paymentView.EnterName(Name);
                paymentView.ClickOnText(WorkwaveData.Payments.Option);
                paymentView.ClickOnText(WorkwaveData.Payments.SaveOption);
                paymentView.ClickOnText("Done");
                if (paymentView.VerifyContinueButtonLoaded(5))
                {
                    paymentView.ClickContinueButton();
                }
                else
                {
                    paymentView.ClickOnButton("Process");
                }
               
                System.TimeSpan.FromSeconds(60);
                while (!paymentView.VerifyAddNewCardViewLoaded(5))
                {
                    System.TimeSpan.FromSeconds(60);
                }

                string message = WorkwaveData.Payments.CardNumber;
                Console.WriteLine(message);
                string[] result = new string[message.Length];
                char[] temp = new char[message.Length];

                temp = message.ToCharArray();
                paymentView.ClickOnCommonField();
                for (int i = 0; i < message.Length; i++)
                {
                    result[i] = Convert.ToString(temp[i]);
                    paymentView.ClickOnKey(result[i]);
                    Console.WriteLine(result[i]);
                }

                paymentView.ClickOnText("Expiration Month");
                paymentView.SelectType("12");
                paymentView.ClickOnText("Expiration Year");
                paymentView.ClickOnText("Expiration Year");
                paymentView.SelectType("2025");
                WorkwaveMobileSupport.TapTargetNoWait(292, 614);
                paymentView.EnterCVV(WorkwaveData.Payments.CVV);              
                paymentView.ClickOnText("Process Credit Card");
                while (!paymentView.VerifyDoneButtonLoaded(5))
                {
                    System.TimeSpan.FromSeconds(60);
                }
                paymentView.VerifyViewLoadedByText(5, "Payment History");
               
            }else if ((WorkwaveData.Payments.Option).Equals("Visa - 1111 (12/25)"))
            {
                paymentView.SelectType(WorkwaveData.Payments.Option);
                paymentView.ClickOnText("Done");
                //paymentView.VerifyViewLoadedByText(5, Name);
                paymentView.ClickOnButton("Process");
            }
        }

        [When(@"Select Payment Mode OpenEdge")]
        public void WhenSelectPaymentModeOpenEdge(Table data)
        {
            WorkwaveData.Payments = data.CreateInstance<Payments>();
            paymentView.PaymentTypeClick();
            System.TimeSpan.FromSeconds(60);
            paymentView.SelectType(WorkwaveData.Payments.PaymentType);
            System.TimeSpan.FromSeconds(60);
            paymentView.ClickOnText("Done");
            if ((WorkwaveData.Payments.PayTotalDue).Equals("Total Due"))
            {
                paymentView.ClickOnButton("Total Due");
                Assert.True(paymentView.getAmountFieldText().Equals(paymentView.getTotalDue().Replace("$", string.Empty).Replace(",", string.Empty)));
                WorkwaveData.Payments.PaymentAmount = paymentView.getTotalDue();
            }
            else
            {
                //WorkwaveData.Payments.PaymentAmount = WorkwaveMobileSupport.RandomDouble(2);
                paymentView.EnterAmount(WorkwaveData.Payments.PaymentAmount);
                WorkwaveData.Payments.PaymentAmount = "$" + WorkwaveData.Payments.PaymentAmount;
            }
            paymentView.ClickOnText("Please select a credit card");
            Name = WorkwaveMobileSupport.RandomString(5);
            if ((WorkwaveData.Payments.Option).Equals("Enter a new card.."))
            {
                paymentView.SelectType(WorkwaveData.Payments.Option);
                paymentView.ClickOnText("Done");
                paymentView.EnterName(Name);
                paymentView.ClickOnText(WorkwaveData.Payments.Option);
                paymentView.ClickOnText(WorkwaveData.Payments.SaveOption);
                paymentView.ClickOnText("Done");
                paymentView.ClickOnButton("Continue");
                System.TimeSpan.FromSeconds(60);
                while (!paymentView.VerifyAddNewCardViewLoaded(5))
                {
                    System.TimeSpan.FromSeconds(60);
                }

                string message = WorkwaveData.Payments.CardNumber;
                Console.WriteLine(message);
                string[] result = new string[message.Length];
                char[] temp = new char[message.Length];

                temp = message.ToCharArray();
                paymentView.ClickCardNumberTextBox();
                for (int i = 0; i < message.Length; i++)
                {
                    result[i] = Convert.ToString(temp[i]);
                    paymentView.ClickOnKey(result[i]);
                    Console.WriteLine(result[i]);
                }

                paymentView.ClickOnText("Expire Month");
                paymentView.SelectType("12");
                paymentView.ClickOnText("Expire Year");
                paymentView.ClickOnText("Expire Year");
                paymentView.SelectType("2025");
                WorkwaveMobileSupport.TapTargetNoWait(292, 614);

                string cvv = WorkwaveData.Payments.CVV;
                Console.WriteLine(cvv);
                string[] result2 = new string[cvv.Length];
                char[] temp2 = new char[cvv.Length];

                temp2 = cvv.ToCharArray();
                paymentView.ClickCVV();
                for (int i = 0; i < cvv.Length; i++)
                {
                    result2[i] = Convert.ToString(temp2[i]);
                    paymentView.ClickOnKey(result2[i]);
                    Console.WriteLine(result2[i]);
                }


                paymentView.ClickOnText("Make Payment");
                while (!paymentView.VerifyDoneButtonLoaded(5))
                {
                    System.TimeSpan.FromSeconds(60);
                }
                paymentView.VerifyViewLoadedByText(5, "Payment History");

            }
            else if ((WorkwaveData.Payments.Option).Equals("Visa - 0010 (12/25)"))
            {
                paymentView.SelectType(WorkwaveData.Payments.Option);
                paymentView.ClickOnText("Done");
                //paymentView.VerifyViewLoadedByText(5, Name);
                paymentView.ClickOnButton("Process");
            }
        }

        [When(@"Select Payment Mode WWP")]
        public void WhenSelectPaymentModeWWP(Table data)
        {
            WorkwaveData.Payments = data.CreateInstance<Payments>();
            paymentView.PaymentTypeClick();
            System.TimeSpan.FromSeconds(60);
            paymentView.SelectType(WorkwaveData.Payments.PaymentType);
            System.TimeSpan.FromSeconds(60);
            paymentView.ClickOnText("Done");
            if ((WorkwaveData.Payments.PayTotalDue).Equals("Total Due"))
            {
                paymentView.ClickOnButton("Total Due");
                Assert.True(paymentView.getAmountFieldText().Equals(paymentView.getTotalDue().Replace("$", string.Empty).Replace(",", string.Empty)));
                WorkwaveData.Payments.PaymentAmount = paymentView.getTotalDue();
            }
            else
            {
                //WorkwaveData.Payments.PaymentAmount = WorkwaveMobileSupport.RandomDouble(2);
                paymentView.EnterAmount(WorkwaveData.Payments.PaymentAmount);
                WorkwaveData.Payments.PaymentAmount = "$" + WorkwaveData.Payments.PaymentAmount;
            }
            paymentView.ClickOnText("Please select a credit card");
            Name = WorkwaveMobileSupport.RandomString(5);
            if ((WorkwaveData.Payments.Option).Equals("Enter a new card.."))
            {
                paymentView.SelectType(WorkwaveData.Payments.Option);
                paymentView.ClickOnText("Done");
                paymentView.EnterName(Name);
                paymentView.ClickOnText(WorkwaveData.Payments.Option);
                paymentView.ClickOnText(WorkwaveData.Payments.SaveOption);
                paymentView.ClickOnText("Done");
                //paymentView.ClickOnButton("Continue");
                WorkwaveMobileSupport.TapTargetNoWait(553, 1644);
                System.TimeSpan.FromSeconds(60);
                while (!paymentView.VerifyAddNewCardViewLoaded(5))
                {
                    System.TimeSpan.FromSeconds(60);
                }

                string message = WorkwaveData.Payments.CardNumber;
                Console.WriteLine(message);
                string[] result = new string[message.Length];
                char[] temp = new char[message.Length];

                temp = message.ToCharArray();
                //paymentView.ClickCardNumberTextBox();
                WorkwaveMobileSupport.TapTargetNoWait(200, 208);
                while (!paymentView.VerifyDoneButtonLoaded(5))
                {
                    paymentView.ClickCardNumberTextBox();
                }
                System.TimeSpan.FromSeconds(60);
                for (int i = 0; i < message.Length; i++)
                {
                    result[i] = Convert.ToString(temp[i]);
                    paymentView.ClickOnKey(result[i]);
                    Console.WriteLine(result[i]);
                }

                paymentView.ClickOnText("Month");
                paymentView.SelectType("12");
                paymentView.ClickOnText("Expiration Year");
                paymentView.ClickOnText("Expiration Year");
                paymentView.SelectType("2025");
                WorkwaveMobileSupport.TapTargetNoWait(292, 614);

                string cvv = WorkwaveData.Payments.CVV;
                Console.WriteLine(cvv);
                string[] result2 = new string[cvv.Length];
                char[] temp2 = new char[cvv.Length];

                temp2 = cvv.ToCharArray();
                paymentView.ClickCVV();
                for (int i = 0; i < cvv.Length; i++)
                {
                    result2[i] = Convert.ToString(temp2[i]);
                    paymentView.ClickOnKey(result2[i]);
                    Console.WriteLine(result2[i]);
                }


                paymentView.ClickOnText("Process Credit Card");
                while (!paymentView.VerifyDoneButtonLoaded(5))
                {
                    System.TimeSpan.FromSeconds(60);
                }
                paymentView.VerifyViewLoadedByText(5, "Payment History");

            }
            else if ((WorkwaveData.Payments.Option).Equals("Visa - 0006 (12/25)"))
            {
                paymentView.SelectType(WorkwaveData.Payments.Option);
                paymentView.ClickOnText("Done");
                //paymentView.VerifyViewLoadedByText(5, Name);
                paymentView.ClickOnText("Visa - 0006 (12/25)");
                paymentView.ClickOnText("Done");
                paymentView.ClickOnButton("Process");
            }
        }


    }
}
