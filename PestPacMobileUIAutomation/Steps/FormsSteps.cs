﻿using NUnit.Framework;
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
            formView.ClickOnStaticText(WorkwaveData.Form.FormType);
            Assert.True(formView.VerifyViewLoadedByContainsText(5, WorkwaveData.Form.FormType));
            formView.ClickOnStaticText("Start");
            WorkwaveData.Form.Text =  WorkwaveMobileSupport.generateRandomString(10);
            formView.EnterOfficeText(WorkwaveData.Form.Text);
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
         
        }

        [When(@"Complete Form")]
        public void WhenCompleteForm()
        {
            formView.ClickOnStaticText("Complete");
            Assert.True(formView.VerifyViewLoadedByHeader(5, "Complete form"));
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


        [Then(@"Verify Form Added")]
        public void ThenVerifyFormAdded()
        {
            WorkwaveMobileSupport.SwipeDownIOS("PAYMENTS");
            System.TimeSpan.FromSeconds(30);
            WorkwaveMobileSupport.SwipeDownIOS("PAYMENTS");
            System.TimeSpan.FromSeconds(30);
            Assert.True( formView.VerifyViewLoadedByContainsText(5, WorkwaveData.Form.FormType));
            Assert.True(formView.VerifyViewLoadedByText(5, "Complete"));
            formView.ClickOnContainsText(WorkwaveData.Form.FormType);
            Assert.True(formView.VerifyViewLoadedByHeader(5, WorkwaveData.Form.FormType));
            Assert.True(formView.VerifyViewLoadedByContainsText(5, WorkwaveData.Form.Text));
            formView.ClickOnText("Done");
        }

       

        [When(@"Save Form As A Draft")]
        public void WhenSaveFormAsADraft()
        {
            formView.ClickTopMenuButton();
            formView.ClickOnText("Save Draft");
            formView.ClickFormBackButton();
        }

        [Then(@"Verify Form Drafted")]
        public void ThenVerifyFormDrafted()
        {
            WorkwaveMobileSupport.SwipeDownIOS("PAYMENTS");
            System.TimeSpan.FromSeconds(30);
            WorkwaveMobileSupport.SwipeDownIOS("PAYMENTS");
            System.TimeSpan.FromSeconds(30);
            Assert.True(formView.VerifyViewLoadedByContainsText(5, WorkwaveData.Form.FormType));
            Assert.True(formView.VerifyViewLoadedByText(5, "Draft"));
        }

        [When(@"Drafted Form Opened")]
        public void WhenDraftedFormOpened()
        {
            formView.ClickOnContainsText( WorkwaveData.Form.FormType);
            while (!formView.EditDraftLabelVisible(2))
            {
                System.TimeSpan.FromSeconds(30);
            }
            Assert.True(formView.VerifyViewLoadedByContainsText(5, WorkwaveData.Form.FormType));
            formView.ClickOnText("Edit Draft");
        }

        [When(@"Preview Form")]
        public void WhenPreviewForm()
        {
            formView.ClickOnText("Preview");
        }

        [Then(@"Verify Preview Loaded")]
        public void ThenVerifyPreviewLoaded()
        {
            Assert.True(formView.VerifyViewLoadedByHeader(5, "Preview"));
            Assert.True(formView.VerifyViewLoadedByText(5, "Share"));
            formView.ClickOnText("Done");
        }

    }
}
