using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WorkWave.Workwave.Mobile.Model;
using WorkWave.Workwave.Mobile.SharedData;

namespace WorkWave.Workwave.Mobile.Steps
{
    [Binding]
    public class TimeSheetSteps
    {
        WorkwaveData WorkwaveData;
        private CommonSteps common;
        TimeSheetPageView timeSheetPageView = new TimeSheetPageView();

        public TimeSheetSteps(WorkwaveData WorkwaveData)
        {
            this.WorkwaveData = WorkwaveData;
            common = new CommonSteps(WorkwaveData);
        }

        [Then(@"Time All In")]
        public void ThenTimeAllIn(Table data)
        {
            WorkwaveData.TimeSheet = data.CreateInstance<TimeSheet>();
            while (!timeSheetPageView.VerifyTimeAllInButtonLoaded(5))
            {
                if (timeSheetPageView.VerifyReopenTimeSheetViewLoaded(2))
                {
                    Assert.True(timeSheetPageView.VerifyViewLoadedByText(5, "Hi Team Lead"));
                    timeSheetPageView.ClickOnStaticText("Reopen Timesheet");
                }

                if (timeSheetPageView.VerifyViewLoaded(2))
                {
                    Assert.True(timeSheetPageView.VerifyViewLoadedByText(5, "Hi Team Lead"));
                    timeSheetPageView.ClickOnStaticText("Go To Timesheet");
                }
            }
            timeSheetPageView.ClickOnStaticText("Time All In");
        }

        [Then(@"Verify Time All In")]
        public void ThenVerifyTimeAllIn()
        {
            Assert.True(timeSheetPageView.VerifyViewLoadedByText(5, "Time All Out"));
            Assert.True(timeSheetPageView.VerifyStatus(5,"Active:" , WorkwaveData.TimeSheet.TeamCount+"/"+ WorkwaveData.TimeSheet.TeamCount));
            Assert.True(timeSheetPageView.VerifyStatus(5, "Inactive:","0/" + WorkwaveData.TimeSheet.TeamCount));
        }

    }
}
