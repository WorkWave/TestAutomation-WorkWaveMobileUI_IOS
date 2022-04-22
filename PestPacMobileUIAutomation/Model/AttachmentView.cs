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
    class AttachmentView : CommonPageObjectsView
    {

        #region Page Factory Setup

        public AttachmentView() => InitializePageFactoryElements();

        #endregion Page Factory Setup

        #region Page Factory

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeButton[@text='Use Photo']")]
        private IWebElement UsePhotoButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeButton[@text='Photos']")]
        private IWebElement PhotoViewHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='PhotosGridView']//XCUIElementTypeCell[last()]")]
        private IWebElement ImageFromGallery { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[contains(@text,'Attachments:')])[1]/../..//*[@text='See All']")]
        private IWebElement AttachmentsSeeAllButton { get; set; }


        #endregion Page Factory

        #region Behavior

        public bool UsePhotoButtonVisible(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(UsePhotoButton), TimeSpan.FromSeconds(time));

        public bool VerifyPhotoViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(PhotoViewHeader), System.TimeSpan.FromSeconds(time));

        public void SelectImageFromGallery() => ImageFromGallery.Click();

        public void ViewAttachments()
        {

            WorkwaveMobileSupport.SwipeIOSUsingCoordinates(((AppiumDriver<IWebElement>)WebApplication.Instance.WebDriver), 0, 192, 5, -1200, 1);
            System.TimeSpan.FromSeconds(10);


        }

        public bool VerifySeeAllViewLoaded(int time) => SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(AttachmentsSeeAllButton), System.TimeSpan.FromSeconds(time));

        public void ClickOnSeeAll() => AttachmentsSeeAllButton.Click();

        #endregion Behavior

    }
}
