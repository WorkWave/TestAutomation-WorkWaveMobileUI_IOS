using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WorkWave.Workwave.Mobile.Model;
using WorkWave.Workwave.Mobile.SharedData;

namespace WorkWave.Workwave.Mobile.Steps
{
    [Binding]
    public class OrderSteps
    {
        WorkwaveData WorkwaveData;
        private CommonSteps common;
        OrderPageView orderPageView = new OrderPageView();
        ServiceLocationView serviceLocationView = new ServiceLocationView();
        String Date = null;

        public OrderSteps(WorkwaveData WorkwaveData)
        {
            this.WorkwaveData = WorkwaveData;
            common = new CommonSteps(WorkwaveData);
        }
       
        [When(@"Order Started")]
        public void WhenOrderStarted()
        {
            orderPageView.ClickOnStaticText("Start");
            WorkwaveData.Order.Status = "IN PROGRESS";
        }
        
        [When(@"Order Completed")]
        public void WhenOrderCompleted()
        {
            orderPageView.ClickOnStaticText(WorkwaveData.Order.OrderName);
            Assert.True(orderPageView.VerifyViewLoadedByText(5, "Stop"));
            orderPageView.ClickOnText("Stop");
            orderPageView.ClickOnText("No, Thanks");
            WorkwaveData.Order.Status = "COMPLETE";
        }
        
        [Then(@"Verify Order Started")]
        public void ThenVerifyOrderStarted()
        {
            Assert.True(orderPageView.VerifyViewLoadedByText(5, "Stop"));            
        }
        
        [Then(@"Verify Order Completed")]
        public void ThenVerifyOrderCompleted()
        {
            Assert.True(orderPageView.VerifyViewLoadedByText(5, "Email/Print"));
        }
        
        [Then(@"Verify Appointment Card Status")]
        public void ThenVerifyAppointmentCardStatus()
        {
            orderPageView.ClickBack();
            orderPageView.VerifyStatus(5, WorkwaveData.Order.OrderName, WorkwaveData.Order.Status);
        }

        [Given(@"Viewing Service Location Custom Fields")]
        public void GivenViewingServiceLocationCustomFields(Table data)
        {
            WorkwaveData.Order = data.CreateInstance<Order>();
            common.GivenNotStartedOrderOpened(data);
            orderPageView.ClickOnStaticText("Show More");
            Assert.True(orderPageView.VerifyViewLoadedByHeader(5, "Service Location"));
        }

        [When(@"Custom Field Selected")]
        public void WhenCustomFieldSelected(Table data)
        {
            WorkwaveData.Order = data.CreateInstance<Order>();
            if (orderPageView.VerifyOKButtonVisible(5))
            {
                orderPageView.ClickOK();
            }
            orderPageView.ClickOnStaticText(WorkwaveData.Order.CustomFieldName);
            Assert.True(orderPageView.VerifyViewLoadedByHeader(5, WorkwaveData.Order.CustomFieldName));

        }

        [When(@"Custom Field Edited")]
        public void WhenCustomFieldEdited(Table data)
        {
            WorkwaveData.Order = data.CreateInstance<Order>();
            switch (WorkwaveData.Order.CustomFieldType)
            {
                case "Text":
                    WorkwaveData.Order.CustomFieldValue = WorkwaveMobileSupport.generateRandomString(5);
                    orderPageView.EnterTextOnCommonField(WorkwaveData.Order.CustomFieldValue);
                    System.TimeSpan.FromSeconds(30);
                    orderPageView.ClickOK();
                    break;
                case "Check Box":
                    orderPageView.ClickOnCheckBoxValue(WorkwaveData.Order.WorkOrderCustomFields);
                    WorkwaveData.Order.CustomFieldValue = WorkwaveData.Order.WorkOrderCustomFields;
                    break;
                case "Date":
                    Date=orderPageView.selectDate();
                    orderPageView.ClickOnStaticText("Save");
                    WorkwaveData.Order.CustomFieldValue = Date;
                    break;
                case "Drop-down":
                    orderPageView.ClickOnText("1");
                    orderPageView.ClickOnStaticText("Save");
                    WorkwaveData.Order.CustomFieldValue = "1";
                    break;
                case "Quantity":
                    WorkwaveData.Order.CustomFieldValue = WorkwaveMobileSupport.RandomInt(5);
                    orderPageView.EnterTextOnCommonField(WorkwaveData.Order.CustomFieldValue);
                    orderPageView.ClickOK();
                    break;
                case "Multi Line":
                    WorkwaveData.Order.CustomFieldValue = WorkwaveMobileSupport.generateRandomString(5);
                    orderPageView.EnterTextOnMultiLineField(WorkwaveData.Order.CustomFieldValue);
                    orderPageView.ClickOnText("Save");
                    break;
            }
        }

        [Then(@"Verify Custom Field Edited")]
        public void ThenVerifyCustomFieldEdited()
        {
            Assert.True(orderPageView.VerifyViewLoadedByText(5, WorkwaveData.Order.CustomFieldValue));
        }

        [Then(@"Verify Edited Custom Field")]
        public void ThenVerifyEditedCustomField()
        {
            Assert.True(orderPageView.VerifyViewLoadedByContainsText(5, WorkwaveData.Order.CustomFieldValue));
        }


        [Given(@"Viewing Work Order Custom Fields")]
        public void GivenViewingWorkOrderCustomFields(Table data)
        {
            WorkwaveData.Order = data.CreateInstance<Order>();
            common.GivenNotStartedOrderOpened(data);
            orderPageView.ClickOnStaticText("Work Order Custom Fields");
            Assert.True(orderPageView.VerifyViewLoadedByHeader(5, "Work Order Custom Fields"));
        }

        [When(@"Traits Field Edited")]
        public void WhenTraitsFieldEdited()
        {
            WorkwaveData.Order.CustomFieldValue = WorkwaveMobileSupport.RandomInt(5);
            orderPageView.EnterTextOnCommonField(WorkwaveData.Order.CustomFieldValue);
            orderPageView.ClickOK();
            if (orderPageView.VerifyOKButtonVisible(5))
            {
                orderPageView.ClickOK();
            }
        }

        [When(@"View Service Location Contacts")]
        public void WhenViewServiceLocationContacts()
        {
            WorkwaveMobileSupport.SwipeDownIOS("SERVICE LOCATION CONTACTS");
            System.TimeSpan.FromSeconds(60);

        }

        [When(@"Access the phone")]
        public void WhenAccessThePhone()
        {
            serviceLocationView.ClickOnPhoneButton();
        }

        [Then(@"Verify the Contact by Phone Opened")]
        public void ThenVerifyTheContactByPhoneOpened()
        {
            Assert.True(orderPageView.VerifyViewLoadedByContainsText(5, "Call"));
            orderPageView.ClickOnText("Cancel");
        }

        [When(@"Access the Email")]
        public void WhenAccessTheEmail()
        {
            serviceLocationView.ClickOnEmailButton();
        }

        [Then(@"Verify the Contact by Email Opened")]
        public void ThenVerifyTheContactByEmailOpened()
        {
            Assert.True(orderPageView.VerifyViewLoadedByText(5, "Send"));
            Assert.True(orderPageView.VerifyViewLoadedByText(5, "Mail.ccBccMultiField"));
            Assert.True(orderPageView.VerifyViewLoadedByText(5, "Subject: "));
        }


    }
}
