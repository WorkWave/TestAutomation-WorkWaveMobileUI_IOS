using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WorkWave.Workwave.Mobile.Model;
using WorkWave.Workwave.Mobile.SharedData;

namespace WorkWave.Workwave.Mobile.Steps
{
    [Binding]
    public class AttachmentsSteps
    {
        WorkwaveData WorkwaveData;
        private CommonSteps common;
        AttachmentView attachmentView = new AttachmentView();
       

        public AttachmentsSteps(WorkwaveData WorkwaveData)
        {
            this.WorkwaveData = WorkwaveData;
            common = new CommonSteps(WorkwaveData);
        }


        [When(@"Attachment Added")]
        public void WhenAttachmentAdded(Table data)
        {
            WorkwaveData.Attachment = data.CreateInstance<Attachment>();
            attachmentView.ClickPlusIcon();
            Assert.True(attachmentView.VerifyViewLoadedByHeader(5, "Add"));
            attachmentView.ClickOnStaticText("Attachments");
            attachmentView.ClickOnText(WorkwaveData.Attachment.Type);
            switch (WorkwaveData.Attachment.Type)
            {
                case "Take a Photo":
                    Assert.True(attachmentView.VerifyViewLoadedByText(5, "Camera Mode"));
                    attachmentView.ClickOnButton("Take Picture");
                    while (!attachmentView.UsePhotoButtonVisible(2))
                    {
                        System.TimeSpan.FromSeconds(30);
                    }
                    attachmentView.ClickOnText("Use Photo");
                    break;
                case "Take a Video":
                    if (attachmentView.VerifyOKButtonVisible(5))
                    {
                        attachmentView.ClickOK();
                    }
                    Assert.True(attachmentView.VerifyViewLoadedByText(5, "Camera Mode"));
                    attachmentView.ClickOnButton("Record Video");
                    System.TimeSpan.FromSeconds(90);
                    attachmentView.ClickOnButton("Stop Recording Video");
                    attachmentView.ClickOnText("Use Video");
                    break;
                case "Pick from Gallery":
                    if (!attachmentView.VerifyPhotoViewLoaded(5))
                    {
                        System.TimeSpan.FromSeconds(30);
                    }
                    attachmentView.SelectImageFromGallery();
                    break;
            }
            while (!attachmentView.VerifySaveButtonVisible(5))
            {
                System.TimeSpan.FromSeconds(30);
            }

            attachmentView.ClickOnStaticText("Save");
        }
        
        [Then(@"Verify Attachment Exists")]
        public void ThenVerifyAttachmentExists()
        {
            WorkwaveMobileSupport.SwipeDownIOS("PAYMENTS");
            if(attachmentView.VerifySeeAllViewLoaded(5))
            {
                attachmentView.ClickOnSeeAll();
            }
            
            Assert.True(attachmentView.VerifyViewLoadedByHeader(5, "Media Gallery"));
           
            switch (WorkwaveData.Attachment.Type)
            {
                case "Take a Photo":
                    Assert.True(attachmentView.VerifyViewLoadedByContainsText(5, "Photo"));
                    break;
                case "Take a Video":
                    Assert.True(attachmentView.VerifyViewLoadedByContainsText(5, "Video"));
                    break;
                case "Pick from Gallery":
                    Assert.True(attachmentView.VerifyViewLoadedByContainsText(5, "Photo"));
                    break;
            }
            attachmentView.ClickBack();
        }

    }
}
