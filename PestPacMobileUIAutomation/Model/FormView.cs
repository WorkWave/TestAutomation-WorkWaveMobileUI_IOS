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
        private IWebElement OfficeTextField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Office Text: ')]")]
        private IWebElement EditedOfficeTextField { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Button: Image')]")]
        public IWebElement CommonInsertImageButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='Photos']")]
        private IWebElement PhotoViewHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='PhotosGridView']//XCUIElementTypeCell[last()]")]
        private IWebElement ImageFromGallery { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Button: Customer Image']")]
        public IWebElement CustomerImageInsertButton { get; set; }

        [FindsBy(How = How.Id, Using = "CameraMode")]
        private IWebElement CameraView { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeButton[@text='Use Photo']")]
        private IWebElement UsePhotoView { get; set; }

        [FindsBy(How = How.Id, Using = "SketchArrowRightSmallBlue")]
        private IWebElement BottomExpandArrowButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='Images']")]
        private IWebElement ImageView { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[contains(text(),'Photo')])[1]")]
        private IWebElement LocationImage { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeAlert[@text='Service Location Photo Option']")]
        private IWebElement PhotoOptionAlert { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@text='FORMS']/../following-sibling::XCUIElementTypeOther[1]//*[@text='See All'])[1]")]
        public IWebElement FormSeeAllButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@text='Draft'])[1]/..//XCUIElementTypeStaticText[3]")]
        private IWebElement DraftedFormName { get; set; }

        [FindsBy(How = How.Id, Using = "FormSideMenu")]
        private IWebElement SideMenuButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@value='Type to search']")]
        private IWebElement SearchTextField { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='Complete']")]
        private IWebElement CompleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@value='Has comment'])[1]")]
        private IWebElement FilledTextField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Role']/../XCUIElementTypeTextField")]
        private IWebElement RoleTextField { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='Preview']")]
        private IWebElement PreviewButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Done']")]
        private IWebElement DoneButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='Sketches']")]
        private IWebElement SketchesHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='Leave without saving']")]
        private IWebElement LeaveWithoutSavingButton { get; set; }

        [FindsBy(How = How.Id, Using = "Take another image")]
        private IWebElement TakeAnotherImageButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@text='Clear All Fields']")]
        private IWebElement ClearAllButton { get; set; }

        [FindsBy(How = How.Id, Using = "SketchArrowLeftSmallBlue")]
        private IWebElement ExpandLeftButton { get; set; }

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
            EnterText(text, OfficeTextField);
        }

        public bool ShareFormHeaderVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(ShareFormsHeader), TimeSpan.FromSeconds(time));

        public bool EditDraftLabelVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(EditDraftLabel), TimeSpan.FromSeconds(time));

        public void ClickTopMenuButton() => FormTopMenu.Click();

        public void ClickFormBackButton() => FormBackButton.Click();

        public void ClickOfficeTextField() => EditedOfficeTextField.Click();

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

        public void ClickCustomerImageInsertButton() => CustomerImageInsertButton.Click();

        public bool VerifyCameraViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(CameraView), System.TimeSpan.FromSeconds(time));

        public bool VerifyUsePhotoViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(UsePhotoView), System.TimeSpan.FromSeconds(time));

        public void ClickBottomExpandArrowButton() => BottomExpandArrowButton.Click();

        public bool VerifyImageViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(ImageView), System.TimeSpan.FromSeconds(time));

        public void ClickFirstLocationImage() => LocationImage.Click();

        public bool PhotoOptionAlertVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(PhotoOptionAlert), System.TimeSpan.FromSeconds(time));

        public void ClickFormSeeAllButton() => FormSeeAllButton.Click();

        public string getDraftedFormName()
        {
            return DraftedFormName.GetAttribute("text");
        }

        public void DeleteForm(String Name)
        {

            SwipeToDeleteForm(((AppiumDriver<IWebElement>)WebApplication.Instance.WebDriver), Name);
            System.TimeSpan.FromSeconds(10);
        }

        public void SwipeToDeleteForm(IPerformsTouchActions driver, String Name)
        {
            IWebElement element1 = WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[@text='" + Name + "']/..//*[@text='chevron']"));
            IWebElement element2 = WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[@id='" + Name + "']"));
            var touchAction = new TouchAction(driver);
            touchAction.Press(element1).MoveTo(element2).Release().Perform();
        }

        public void ClickSideMenuButton() => SideMenuButton.Click();

        public void EnterFeildName(string text)
        {
            EnterText(text, SearchTextField);
        }

        public bool VerifyFieldStatus(int time, String FieldName, String Status)
        {
            return SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[@text='"+FieldName+"'])[2]/..//*[@text='"+Status+"']"))), System.TimeSpan.FromSeconds(time));
        }

        public void ClickOnSearchedFeild(String Text)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[@text='" + Text + "'])[2]"));
            element.Click();
        }

        public bool VerifyCompleteButtonVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(CompleteButton), System.TimeSpan.FromSeconds(time));
    
        public bool VerifySignedFormDisplayed(int time, String FormName)
        { 
            return SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[@text='" + FormName + "']/..//*[@text='Signed']"))), System.TimeSpan.FromSeconds(time));
        }

        public void ClickFilledTextField() => FilledTextField.Click();

        public string getFilledFieldValue()
        {
            return FilledTextField.GetAttribute("text");
        }

        public void SelectRole(String Type)
        {
            RoleTextField.Click();
            //AppiumWebElement PickerWheel = (AppiumWebElement)WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[@class='UIAPicker']"));
            //PickerWheel.SetImmediateValue(Type);
            WorkwaveMobileSupport.TapTargetNoWait(554,2050);
        }

        public bool VerifyFormStatus(int time, String FieldName, String Status)
        {
            return SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(WebApplication.Instance.WebDriver.FindElement(By.XPath("//*[contains(text(),'" + FieldName + "')]/..//*[@text='" + Status + "']"))), System.TimeSpan.FromSeconds(time));
        }


        public string getRoleValue()
        {
            return RoleTextField.GetAttribute("text");
        }

        public bool VerifyPreviewButtonLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(PreviewButton), System.TimeSpan.FromSeconds(time));

        public bool VerifyDoneButtonLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(DoneButton), System.TimeSpan.FromSeconds(time));

        public void ClickOnForm(String Text,String Status)
        {
            IWebElement element = WebApplication.Instance.WebDriver.FindElement(By.XPath("(//*[contains(text(),'"+Text+"')])[1]/..//*[@text='"+Status+"']"));
            element.Click();
        }

        public void ClickInsertImageButton() => CommonInsertImageButton.Click();

        public bool VerifySketchesHeaderVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(SketchesHeader), System.TimeSpan.FromSeconds(time));

        public bool LeaveWithoutSavingVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(LeaveWithoutSavingButton), TimeSpan.FromSeconds(time));

        public void ViewForms()
        {

            WorkwaveMobileSupport.SwipeIOSUsingCoordinates(((AppiumDriver<IWebElement>)WebApplication.Instance.WebDriver), 0, 192, 5, -500, 1);
            System.TimeSpan.FromSeconds(10);

        }

        public bool VerifyFormSeeAllButtonLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(FormSeeAllButton), System.TimeSpan.FromSeconds(time));

        public bool VerifyTakeAnotherIamgeButtonLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(TakeAnotherImageButton), System.TimeSpan.FromSeconds(time));

        public bool VerifyClearAllButtonLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(ClearAllButton), System.TimeSpan.FromSeconds(time));

        public void ClickLeftExpandButton() => ExpandLeftButton.Click();
        #endregion Behavior
    }
}
