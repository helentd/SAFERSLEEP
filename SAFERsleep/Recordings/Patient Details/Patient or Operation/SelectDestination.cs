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
    ///The SelectDestination recording.
    /// </summary>
    [TestModule("1ca4f16b-8cb0-43c2-ac31-d0081bd34b2f", ModuleType.Recording, 1)]
    public partial class SelectDestination : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static SelectDestination instance = new SelectDestination();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectDestination()
        {
            Destination = "21";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectDestination Instance
        {
            get { return instance; }
        }

#region Variables

        string _Destination;

        /// <summary>
        /// Gets or sets the value of variable Destination.
        /// </summary>
        [TestVariable("654e9fca-8e57-4da8-a62d-d5523eddf249")]
        public string Destination
        {
            get { return _Destination; }
            set { _Destination = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Destination' with focus on 'FrmORMain.Patient_Details.Patient_or_Operation.Destination'.", repo.FrmORMain.Patient_Details.Patient_or_Operation.DestinationInfo, new RecordItemIndex(0));
            repo.FrmORMain.Patient_Details.Patient_or_Operation.Destination.PressKeys(Destination);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
