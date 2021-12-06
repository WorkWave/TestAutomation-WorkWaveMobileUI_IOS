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


        [FindsBy(How = How.XPath, Using = "//*[@text='Start typing note…']")]
        private IWebElement NotesTextField { get; set; }

        #endregion Page Factory

        #region Behavior

        public void EnterNote(string name)
        {
            NotesTextField.Click();
            NotesTextField.SendKeys(name);
            WorkwaveMobileSupport.HideKeyboard();
        }


        #endregion Behavior

    }
}
