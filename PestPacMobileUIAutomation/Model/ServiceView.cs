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

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Service Price')]/..//XCUIElementTypeTextField[2]")]
        private IWebElement ServicePrice { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Total']/..//*[@XCElementType='XCUIElementTypeStaticText'][2]")]
        private IWebElement TotalValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@text,'%')]")]
        private IWebElement DiscountValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='UIATabBar']//*[@class='UIAButton'][2]")]
        private IWebElement ProductButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='UIATabBar']//*[@class='UIAButton'][4]")]
        private IWebElement MaterialButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='UIATabBar']//*[@class='UIAButton'][5]")]
        private IWebElement DiscountButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeTextField[3]")]
        private IWebElement PriceField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Quantity']/..//XCUIElementTypeTextField[1]")]
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

        [FindsBy(How = How.XPath, Using = "//*[@text='Do Not Charge for Service']/..//*[@label='0']")]
        private IWebElement DoNotChargeForServiceToggleButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='UIATabBar']//*[@class='UIAButton'][3]")]
        private IWebElement PestButton { get; set; }

        [FindsBy(How = How.Id, Using = "SERVICES")]
        private IWebElement ServiceLabel { get; set; }

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

        public String GetservicePrice()
        {
            String servicePrice = ServicePrice.GetAttribute("text").ToString();         
            return servicePrice;
        }

        double serviceAmount = 0.00;
        public double GetServiceAmount(String Name)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[contains(text(),'" + Name + "')]/..//XCUIElementTypeStaticText[2]"));
            String stringValue = element.GetAttribute("text").ToString();
            String[] amount = stringValue.Split('$');
            String previousAmountS = amount[1].Replace(",", "");
            serviceAmount = double.Parse(previousAmountS);
            return serviceAmount;
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

        public void ClickDiscountButton() => DiscountButton.Click();

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

       

        public bool VerifyServicesViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(ServiceLabel), System.TimeSpan.FromSeconds(time));

        public string getMaterialQuantity() => MaterialQuantityField.GetAttribute("text");

        public IWebElement findDiscount(string text)
        {
            return findListElement(text, "title", "id");
        }

        public string getServicePriceString(String Name) => WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[contains(text(),'" + Name + "')]/..//XCUIElementTypeStaticText[2]")).GetAttribute("text");

        public void EnterServicePrice(string text)
        {
            EnterText(text, ServicePrice);
        }

        public void SwipeToDeleteService(IPerformsTouchActions driver, String Name)
        {
            IWebElement element1 = WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[contains(text(),'" + Name + "')])[1]/..//*[@id='drillDownIcon']"));
            IWebElement element2 = WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[contains(text(),'" + Name + "')])[1]"));
            var touchAction = new TouchAction(driver);
            touchAction.Press(element1).MoveTo(element2).Release().Perform();
        }

        public void DeleteService(String Name)
        {

            SwipeToDeleteService(((AppiumDriver<IWebElement>)WebApplication.Instance.WebDriver), Name);
            System.TimeSpan.FromSeconds(10);
        }

        public void ClickDoNotChargeForServiceToggleButton() => DoNotChargeForServiceToggleButton.Click();

        public bool VerifyServiceAddedWithOutServicePrice(int time, String Text) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[@id='"+Text+"' and  '$0.00']"))), System.TimeSpan.FromSeconds(time));

        public void ClickPestButton() => PestButton.Click();

        double proudctAmount = 0.00;
        public double GetProductAmount(String Product)
        {
            IWebElement element1 = WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[@text='" + Product + "']/..//XCUIElementTypeStaticText[2]"));
            String stringValue = ProductMainSubTotalField.GetAttribute("text").ToString();
            String[] amount = stringValue.Split('$');
            String previousAmountS = amount[1].Replace(",", "");
            proudctAmount = double.Parse(previousAmountS);
            return proudctAmount;
        }

        public double GetProductAmountTwo(String Product)
        {
            IWebElement element1 = WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[@text='" + Product + "']/..//XCUIElementTypeStaticText[3]"));
            String stringValue = ProductMainSubTotalField.GetAttribute("text").ToString();
            String[] amount = stringValue.Split('$');
            String previousAmountS = amount[1].Replace(",", "");
            proudctAmount = double.Parse(previousAmountS);
            return proudctAmount;
        }

        public void ViewServices()
        {

            WorkwaveMobileSupport.SwipeIOSUsingCoordinates(((AppiumDriver<IWebElement>)WebApplication.Instance.WebDriver), 0, 192, 5, -500, 1);
            System.TimeSpan.FromSeconds(10);


        }

        #endregion Behavior

    }
}
