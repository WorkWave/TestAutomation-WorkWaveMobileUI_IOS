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
        OrderPageView orderPageView = new OrderPageView();
        DailyView dailyView = new DailyView();
        CommonPageObjectsView commonPageObjectsView = new CommonPageObjectsView();

        public TimeSheetSteps(WorkwaveData WorkwaveData)
        {
            this.WorkwaveData = WorkwaveData;
            common = new CommonSteps(WorkwaveData);
        }

        [When(@"Time All In")]
        public void WhenTimeAllIn(Table data)
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
                if (dailyView.VerifyViewLoaded(1))
                {
                    timeSheetPageView.ClickOnText("whiteClock");
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
            int count = int.Parse(WorkwaveData.TimeSheet.TeamCount);
            for (int i = 1; i <= count; i++)
            {
                Assert.True(timeSheetPageView.VerifyTeamMemberStatus(5, i.ToString(), "Active"));
            }
        }

        [When(@"Time All Out")]
        public void WhenTimeAllOut(Table data)
        {
            WorkwaveData.TimeSheet = data.CreateInstance<TimeSheet>();
            timeSheetPageView.ClickOnStaticText("Time All Out");
        }

        [Then(@"Verify Time All Out")]
        public void ThenVerifyTimeAllOut()
        {
            Assert.True(timeSheetPageView.VerifyViewLoadedByText(5, "Time All In"));
            Assert.True(timeSheetPageView.VerifyStatus(5, "Active:", "0/" + WorkwaveData.TimeSheet.TeamCount));
            Assert.True(timeSheetPageView.VerifyStatus(5, "Inactive:", WorkwaveData.TimeSheet.TeamCount+"/" + WorkwaveData.TimeSheet.TeamCount));
            int count = int.Parse(WorkwaveData.TimeSheet.TeamCount);
            for (int i = 1; i <= count; i++)
            {
                Assert.True(timeSheetPageView.VerifyTeamMemberStatus(5, i.ToString(), "Inactive"));
            }
        }

       
        [When(@"Add Team Event")]
        public void WhenAddTeamEvent(Table data)
        {
            WorkwaveData.TimeSheet = data.CreateInstance<TimeSheet>();
            timeSheetPageView.ClickPlusIcon();
            Assert.True(timeSheetPageView.VerifyViewLoadedByText(5, "Add Team Event"));
            timeSheetPageView.ClickOnText(WorkwaveData.TimeSheet.Event);           
        }

        [Then(@"Verify Team Event Added")]
        public void ThenVerifyTeamEventAdded()
        {
            switch (WorkwaveData.TimeSheet.Event)
            {
                case "Team Lunch":
                    Assert.True(timeSheetPageView.VerifyViewLoadedByText(5, "Team Timesheets"));
                    Assert.True(timeSheetPageView.VerifyStatus(5, "Travel/Breaks:", WorkwaveData.TimeSheet.TeamCount + "/" + WorkwaveData.TimeSheet.TeamCount));
                    int count = int.Parse(WorkwaveData.TimeSheet.TeamCount);
                    for (int i = 1; i <= count; i++)
                    {
                        Assert.True(timeSheetPageView.VerifyStatusUpdated(5, i.ToString(), "On Lunch"));
                        Assert.True(timeSheetPageView.VerifyTeamMemberStatus(5, i.ToString(), "End Lunch"));
                    }
                    break;
                case "Team Break":
                    Assert.True(timeSheetPageView.VerifyViewLoadedByText(5, "Team Timesheets"));
                    Assert.True(timeSheetPageView.VerifyStatus(5, "Travel/Breaks:", WorkwaveData.TimeSheet.TeamCount + "/" + WorkwaveData.TimeSheet.TeamCount));
                    count = int.Parse(WorkwaveData.TimeSheet.TeamCount);
                    for (int i = 1; i <= count; i++)
                    {
                        Assert.True(timeSheetPageView.VerifyStatusUpdated(5, i.ToString(), "On Break"));
                        Assert.True(timeSheetPageView.VerifyTeamMemberStatus(5, i.ToString(), "End Break"));
                    }
                    break;
                case "Team Travel Time":
                    Assert.True(timeSheetPageView.VerifyViewLoadedByText(5, "Team Timesheets"));
                    Assert.True(timeSheetPageView.VerifyStatus(5, "Travel/Breaks:", WorkwaveData.TimeSheet.TeamCount + "/" + WorkwaveData.TimeSheet.TeamCount));
                    count = int.Parse(WorkwaveData.TimeSheet.TeamCount);
                    for (int i = 1; i <= count; i++)
                    {
                        Assert.True(timeSheetPageView.VerifyStatusUpdated(5, i.ToString(), "Traveling"));
                        Assert.True(timeSheetPageView.VerifyTeamMemberStatus(5, i.ToString(), "End Travel"));
                    }
                    break;

            }
        }

        [When(@"End Team Event for All")]
        public void WhenEndTeamEventForAll(Table data)
        {
            WorkwaveData.TimeSheet = data.CreateInstance<TimeSheet>();
            timeSheetPageView.ClickOnStaticText("End Event for All");
        }

        [Then(@"Verify End Team Event")]
        public void ThenVerifyEndTeamEvent()
        {
            switch (WorkwaveData.TimeSheet.Event)
            {
                case "Team Lunch":
                    Assert.True(timeSheetPageView.VerifyStatus(5, "Travel/Breaks:", "0/" + WorkwaveData.TimeSheet.TeamCount));
                    int count = int.Parse(WorkwaveData.TimeSheet.TeamCount);
                    for (int i = 1; i <= count; i++)
                    {
                        Assert.True(timeSheetPageView.VerifyTeamMemberStatus(5, i.ToString(), "Active"));
                    }
                    break;

            }
        }

        [When(@"Time Single Technician In")]
        public void WhenTimeSingleTechnicianIn(Table data)
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
                if (dailyView.VerifyViewLoaded(1))
                {
                    timeSheetPageView.ClickOnText("whiteClock");
                }
            }
            timeSheetPageView.ClickOnButton(WorkwaveData.TimeSheet.TeamMemberName);
        }

        [Then(@"Verify Time Single Technician In")]
        public void ThenVerifyTimeSingleTechnicianIn()
        {
            Assert.True(timeSheetPageView.VerifyViewLoadedByText(5, "pauseIcon"));
            Assert.True(timeSheetPageView.VerifyStatus(5, WorkwaveData.TimeSheet.TeamMemberName,"Active"));
            Assert.True(timeSheetPageView.VerifyStatus(5, "Active:", "1/" + WorkwaveData.TimeSheet.TeamCount));           
        }

        [When(@"Time Single Technician Out")]
        public void WhenTimeSingleTechnicianOut()
        {
            timeSheetPageView.ClickOnButton(WorkwaveData.TimeSheet.TeamMemberName);
        }

        [Then(@"Verify Time Single Technician Out")]
        public void ThenVerifyTimeSingleTechnicianOut()
        {
            Assert.True(timeSheetPageView.VerifyStatus(5, WorkwaveData.TimeSheet.TeamMemberName, "Inactive"));
            Assert.True(timeSheetPageView.VerifyStatus(5, "Active:", "0/" + WorkwaveData.TimeSheet.TeamCount));
            Assert.True(timeSheetPageView.VerifyStatus(5, "Inactive:", WorkwaveData.TimeSheet.TeamCount + "/" + WorkwaveData.TimeSheet.TeamCount));

        }

        [When(@"Add Event for Single Technician")]
        public void WhenAddEventForSingleTechnician(Table data)
        {
            WorkwaveData.TimeSheet = data.CreateInstance<TimeSheet>();
            timeSheetPageView.ClickOnEventButton(WorkwaveData.TimeSheet.TeamMemberName);
            Assert.True(timeSheetPageView.VerifyViewLoadedByText(5, "Add Event"));
            timeSheetPageView.ClickOnText(WorkwaveData.TimeSheet.Event);
        }

        [Then(@"Verify Add Event for Single Technician")]
        public void ThenVerifyAddEventForSingleTechnician()
        {
            Assert.True(timeSheetPageView.VerifyViewLoadedByText(5, "Team Timesheets"));
            timeSheetPageView.ClickBack();
            timeSheetPageView.ClickOnText("whiteClock");
            Assert.True(timeSheetPageView.VerifyStatus(5, "Travel/Breaks:", "1/" + WorkwaveData.TimeSheet.TeamCount));
           
            if (WorkwaveData.TimeSheet.Event.Equals("Travel Time"))
            {
                Assert.True(timeSheetPageView.VerifyStatus(5, WorkwaveData.TimeSheet.TeamMemberName, "End Travel"));
                Assert.True(timeSheetPageView.VerifyTechnicianStatus(5, WorkwaveData.TimeSheet.TeamMemberName, "Traveling"));
            }
            else
            {
                Assert.True(timeSheetPageView.VerifyStatus(5, WorkwaveData.TimeSheet.TeamMemberName, "End " + WorkwaveData.TimeSheet.Event));
                Assert.True(timeSheetPageView.VerifyTechnicianStatus(5, WorkwaveData.TimeSheet.TeamMemberName, "On " + WorkwaveData.TimeSheet.Event));
            }
           

        }

        [When(@"End Event for Single Technician")]
        public void WhenEndEventForSingleTechnician()
        {
            
            if (WorkwaveData.TimeSheet.Event.Equals("Travel Time"))
            {
                timeSheetPageView.ClickOnText("End Travel");
            }
            else
            {
                timeSheetPageView.ClickOnText("End " + WorkwaveData.TimeSheet.Event);
            }
        }

        [Then(@"Verify End Event for Single Technician")]
        public void ThenVerifyEndEventForSingleTechnician()
        {
            Assert.True(timeSheetPageView.VerifyViewLoadedByText(5, "pauseIcon"));
            Assert.True(timeSheetPageView.VerifyStatus(5, WorkwaveData.TimeSheet.TeamMemberName, "Active"));
            Assert.True(timeSheetPageView.VerifyStatus(5, "Active:", "1/" + WorkwaveData.TimeSheet.TeamCount));
        }

        [When(@"Start WorkOrder Without TimeIn")]
        public void WhenStartWorkOrderWithoutTimeIn()
        {
            while (!dailyView.VerifyViewLoaded(1))
            {
                if (commonPageObjectsView.MainBackButtonVisible(5))
                {
                    commonPageObjectsView.ClickBack();
                }
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
               
            while (!dailyView.VerifyNotStartedOrderLoaded(5))
            {
                WorkwaveMobileSupport.Swipe(-1139);
            }
            dailyView.NotStartedOrderClick();
            Assert.True(orderPageView.VerifyViewLoadedByText(5, "Start"));   
            orderPageView.ClickOnText("Start");
        }

        [Then(@"Verify Not Able to Start WorkOrder Without TimeIn")]
        public void ThenVerifyNotAbleToStartWorkOrderWithoutTimeIn()
        {
            Assert.True(timeSheetPageView.VerifyViewLoadedByText(5, "Checking if at least one member of your team is timed in"));
            Assert.True(timeSheetPageView.VerifyViewLoadedByText(5, "Not Timed In"));
            Assert.True(timeSheetPageView.VerifyViewLoadedByText(5, "Please time in for the day before starting a work order."));
            orderPageView.ClickOnText("OK");
            commonPageObjectsView.ClickBack();
        }


    }
}
