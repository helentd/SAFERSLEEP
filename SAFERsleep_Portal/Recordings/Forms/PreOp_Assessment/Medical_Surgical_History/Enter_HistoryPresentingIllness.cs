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

namespace SAFERsleep_Portal.Recordings.Forms.PreOp_Assessment.Medical_Surgical_History
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Enter_HistoryPresentingIllness recording.
    /// </summary>
    [TestModule("0f05b8fc-d946-4751-a1e0-0ae45c99363f", ModuleType.Recording, 1)]
    public partial class Enter_HistoryPresentingIllness : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep_Portal.SAFERsleep_PortalRepository repository.
        /// </summary>
        public static SAFERsleep_Portal.SAFERsleep_PortalRepository repo = SAFERsleep_Portal.SAFERsleep_PortalRepository.Instance;

        static Enter_HistoryPresentingIllness instance = new Enter_HistoryPresentingIllness();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enter_HistoryPresentingIllness()
        {
            HistoryPresentingIllness = "this is a test for history of presenting illness";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enter_HistoryPresentingIllness Instance
        {
            get { return instance; }
        }

#region Variables

        string _HistoryPresentingIllness;

        /// <summary>
        /// Gets or sets the value of variable HistoryPresentingIllness.
        /// </summary>
        [TestVariable("5e34adb2-a6bb-4d2f-ab6f-d69876f3a22f")]
        public string HistoryPresentingIllness
        {
            get { return _HistoryPresentingIllness; }
            set { _HistoryPresentingIllness = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PreOperativeForm.PreOpAssessment_Form.MedicalSurgicalHistorySection.HistoryPresentingIllness' at Center.", repo.PreOperativeForm.PreOpAssessment_Form.MedicalSurgicalHistorySection.HistoryPresentingIllnessInfo, new RecordItemIndex(0));
            repo.PreOperativeForm.PreOpAssessment_Form.MedicalSurgicalHistorySection.HistoryPresentingIllness.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$HistoryPresentingIllness'.", new RecordItemIndex(1));
            Keyboard.Press(HistoryPresentingIllness);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
