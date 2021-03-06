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

namespace SAFERsleep.Recordings.Fluids.FunctionalTesting
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CheckInFluidSummary recording.
    /// </summary>
    [TestModule("2c9a415b-484f-440e-a5e4-77035ece9603", ModuleType.Recording, 1)]
    public partial class CheckInFluidSummary : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static CheckInFluidSummary instance = new CheckInFluidSummary();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckInFluidSummary()
        {
            TypeFluid = "Input";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CheckInFluidSummary Instance
        {
            get { return instance; }
        }

#region Variables

        string _TypeFluid;

        /// <summary>
        /// Gets or sets the value of variable TypeFluid.
        /// </summary>
        [TestVariable("bc1316ee-12af-4253-9018-dfd110f4e6b1")]
        public string TypeFluid
        {
            get { return _TypeFluid; }
            set { _TypeFluid = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FluidUnit.
        /// </summary>
        [TestVariable("56d230ba-1e26-4d25-95c6-43a8ccbac0bd")]
        public string FluidUnit
        {
            get { return repo.FluidUnit; }
            set { repo.FluidUnit = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable VolumeGiven.
        /// </summary>
        [TestVariable("0ed5254b-a894-4973-b9d5-992eb91a14cb")]
        public string VolumeGiven
        {
            get { return repo.VolumeGiven; }
            set { repo.VolumeGiven = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FluidName.
        /// </summary>
        [TestVariable("f8802379-a5c2-4098-a0d6-3cbad52dc7a7")]
        public string FluidName
        {
            get { return repo.FluidName; }
            set { repo.FluidName = value; }
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

            // Click on Summary tab
            Report.Log(ReportLevel.Info, "Mouse", "Click on Summary tab\r\nMouse Left Click item 'FrmORMain.FluidBalance.Tabs.FluidSummary' at Center.", repo.FrmORMain.FluidBalance.Tabs.FluidSummaryInfo, new RecordItemIndex(0));
            repo.FrmORMain.FluidBalance.Tabs.FluidSummary.Click();
            
            // Validate the  FluidInput  is added succesfully in the Summary tab
            CheckInSummaryTab(TypeFluid);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
