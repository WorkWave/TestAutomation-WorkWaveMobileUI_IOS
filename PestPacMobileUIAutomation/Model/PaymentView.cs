using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
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

        [FindsBy(How = How.XPath, Using = "//*[@text='Check Number']/following-sibling::XCUIElementTypeTextField[1]")]
        private IWebElement CheckNumberField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Reference']/following-sibling::XCUIElementTypeTextField[1]")]
        private IWebElement ReferenceField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Name On Card']/../XCUIElementTypeTextField[5]")]
        private IWebElement NameOnCard { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Cancel']")]
        private IWebElement CancelLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='CVV'])[2]")]
        private IWebElement CVV_TextField { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='UIATextField'])[2]")]
        private IWebElement CVV_TextFieldTwo { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='UIATextField'])[1]")]
        private IWebElement CardNumberTextField { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='Continue']")]
        private IWebElement ContinueButtton { get; set; }

        #endregion Page Factory

        #region Behavior

        public void PaymentTypeClick() => PaymentType.Click();

        public string getAmountFieldText() => AmountField.GetAttribute("text");

        public string getTotalDue() => TotalDueField.GetAttribute("text");

        public void EnterAmount(string name)
        {
            EnterText(name, AmountField);
        }

        public void EnterCheckNumber(string name)
        {
            EnterText(name, CheckNumberField);
        }

        public void EnterReference(string name)
        {
            EnterText(name, ReferenceField);
        }

        public void ViewPayment()
        {

            WorkwaveMobileSupport.SwipeIOSUsingCoordinates(((AppiumDriver<IWebElement>)WebApplication.Instance.WebDriver), 0, 192, 100, -3500, 1);
            System.TimeSpan.FromSeconds(10);


        }

        public bool VerifyPaymentsViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(PaymentHeader), System.TimeSpan.FromSeconds(time));

        public void EnterName(string name)
        {
            EnterText(name, NameOnCard);
        }

        public bool VerifyAddNewCardViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(CancelLabel), System.TimeSpan.FromSeconds(time));

        public void EnterCVV(string name)
        {
            EnterText(name, CVV_TextField);
        }

        public void EnterCVVTwo(string name)
        {
            EnterText(name, CVV_TextFieldTwo);
        }

        public void ClickCardNumberTextBox() => CardNumberTextField.Click();

        public void ClickCVV() => CVV_TextFieldTwo.Click();

        public void EnterCardNumber(string name)
        {

            CardNumberTextField.SendKeys(name);
            //WorkwaveMobileSupport.HideKeyboard();
        }
        public bool VerifyContinueButtonLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(ContinueButtton), System.TimeSpan.FromSeconds(time));

        public void ClickContinueButton() => ContinueButtton.Click();

        #endregion Behavior

    }
}
