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

namespace SAFERsleep.Recordings.Fluids.FunctionalTesting.Output
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RepeatOutputFluid recording.
    /// </summary>
    [TestModule("6e1cecaa-b902-4f36-8469-4a47b44d74e6", ModuleType.Recording, 1)]
    public partial class RepeatOutputFluid : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static RepeatOutputFluid instance = new RepeatOutputFluid();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RepeatOutputFluid()
        {
            FinishLevel = "200";
            TimeAddFluid = "14:00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RepeatOutputFluid Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable FinishLevel.
        /// </summary>
        [TestVariable("1d976977-c0ef-4b30-b176-c1ab4adf762f")]
        public string FinishLevel
        {
            get { return repo.FinishLevel; }
            set { repo.FinishLevel = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TimeAddFluid.
        /// </summary>
        [TestVariable("32b3a6eb-9cda-4b7d-b560-12d904d7e5c3")]
        public string TimeAddFluid
        {
            get { return repo.TimeAddFluid; }
            set { repo.TimeAddFluid = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.FluidBalance.Tabs.FluidOutput' at Center.", repo.FrmORMain.FluidBalance.Tabs.FluidOutputInfo, new RecordItemIndex(0));
            repo.FrmORMain.FluidBalance.Tabs.FluidOutput.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.FluidBalance.ButtonRepeatOutput' at Center.", repo.FrmORMain.FluidBalance.ButtonRepeatOutputInfo, new RecordItemIndex(1));
            repo.FrmORMain.FluidBalance.ButtonRepeatOutput.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$FinishLevel) on item 'AddFluidOutput.OutputStartVolume'.", repo.AddFluidOutput.OutputStartVolumeInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.AddFluidOutput.OutputStartVolumeInfo, "Text", FinishLevel);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'AddFluidOutput.Time' and assigning its value to variable 'TimeAddFluid'.", repo.AddFluidOutput.TimeInfo, new RecordItemIndex(3));
            TimeAddFluid = repo.AddFluidOutput.Time.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
