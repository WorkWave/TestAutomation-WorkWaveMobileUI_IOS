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
    class PaymentView : CommonPageObjectsView
    {

        #region Page Factory Setup

        public PaymentView() => InitializePageFactoryElements();

        #endregion Page Factory Setup

        #region Page Factory

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='Payments']")]
        private IWebElement PaymentHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Payment Type']/../XCUIElementTypeTextField[1]")]
        private IWebElement PaymentType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Amount']/../XCUIElementTypeTextField[2]")]
        private IWebElement AmountField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Total Due:']/preceding-sibling::XCUIElementTypeStaticText[1]")]
        private IWebElement TotalDueField { get; set; }

        #endregion Page Factory

        #region Behavior

        public void PaymentTypeClick() => PaymentType.Click();

        public string getAmountFieldText() => AmountField.GetAttribute("text");

        public string getTotalDue() => TotalDueField.GetAttribute("text");

        public void EnterAmount(string name)
        {
            EnterText(name, AmountField);
        }

        public bool VerifyPaymentsViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(PaymentHeader), System.TimeSpan.FromSeconds(time));


        #endregion Behavior

    }
}
