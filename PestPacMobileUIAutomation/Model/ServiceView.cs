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
    class ServiceView : CommonPageObjectsView
    {

        #region Page Factory Setup

        public ServiceView() => InitializePageFactoryElements();

        #endregion Page Factory Setup

        #region Page Factory

        [FindsBy(How = How.XPath, Using = "//*[@text='Work Order Discounts']/..//*[@XCElementType='XCUIElementTypeStaticText'][2]")]
        private IWebElement WorkOrderDiscountValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Subtotal']/..//*[@XCElementType='XCUIElementTypeStaticText'][2]")]
        private IWebElement SubTotalValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Total']/..//*[@XCElementType='XCUIElementTypeStaticText'][2]")]
        private IWebElement TotalValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@text,'%')]")]
        private IWebElement DiscountValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Tab Bar']//XCUIElementTypeButton[2]")]
        private IWebElement ProductButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeTextField[5]")]
        private IWebElement PriceField { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeTextField[3]")]
        private IWebElement QuantityField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Subtotal']/..//XCUIElementTypeTextField")]
        private IWebElement ProductSubTotalField { get; set; }

        #endregion Page Factory

        #region Behavior

        double discountAmount = 0.00;
        public double GetWorkOrderDiscountValue()
        {
            String stringValue = WorkOrderDiscountValue.GetAttribute("text").ToString();
            String[] amount = stringValue.Split('$');
            String previousAmountS = amount[1].Replace(",","");
            discountAmount = double.Parse(previousAmountS);
            return discountAmount;
        }

        double subTotal = 0.00;
        public double GetSubTotal()
        {
            String stringValue = SubTotalValue.GetAttribute("text").ToString();
            String[] amount = stringValue.Split('$');
            String previousAmountS = amount[1].Replace(",", "");
            subTotal = double.Parse(previousAmountS);
            return subTotal;
        }

        double total = 0.00;
        public double GetTotal()
        {
            String stringValue = TotalValue.GetAttribute("text").ToString();
            String[] amount = stringValue.Split('$');
            String previousAmountS = amount[1].Replace(",", "");
            total = double.Parse(previousAmountS);
            return total;
        }

        public void ClickOnDiscount() => WorkOrderDiscountValue.Click();

        public bool IsDiscountValueExist(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(DiscountValue), System.TimeSpan.FromSeconds(time));

        public void ClickOnDiscountValue() => DiscountValue.Click();

        public void ClickProductButton() => ProductButton.Click();

        public string getPrice() => PriceField.GetAttribute("text");

        public void EnterProductQuantity(string text)
        {
            EnterText(text, QuantityField);
        }

        public string GetProductSubTotal() => ProductSubTotalField.GetAttribute("text");

        double proSubTotal = 0.00;
        public double GetProSubTotalValue()
        {
            String stringValue = ProductSubTotalField.GetAttribute("text").ToString();
            String previousAmountS = stringValue.Replace(",", "");
            proSubTotal = double.Parse(previousAmountS);
            return proSubTotal;
        }

        #endregion Behavior

    }
}
