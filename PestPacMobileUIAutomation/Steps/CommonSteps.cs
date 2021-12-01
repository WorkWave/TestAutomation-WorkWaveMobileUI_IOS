using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WorkWave.TA.TestEngine;
using WorkWave.Workwave.Mobile.Model;
using WorkWave.Workwave.Mobile.SharedData;

namespace WorkWave.Workwave.Mobile.Steps
{
    [Binding]
    public sealed class CommonSteps
    {
        WorkwaveData WorkwaveData;

        public CommonSteps(WorkwaveData WorkwaveData)
        {
            this.WorkwaveData = WorkwaveData;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            WebApplication.Instance.StartAppiumStudio();
            WebApplication.Instance.InitializeLogger();

            WebApplication.Instance.CreateNewDriver();
            WebApplication.Log.Info("Created Web Driver: " + WebApplication.Instance.WebDriver.GetType());

            // WorkwaveMobile config
            WorkwaveMobileSupport.InitializeWorkwaveMobileConfig();
        }

        [BeforeFeature]
        public static void LoginBefore()
        {
            LoginPageView loginPg = new LoginPageView();
            TimeSheetPageView timeSheetPageView = new TimeSheetPageView();

            if (!loginPg.VerifyViewLoaded(2))
            {
                if (loginPg.ProgressBarVisible())
                {
                    System.TimeSpan.FromSeconds(30);
                    if (timeSheetPageView.VerifyViewLoaded(2))
                    {
                        timeSheetPageView.ClickOnStaticText("Go To Timesheet");
                    }
                }               
            }
            else if (loginPg.VerifyViewLoaded(2))
            {
                loginPg.LoginAttempt(WorkwaveMobileSupport.DefaultEmail, WorkwaveMobileSupport.DefaultPassword);
            }
        }

        public static void ReturnToDailyView()
        {
            DailyView dailyView = new DailyView();
            CommonPageObjectsView commonPageObjectsView = new CommonPageObjectsView();

            while (!dailyView.VerifyViewLoaded(1))

                commonPageObjectsView.ClickBack();

        }

        [Given(@"Not Started Order Opened")]
        public void GivenNotStartedOrderOpened(Table data)
        {
            WorkwaveData.Order = data.CreateInstance<Order>();
            DailyView dailyView = new DailyView();
            OrderPageView orderPageView = new OrderPageView();
            LoginBefore();
            dailyView.NotStartedOrderClick();
            Assert.True(orderPageView.VerifyViewLoadedByText(5, "Start"));
            WorkwaveData.Order.OrderNumber = orderPageView.GetOrderNumber();
            WorkwaveData.Order.Status = "NOT STARTED";
            WorkwaveData.Order.OrderName = orderPageView.GetOrderName();
        }
    }
}
