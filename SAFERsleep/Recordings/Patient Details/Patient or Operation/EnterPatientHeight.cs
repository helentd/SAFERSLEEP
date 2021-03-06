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
    ///The EnterPatientHeight recording.
    /// </summary>
    [TestModule("99de9442-00fb-41a0-bbf9-8da500584ea5", ModuleType.Recording, 1)]
    public partial class EnterPatientHeight : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static EnterPatientHeight instance = new EnterPatientHeight();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterPatientHeight()
        {
            Height = "180";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterPatientHeight Instance
        {
            get { return instance; }
        }

#region Variables

        string _Height;

        /// <summary>
        /// Gets or sets the value of variable Height.
        /// </summary>
        [TestVariable("d5783e2f-ab42-4285-8749-541ef2a42b9e")]
        public string Height
        {
            get { return _Height; }
            set { _Height = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Height' with focus on 'FrmORMain.Patient_Details.Patient_or_Operation.Height'.", repo.FrmORMain.Patient_Details.Patient_or_Operation.HeightInfo, new RecordItemIndex(0));
            repo.FrmORMain.Patient_Details.Patient_or_Operation.Height.PressKeys(Height);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
