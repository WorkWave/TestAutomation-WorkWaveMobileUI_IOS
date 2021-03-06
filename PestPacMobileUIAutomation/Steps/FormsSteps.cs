using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WorkWave.Workwave.Mobile.Model;
using WorkWave.Workwave.Mobile.SharedData;

namespace WorkWave.Workwave.Mobile.Steps
{
    [Binding]
    public class FormsSteps
    {
        WorkwaveData WorkwaveData;
        private CommonSteps common;
        FormView formView = new FormView();
        OrderPageView orderPageView = new OrderPageView();
        AttachmentView attachmentView = new AttachmentView();
        String FormType, Text, FormName, FieldName, Date;

        public FormsSteps(WorkwaveData WorkwaveData)
        {
            this.WorkwaveData = WorkwaveData;
            common = new CommonSteps(WorkwaveData);
        }

        [When(@"Form Added")]
        public void WhenFormAdded(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            while (!orderPageView.VerifyStartButtonLoaded(5))
            {
                System.TimeSpan.FromSeconds(60);
            }
            formView.ClickPlusIcon();
            System.TimeSpan.FromSeconds(60);
            Assert.True(formView.VerifyViewLoadedByHeader(5, "Add"));
            formView.ClickOnStaticText("Forms");
            WhenFormTemplatesSearched();
            formView.ClickOnStaticText(WorkwaveData.Form.FormType);
            Assert.True(formView.VerifyViewLoadedByContainsText(5, WorkwaveData.Form.FormType));
            FormType = WorkwaveData.Form.FormType;
        }

        [When(@"Fill Form Fields")]
        public void WhenFillFormFields(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.ClickOnStaticText("Start");
            WorkwaveData.Form.Text = WorkwaveMobileSupport.generateRandomString(10);
            Text = WorkwaveData.Form.Text;
            formView.EnterTextToCommonField("Test", WorkwaveData.Form.FieldName);
           // formView.EnterOfficeText(WorkwaveData.Form.Text);
        }


        [When("Form Templates Searched")]
        public void WhenFormTemplatesSearched()
        {

            while (!formView.NewFormHeaderVisible(2))
            {
                System.TimeSpan.FromSeconds(30);
            }

            formView.ClickSearch();
            Assert.True(formView.VerifySearchOpen(5));
            formView.EnterSearchText(WorkwaveData.Form.FormType);
         
        }

        [When(@"Complete Form")]
        public void WhenCompleteForm()
        {
            formView.ClickOnStaticText("Complete");
            Assert.True(formView.VerifyViewLoadedByHeader(5, "Complete form"));
            formView.ClickOnText("Proceed");
            while (!formView.ShareFormHeaderVisible(2))
            {
                System.TimeSpan.FromSeconds(30);
            }
            formView.ClickOnStaticText("Skip");
            while (!orderPageView.VerifyStartButtonLoaded(2))
            {
                System.TimeSpan.FromSeconds(30);
            }

        }


        [Then(@"Verify Form Added")]
        public void ThenVerifyFormAdded()
        {
            //WorkwaveMobileSupport.SwipeDownIOS("PAYMENTS");
            //System.TimeSpan.FromSeconds(30);
            //WorkwaveMobileSupport.SwipeDownIOS("PAYMENTS");
            //System.TimeSpan.FromSeconds(30);
            formView.ViewForms();
            
            if (!formView.VerifyCompletedFormLableVisible(5))
            {
                WorkwaveMobileSupport.SwipeUpIOS("FORMS");
                System.TimeSpan.FromSeconds(30);
            }
            if (!formView.VerifyCompletedFormLableVisible(5))
            {
                WorkwaveMobileSupport.SwipeDownIOS("FORMS");
                System.TimeSpan.FromSeconds(30);
            }
            Assert.True( formView.VerifyViewLoadedByContainsText(5, WorkwaveData.Form.FormType));
            Assert.True(formView.VerifyViewLoadedByText(5, "Complete"));
            formView.ClickOnContainsText(FormType);
            
            while (!formView.VerifyDoneButtonLoaded(2))
            {
                System.TimeSpan.FromSeconds(30);
            }
            Assert.True(formView.VerifyViewLoadedByHeader(5, FormType));
            Assert.True(formView.VerifyViewLoadedByContainsText(5, Text));
           
            formView.ClickOnText("Done");
        }

       

