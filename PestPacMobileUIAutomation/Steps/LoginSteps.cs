using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WorkWave.Workwave.Mobile.Model;
using WorkWave.Workwave.Mobile.SharedData;

namespace WorkWave.Workwave.Mobile.Steps
{
    [Binding]
    public class LoginSteps
    {
        WorkwaveData WorkwaveData;
        private CommonSteps common;
        LoginPageView loginPg = new LoginPageView();
        DailyView dailyView = new DailyView();
        TimeSheetPageView timeSheetPageView = new TimeSheetPageView();

        public LoginSteps(WorkwaveData WorkwaveData)
        {
            this.WorkwaveData = WorkwaveData;
            common = new CommonSteps(WorkwaveData);
        }

        [Given(@"Logged Out")]
        public void GivenLoggedOut()
        {
            if (!loginPg.VerifyViewLoaded(2))
            {
                if (loginPg.ProgressBarVisible())
                {
                    System.TimeSpan.FromSeconds(30);
                }
                dailyView.Menu();
                dailyView.LogoutButtonClick();
                Assert.True(loginPg.VerifyViewLoadedByHeader(5, "Attention"));
                loginPg.ClickOk();
            }
            
        }
        
        [When(@"I Login")]
        public void WhenILogin(Table data)
        {
            WorkwaveData.Login = data.CreateInstance<Login>();
            loginPg.LoginAttempt(WorkwaveData.Login.Email, WorkwaveData.Login.Password);
        }
        
        [Then(@"Verify logged in")]
        public void ThenVerifyLoggedIn()
        {
            while (!dailyView.VerifyViewLoaded(5))
            {
                if (loginPg.ProgressBarVisible())
                {
                    System.TimeSpan.FromSeconds(30);
                }
                if(timeSheetPageView.VerifyViewLoaded(5))
                {
                    timeSheetPageView.ClickOnStaticText("Go To Timesheet");
                    Assert.True(loginPg.VerifyViewLoadedByHeader(5, "Timesheets"));
                    timeSheetPageView.ClickOnStaticText("Time In");
                    timeSheetPageView.ClickBack();
                }
                
            }
            
        }
        
        [Then(@"Verify invalid email")]
        public void ThenVerifyInvalidEmail()
        {
            Assert.True(loginPg.VerifyViewLoadedByText(5, "Invalid username or password"));
        }
    }
}
