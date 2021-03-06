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

namespace SAFERsleep.Recordings.PainPrescriptions
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DeletePainPrescription recording.
    /// </summary>
    [TestModule("4b856c65-3e3a-4947-8d93-5ea244ba4f64", ModuleType.Recording, 1)]
    public partial class DeletePainPrescription : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static DeletePainPrescription instance = new DeletePainPrescription();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeletePainPrescription()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeletePainPrescription Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable PrescriptionType.
        /// </summary>
        [TestVariable("16bcb67e-3d39-4841-a19b-65743594bffd")]
        public string PrescriptionType
        {
            get { return repo.PrescriptionType; }
            set { repo.PrescriptionType = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.PainPrescriptions.AddedPrescription' at Center.", repo.FrmORMain.PainPrescriptions.AddedPrescriptionInfo, new RecordItemIndex(0));
            repo.FrmORMain.PainPrescriptions.AddedPrescription.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.PainPrescriptions.ButtonDelete' at Center.", repo.FrmORMain.PainPrescriptions.ButtonDeleteInfo, new RecordItemIndex(1));
            repo.FrmORMain.PainPrescriptions.ButtonDelete.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmConfirmation.Yes' at Center.", repo.FrmConfirmation.YesInfo, new RecordItemIndex(2));
            repo.FrmConfirmation.Yes.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
