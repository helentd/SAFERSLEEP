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

namespace SAFERsleep.Recordings.DischargePrescription
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EditDischargeMedication recording.
    /// </summary>
    [TestModule("9a29e968-5767-48d1-92b9-e815d6c8d9df", ModuleType.Recording, 1)]
    public partial class EditDischargeMedication : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static EditDischargeMedication instance = new EditDischargeMedication();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditDischargeMedication()
        {
            DischargeDrug = "";
            Edit_DischargeDrug = "";
            DischarInstruction = "This is Discharge Instruction test";
            Edit_DischarInstruction = "";
            DischarSupply = "This is Discharge Supply test";
            Edit_DischarSupply = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditDischargeMedication Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable DischarInstruction.
        /// </summary>
        [TestVariable("8ed1c80c-50c0-463d-83a3-bbc3e2ac725f")]
        public string DischarInstruction
        {
            get { return repo.DischarInstruction; }
            set { repo.DischarInstruction = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DischarSupply.
        /// </summary>
        [TestVariable("97a6c343-dae8-4e4f-bbdf-3627b518bf73")]
        public string DischarSupply
        {
            get { return repo.DischarSupply; }
            set { repo.DischarSupply = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DischargeDrug.
        /// </summary>
        [TestVariable("cea22d0d-9404-448a-bf5f-9439925141c0")]
        public string DischargeDrug
        {
            get { return repo.DischargeDrug; }
            set { repo.DischargeDrug = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Edit_DischarInstruction.
        /// </summary>
        [TestVariable("92378e94-ca10-4d62-b9c3-0faefe9ad020")]
        public string Edit_DischarInstruction
        {
            get { return repo.Edit_DischarInstruction; }
            set { repo.Edit_DischarInstruction = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Edit_DischarSupply.
        /// </summary>
        [TestVariable("9ebe3256-c466-4311-b897-7f98022c19ff")]
        public string Edit_DischarSupply
        {
            get { return repo.Edit_DischarSupply; }
            set { repo.Edit_DischarSupply = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Edit_DischargeDrug.
        /// </summary>
        [TestVariable("014df50c-d602-4b34-8be1-821a9dd29214")]
        public string Edit_DischargeDrug
        {
            get { return repo.Edit_DischargeDrug; }
            set { repo.Edit_DischargeDrug = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.DischargePrecription.AddedDischargeMedication' at Center.", repo.FrmORMain.DischargePrecription.AddedDischargeMedicationInfo, new RecordItemIndex(0));
            repo.FrmORMain.DischargePrecription.AddedDischargeMedication.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.DischargePrecription.ButtonEdit' at Center.", repo.FrmORMain.DischargePrecription.ButtonEditInfo, new RecordItemIndex(1));
            repo.FrmORMain.DischargePrecription.ButtonEdit.Click();
            Delay.Milliseconds(200);
            
            UserCodeCollection_OR.Clear_TextBox(repo.AddDischargePrescription.DrugNameInfo, "Combobox");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edit_DischargeDrug'.", new RecordItemIndex(3));
            Keyboard.Press(Edit_DischargeDrug);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            UserCodeCollection_OR.Clear_TextBox(repo.AddDischargePrescription.DischarInstructionInfo, "Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edit_DischarInstruction'.", new RecordItemIndex(6));
            Keyboard.Press(Edit_DischarInstruction);
            Delay.Milliseconds(100);
            
            UserCodeCollection_OR.Clear_TextBox(repo.AddDischargePrescription.SupplyInfo, "Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edit_DischarSupply'.", new RecordItemIndex(8));
            Keyboard.Press(Edit_DischarSupply);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddDischargePrescription.ButtonOK' at Center.", repo.AddDischargePrescription.ButtonOKInfo, new RecordItemIndex(9));
            repo.AddDischargePrescription.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmORMain.DischargePrecription.EditedAddedDischargeMedication'.", repo.FrmORMain.DischargePrecription.EditedAddedDischargeMedicationInfo, new RecordItemIndex(10));
            Validate.Exists(repo.FrmORMain.DischargePrecription.EditedAddedDischargeMedicationInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}