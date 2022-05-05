using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WorkWave.Workwave.Mobile.Model;
using WorkWave.Workwave.Mobile.SharedData;

namespace WorkWave.Workwave.Mobile.Steps
{
    [Binding]
    public class SketchSteps
    {
        WorkwaveData WorkwaveData;
        private CommonSteps common;
        SketchView sketchView = new SketchView();
        AttachmentView attachmentView = new AttachmentView();
        String SketchName,Text;

        public SketchSteps(WorkwaveData WorkwaveData)
        {
            this.WorkwaveData = WorkwaveData;
            common = new CommonSteps(WorkwaveData);
        }

        [Given(@"New Sketch Opened")]
        public void GivenNewSketchOpened(Table data)
        {
            WorkwaveData.Sketch = data.CreateInstance<Sketch>();
            sketchView.ClickPlusIcon();
            Assert.True(sketchView.VerifyViewLoadedByHeader(5, "Add"));
            sketchView.ClickOnStaticText("Sketch");
            while (!sketchView.VerifyBackgroundSelectionVisible(5))
            {
                System.TimeSpan.FromSeconds(60);
            }
            sketchView.ClickOnText(WorkwaveData.Sketch.SketchBackground);
        }
        
        //Coordinates are set as per the iphone11 resolutions
        [When(@"Object Added To Sketch")]
        public void WhenObjectAddedToSketch(Table data)
        {
            WorkwaveData.Sketch = data.CreateInstance<Sketch>();
            Assert.True(sketchView.VerifySketchPadVisible(5));
            System.TimeSpan.FromSeconds(60);
            sketchView.ClickOnText(WorkwaveData.Sketch.Tool);
            switch (WorkwaveData.Sketch.Tool)
            {
                case "Objects":
                    if (!sketchView.VerifAllToolHeaderVisible(5))
                    {
                        sketchView.ClickOnText(WorkwaveData.Sketch.Tool);
                    }
                    sketchView.ClickOnText(WorkwaveData.Sketch.SubTool);
                    System.TimeSpan.FromSeconds(60);
                    WorkwaveMobileSupport.TapTargetNoWait(200, 200);
                    break;
                case "Text":                   
                    WorkwaveMobileSupport.TapTargetNoWait(1687, 518);
                    WorkwaveMobileSupport.TapTargetNoWait(700, 200);
                    while (!sketchView.VerifyEnterTextHeaderVisible(5))
                    {
                        WorkwaveMobileSupport.TapTargetNoWait(1687, 518);
                        WorkwaveMobileSupport.TapTargetNoWait(200, 200);
                    }
                    Assert.True(sketchView.VerifyViewLoadedByText(5, "Enter Text"));
                    Text = WorkwaveMobileSupport.RandomString(5);
                    sketchView.EnterTextOnCommonField(Text);
                    sketchView.ClickOnText("Insert");
                    break;
                case "Labels":
                    WorkwaveMobileSupport.TapTargetNoWait(1687, 380);
                    WorkwaveMobileSupport.TapTargetNoWait(200, 200);
                    Assert.True(sketchView.VerifyViewLoadedByText(5, "Label"));
                    sketchView.EnterTextOnCommonField(WorkwaveMobileSupport.RandomString(3));
                    sketchView.ClickOnText("Insert");
                    break;
                case "Draw":
                    WorkwaveMobileSupport.TapTargetNoWait(1687, 242);
                    if(WorkwaveData.Sketch.SubTool.Equals("Arrow"))
                    {
                        sketchView.ClickOnText("SketchArrowDownGray");
                        sketchView.ClickOnText(WorkwaveData.Sketch.SubTool);
                        WorkwaveMobileSupport.TapTargetNoWait(1687, 664);
                        //WorkwaveMobileSupport.TapTargetNoWait(200, 200);
                        //WorkwaveMobileSupport.TapTargetNoWait(400, 400);
                        WorkwaveMobileSupport.LongPressMovePoint(200,200,400,400);
                    }else if (WorkwaveData.Sketch.SubTool.Equals("Rectangle"))
                    {
                        sketchView.ClickOnText("Rect");
                        WorkwaveMobileSupport.LongPressMovePoint(200, 200, 400, 400);
                    }else if(WorkwaveData.Sketch.SubTool.Equals("Straight"))
                    {
                        sketchView.ClickOnText("Straight");
                        WorkwaveMobileSupport.LongPressMovePoint(200, 200, 400, 400);
                    }
                    else if (WorkwaveData.Sketch.SubTool.Equals("Freehand"))
                    {
                        sketchView.ClickOnText("Freehand");
                        WorkwaveMobileSupport.LongPressMovePoint(200, 200, 400, 400);
                    }else if (WorkwaveData.Sketch.SubTool.Equals("Polygon"))
                    {
                        sketchView.ClickOnText("Polygon");
                        WorkwaveMobileSupport.TapTargetNoWait(200, 200);
                        WorkwaveMobileSupport.TapTargetNoWait(200, 400);
                        WorkwaveMobileSupport.TapTargetNoWait(400, 400);
                        WorkwaveMobileSupport.TapTargetNoWait(400, 200);
                        WorkwaveMobileSupport.TapTargetNoWait(200, 200);
                    }

                        break;
                case "Treatment":
                    WorkwaveMobileSupport.TapTargetNoWait(1659, 732);
                    sketchView.ClickOnText(WorkwaveData.Sketch.SubTool);
                    if (WorkwaveData.Sketch.SubTool.Equals("No Material"))
                    {
                        sketchView.ClickButton(WorkwaveData.Sketch.SubTool);
                        sketchView.ClickOnText("Search materials");
                        sketchView.EnterTextToCommonField(WorkwaveData.Sketch.TreatmentMaterial, "Search materials");
                        sketchView.ClickOnText(WorkwaveData.Sketch.TreatmentMaterial);
                        WorkwaveMobileSupport.TapTargetNoWait(200, 200);
                    }
                    else if (WorkwaveData.Sketch.SubTool.Equals("Size"))
                    {
                        for (int i = 1; i <= 3; i++)
                        {
                            WorkwaveMobileSupport.PressMovePoint(1687, 372, 1687, 664);
                            sketchView.ClickOnSizeButton(i.ToString());
                           WorkwaveMobileSupport.TapTargetNoWait(200+i+100, 200+i+100);
                          
                        }
                    }
                         
                    break;

            }
          
        }
        