        [When(@"Save Form As A Draft")]
        public void WhenSaveFormAsADraft()
        {
            formView.ClickTopMenuButton();
            formView.ClickOnText("Save Draft");
            System.TimeSpan.FromSeconds(30);
            formView.ClickFormBackButton();
        }

        [Then(@"Verify Form Drafted")]
        public void ThenVerifyFormDrafted()
        {
            formView.ViewForms();

            if (!formView.VerifyCompletedFormLableVisible(5))
            {
                WorkwaveMobileSupport.SwipeUpIOS("FORMS");
                System.TimeSpan.FromSeconds(30);
            }
            if (!formView.VerifyCompletedFormLableVisible(5))
            {
                WorkwaveMobileSupport.SwipeDownIOS("FORMS");
                System.TimeSpan.FromSeconds(30);
            }
            Assert.True(formView.VerifyViewLoadedByContainsText(5, WorkwaveData.Form.FormType));
            Assert.True(formView.VerifyViewLoadedByText(5, "Draft"));
        }

        [When(@"Drafted Form Opened")]
        public void WhenDraftedFormOpened()
        {
            formView.ClickOnForm( WorkwaveData.Form.FormType,"Draft");
            while (!formView.EditDraftLabelVisible(2))
            {
                System.TimeSpan.FromSeconds(30);
            }
            Assert.True(formView.VerifyViewLoadedByContainsText(5, WorkwaveData.Form.FormType));
            formView.ClickOnText("Edit Draft");
        }

        [When(@"Preview Form")]
        public void WhenPreviewForm()
        {
            formView.ClickOnText("Preview");
        }

        [Then(@"Verify Preview Loaded")]
        public void ThenVerifyPreviewLoaded()
        {
            Assert.True(formView.VerifyViewLoadedByHeader(5, "Preview"));
            Assert.True(formView.VerifyViewLoadedByText(5, "Share"));
            formView.ClickOnText("Done");
            formView.ClickOnText("FormBackArrow");
        }

        [When(@"Form Favorited")]
        public void WhenFormFavorited(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.ClickPlusIcon();
            Assert.True(formView.VerifyViewLoadedByHeader(5, "Add"));
            formView.ClickOnStaticText("Forms");
            WhenFormTemplatesSearched();
            formView.ClickOnFavourite(WorkwaveData.Form.FormType);
        }

        [Then(@"Verify Form Favorited")]
        public void ThenVerifyFormFavorited()
        {
            formView.ClickBack();
            formView.ClickPlusIcon();
            Assert.True(formView.VerifyViewLoadedByHeader(5, "Add"));
            formView.ClickOnStaticText("Forms");
            while (!formView.NewFormHeaderVisible(2))
            {
                System.TimeSpan.FromSeconds(30);
            }

            Assert.True(formView.VerifyFormAdded(5, WorkwaveData.Form.FormType));
        }

        [When(@"Form Unfavorited")]
        public void WhenFormUnfavorited()
        {
            FormType = formView.getFavoriteFormName();
            formView.ClickOnUnFavourite(FormType);
        }

        [Then(@"Verify Form Unfavorited")]
        public void ThenVerifyFormUnfavorited()
        {
            Assert.True(formView.findFormEntryFromFavorites(FormType) == null);
        }

        [When(@"Insert Image To Form")]
        public void WhenInsertImageToForm(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();

           
            if (WorkwaveData.Form.DocumentType.Equals("Pick from Gallery"))
            {
                formView.ClickOnText("FormNavigationBarResetZoom");
                formView.ClickInsertImageButton();
                formView.ClickOnText(WorkwaveData.Form.DocumentType);
                while (!formView.VerifyPhotoViewLoaded(5))
                {
                    System.TimeSpan.FromSeconds(30);
                }
                attachmentView.ClickOnText("All Photos");
                formView.SelectImageFromGallery();
            }else if (WorkwaveData.Form.DocumentType.Equals("Take a Photo"))
            {
                formView.ClickInsertImageButton();
                if (formView.VerifyTakeAnotherIamgeButtonLoaded(5))
                {
                    formView.ClickOnText("Take another image");
                }
                formView.ClickOnText(WorkwaveData.Form.DocumentType);

                attachmentView.ClickOnButton("Take Picture");
                while (!attachmentView.UsePhotoButtonVisible(2))
                {
                    System.TimeSpan.FromSeconds(30);
                }
                attachmentView.ClickOnText("Use Photo");

            }else if (WorkwaveData.Form.DocumentType.Equals("Location Images"))
            {
                if(formView.VerifyClearAllButtonLoaded(5))
                {
                    formView.ClickLeftExpandButton();
                }
                formView.ClickInsertImageButton();
                if (formView.VerifyTakeAnotherIamgeButtonLoaded(5))
                {
                    formView.ClickOnText("Take another image");
                }
                formView.ClickOnText(WorkwaveData.Form.DocumentType);
                while(!formView.VerifyImageViewLoaded(5))
                {
                    System.TimeSpan.FromSeconds(30);
                }
                formView.ClickFirstLocationImage();
                formView.ClickOnStaticText("Select as Background");
            }
           
        }

