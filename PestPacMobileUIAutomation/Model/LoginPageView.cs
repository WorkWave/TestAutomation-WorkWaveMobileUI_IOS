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
    class LoginPageView : CommonPageObjectsView
    {

        #region Page Factory Setup

        public LoginPageView() => InitializePageFactoryElements();

        #endregion Page Factory Setup

        #region Page Factory

        [FindsBy(How = How.XPath, Using = "//*[@text='Email']")]
        private IWebElement EmailTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Password']")]
        private IWebElement PasswordTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeButton[@text='Log In']")]
        private IWebElement LoginButton { get; set; }

       

        [FindsBy(How = How.Id, Using = "Downloading...")]
        private IWebElement ProgressBar { get; set; }

        #endregion Page Factory

        #region Behavior

        public bool VerifyViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(EmailTextBox), System.TimeSpan.FromSeconds(time));

        public bool EmailTextBoxVisible() => EmailTextBox.Displayed;
        public void ClearEmail() => EmailTextBox.Clear();

        public void EnterEmail(string email) => EmailTextBox.SendKeys(email);

        public void ClearPassword() => PasswordTextbox.Clear();

        public void EnterPassword(string pass) => PasswordTextbox.SendKeys(pass);

        public void Login() => LoginButton.Click();

        public bool ProgressBarVisible()
        {
            if (WorkwaveMobileSupport.IsDisplayed(ProgressBar))
                return true;
            return false;
        }

        #endregion Behavior

        #region Behavior Support

        public void LoginAttempt(string email, string password)
        {
            EmailTextBox.Click();
            ClearEmail();
            EnterEmail(email);
            WorkwaveMobileSupport.HideKeyboard();
            PasswordTextbox.Click();
            ClearPassword();
            EnterPassword(password);    
            WorkwaveMobileSupport.HideKeyboard();
            Login();
        }

        #endregion Behavior Support
    }
}
