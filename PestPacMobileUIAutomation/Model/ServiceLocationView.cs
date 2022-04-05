using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWave.TA.TestEngine;

namespace WorkWave.Workwave.Mobile.Model
{
    class ServiceLocationView : CommonPageObjectsView
    {

        #region Page Factory Setup

        public ServiceLocationView() => InitializePageFactoryElements();

        #endregion Page Factory Setup

        #region Page Factory


        [FindsBy(How = How.XPath, Using = "//*[@text='Service Location Contacts']/../following-sibling::XCUIElementTypeCell[1]")]
        private IWebElement PhoneButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@text='Service Location Contacts']/../following-sibling::XCUIElementTypeCell[2]")]
        private IWebElement EmailButton { get; set; }


        #endregion Page Factory

        #region Behavior

        public void ClickOnPhoneButton() => PhoneButton.Click();

        public void ClickOnEmailButton() => EmailButton.Click();

        #endregion Behavior

    }
}