        [When(@"Insert Sketch To Form")]
        public void WhenInsertSketchToForm(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.ClickInsertImageButton();
            System.TimeSpan.FromSeconds(60);
            if (formView.VerifyTakeAnotherIamgeButtonLoaded(5))
            {
                formView.ClickOnText("Take another image");
            }
            formView.ClickOnText(WorkwaveData.Form.DocumentType);
            while (!formView.VerifySketchesHeaderVisible(5))
            {
                System.TimeSpan.FromSeconds(30);
            }
            formView.ClickOnContainsText(WorkwaveData.Form.SketchName);
        }


        [Then(@"Verify Image Added")]
        public void ThenVerifyImageAdded()
        {
            Assert.True(formView.VerifyViewLoadedByContainsText(5, WorkwaveData.Form.FormType));
            Assert.True(formView.VerifyViewLoadedByText(5, "Image"));
        }

        [When(@"All Form Fields Cleared")]
        public void WhenAllFormFieldsCleared()
        {
            //formView.ClickOfficeTextField();
            //formView.ClickOnText("done");
            if (formView.VerifyClearAllButtonLoaded(5))
            {
                formView.ClickOnText("Clear All Fields");
            }
            formView.ClickBottomExpandArrowButton();
            formView.ClickOnText("Clear All Fields");
            Assert.True(formView.VerifyViewLoadedByHeader(5, "Clear Form"));
            formView.ClickOnText("Clear All Fields");
        }

        [Then(@"Verify All Form Fields Cleared")]
        public void ThenVerifyAllFormFieldsCleared()
        {
            Assert.True(formView.findElement(Text) == null);
            Assert.True(formView.findElement("Image") == null);
        }

        [When(@"Add Image To Media Gallery")]
        public void WhenAddImageToMediaGallery(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.ClickOnText("camera");
            if (formView.PhotoOptionAlertVisible(5))
            {
                formView.ClickOnText("Add New Picture");
            }
            if (WorkwaveData.Form.DocumentType.Equals("Pick from Gallery"))
            {
                formView.ClickOnText(WorkwaveData.Form.DocumentType);
                while (!formView.VerifyPhotoViewLoaded(5))
                {
                    System.TimeSpan.FromSeconds(30);
                }
                formView.ClickOnText("All Photos");
                formView.SelectImageFromGallery();
            }
            else if (WorkwaveData.Form.DocumentType.Equals("Take a Photo"))
            {
                formView.ClickOnText(WorkwaveData.Form.DocumentType);
                while (!formView.VerifyCameraViewLoaded(5))
                {
                    System.TimeSpan.FromSeconds(30);
                }
                formView.ClickOnText("Take Picture");
                while (!formView.VerifyUsePhotoViewLoaded(5))
                {
                    System.TimeSpan.FromSeconds(30);
                }
                formView.ClickOnText("Use Photo");
            }

            formView.ClickOnText("Save");
        }

        [When(@"Draft Form Delete")]
        public void WhenDraftFormDelete()
        {
            while (!orderPageView.VerifyStartButtonLoaded(5))
            {
                System.TimeSpan.FromSeconds(30);
            }
            formView.ClickFormSeeAllButton();
            FormName = formView.getDraftedFormName();
            formView.DeleteForm(FormName);
            if (formView.DeleteButtonVisible(2))
            {
                System.TimeSpan.FromSeconds(30);
                Assert.True(formView.VerifyViewLoadedByText(5, "Delete"));
                formView.ClickOnText("Delete");
            }

        }

        [Then(@"Verify Form Deleted")]
        public void ThenVerifyFormDeleted()
        {
            Assert.True(formView.findElement(FormName) == null);
            formView.ClickBack();
        }

