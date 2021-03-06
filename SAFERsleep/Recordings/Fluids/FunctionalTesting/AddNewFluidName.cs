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
    ///The AddNewFluidName recording.
    /// </summary>
    [TestModule("e0a2cbf5-3233-41e5-8d4a-979063dc023b", ModuleType.Recording, 1)]
    public partial class AddNewFluidName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static AddNewFluidName instance = new AddNewFluidName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddNewFluidName()
        {
            FluidName = "NewInput";
            StartLevel = "100";
            FluidUnit = "ml";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddNewFluidName Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable FluidName.
        /// </summary>
        [TestVariable("ec3c644d-1369-4489-9bc3-e8a9363002e5")]
        public string FluidName
        {
            get { return repo.FluidName; }
            set { repo.FluidName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable StartLevel.
        /// </summary>
        [TestVariable("d6a970b0-640b-468d-9dfe-f1c919ac2d61")]
        public string StartLevel
        {
            get { return repo.StartLevel; }
            set { repo.StartLevel = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FluidUnit.
        /// </summary>
        [TestVariable("53bd34e3-e692-4e4c-a693-97d3c0f936d7")]
        public string FluidUnit
        {
            get { return repo.FluidUnit; }
            set { repo.FluidUnit = value; }
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

            // Click on Add New Fluid
            Report.Log(ReportLevel.Info, "Mouse", "Click on Add New Fluid\r\nMouse Left Click item 'AddFluidInput.AddNewFluid' at Center.", repo.AddFluidInput.AddNewFluidInfo, new RecordItemIndex(0));
            repo.AddFluidInput.AddNewFluid.Click();
            Delay.Milliseconds(200);
            
            // Enter New Fluid name
            Report.Log(ReportLevel.Info, "Mouse", "Enter New Fluid name\r\nMouse Left Click item 'AddNewFluid.EdtFluidName' at Center.", repo.AddNewFluid.EdtFluidNameInfo, new RecordItemIndex(1));
            repo.AddNewFluid.EdtFluidName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FluidName'.", new RecordItemIndex(2));
            Keyboard.Press(FluidName);
            Delay.Milliseconds(100);
            
            UserCodeCollection_OR.Clear_TextBox(repo.AddNewFluid.EdtVolumeInfo, "Text");
            Delay.Milliseconds(0);
            
            // Enter Volume/StartLevel
            Report.Log(ReportLevel.Info, "Keyboard", "Enter Volume/StartLevel\r\nKey sequence from variable '$StartLevel'.", new RecordItemIndex(4));
            Keyboard.Press(StartLevel);
            Delay.Milliseconds(100);
            
            UserCodeCollection_OR.Clear_TextBox(repo.AddNewFluid.EdtUnitInfo, "Text");
            Delay.Milliseconds(0);
            
            // Enter Unit
            Report.Log(ReportLevel.Info, "Keyboard", "Enter Unit\r\nKey sequence from variable '$FluidUnit'.", new RecordItemIndex(6));
            Keyboard.Press(FluidUnit);
            Delay.Milliseconds(100);
            
            // Click OK
            Report.Log(ReportLevel.Info, "Mouse", "Click OK\r\nMouse Left Click item 'AddNewFluid.ButtonOK' at Center.", repo.AddNewFluid.ButtonOKInfo, new RecordItemIndex(7));
            repo.AddNewFluid.ButtonOK.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
