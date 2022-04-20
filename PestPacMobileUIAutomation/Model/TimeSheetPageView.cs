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
    class TimeSheetPageView : CommonPageObjectsView
    {

        #region Page Factory Setup

        public TimeSheetPageView() => InitializePageFactoryElements();

        #endregion Page Factory Setup

        #region Page Factory

      
        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeButton[@text='Go To Timesheet']")]
        private IWebElement GoToTimeSheetButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeButton[@text='Reopen Timesheet']")]
        private IWebElement ReopenTimeSheetButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeButton[@text='Time All In']")]
        private IWebElement TimeAllInButton { get; set; }


        #endregion Page Factory

        #region Behavior

        public bool VerifyViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(GoToTimeSheetButton), System.TimeSpan.FromSeconds(time));

        public bool VerifyReopenTimeSheetViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(ReopenTimeSheetButton), System.TimeSpan.FromSeconds(time));

        public bool VerifyTimeAllInButtonLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(TimeAllInButton), System.TimeSpan.FromSeconds(time));

        #endregion Behavior

    }
}