        [When(@"New Sketch Saved")]
        public void WhenNewSketchSaved(Table data)
        {
            WorkwaveData.Sketch = data.CreateInstance<Sketch>();
            sketchView.ClickCommonSave();
            Assert.True(sketchView.VerifyViewLoadedByHeader(5, "Sketch"));
            WorkwaveData.Sketch.SketchName = WorkwaveData.Sketch.SketchName + WorkwaveMobileSupport.RandomInt(3);
            sketchView.EnterSketchName(WorkwaveData.Sketch.SketchName);
            System.TimeSpan.FromSeconds(30);
            sketchView.ClickOK();
            //WorkwaveMobileSupport.TapTargetNoWait(1200, 550);
            SketchName = WorkwaveData.Sketch.SketchName;
        }
        
        [Then(@"Verify Sketch Added")]
        public void ThenVerifySketchAdded()
        {
            if (sketchView.VerifyOrderPageLoaded(5))
            {
                System.TimeSpan.FromSeconds(30);
            }

            // WorkwaveMobileSupport.SwipeDownIOS("SKETCHES");
            if (!sketchView.VerifySketchHeaderVisible(5))
            {
                System.TimeSpan.FromSeconds(30);
                sketchView.ViewSketches();
            }
          
            if (attachmentView.VerifySeeAllViewLoaded(5))
            {
                attachmentView.ClickOnSeeAll();
            }

            Assert.True(attachmentView.VerifyViewLoadedByContainsText(5, SketchName));
        }