        [When(@"Start Form Editing")]
        public void WhenStartFormEditing()
        {
            while (!formView.VerifyPreviewButtonLoaded(2))
            {
                System.TimeSpan.FromSeconds(30);
            }
            formView.ClickOnStaticText("Start");
        }

        [When(@"Search For Field")]
        public void WhenSearchForField(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.ClickSideMenuButton();
            formView.ClickOnText("Type to search");
            formView.EnterFeildName(WorkwaveData.Form.FieldName);
            FieldName = WorkwaveData.Form.FieldName;
        }

        [Then(@"Verify Search Result")]
        public void ThenVerifySearchResult(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            Assert.True(formView.VerifyFieldStatus(5, FieldName, WorkwaveData.Form.Status));
        }

        [Then(@"Verify ReadOnly Field Is Not Editable")]
        public void ThenVerifyReadOnlyFieldIsNotEditable()
        {
            formView.ClickOnSearchedFeild(FieldName);
            formView.ClickSideMenuButton();
            formView.ClickOnSearchedFeild(FieldName);
            Assert.True(formView.findElement("Done") == null);
        }

        [When(@"Required Feilds Filled")]
        public void WhenRequiredFeildsFilled(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.ClickOnTextThree("Mode: Default");
            Assert.True(formView.VerifyViewLoadedByText(5, "Required Fields Completed:"));
            Assert.True(!formView.VerifyCompleteButtonVisible(5));
            formView.EnterTextCommonFieldTwo("Test", WorkwaveData.Form.FieldName);
            formView.ClickOnText("Given Name:");
        }

        [Then(@"Verify Required Fields Completed")]
        public void ThenVerifyRequiredFieldsCompleted()
        {
            Assert.True(formView.VerifyCompleteButtonVisible(5));
        }

        [When(@"Search Form")]
        public void WhenSearchForm(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            WorkwaveMobileSupport.SwipeDownIOS("PAYMENTS");
            System.TimeSpan.FromSeconds(30);
            WorkwaveMobileSupport.SwipeDownIOS("PAYMENTS");
            System.TimeSpan.FromSeconds(30);
            formView.ClickFormSeeAllButton();
            formView.ClickOnText(WorkwaveData.Form.FormType);
        }

        [Then(@"Verify Fields Editable After Customer Signs")]
        public void ThenVerifyFieldsEditableAfterCustomerSigns(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            //Assert.True(formView.VerifyViewLoadedByHeader(5,  WorkwaveData.Form.FormType));
            formView.ClickOnStaticText("Edit Draft");
            Assert.True(formView.VerifyViewLoadedByText(5, "Done"));
            //formView.ClickOnText(WorkwaveData.Form.FieldName);
            Assert.True(formView.findElement("done") != null);
        }

        [When(@"Clear Non Auto Fields")]
        public void WhenClearNonAutoFields()
        {
            formView.ClickFilledTextField();
            Text = formView.getFilledFieldValue();
            formView.ClickOnText("done");
            formView.ClickBottomExpandArrowButton();
            formView.ClickOnText("Clear All Fields");
            Assert.True(formView.VerifyViewLoadedByHeader(5, "Clear Form"));
            formView.ClickOnText("Clear Non-Auto Fields");
        }

        [Then(@"Verify Non Auto Fields Cleared")]
        public void ThenVerifyNonAutoFieldsCleared()
        {
            String textNow = formView.getFilledFieldValue();
            Assert.True(Text.Equals(textNow));
        }
       
        [When(@"Fill The Form")]
        public void WhenFillTheForm(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.ClickOnStaticText("Start");
            WorkwaveData.Form.Text = WorkwaveMobileSupport.generateRandomString(10);
            Text = WorkwaveData.Form.Text;
            System.TimeSpan.FromSeconds(30);
            formView.EnterTextToCommonField(WorkwaveData.Form.Text, WorkwaveData.Form.FieldName);
            formView.ClickOnText("Given Name:");
        }

        [When(@"Send The Form")]
        public void WhenSendTheForm(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.ClickOnText("Send");
            Assert.True(formView.VerifyViewLoadedByHeader(5, "Send Form"));
            if (WorkwaveData.Form.Role.Equals("Customer"))
            {
                formView.SelectRole(WorkwaveData.Form.Role);
                formView.ClickOnText("Done");
                formView.ClickOnText(WorkwaveData.Form.Email);
            }
            else if(WorkwaveData.Form.Role.Equals("Administrator"))
            {
                formView.EnterTextToCommonField(WorkwaveData.Form.Name,"Search");
                formView.ClickOnStaticText(WorkwaveData.Form.Name);
            }
                    
            formView.ClickOnText("Send");
        }

