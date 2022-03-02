﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWave.TA.TestEngine;

namespace WorkWave.Workwave.Mobile.Model
{
    class FormView : CommonPageObjectsView
    {
        #region Page Factory Setup

        public FormView() => InitializePageFactoryElements();

        #endregion Page Factory Setup

        #region Page Factory

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='New Form']")]
        private IWebElement NewFormsHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='Share Form']")]
        private IWebElement ShareFormsHeader { get; set; }

        [FindsBy(How = How.Id, Using = "searchBlue")]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@value='Search']")]
        public IWebElement SearchTextFeild { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeOther[@text='Office Text']")]
        private IWebElement OfficeTextTextField { get; set; }

        #endregion Page Factory

        #region Behavior

        public bool NewFormHeaderVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(NewFormsHeader), TimeSpan.FromSeconds(time));

        public void ClickSearch() => SearchButton.Click();

        public bool VerifySearchOpen(int time)
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(SearchTextFeild), System.TimeSpan.FromSeconds(time)))
                return true;
            return false;
        }

        public void EnterSearchText(string text)
        {
            EnterText(text, SearchTextFeild);
        }

        public void EnterOfficeText(string text)
        {
            EnterText(text, OfficeTextTextField);
        }

        public bool ShareFormHeaderVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(ShareFormsHeader), TimeSpan.FromSeconds(time));

        #endregion Behavior
    }
}