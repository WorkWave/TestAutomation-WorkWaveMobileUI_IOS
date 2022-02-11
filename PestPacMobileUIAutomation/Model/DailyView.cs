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
    class DailyView : CommonPageObjectsView
    {

        #region Page Factory Setup

        public DailyView() => InitializePageFactoryElements();

        #endregion Page Factory Setup

        #region Page Factory


        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='TODAY']")]
        private IWebElement TodayHeader { get; set; }

        [FindsBy(How = How.Id, Using = "MenuIcon")]
        private IWebElement MenuBarButton { get; set; }

        [FindsBy(How = How.Id, Using = "Log Out")]
        private IWebElement LogoutButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@text='NOT STARTED'])[1]")]
        private IWebElement NotStartedOption { get; set; }

        #endregion Page Factory

        #region Behavior

        public bool VerifyViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(TodayHeader), System.TimeSpan.FromSeconds(time));

        public void Menu()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(MenuBarButton), System.TimeSpan.FromSeconds(40)))
                MenuBarButton.Click();
        }

        public void LogoutButtonClick() => LogoutButton.Click();

        public void NotStartedOrderClick() => NotStartedOption.Click();

        public bool VerifyNotStartedOrderLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(NotStartedOption), System.TimeSpan.FromSeconds(time));


        #endregion Behavior

    }
}
