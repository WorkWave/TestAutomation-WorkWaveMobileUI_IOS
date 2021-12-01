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
    class OrderPageView : CommonPageObjectsView
    {

        #region Page Factory Setup

        public OrderPageView() => InitializePageFactoryElements();

        #endregion Page Factory Setup

        #region Page Factory

      
        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeButton[@text='Go To Timesheet']")]
        private IWebElement GoToTimeSheetButton { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Order #")]
        private IWebElement OrderLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='camera'])[2]/../XCUIElementTypeStaticText[2]")]
        private IWebElement OrderNameLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Check Box']/../XCUIElementTypeStaticText[2]")]
        private IWebElement CheckBoxLabel { get; set; }


        #endregion Page Factory

        #region Behavior

        public bool VerifyViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(GoToTimeSheetButton), System.TimeSpan.FromSeconds(time));

        public string GetOrderNumber()
        {
            return OrderLabel.GetAttribute("text");
        }

        public string GetOrderName()
        {
            return OrderNameLabel.GetAttribute("text");
        }

        public string GetCheckBoxText()
        {
            return CheckBoxLabel.GetAttribute("text");
        }

        #endregion Behavior

    }
}
