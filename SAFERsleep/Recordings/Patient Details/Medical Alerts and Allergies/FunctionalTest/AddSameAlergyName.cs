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
    ///The AddSameAlergyName recording.
    /// </summary>
    [TestModule("be65bf04-db05-49f2-be6c-fe39a1af7ad6", ModuleType.Recording, 1)]
    public partial class AddSameAlergyName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static AddSameAlergyName instance = new AddSameAlergyName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddSameAlergyName()
        {
            AllergyName = "Morphine";
            AlertClass = "Drug";
            NewAllergyNAme = "Adenosine";
            NameToEdit = "";
            AllergyDetails = "this is a test allergy";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddSameAlergyName Instance
        {
            get { return instance; }
        }

#region Variables

        string _AlertClass;

        /// <summary>
        /// Gets or sets the value of variable AlertClass.
        /// </summary>
        [TestVariable("5fbec8a3-6c65-4107-aae9-e42629615042")]
        public string AlertClass
        {
            get { return _AlertClass; }
            set { _AlertClass = value; }
        }

        string _NewAllergyNAme;

        /// <summary>
        /// Gets or sets the value of variable NewAllergyNAme.
        /// </summary>
        [TestVariable("e78c3336-2cee-4ae7-89aa-447ccc4bb6a6")]
        public string NewAllergyNAme
        {
            get { return _NewAllergyNAme; }
            set { _NewAllergyNAme = value; }
        }

        string _NameToEdit;

        /// <summary>
        /// Gets or sets the value of variable NameToEdit.
        /// </summary>
        [TestVariable("2c7699a9-a145-49cd-82a0-f23e2e65e388")]
        public string NameToEdit
        {
            get { return _NameToEdit; }
            set { _NameToEdit = value; }
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
        /// Gets or sets the value of variable AllergyDetails.
        /// </summary>
        [TestVariable("6198368e-e4c5-4ac6-80ee-07523c0b1eb1")]
        public string AllergyDetails
        {
            get { return repo.AllergyDetails; }
            set { repo.AllergyDetails = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable AllergyName.
        /// </summary>
        [TestVariable("70e348c4-2ee4-4e4c-aa86-5c6320ba20d8")]
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

            // Click on Add Allergy button
            Report.Log(ReportLevel.Info, "Mouse", "Click on Add Allergy button\r\nMouse Left Click item 'FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AddDrugAllergyCI' at Center.", repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AddDrugAllergyCIInfo, new RecordItemIndex(0));
            repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AddDrugAllergyCI.Click();
            Delay.Milliseconds(200);
            
            // Enter same Allergy Name
            Report.Log(ReportLevel.Info, "Mouse", "Enter same Allergy Name\r\nMouse Left Click item 'FrmAddDrugAllergy.AllergyName' at Center.", repo.FrmAddDrugAllergy.AllergyNameInfo, new RecordItemIndex(1));
            repo.FrmAddDrugAllergy.AllergyName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AllergyName'.", new RecordItemIndex(2));
            Keyboard.Press(AllergyName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            // Store this name to use for Edit
            Report.Log(ReportLevel.Info, "Get Value", "Store this name to use for Edit\r\nGetting attribute 'Text' from item 'FrmAddDrugAllergy.AllergyName' and assigning its value to variable 'NameToEdit'.", repo.FrmAddDrugAllergy.AllergyNameInfo, new RecordItemIndex(4));
            NameToEdit = repo.FrmAddDrugAllergy.AllergyName.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAddDrugAllergy.OK' at Center.", repo.FrmAddDrugAllergy.OKInfo, new RecordItemIndex(5));
            repo.FrmAddDrugAllergy.OK.Click();
            Delay.Milliseconds(200);
            
            // Check Duplicate validation message
            MedicalAlertAllergyCollection.CheckDupplicateDrugLCassConditionName(AlertClass);
            Delay.Milliseconds(0);
            
            // Click OK on Error poppup
            Report.Log(ReportLevel.Info, "Mouse", "Click OK on Error poppup\r\nMouse Left Click item 'Error.ButtonOK' at Center.", repo.Error.ButtonOKInfo, new RecordItemIndex(7));
            repo.Error.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            // E ter new Allergy name
            Report.Log(ReportLevel.Info, "Mouse", "E ter new Allergy name\r\nMouse Left Click item 'FrmAddDrugAllergy.AllergyName' at Center.", repo.FrmAddDrugAllergy.AllergyNameInfo, new RecordItemIndex(8));
            repo.FrmAddDrugAllergy.AllergyName.Click();
            Delay.Milliseconds(200);
            
            UserCodeCollection_OR.Clear_TextBox(repo.FrmAddDrugAllergy.AllergyNameInfo, "Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NewAllergyNAme'.", new RecordItemIndex(10));
            Keyboard.Press(NewAllergyNAme);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(11));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            // ReAssign new allergy name to old Allergyy name
            ReAssignNewAllergyName(NewAllergyNAme);
            Delay.Milliseconds(0);
            
            // Adverse Reaction; Possible Contraindication; Contraindication; Possible Allergy; Allergy
            Report.Log(ReportLevel.Info, "Mouse", "Adverse Reaction; Possible Contraindication; Contraindication; Possible Allergy; Allergy\r\nMouse Left Click item 'FrmAddDrugAllergy.WarningType' at Center.", repo.FrmAddDrugAllergy.WarningTypeInfo, new RecordItemIndex(13));
            repo.FrmAddDrugAllergy.WarningType.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAddDrugAllergy.AllergyDetails' at Center.", repo.FrmAddDrugAllergy.AllergyDetailsInfo, new RecordItemIndex(14));
            repo.FrmAddDrugAllergy.AllergyDetails.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AllergyDetails'.", new RecordItemIndex(15));
            Keyboard.Press(AllergyDetails);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAddDrugAllergy.OK' at Center.", repo.FrmAddDrugAllergy.OKInfo, new RecordItemIndex(16));
            repo.FrmAddDrugAllergy.OK.Click();
            Delay.Milliseconds(200);
            
            // Check new Allergy is added succesfully
            Report.Log(ReportLevel.Info, "Validation", "Check new Allergy is added succesfully\r\nValidating Exists on item 'FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AllergyListItem'.", repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AllergyListItemInfo, new RecordItemIndex(17));
            Validate.Exists(repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AllergyListItemInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
