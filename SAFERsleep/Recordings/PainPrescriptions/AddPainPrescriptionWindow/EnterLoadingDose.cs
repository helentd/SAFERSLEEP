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

namespace SAFERsleep.Recordings.PainPrescriptions.AddPainPrescriptionWindow
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EnterLoadingDose recording.
    /// </summary>
    [TestModule("8ba99346-9efe-44ce-85ee-bc316ed1b479", ModuleType.Recording, 1)]
    public partial class EnterLoadingDose : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static EnterLoadingDose instance = new EnterLoadingDose();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterLoadingDose()
        {
            Unit = "ml";
            LoadingDose = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterLoadingDose Instance
        {
            get { return instance; }
        }

#region Variables

        string _Unit;

        /// <summary>
        /// Gets or sets the value of variable Unit.
        /// </summary>
        [TestVariable("03bdcf57-d9e0-4044-9e40-499bc6f8b063")]
        public string Unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }

        string _LoadingDose;

        /// <summary>
        /// Gets or sets the value of variable LoadingDose.
        /// </summary>
        [TestVariable("185d32b7-ca82-4893-b572-8942d204e3c0")]
        public string LoadingDose
        {
            get { return _LoadingDose; }
            set { _LoadingDose = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FormName.
        /// </summary>
        [TestVariable("177a8e11-f912-45b7-bebc-eda0b3869398")]
        public string FormName
        {
            get { return repo.FormName; }
            set { repo.FormName = value; }
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

            UserCodeCollection_OR.Clear_TextBox(repo.AddPainPrescription.DoseDetails.LoadingUnitInfo, "Combobox");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Unit'.", new RecordItemIndex(1));
            Keyboard.Press(Unit);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            UserCodeCollection_OR.Clear_TextBox(repo.AddPainPrescription.DoseDetails.LoadingDoseInfo, "Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LoadingDose'.", new RecordItemIndex(4));
            Keyboard.Press(LoadingDose);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
