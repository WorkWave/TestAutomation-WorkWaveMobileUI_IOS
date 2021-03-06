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
    class CommonPageObjectsView
    {

        #region Page Factory Setup

        public CommonPageObjectsView() => InitializePageFactoryElements();

        public void InitializePageFactoryElements() => PageFactory.InitElements(WebApplication.Instance.WebDriver, this);

        #endregion Page Factory Setup

        #region Page Factory

        [FindsBy(How = How.Id, Using = "Back")]
        private IWebElement BackButton { get; set; }

        [FindsBy(How = How.Id, Using = "BackArrowWhite")]
        private IWebElement BackTwoButton { get; set; }

        [FindsBy(How = How.Id, Using = "leftArrow")]
        private IWebElement BackButtonTwo { get; set; }

        [FindsBy(How = How.Id, Using = "FormBackArrow")]
        private IWebElement FormBackButton { get; set; }

        [FindsBy(How = How.Id, Using = "OK")]
        private IWebElement OKButton { get; set; }

        [FindsBy(How = How.Id, Using = "Ok")]
        private IWebElement OkButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='UIATextField']")]
        private IWebElement CommonTextField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@XCElementType='XCUIElementTypeTextView']")]
        private IWebElement MultiLineTextField { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='Save']")]
        private IWebElement SaveButton { get; set; }

        [FindsBy(How = How.Id, Using = "Save")]
        private IWebElement SaveCommonButton { get; set; }

        [FindsBy(How = How.Id, Using = "plusButtonIcon")]
        private IWebElement PlusIcon { get; set; }

        [FindsBy(How = How.Id, Using = "AddIconLarge")]
        private IWebElement AddIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='TODAY']")]
        private IWebElement TodayIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeButton[@text='Delete']")]
        private IWebElement DeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Play']")]
        private IWebElement PlayButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Next Order']")]
        private IWebElement NextOrderButton { get; set; }

        [FindsBy(How = How.Id, Using = "Done")]
        private IWebElement DoneButton { get; set; }

        #endregion Page Factory

        #region Behavior

        public void EnterText(string text, IWebElement field)
        {
            field.Click();
            if (!field.GetAttribute("text").Equals(""))
                field.Clear();
            field.SendKeys(text);
            WorkwaveMobileSupport.HideKeyboard();
        }

        public void ClickBack() => BackButton.Click();

        public void ClickFormBack() => FormBackButton.Click();

        public void ClickBackTwo() => BackButtonTwo.Click();

        public void ClickOnButton(String Name)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[contains(text(),'" + Name + "')]/../XCUIElementTypeButton[1]"));
            element.Click();
        }

        public void ClickButton(String Name)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("//XCUIElementTypeButton[@text='" + Name + "']"));
            element.Click();
        }

        public void ClickOnArrowFollowingToText(String Name)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[contains(text(),'" + Name + "')]/..//*[@id='drillDownIcon']"));
            element.Click();
        }

        public void ClickOnArrowFollowingToTextTwo(String Name)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[contains(text(),'" + Name + "')]/..//*[@id='chevron']"));
            element.Click();
        }

        public void ClickOnStaticText(String Text)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("//XCUIElementTypeStaticText[@text='" + Text + "']"));
            element.Click();
        }

        public void ClickOnLastStaticText(String Text)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("(//XCUIElementTypeStaticText[@text='" + Text + "'])[last()]"));
            element.Click();
        }

        public void ClickOnText(String Text)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[@text='" + Text + "']"));
            element.Click();
        }
        public void ClickOnTextTwo(String Text)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[@text='" + Text + "'])[2]"));
            element.Click();
        }

        public void ClickOnTextThree(String Text)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[@text='" + Text + "'])[3]"));
            element.Click();
        }

        public void ClickOnContainsText(String Text)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[contains(text(),'" + Text + "')]"));
            element.Click();
        }

        public void ClickOnCheckBoxValue(String Text)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[@text='Check Box'])[2]//*[@text='" + Text + "']"));
            element.Click();
        }

        public bool VerifyViewLoadedByHeader(int time, String Header) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(WebApplication.Instance.WebDriver.FindElement(By.XPath("//XCUIElementTypeStaticText[@text='" + Header + "']"))), System.TimeSpan.FromSeconds(time));

        public bool VerifyOKButtonVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(OKButton), System.TimeSpan.FromSeconds(time));

        public bool VerifySaveButtonVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(SaveButton), System.TimeSpan.FromSeconds(time));

        public bool VerifyViewLoadedByText(int time, String Text) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[@text='" + Text + "']"))), System.TimeSpan.FromSeconds(time));

        public bool VerifyViewLoadedByContainsText(int time, String Text) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[contains(@text,'" + Text + "')]"))), System.TimeSpan.FromSeconds(time));

        public void ClickOK() => OKButton.Click();

        public void ClickOk() => OkButton.Click();

        public bool VerifyStatus(int time, String OrderName, String Status)
        {
            return SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[@text='" + OrderName + "']/..//*[@text='" + Status + "']"))), System.TimeSpan.FromSeconds(time));
        }


        public void EnterTextOnCommonField(string name)
        {
            EnterText(name, CommonTextField);
        }
        public void ClickOnCommonField() => CommonTextField.Click();

        public String selectDate()
        {
            String UpdatedDate = null;

            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            var dates = Convert.ToDateTime(tomorrow);
            UpdatedDate = dates.ToString("MM/dd/yyy");
            Console.WriteLine(UpdatedDate);

            IWebElement DatePickerWheel = WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[@XCElementType='XCUIElementTypePickerWheel'])[2]"));

            //IList<IWebElement> Columns = DatePickerWheel.FindElements(By.XPath("(//XCUIElementTypePickerWheel)[2]"));
            //Columns.ElementAt(1).SendKeys(UpdatedDate);
            //Columns.ElementAt(1).SendKeys(UpdatedDate);
            DatePickerWheel.SendKeys(UpdatedDate);

            return UpdatedDate;
        }

        public void ClickPlusIcon() => PlusIcon.Click();

        public void ClickAddIcon() => AddIcon.Click();

        public IList<IWebElement> findElementsGivenByType(string id, string byType)
        {
            IList<IWebElement> elems = null;
            switch (byType)
            {
                case "xpath":
                    elems = WebApplication.Instance.WebDriver.FindElements(By.XPath(id));
                    break;
                case "id":
                    elems = WebApplication.Instance.WebDriver.FindElements(By.Id(id));
                    break;
                case "class":
                    elems = WebApplication.Instance.WebDriver.FindElements(By.ClassName(id));
                    break;
            }
            return elems;
        }

        public IWebElement findListElement(string name, string id, string byType)
        {
            int index = 1;
            IWebElement currElem = null;
            IList<IWebElement> allElements = null;
            string prevLastFoundElem = "";
            try
            {
                allElements = findElementsGivenByType(id, byType);
            }
            catch
            {
                return null;
            }

            if (allElements.Count == 0)
                return null;

            if (name.Equals("") || name.Equals("ANY"))
                return allElements[index - 1];

            while (index < allElements.Count + 1)
            {
                try
                {
                    currElem = allElements[index - 1];

                    if (index == allElements.Count && prevLastFoundElem.Equals(currElem.GetAttribute("text")))
                        break;

                    if (currElem.GetAttribute("text").Equals(name))
                        return currElem;

                    if (index == allElements.Count)
                    {
                        prevLastFoundElem = currElem.GetAttribute("text");
                        WorkwaveMobileSupport.Swipe(-1139);
                        allElements = findElementsGivenByType(id, byType);
                        index = 1;
                    }
                    else
                        index++;

                }
                catch
                {
                    break;
                }
            }

            return null;
        }
        public void EnterTextCommonField(string text, string fieldName)
        {
            IWebElement field = WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[@text='" + fieldName + "']/../../XCUIElementTypeTextField"));
            field.Click();
            if (!field.GetAttribute("text").Equals(""))
                field.Clear();
            field.SendKeys(text);
            WorkwaveMobileSupport.HideKeyboard();
        }

        

        public void EnterTextCommonFieldTwo(string text, string fieldName)
        {
            IWebElement field = WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[@text='" + fieldName + "'])[2]"));
            field.Click();
            if (!field.GetAttribute("text").Equals(""))
                field.Clear();
            field.SendKeys(text);
            WorkwaveMobileSupport.HideKeyboard();
        }

        public void EnterTextToCommonField(string text, string fieldName)
        {
            IWebElement field = WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[@text='" + fieldName + "'])[1]"));
            field.Click();
            if (!field.GetAttribute("text").Equals(""))
                field.Clear();
            field.SendKeys(text);
            WorkwaveMobileSupport.HideKeyboard();
        }

        public void ClickCommonSave() => SaveCommonButton.Click();

        public IWebElement findElement(string name)
        {
            return findListElement(name, name, "id");
        }

        public void SelectType(String Type)
        {

            AppiumWebElement PickerWheel = (AppiumWebElement)WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[@class='UIAPickerWheel']"));
            PickerWheel.SetImmediateValue(Type);
        }

        public bool MainBackButtonVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(BackButton), TimeSpan.FromSeconds(time));

        public bool MainBackButtonTwoVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(BackTwoButton), TimeSpan.FromSeconds(time));

        public void ClickMainBackButtonTwo() => BackTwoButton.Click();

        public bool HomePageLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(TodayIcon), TimeSpan.FromSeconds(time));

        public IWebElement findElementGivenByType(string id, string byType, IWebElement container)
        {
            IWebElement elem = null;
            switch (byType)
            {
                case "xpath":
                    elem = container.FindElement(By.XPath(id));
                    break;
                case "id":
                    elem = container.FindElement(By.Id(id));
                    break;
                case "class":
                    elem = container.FindElement(By.ClassName(id));
                    break;
            }
            return elem;
        }

        public IWebElement findListElementContainer(string name, string container, string id, string containerByType, string byType)
        {
            int index = 1;
            IWebElement currElem = null;
            IList<IWebElement> allElements = null;
            string prevLastFoundElem = "";
            try
            {
                allElements = findElementsGivenByType(container, containerByType);
                if (allElements.Count == 0)
                    return null;
            }
            catch
            {
                return null;
            }

            if (name.Equals("") || name.Equals("ANY"))
                return allElements[index - 1];

            while (index < allElements.Count + 1)
            {
                try
                {
                    currElem = findElementGivenByType(id, byType, allElements[index - 1]);

                    if (index == allElements.Count && prevLastFoundElem.Equals(currElem.GetAttribute("text")))
                        break;

                    if (currElem.GetAttribute("text").Equals(name))
                        return allElements[index - 1];

                    if (index == allElements.Count)
                    {
                        prevLastFoundElem = currElem.GetAttribute("text");
                        WorkwaveMobileSupport.Swipe(-1139);
                        allElements = findElementsGivenByType(container, containerByType);
                        index = 1;
                    }
                    else
                        index++;

                }
                catch
                {
                    break;
                }
            }

            return null;
        }

        public bool DeleteButtonVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(DeleteButton), TimeSpan.FromSeconds(time));


        public void SwipeDown()
        {

            WorkwaveMobileSupport.SwipeIOSUsingCoordinates(((AppiumDriver<IWebElement>)WebApplication.Instance.WebDriver), 0, 192, 5, -5000, 1);
            System.TimeSpan.FromSeconds(10);


        }

        public bool FormBackButtonVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(FormBackButton), TimeSpan.FromSeconds(time));

        public void EnterTextOnMultiLineField(string name)
        {
            EnterText(name, MultiLineTextField);
        }

        public bool VerifyViewLoaded(int time, String Header) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(WebApplication.Instance.WebDriver.FindElement(By.Id(Header))), System.TimeSpan.FromSeconds(time));

        public bool VerifyPlayButtonVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(PlayButton), System.TimeSpan.FromSeconds(time));

      
        public bool VerifyOrderPageLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(NextOrderButton), System.TimeSpan.FromSeconds(time));

        public void ClickOnKey(String Name)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("//XCUIElementTypeKey[@text='"+ Name + "']"));
            element.Click();
        }

        public bool VerifyDoneButtonLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(DoneButton), System.TimeSpan.FromSeconds(time));

        #endregion Behavior
    }
}
