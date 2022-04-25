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

        public bool VerifyTeamMemberStatus(int time,String index, String Status)
        {
            return SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[@class='UIATable']//*[@accessibilityLabel='AddIconCell'])[" + index + "]//*[@text='" + Status + "']"))), System.TimeSpan.FromSeconds(time));
        }

        public bool VerifyStatusUpdated(int time, String index,String Text) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[contains(@text,'" + Text + "')])[" + index + "]"))), System.TimeSpan.FromSeconds(time));

        public void ClickOnEventButton(String Name)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[contains(text(),'" + Name + "')]/../XCUIElementTypeButton[2]"));
            element.Click();
        }
        public bool VerifyTechnicianStatus(int time, String OrderName, String Status)
        {
            return SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[@text='" + OrderName + "']/..//*[contains(@text,'" + Status + "')]"))), System.TimeSpan.FromSeconds(time));
        }

        #endregion Behavior

    }
}
