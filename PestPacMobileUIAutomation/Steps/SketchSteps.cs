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
        String SketchName;

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
                    WorkwaveMobileSupport.TapTargetNoWait(200, 200);
                    Assert.True(sketchView.VerifyViewLoadedByText(5, "Enter Text"));
                    sketchView.EnterTextOnCommonField(WorkwaveMobileSupport.RandomString(5));
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
                    }
                    WorkwaveMobileSupport.TapTargetNoWait(200, 200);                
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

            WorkwaveMobileSupport.SwipeDownIOS("SKETCHES");
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

    }
}
