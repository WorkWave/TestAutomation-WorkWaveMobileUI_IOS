using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WorkWave.Workwave.Mobile.Model;
using WorkWave.Workwave.Mobile.SharedData;

namespace WorkWave.Workwave.Mobile.Steps
{
    [Binding]
    public class FormsSteps
    {
        WorkwaveData WorkwaveData;
        private CommonSteps common;
        FormView formView = new FormView();
        OrderPageView orderPageView = new OrderPageView();
        String FormType;

        public FormsSteps(WorkwaveData WorkwaveData)
        {
            this.WorkwaveData = WorkwaveData;
            common = new CommonSteps(WorkwaveData);
        }

        [When(@"Form Added")]
        public void WhenFormAdded(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.ClickPlusIcon();
            Assert.True(formView.VerifyViewLoadedByHeader(5, "Add"));
            formView.ClickOnStaticText("Forms");
            WhenFormTemplatesSearched();
            formView.ClickOnStaticText(FormType);
            formView.VerifyViewLoadedByContainsText(5,FormType);
            formView.ClickOnStaticText("Start");
            WorkwaveData.Form.Text =  WorkwaveMobileSupport.generateRandomString(10);
            formView.EnterOfficeText(WorkwaveData.Form.Text);
            formView.ClickOnStaticText("Complete");
            formView.VerifyViewLoadedByHeader(5, "Complete form");
            formView.ClickOnText("Proceed");
            while (!formView.ShareFormHeaderVisible(2))
            {
                System.TimeSpan.FromSeconds(30);
            }
            formView.ClickOnStaticText("Skip");
            while (!orderPageView.VerifyStartButtonLoaded(2))
            {
                System.TimeSpan.FromSeconds(30);
            }
        }

        [When("Form Templates Searched")]
        public void WhenFormTemplatesSearched()
        {

            while (!formView.NewFormHeaderVisible(2))
            {
                System.TimeSpan.FromSeconds(30);
            }

            formView.ClickSearch();
            Assert.True(formView.VerifySearchOpen(5));
            formView.EnterSearchText(WorkwaveData.Form.FormType);
            FormType = WorkwaveData.Form.FormType;
        }

        [Then(@"Verify Form Added")]
        public void ThenVerifyFormAdded()
        {
            WorkwaveMobileSupport.SwipeDownIOS("PAYMENTS");
            System.TimeSpan.FromSeconds(30);
            WorkwaveMobileSupport.SwipeDownIOS("PAYMENTS");
            System.TimeSpan.FromSeconds(30);
            formView.VerifyViewLoadedByContainsText(5, FormType);
            formView.ClickOnContainsText(FormType);
            formView.VerifyViewLoadedByHeader(5, FormType);
            formView.VerifyViewLoadedByContainsText(5, WorkwaveData.Form.Text);
            formView.ClickOnText("Done");
        }
    }
}
