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
    class SketchView : CommonPageObjectsView
    {

        #region Page Factory Setup

        public SketchView() => InitializePageFactoryElements();

        #endregion Page Factory Setup

        #region Page Factory

        [FindsBy(How = How.Id, Using = "SketchPadBase")]
        private IWebElement SketchPad { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[contains(@text,'Notes:')])[1]/../..//*[@text='See All']")]
        private IWebElement NotesSeeAllButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Enter the Sketch name']/..//XCUIElementTypeTextField")]
        private IWebElement SketchNameTextField { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='What kind of background would you like to load ?']")]
        private IWebElement BackgroundHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='All Tools']")]
        private IWebElement AllToolButton { get; set; }


        #endregion Page Factory

        #region Behavior

        public bool VerifySketchPadVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(SketchPad), TimeSpan.FromSeconds(time));

        public bool VerifyBackgroundSelectionVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(BackgroundHeader), System.TimeSpan.FromSeconds(time));

        public void EnterSketchName(string text)
        {
            EnterText(text, SketchNameTextField);
        }

        public bool VerifAllToolHeaderVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(AllToolButton), TimeSpan.FromSeconds(time));

        public void ClickOnSizeButton(String Index)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[@text='Color']/../following-sibling::XCUIElementTypeCell["+ Index + "]"));
            element.Click();
        }
        #endregion Behavior

    }
}
