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

namespace SAFERsleep.Recordings.ConfirmationFeatures.Destination
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectDestination recording.
    /// </summary>
    [TestModule("7f1c0e43-569d-4df3-ae17-ee8bcd8ad65a", ModuleType.Recording, 1)]
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
        [TestVariable("ce91c61f-e5d1-4371-b746-dc8a6c2acf02")]
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmConfirmDestination.EnterDestinationMessage'.", repo.FrmConfirmDestination.EnterDestinationMessageInfo, new RecordItemIndex(0));
            Validate.Exists(repo.FrmConfirmDestination.EnterDestinationMessageInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmConfirmDestination.DestinationCombobox' at Center.", repo.FrmConfirmDestination.DestinationComboboxInfo, new RecordItemIndex(1));
            repo.FrmConfirmDestination.DestinationCombobox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Destination'.", new RecordItemIndex(2));
            Keyboard.Press(Destination);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmConfirmDestination.ButtonOK' at Center.", repo.FrmConfirmDestination.ButtonOKInfo, new RecordItemIndex(4));
            repo.FrmConfirmDestination.ButtonOK.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