        [When(@"Sketch Deleted")]
        public void WhenSketchDeleted()
        {
            sketchView.ClickOnText(SketchName);
            sketchView.ClickOnStaticText("Clear All");
            System.TimeSpan.FromSeconds(30);
            sketchView.ClickCommonSave();
            sketchView.ClickOnText("Delete");
        }

        [Then(@"Verify Sketch Deleted")]
        public void ThenVerifySketchDeleted()
        {
            Console.WriteLine(SketchName);
            Assert.True(sketchView.findElement(SketchName) == null);
        }

        [When(@"Capture Location Image")]
        public void WhenCaptureLocationImage(Table data)
        {
            WorkwaveData.Attachment = data.CreateInstance<Attachment>();
            sketchView.ClickOnText("camera");
            if (sketchView.VerifyServiceLocationPhotoOptionAlertVisible(5))
            {
                sketchView.ClickOnText("Add New Picture");
            }
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
                    while (!attachmentView.VerifyPlayButtonVisible(5))
                    {
                        attachmentView.ClickOnButton("Record Video");
                        System.TimeSpan.FromSeconds(90);
                        attachmentView.ClickOnButton("Stop Recording Video");
                    }
                    attachmentView.ClickOnText("Use Video");
                    break;
                case "Pick from Gallery":

                    if (!attachmentView.VerifyPhotoViewLoaded(5))
                    {
                        System.TimeSpan.FromSeconds(30);
                    }
                    attachmentView.ClickOnText("All Photos");
                    attachmentView.SelectImageFromGallery();
                    break;
            }
            while (!attachmentView.VerifySaveButtonVisible(5))
            {
                System.TimeSpan.FromSeconds(30);
            }

            attachmentView.ClickOnStaticText("Save");        
        }

        [When(@"Location Image Added To Sketch")]
        public void WhenLocationImageAddedToSketch()
        {
            Assert.True(attachmentView.VerifyViewLoadedByHeader(5, "Images"));
            attachmentView.ClickOnContainsText("Photo");
            sketchView.ClickOnStaticText("Select as Background");
        }

        [When(@"Take Image For Background")]
        public void WhenTakeImageForBackground()
        {
           
            Assert.True(attachmentView.VerifyViewLoadedByText(5, "Camera Mode"));
            attachmentView.ClickOnButton("Take Picture");
            while (!attachmentView.UsePhotoButtonVisible(2))
            {
                System.TimeSpan.FromSeconds(30);
            }
            attachmentView.ClickOnText("Use Photo");
        }

        [When(@"Pick Image For Background")]
        public void WhenPickImageForBackground()
        {
            if (!attachmentView.VerifyPhotoViewLoaded(5))
            {
                System.TimeSpan.FromSeconds(30);
            }
            attachmentView.ClickOnText("All Photos");
            attachmentView.SelectImageFromGallery();
        }

        [When(@"Clear All")]
        public void WhenClearAll()
        {
            attachmentView.ClickOnText("SketchArrowRightSmallBlue");
            attachmentView.ClickOnText("Clear All");
        }

        [Then(@"Verify All Cleared")]
        public void ThenVerifyAllCleared()
        {
            Assert.True(sketchView.findElement(Text) == null);
        }

        [When(@"Undo")]
        public void WhenUndo()
        {
            attachmentView.ClickOnText("Undo");
        }

        [Then(@"Undo Success")]
        public void ThenUndoSuccess()
        {
            Assert.True(sketchView.findElement(Text) != null);
        }

        [When(@"Redo")]
        public void WhenRedo()
        {
            attachmentView.ClickOnText("Redo");
        }

        [Then(@"Redo Success")]
        public void ThenRedoSuccess()
        {
            Assert.True(sketchView.findElement(Text) == null);
        }

    }
}
