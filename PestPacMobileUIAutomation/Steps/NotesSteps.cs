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

        [When(@"Note Added")]
        public void WhenNoteAdded(Table data)
        {
            WorkwaveData.Note = data.CreateInstance<Note>();

            WorkwaveData.Note.NoteText += WorkwaveMobileSupport.generateRandomString(10);
            noteView.EnterNote(WorkwaveData.Note.NoteText);
            noteView.ClickOnText(WorkwaveData.Note.NoteStatus);
            noteView.ClickOnText("Save");
            Assert.True(noteView.VerifyViewLoadedByText(5, "Start"));
        }


        [When(@"Note Modified")]
        public void WhenNoteModified(Table data)
        {
            WorkwaveData.Note = data.CreateInstance<Note>();
            WorkwaveData.Note.NoteText += WorkwaveMobileSupport.generateRandomString(10);
            noteView.EditNote(WorkwaveData.Note.NoteText);
            noteView.ClickOnText(WorkwaveData.Note.NoteStatus);
            noteView.ClickOnText("Save");
            Assert.True(noteView.VerifyViewLoadedByText(5, "Start"));
            WorkwaveMobileSupport.SwipeUpIOS("NOTES");
        }
        
        [Then(@"Verify Note Exists")]
        public void ThenVerifyNoteExists()
        {
            noteView.ViewNotes();
            //if (noteView.VerifySeeAllViewLoaded(5))
            //{
            //    noteView.ClickOnSeeAll();
            //}
            System.TimeSpan.FromSeconds(60);
            noteView.ClickPlusIcon();
            noteView.ClickClose();
            System.TimeSpan.FromSeconds(60);
            Assert.True(noteView.VerifyViewLoadedByContainsText(5, WorkwaveData.Note.NoteText));
        }

        [When(@"Existing Note Selected")]
        public void WhenExistingNoteSelected()
        {
            noteView.ClickOnContainsText(WorkwaveData.Note.NoteText);
        }

        [When(@"Users Tagged On Note")]
        public void WhenUsersTaggedOnNote(Table data)
        {
            WorkwaveData.Note = data.CreateInstance<Note>();
            noteView.ClickOnText("addIconMini");
            noteView.ClickOnText(WorkwaveData.Note.TaggedUsers);
            noteView.ClickOnText("Done");
        }

        [Then(@"Verify Users Tagged On Note")]
        public void ThenVerifyUsersTaggedOnNote()
        {
            Assert.True(noteView.VerifyViewLoadedByText(5, WorkwaveData.Note.TaggedUsers));
        }

        [Then(@"Verify Tagged User Removed On Note")]
        public void ThenVerifyTaggedUserRemovedOnNote()
        {
            System.TimeSpan.FromSeconds(60);
            Assert.True(noteView.findElement(WorkwaveData.Note.TaggedUsers) == null);
        }

        [When(@"Canned Note Added")]
        public void WhenCannedNoteAdded(Table data)
        {
            WorkwaveData.Note = data.CreateInstance<Note>();
            noteView.ClickOnStaticText("Canned Note");
            Assert.True(noteView.VerifyViewLoadedByHeader(5, "Canned Notes"));
            noteView.ClickOnText(WorkwaveData.Note.NoteHeader);
            Assert.True(noteView.VerifyViewLoadedByText(5, WorkwaveData.Note.NoteText));
            noteView.ClickOnText("Save");
            Assert.True(noteView.VerifyViewLoadedByText(5, "Start"));
        }


    }
}
