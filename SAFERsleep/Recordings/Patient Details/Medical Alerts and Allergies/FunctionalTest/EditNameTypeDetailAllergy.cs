﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SAFERsleep.Recordings.Patient_Details.Medical_Alerts_and_Allergies.FunctionalTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EditNameTypeDetailAllergy recording.
    /// </summary>
    [TestModule("d563591d-5c5f-49e1-9d8b-771e607b5781", ModuleType.Recording, 1)]
    public partial class EditNameTypeDetailAllergy : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static EditNameTypeDetailAllergy instance = new EditNameTypeDetailAllergy();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditNameTypeDetailAllergy()
        {
            NewAlertType = "Allergy";
            NewAlertName = "ADT Booster";
            NewAlertDetail = "NewAlertDetail";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditNameTypeDetailAllergy Instance
        {
            get { return instance; }
        }

#region Variables

        string _NewAlertType;

        /// <summary>
        /// Gets or sets the value of variable NewAlertType.
        /// </summary>
        [TestVariable("4a0b78c6-dbb2-443f-b6d6-97f03ab31c04")]
        public string NewAlertType
        {
            get { return _NewAlertType; }
            set { _NewAlertType = value; }
        }

        string _NewAlertName;

        /// <summary>
        /// Gets or sets the value of variable NewAlertName.
        /// </summary>
        [TestVariable("f5d687b2-d286-49c9-b6fd-d1475b29fbd2")]
        public string NewAlertName
        {
            get { return _NewAlertName; }
            set { _NewAlertName = value; }
        }

        string _NewAlertDetail;

        /// <summary>
        /// Gets or sets the value of variable NewAlertDetail.
        /// </summary>
        [TestVariable("ebdfb332-3eb2-4366-8f82-6d2e3c80ba40")]
        public string NewAlertDetail
        {
            get { return _NewAlertDetail; }
            set { _NewAlertDetail = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable AllergyDetails.
        /// </summary>
        [TestVariable("7f5f4385-d889-461a-9504-94e9728bd5b4")]
        public string AllergyDetails
        {
            get { return repo.AllergyDetails; }
            set { repo.AllergyDetails = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable WarningType.
        /// </summary>
        [TestVariable("b77bf5d2-c512-4cb5-bdeb-569bd2e82eb6")]
        public string WarningType
        {
            get { return repo.WarningType; }
            set { repo.WarningType = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable AllergyName.
        /// </summary>
        [TestVariable("0d54d1d0-8b75-4237-806a-ee5e4f42c276")]
        public string AllergyName
        {
            get { return repo.AllergyName; }
            set { repo.AllergyName = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            // Click on Allergy item
            Report.Log(ReportLevel.Info, "Mouse", "Click on Allergy item\r\nMouse Left DoubleClick item 'FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AllergyListItem' at Center.", repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AllergyListItemInfo, new RecordItemIndex(0));
            repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AllergyListItem.DoubleClick();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EditDrugAllergyCI.AllergyName' at Center.", repo.EditDrugAllergyCI.AllergyNameInfo, new RecordItemIndex(1));
            repo.EditDrugAllergyCI.AllergyName.Click();
            Delay.Milliseconds(200);
            
            UserCodeCollection_OR.Clear_TextBox(repo.EditDrugAllergyCI.AllergyNameInfo, "Combobox");
            Delay.Milliseconds(0);
            
            // Enter new AllertType
            Report.Log(ReportLevel.Info, "Keyboard", "Enter new AllertType\r\nKey sequence from variable '$NewAlertName'.", new RecordItemIndex(3));
            Keyboard.Press(NewAlertName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            // Click on Allergy type DDL
            Report.Log(ReportLevel.Info, "Mouse", "Click on Allergy type DDL\r\nMouse Left Click item 'EditDrugAllergyCI.AllergyType' at Center.", repo.EditDrugAllergyCI.AllergyTypeInfo, new RecordItemIndex(5));
            repo.EditDrugAllergyCI.AllergyType.Click();
            Delay.Milliseconds(200);
            
            UserCodeCollection_OR.Clear_TextBox(repo.EditDrugAllergyCI.AllergyTypeInfo, "Combobox");
            Delay.Milliseconds(0);
            
            // Enter new AllertType
            Report.Log(ReportLevel.Info, "Keyboard", "Enter new AllertType\r\nKey sequence from variable '$NewAlertType'.", new RecordItemIndex(7));
            Keyboard.Press(NewAlertType);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(8));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EditDrugAllergyCI.Detail' at Center.", repo.EditDrugAllergyCI.DetailInfo, new RecordItemIndex(9));
            repo.EditDrugAllergyCI.Detail.Click();
            Delay.Milliseconds(200);
            
            UserCodeCollection_OR.Clear_TextBox(repo.EditDrugAllergyCI.DetailInfo, "Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NewAlertDetail'.", new RecordItemIndex(11));
            Keyboard.Press(NewAlertDetail);
            Delay.Milliseconds(100);
            
            ReAssignAlertNameTypeDetail(NewAlertType, NewAlertName, NewAlertDetail);
            Delay.Milliseconds(0);
            
            // Save it
            Report.Log(ReportLevel.Info, "Mouse", "Save it\r\nMouse Left Click item 'EditDrugAllergyCI.ButtonOK' at Center.", repo.EditDrugAllergyCI.ButtonOKInfo, new RecordItemIndex(13));
            repo.EditDrugAllergyCI.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AllergyListItem'.", repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AllergyListItemInfo, new RecordItemIndex(14));
            Validate.Exists(repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AllergyListItemInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
