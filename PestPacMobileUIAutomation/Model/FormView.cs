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
    class FormView : CommonPageObjectsView
    {
        #region Page Factory Setup

        public FormView() => InitializePageFactoryElements();

        #endregion Page Factory Setup

        #region Page Factory

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='New Form']")]
        private IWebElement NewFormsHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='Share Form']")]
        private IWebElement ShareFormsHeader { get; set; }

        [FindsBy(How = How.Id, Using = "searchBlue")]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@value='Search']")]
        public IWebElement SearchTextFeild { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeOther[@text='Office Text']")]
        private IWebElement OfficeTextTextField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Edit Draft']")]
        public IWebElement EditDraftLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='FormBackArrow']/..//*[@class='UIAButton'][2]")]
        public IWebElement FormTopMenu { get; set; }

        [FindsBy(How = How.Id, Using = "FormBackArrow")]
        private IWebElement FormBackButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@text='FormBookmarkedFilled']/preceding-sibling::XCUIElementTypeStaticText[1])[1]")]
        private IWebElement FavoriteFormName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Button: Office Image']")]
        public IWebElement InsertButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeButton[@text='Photos']")]
        private IWebElement PhotoViewHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "(//XCUIElementTypeImage[contains(text(),'Photo')])[1]")]
        private IWebElement ImageFromGallery { get; set; }

        #endregion Page Factory

        #region Behavior

        public bool NewFormHeaderVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(NewFormsHeader), TimeSpan.FromSeconds(time));

        public void ClickSearch() => SearchButton.Click();

        public bool VerifySearchOpen(int time)
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(SearchTextFeild), System.TimeSpan.FromSeconds(time)))
                return true;
            return false;
        }

        public void EnterSearchText(string text)
        {
            EnterText(text, SearchTextFeild);
        }

        public void EnterOfficeText(string text)
        {
            EnterText(text, OfficeTextTextField);
        }

        public bool ShareFormHeaderVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(ShareFormsHeader), TimeSpan.FromSeconds(time));

        public bool EditDraftLabelVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(EditDraftLabel), TimeSpan.FromSeconds(time));

        public void ClickTopMenuButton() => FormTopMenu.Click();

        public void ClickFormBackButton() => FormBackButton.Click();

        public void ClickOnFavourite(String Name)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[contains(text(),'" + Name + "')]/..//*[@id='FormBookmarkedNotFilled']"));
            element.Click();
        }

        public bool VerifyFormAdded(int time, String Text) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(WebApplication.Instance.WebDriver.FindElement(By.XPath("//XCUIElementTypeOther[@text='FAVORITES']/..//*[@text='" + Text + "']"))), System.TimeSpan.FromSeconds(time));

        public string getFavoriteFormName()
        {
            return FavoriteFormName.GetAttribute("text");
        }

        public void ClickOnUnFavourite(String Name)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[contains(text(),'" + Name + "')]/..//*[@id='FormBookmarkedFilled']"));
            element.Click();
        }        

        public IWebElement findFormEntryFromFavorites(string type)
        {
            return findListElementContainer(type, "//XCUIElementTypeOther[@text='FAVORITES']/..//*[@text='" + type + "']", "Title", "xpath", "id");
        }

        public void ClickInsertButton() => InsertButton.Click();

        public bool VerifyPhotoViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(PhotoViewHeader), System.TimeSpan.FromSeconds(time));

        public void SelectImageFromGallery() => ImageFromGallery.Click();

        #endregion Behavior
    }
}
