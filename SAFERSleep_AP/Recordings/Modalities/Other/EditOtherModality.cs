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

namespace SAFERSleep_AP.Recordings.Modalities.Other
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EditOtherModality recording.
    /// </summary>
    [TestModule("78a6d8f3-3db4-4da3-b16d-4aad027438c1", ModuleType.Recording, 1)]
    public partial class EditOtherModality : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERSleep_AP.SAFERSleep_APRepository repository.
        /// </summary>
        public static SAFERSleep_AP.SAFERSleep_APRepository repo = SAFERSleep_AP.SAFERSleep_APRepository.Instance;

        static EditOtherModality instance = new EditOtherModality();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditOtherModality()
        {
            ReasonForAcknowledge = "";
            Route = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditOtherModality Instance
        {
            get { return instance; }
        }

#region Variables

        string _ReasonForAcknowledge;

        /// <summary>
        /// Gets or sets the value of variable ReasonForAcknowledge.
        /// </summary>
        [TestVariable("ced340f3-8633-4364-9fba-1fbdccb9c3fe")]
        public string ReasonForAcknowledge
        {
            get { return _ReasonForAcknowledge; }
            set { _ReasonForAcknowledge = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ExistingMedicationDropdown.
        /// </summary>
        [TestVariable("775a390e-79ed-4063-a29d-3d9e115e80c7")]
        public string ExistingMedicationDropdown
        {
            get { return repo.ExistingMedicationDropdown; }
            set { repo.ExistingMedicationDropdown = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Medication.
        /// </summary>
        [TestVariable("52b6827b-4200-457f-8aad-91aaa2b7444c")]
        public string Medication
        {
            get { return repo.Medication; }
            set { repo.Medication = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ExistingMedication.
        /// </summary>
        [TestVariable("dad07a18-c8e6-45ad-a63c-78982b425b53")]
        public string ExistingMedication
        {
            get { return repo.ExistingMedication; }
            set { repo.ExistingMedication = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Route.
        /// </summary>
        [TestVariable("06b7b0ab-3d7a-4ee0-98d9-ae3ff5550cda")]
        public string Route
        {
            get { return repo.Route; }
            set { repo.Route = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.Modalities.AddModalityWindow.Other.ExistingMedicationOther' at Center.", repo.MainWindow.Modalities.AddModalityWindow.Other.ExistingMedicationOtherInfo, new RecordItemIndex(0));
            repo.MainWindow.Modalities.AddModalityWindow.Other.ExistingMedicationOther.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ListItems.MedicationListItem' at Center.", repo.ListItems.MedicationListItemInfo, new RecordItemIndex(1));
            repo.ListItems.MedicationListItem.Click();
            Delay.Milliseconds(200);
            
            SAFERSleepAPCollection.AcknowledgeAllergy(ReasonForAcknowledge, repo.MainWindow.Modalities.AllergyChecking.AcknowledgedButtonOtherInfo, repo.MainWindow.Modalities.ReasonForAcknowledgeAllergy.SaveInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.Modalities.AddModalityWindow.Other.Route' at Center.", repo.MainWindow.Modalities.AddModalityWindow.Other.RouteInfo, new RecordItemIndex(3));
            repo.MainWindow.Modalities.AddModalityWindow.Other.Route.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Route'.", new RecordItemIndex(4));
            Keyboard.Press(Route);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(5));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            // Save Modality
            Report.Log(ReportLevel.Info, "Mouse", "Save Modality\r\nMouse Left Click item 'MainWindow.MainButtons.OnPoppup.SaveDialogue' at Center.", repo.MainWindow.MainButtons.OnPoppup.SaveDialogueInfo, new RecordItemIndex(6));
            repo.MainWindow.MainButtons.OnPoppup.SaveDialogue.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MainWindow.Modalities.SimpleModalities.AddedOtherModality'.", repo.MainWindow.Modalities.SimpleModalities.AddedOtherModalityInfo, new RecordItemIndex(7));
            Validate.Exists(repo.MainWindow.Modalities.SimpleModalities.AddedOtherModalityInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
