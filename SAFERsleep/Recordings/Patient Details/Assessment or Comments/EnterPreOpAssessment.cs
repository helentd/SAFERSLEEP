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

namespace SAFERsleep.Recordings.Patient_Details.Assessment_or_Comments
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EnterPreOpAssessment recording.
    /// </summary>
    [TestModule("efb7485e-e1af-45ca-984e-6f2e764b6ab6", ModuleType.Recording, 1)]
    public partial class EnterPreOpAssessment : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static EnterPreOpAssessment instance = new EnterPreOpAssessment();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterPreOpAssessment()
        {
            PreOpAssessment = "this is a test comment on PreOpAssessment";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterPreOpAssessment Instance
        {
            get { return instance; }
        }

#region Variables

        string _PreOpAssessment;

        /// <summary>
        /// Gets or sets the value of variable PreOpAssessment.
        /// </summary>
        [TestVariable("597c4cfb-1044-4c85-adb6-145b2283e32d")]
        public string PreOpAssessment
        {
            get { return _PreOpAssessment; }
            set { _PreOpAssessment = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PreOpAssessment' with focus on 'FrmORMain.Patient_Details.Assessment.PreOpAssessment'.", repo.FrmORMain.Patient_Details.Assessment.PreOpAssessmentInfo, new RecordItemIndex(0));
            repo.FrmORMain.Patient_Details.Assessment.PreOpAssessment.PressKeys(PreOpAssessment);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
