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
    class NoteView : CommonPageObjectsView
    {

        #region Page Factory Setup

        public NoteView() => InitializePageFactoryElements();

        #endregion Page Factory Setup

        #region Page Factory


        [FindsBy(How = How.XPath, Using = "//*[@text='Note']/./..//XCUIElementTypeTextView")]
        private IWebElement NotesTextField { get; set; }


        [FindsBy(How = How.XPath, Using = "(//*[contains(@text,'Notes:')])[1]/../..//*[@text='See All']")]
        private IWebElement NotesSeeAllButton { get; set; }


        #endregion Page Factory

        #region Behavior

        public void EnterNote(string name)
        {
            NotesTextField.Click();
            NotesTextField.SendKeys(name);
            WorkwaveMobileSupport.HideKeyboard();
        }

        public void EditNote(string name)
        {
            EnterText(name, NotesTextField);
        }

        public bool VerifySeeAllViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(NotesSeeAllButton), System.TimeSpan.FromSeconds(time));

        public void ClickOnSeeAll() => NotesSeeAllButton.Click();

        #endregion Behavior

    }
}
