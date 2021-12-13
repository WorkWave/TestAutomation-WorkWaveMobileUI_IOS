using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
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

        [FindsBy(How = How.XPath, Using = "//*[@text='Tab Bar']//XCUIElementTypeButton[4]")]
        private IWebElement MaterialButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeTextField[5]")]
        private IWebElement PriceField { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeTextField[3]")]
        private IWebElement QuantityField { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeTextField[1]")]
        private IWebElement MaterialQuantityField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Subtotal']/..//XCUIElementTypeTextField")]
        private IWebElement ProductSubTotalField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Subtotal']/..//XCUIElementTypeStaticText[2]")]
        private IWebElement ProductMainSubTotalField { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[contains(@text,'$')])[last()-1]")]
        private IWebElement ProductValue { get; set; }

        [FindsBy(How = How.Id, Using = "Subtotal")]
        private IWebElement SubTotalValueLabel { get; set; }

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

        public void ClickMaterialButton() => MaterialButton.Click();

        public string getPrice() => PriceField.GetAttribute("text");

        public void EnterProductQuantity(string text)
        {
            EnterText(text, QuantityField);
        }

        public void EnterMaterialQuantity(string text)
        {
            EnterText(text, MaterialQuantityField);
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

        double proMainSubTotal = 0.00;
        public double GetProMainSubTotalValue()
        {
            String stringValue = ProductMainSubTotalField.GetAttribute("text").ToString();
            String[] amount = stringValue.Split('$');
            String previousAmountS = amount[1].Replace(",", "");
            proMainSubTotal = double.Parse(previousAmountS);
            return proMainSubTotal;
        }

        public string getFirstProPrice(String Name) => WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[@text='" + Name + "'])[1]/..//XCUIElementTypeStaticText[3]")).GetAttribute("text");

        double productValue = 0.00;
        public double GetproductValue()
        {
            String stringValue = ProductValue.GetAttribute("text").ToString();
            String[] amount = stringValue.Split('$');
            String previousAmountS = amount[1].Replace(",", "");
            productValue = double.Parse(previousAmountS);
            return productValue;
        }

        public double GetFirstproductValue(String Name)
        {
            IWebElement element1 = WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[@text='" + Name + "'])[1]/..//XCUIElementTypeStaticText[3]"));
            String stringValue = element1.GetAttribute("text").ToString();
            String[] amount = stringValue.Split('$');
            String previousAmountS = amount[1].Replace(",", "");
            productValue = double.Parse(previousAmountS);
            return productValue;
        }

        public void SwipeToDeleteProduct(IPerformsTouchActions driver, String Name)
        {
            IWebElement element1 = WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[@text='" + Name + "'])[1]/..//*[@id='chevron']"));
            IWebElement element2 = WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[@text='" + Name + "'])[1]"));
            var touchAction = new TouchAction(driver);
            touchAction.Press(element1).MoveTo(element2).Release().Perform();
        }

        public void DeleteProductMaterial(String Name)
        {

            SwipeToDeleteProduct(((AppiumDriver<IWebElement>)WebApplication.Instance.WebDriver), Name);
            System.TimeSpan.FromSeconds(10);
        }

        public IWebElement findElement(string name)
        {
            return findListElement(name, name, "id");
        }

        public bool VerifyServicesViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(SubTotalValueLabel), System.TimeSpan.FromSeconds(time));

        public string getMaterialQuantity() => MaterialQuantityField.GetAttribute("text");

        #endregion Behavior

    }
}