        [Then(@"Verify Sending Successful")]
        public void ThenVerifySendingSuccessful(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            Assert.True(formView.VerifyViewLoadedByHeader(5, "Email sent!"));
            //WorkwaveMobileSupport.SwipeDownIOS("PAYMENTS");
            //System.TimeSpan.FromSeconds(30);
            //WorkwaveMobileSupport.SwipeDownIOS("PAYMENTS");
            //System.TimeSpan.FromSeconds(30);
            formView.ViewForms();
            Assert.True(formView.VerifyFormStatus(5, FormType, WorkwaveData.Form.Status));
        }

        [When(@"Search Forms")]
        public void WhenSearchForms(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            WorkwaveData.Form = data.CreateInstance<Form>();
            //WorkwaveMobileSupport.SwipeDownIOS("PAYMENTS");
            //System.TimeSpan.FromSeconds(30);
            //WorkwaveMobileSupport.SwipeDownIOS("PAYMENTS");
            //System.TimeSpan.FromSeconds(30);
            formView.ViewFormsTwo();
            if (formView.VerifyFormSeeAllButtonLoaded(5))
            {
                formView.ClickFormSeeAllButton();
            }
            
            formView.ClickOnText(WorkwaveData.Form.Status);
        }


        [Then(@"Verify Form Editor Displaying")]
        public void ThenVerifyFormEditorDisplaying()
        {
            while (!formView.VerifyPreviewButtonLoaded(2))
            {
                System.TimeSpan.FromSeconds(30);
            }           
            Assert.True(formView.VerifyViewLoadedByText(5, "Edit Draft"));
        }

        [Then(@"Verify Form Editor Not Displaying")]
        public void ThenVerifyFormEditorNotDisplaying()
        {
            Assert.True(formView.findElement("Edit Draft") == null);
            Assert.True(formView.VerifyViewLoadedByHeader(5, "All Forms"));
            Assert.True(formView.VerifyViewLoadedByText(5, "Canceled"));
        }

        [Then(@"Verify Form Interactable")]
        public void ThenVerifyFormInteractable()
        {
            formView.ClickOnForm(FormType, WorkwaveData.Form.Status);
            ThenVerifyFormEditorDisplaying();
        }

        [When(@"Filter Date Field")]
        public void WhenFilterDateField(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.ClickOnText("done");
            formView.ClickOnText(WorkwaveData.Form.FieldName);
            Assert.True(formView.VerifyViewLoadedByText(5, "Date"));
            Date = DateTime.Now.ToString("MM/dd/yyyy"); ;
            formView.ClickOnText("Set");
        }

        [Then(@"Verify Date Added")]
        public void ThenVerifyDateAdded()
        {
            Assert.True(formView.VerifyViewLoadedByText(5, WorkwaveData.Form.FieldName+": " +Date));
        }

        [When(@"Select Value of DropDown")]
        public void WhenSelectValueOfDropDown(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.ClickOnContainsText(WorkwaveData.Form.FieldName);
          //  formView.ClickOnContainsText(WorkwaveData.Form.FieldName);
            Assert.True(formView.VerifyViewLoadedByText(5, "searchBlue"));
            //formView.ClickOnText("searchBlue");
            //formView.EnterTextOnCommonField(WorkwaveData.Form.Value);
            formView.ClickOnTextTwo(WorkwaveData.Form.Value);
        }

        [Then(@"Verify Value Selected")]
        public void ThenVerifyValueSelected()
        {
            Assert.True(formView.VerifyViewLoadedByText(5, WorkwaveData.Form.FieldName + ": " + WorkwaveData.Form.Value));
        }

        [When(@"Enter Text To Text Field")]
        public void WhenEnterTextToTextField(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.EnterTextToCommonField(WorkwaveData.Form.Value, WorkwaveData.Form.FieldName);
            //These coordinates are assigned as per iphone 11
            WorkwaveMobileSupport.TapTargetNoWait(241,576);
        }

