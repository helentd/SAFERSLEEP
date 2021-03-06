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

namespace SAFERsleep.Recordings.Patient_Details.Patient_or_Operation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EnterPatientWeight recording.
    /// </summary>
    [TestModule("2ac158bf-2201-494c-bffb-63341e30ef65", ModuleType.Recording, 1)]
    public partial class EnterPatientWeight : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static EnterPatientWeight instance = new EnterPatientWeight();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterPatientWeight()
        {
            PatientWeight = "80";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterPatientWeight Instance
        {
            get { return instance; }
        }

#region Variables

        string _PatientWeight;

        /// <summary>
        /// Gets or sets the value of variable PatientWeight.
        /// </summary>
        [TestVariable("62a11088-1f80-4f6a-a52e-0ea2ea27a500")]
        public string PatientWeight
        {
            get { return _PatientWeight; }
            set { _PatientWeight = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PatientWeight' with focus on 'FrmORMain.Patient_Details.Patient_or_Operation.Weight'.", repo.FrmORMain.Patient_Details.Patient_or_Operation.WeightInfo, new RecordItemIndex(0));
            repo.FrmORMain.Patient_Details.Patient_or_Operation.Weight.PressKeys(PatientWeight);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
