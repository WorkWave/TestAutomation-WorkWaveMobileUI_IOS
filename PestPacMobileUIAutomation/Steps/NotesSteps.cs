using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WorkWave.Workwave.Mobile.Model;
using WorkWave.Workwave.Mobile.SharedData;

namespace WorkWave.Workwave.Mobile.Steps
{
    [Binding]
    public class NotesSteps
    {

        WorkwaveData WorkwaveData;
        private CommonSteps common;
        NoteView noteView = new NoteView();

        public NotesSteps(WorkwaveData WorkwaveData)
        {
            this.WorkwaveData = WorkwaveData;
            common = new CommonSteps(WorkwaveData);
        }

        [When(@"New Note Opened")]
        public void WhenNewNoteOpened()
        {
            noteView.ClickPlusIcon();
            Assert.True(noteView.VerifyViewLoadedByHeader(5, "Add"));
            noteView.ClickOnStaticText("Notes");
        }
        
        [When(@"Note Modified")]
        public void WhenNoteModified(Table data)
        {
            WorkwaveData.Note = data.CreateInstance<Note>();

            WorkwaveData.Note.NoteText += WorkwaveMobileSupport.generateRandomString(10);
            noteView.EnterNote(WorkwaveData.Note.NoteText);
            noteView.ClickOnText(WorkwaveData.Note.NoteStatus);
            noteView.ClickOnText("Save");
            Assert.True(noteView.VerifyViewLoadedByText(5, "Start"));
        }
        
        [Then(@"Verify Note Exists")]
        public void ThenVerifyNoteExists()
        {
            WorkwaveMobileSupport.SwipeDownIOS("NOTES");
            Assert.True(noteView.VerifyViewLoadedByText(5, WorkwaveData.Note.NoteText));
        }
    }
}