        [When(@"Enter Text To Multi-line Text Field")]
        public void WhenEnterTextToMulti_LineTextField(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.SwipeDown();
            System.TimeSpan.FromSeconds(30);
            formView.SwipeDown();
            System.TimeSpan.FromSeconds(30);
            formView.EnterTextToCommonField(WorkwaveData.Form.Value, WorkwaveData.Form.FieldName);
            //These coordinates are assigned as per iphone 11
            WorkwaveMobileSupport.TapTargetNoWait(208, 740);
        }

        [When(@"Enter Text To Multi-line Text Field From Mapped Lookup Values")]
        public void WhenEnterTextToMulti_LineTextFieldFromMappedLookupValues(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.ClickOnText("FormNavigationBarResetZoom");
            //These coordinates are assigned as per iphone 11
            WorkwaveMobileSupport.TapTargetNoWait(380,1210);
            Assert.True(formView.VerifyViewLoadedByHeader(5, "Notes"));
            //formView.ClickOnText("searchBlue");
            //formView.EnterTextOnCommonField(WorkwaveData.Form.Value);
            formView.ClickOnStaticText(WorkwaveData.Form.Value);
        }

        [Then(@"Verify Value Added")]
        public void ThenVerifyValueAdded()
        {
            Assert.True(formView.VerifyViewLoadedByText(5, WorkwaveData.Form.FieldName + ":  " + WorkwaveData.Form.Value));
        }

        [When(@"Enter Text To Text Field From Mapped Lookup Values")]
        public void WhenEnterTextToTextFieldFromMappedLookupValues(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            //These coordinates are assigned as per iphone 11
            WorkwaveMobileSupport.TapTargetNoWait(380, 675);
            //formView.ClickOnText("searchBlue");
            //formView.EnterTextOnCommonField(WorkwaveData.Form.Value);
            formView.ClickOnStaticText(WorkwaveData.Form.Value);
        }

        [When(@"Select Value of DropDown From Mapped Lookup Values")]
        public void WhenSelectValueOfDropDownFromMappedLookupValues(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.ClickOnContainsText(WorkwaveData.Form.FieldName);
            Assert.True(formView.VerifyViewLoadedByText(5, "searchBlue"));
            //formView.ClickOnText("searchBlue");
            //formView.EnterTextOnCommonField(WorkwaveData.Form.Value);
            formView.ClickOnStaticText(WorkwaveData.Form.Value);
        }

        [When(@"Manipulate Radio Button")]
        public void WhenManipulateRadioButton(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.ClickOnText("FormNavigationBarResetZoom");
            formView.ClickOnText("Button: Paid.0: Off");
        }

        [Then(@"Verify Radio Button Clicked")]
        public void ThenVerifyRadioButtonClicked()
        {
            Assert.True(formView.VerifyViewLoadedByText(5, "Button: Paid.0: " + WorkwaveData.Form.FieldName));
        }

        [When(@"Resize The Screen")]
        public void WhenResizeTheScreen()
        {
            formView.ClickOnText("FormNavigationBarResetZoom");
        }

        [When(@"Capture The Signature")]
        public void WhenCaptureTheSignature()
        {
            formView.ClickOnText("Signature Field: Signature");
            Assert.True(formView.VerifyViewLoadedByText(5, "Sign here"));
            formView.ClickOnText("▶");
            Assert.True(formView.VerifyViewLoadedByText(5, "clear"));
            formView.ClickOnText("Save");
        }

        [Then(@"Verify Signature Captured")]
        public void ThenVerifySignatureCaptured()
        {
            ThenVerifyImageAdded();
        }

        [When(@"Manipulate CheckBox")]
        public void WhenManipulateCheckBox(Table data)
        {
            WorkwaveData.Form = data.CreateInstance<Form>();
            formView.ClickOnText("Button: "+ WorkwaveData.Form.FieldName + ": Off");
        }

        [Then(@"Verify CheckBox Selected")]
        public void ThenVerifyCheckBoxSelected()
        {
            Assert.True(formView.VerifyViewLoadedByText(5, "Button: " + WorkwaveData.Form.FieldName + ": Yes"));
        }

        [Then(@"ReturnsToHome")]
        public void ThenReturnsToHome()
        {
            formView.ClickFormBackButton();
            while (!formView.LeaveWithoutSavingVisible(5))
            {
                formView.ClickFormBackButton();
            }
            formView.ClickOnText("Leave without saving");
        }

    }
}
