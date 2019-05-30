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

namespace SAFERSleep_AP.Recordings.Modalities.CoAnalgesia
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddCoAnalgesiaModality recording.
    /// </summary>
    [TestModule("d743d8ce-e701-4425-b259-d7c695f464e2", ModuleType.Recording, 1)]
    public partial class AddCoAnalgesiaModality : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERSleep_AP.SAFERSleep_APRepository repository.
        /// </summary>
        public static SAFERSleep_AP.SAFERSleep_APRepository repo = SAFERSleep_AP.SAFERSleep_APRepository.Instance;

        static AddCoAnalgesiaModality instance = new AddCoAnalgesiaModality();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddCoAnalgesiaModality()
        {
            Medication = "Amiodarone";
            ReasonAcknowledged = "This is a test reason for acknowledge allergy";
            Mode = "Loading Dose and Continuous Infusion";
            Dose = "5";
            Unit = "mg";
            Rate = "5.55";
            hr = "1";
            DoseLimit = "1.05";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddCoAnalgesiaModality Instance
        {
            get { return instance; }
        }

#region Variables

        string _ReasonAcknowledged;

        /// <summary>
        /// Gets or sets the value of variable ReasonAcknowledged.
        /// </summary>
        [TestVariable("3edf9965-df90-43af-b5e6-a73ff900f33a")]
        public string ReasonAcknowledged
        {
            get { return _ReasonAcknowledged; }
            set { _ReasonAcknowledged = value; }
        }

        string _Unit;

        /// <summary>
        /// Gets or sets the value of variable Unit.
        /// </summary>
        [TestVariable("a1243205-4263-42b2-af97-46cefbe55e7d")]
        public string Unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }

        string _hr;

        /// <summary>
        /// Gets or sets the value of variable hr.
        /// </summary>
        [TestVariable("2b4629f2-e9c0-4c06-8c24-721aa98af9c2")]
        public string hr
        {
            get { return _hr; }
            set { _hr = value; }
        }

        string _DoseLimit;

        /// <summary>
        /// Gets or sets the value of variable DoseLimit.
        /// </summary>
        [TestVariable("bd3cc5c4-b775-4e57-96ad-cc0c0cb49bdf")]
        public string DoseLimit
        {
            get { return _DoseLimit; }
            set { _DoseLimit = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Medication.
        /// </summary>
        [TestVariable("1dbe60f7-f6cb-466a-a907-b07162257906")]
        public string Medication
        {
            get { return repo.Medication; }
            set { repo.Medication = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Mode.
        /// </summary>
        [TestVariable("c5e2a844-7d07-474f-a336-2952b9a21429")]
        public string Mode
        {
            get { return repo.Mode; }
            set { repo.Mode = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Dose.
        /// </summary>
        [TestVariable("a72b0f4c-23dd-496d-aa12-20c31e5aa0f6")]
        public string Dose
        {
            get { return repo.Dose; }
            set { repo.Dose = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Rate.
        /// </summary>
        [TestVariable("c387cf15-ea5c-41b1-acb8-b69a81db0278")]
        public string Rate
        {
            get { return repo.Rate; }
            set { repo.Rate = value; }
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
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            // Click on Add button
            Report.Log(ReportLevel.Info, "Mouse", "Click on Add button\r\nMouse Left Click item 'MainWindow.Modalities.AdvancedModalities.Add' at Center.", repo.MainWindow.Modalities.AdvancedModalities.AddInfo, new RecordItemIndex(0));
            repo.MainWindow.Modalities.AdvancedModalities.Add.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ModalityMenuItems.CoAnalgesia' at Center.", repo.ModalityMenuItems.CoAnalgesiaInfo, new RecordItemIndex(1));
            repo.ModalityMenuItems.CoAnalgesia.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.Modalities.AddModalityWindow.CoAnalgesia.MedicationCoAnalgesia' at Center.", repo.MainWindow.Modalities.AddModalityWindow.CoAnalgesia.MedicationCoAnalgesiaInfo, new RecordItemIndex(2));
            repo.MainWindow.Modalities.AddModalityWindow.CoAnalgesia.MedicationCoAnalgesia.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ListItems.MedicationListItem' at Center.", repo.ListItems.MedicationListItemInfo, new RecordItemIndex(3));
            repo.ListItems.MedicationListItem.Click();
            
            SAFERSleepAPCollection.AcknowledgeAllergy(ReasonAcknowledged, repo.MainWindow.Modalities.AllergyChecking.AcknowledgedButtonCoAnalgesiaInfo, repo.MainWindow.Modalities.ReasonForAcknowledgeAllergy.SaveInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.Modalities.AddModalityWindow.CoAnalgesia.ModeCoAnalgesia' at Center.", repo.MainWindow.Modalities.AddModalityWindow.CoAnalgesia.ModeCoAnalgesiaInfo, new RecordItemIndex(5));
            repo.MainWindow.Modalities.AddModalityWindow.CoAnalgesia.ModeCoAnalgesia.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Mode'.", new RecordItemIndex(6));
            Keyboard.Press(Mode);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.Modalities.AddModalityWindow.CoAnalgesia.DoseCoAnalgesia' at Center.", repo.MainWindow.Modalities.AddModalityWindow.CoAnalgesia.DoseCoAnalgesiaInfo, new RecordItemIndex(8));
            repo.MainWindow.Modalities.AddModalityWindow.CoAnalgesia.DoseCoAnalgesia.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Dose'.", new RecordItemIndex(9));
            Keyboard.Press(Dose);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.Modalities.AddModalityWindow.CoAnalgesia.DoseUnitCoAnalgesia' at Center.", repo.MainWindow.Modalities.AddModalityWindow.CoAnalgesia.DoseUnitCoAnalgesiaInfo, new RecordItemIndex(10));
            repo.MainWindow.Modalities.AddModalityWindow.CoAnalgesia.DoseUnitCoAnalgesia.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Unit'.", new RecordItemIndex(11));
            Keyboard.Press(Unit);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(12));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.Modalities.AddModalityWindow.CoAnalgesia.RateCoAnalgesia' at Center.", repo.MainWindow.Modalities.AddModalityWindow.CoAnalgesia.RateCoAnalgesiaInfo, new RecordItemIndex(13));
            repo.MainWindow.Modalities.AddModalityWindow.CoAnalgesia.RateCoAnalgesia.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Rate'.", new RecordItemIndex(14));
            Keyboard.Press(Rate);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.Modalities.AddModalityWindow.CoAnalgesia.hrCoAnalgesia' at Center.", repo.MainWindow.Modalities.AddModalityWindow.CoAnalgesia.hrCoAnalgesiaInfo, new RecordItemIndex(15));
            repo.MainWindow.Modalities.AddModalityWindow.CoAnalgesia.hrCoAnalgesia.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$hr'.", new RecordItemIndex(16));
            Keyboard.Press(hr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(17));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.Modalities.AddModalityWindow.CoAnalgesia.DoseLimitCoAnalgesia' at Center.", repo.MainWindow.Modalities.AddModalityWindow.CoAnalgesia.DoseLimitCoAnalgesiaInfo, new RecordItemIndex(18));
            repo.MainWindow.Modalities.AddModalityWindow.CoAnalgesia.DoseLimitCoAnalgesia.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Back' Press.", new RecordItemIndex(19));
            Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DoseLimit'.", new RecordItemIndex(20));
            Keyboard.Press(DoseLimit);
            
            // Save Co-Analgesia Modality
            Report.Log(ReportLevel.Info, "Mouse", "Save Co-Analgesia Modality\r\nMouse Left Click item 'MainWindow.MainButtons.OnPoppup.SaveDialogue' at Center.", repo.MainWindow.MainButtons.OnPoppup.SaveDialogueInfo, new RecordItemIndex(21));
            repo.MainWindow.MainButtons.OnPoppup.SaveDialogue.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}