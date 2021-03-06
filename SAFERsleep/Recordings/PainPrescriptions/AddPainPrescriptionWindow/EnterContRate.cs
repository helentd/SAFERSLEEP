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
    ///The EnterContRate recording.
    /// </summary>
    [TestModule("315fb3bf-778c-4285-821c-80ea87244f3c", ModuleType.Recording, 1)]
    public partial class EnterContRate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static EnterContRate instance = new EnterContRate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterContRate()
        {
            ContinuousRate = "";
            Unit = "ml";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterContRate Instance
        {
            get { return instance; }
        }

#region Variables

        string _ContinuousRate;

        /// <summary>
        /// Gets or sets the value of variable ContinuousRate.
        /// </summary>
        [TestVariable("26c82740-918d-4d0e-832b-0028f854a075")]
        public string ContinuousRate
        {
            get { return _ContinuousRate; }
            set { _ContinuousRate = value; }
        }

        string _Unit;

        /// <summary>
        /// Gets or sets the value of variable Unit.
        /// </summary>
        [TestVariable("084a455d-5f62-4367-b399-0c1285896376")]
        public string Unit
        {
            get { return _Unit; }
            set { _Unit = value; }
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

            UserCodeCollection_OR.Clear_TextBox(repo.AddPainPrescription.DoseDetails.RateUnitInfo, "Combobox");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Unit'.", new RecordItemIndex(1));
            Keyboard.Press(Unit);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            UserCodeCollection_OR.Clear_TextBox(repo.AddPainPrescription.DoseDetails.ContinuousRateInfo, "Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ContinuousRate'.", new RecordItemIndex(4));
            Keyboard.Press(ContinuousRate);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
