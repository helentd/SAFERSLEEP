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
    ///The EndCase_CompleteFinishLevel recording.
    /// </summary>
    [TestModule("cebe5f25-78dd-467b-bd5c-63eedd884ff3", ModuleType.Recording, 1)]
    public partial class EndCase_CompleteFinishLevel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static EndCase_CompleteFinishLevel instance = new EndCase_CompleteFinishLevel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EndCase_CompleteFinishLevel()
        {
            CompleteAction = "Finish";
            TypeFluid = "input";
            StartLevel = "500";
            FinishLevel = "200";
            VolumeGiven = "300";
            RunningTotal = "300";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EndCase_CompleteFinishLevel Instance
        {
            get { return instance; }
        }

#region Variables

        string _CompleteAction;

        /// <summary>
        /// Gets or sets the value of variable CompleteAction.
        /// </summary>
        [TestVariable("71e91bf6-ece7-40a9-9feb-f3a8140c67ef")]
        public string CompleteAction
        {
            get { return _CompleteAction; }
            set { _CompleteAction = value; }
        }

        string _TypeFluid;

        /// <summary>
        /// Gets or sets the value of variable TypeFluid.
        /// </summary>
        [TestVariable("f7ae18a3-6ba7-4d45-bfa5-565672fc56fb")]
        public string TypeFluid
        {
            get { return _TypeFluid; }
            set { _TypeFluid = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable StartLevel.
        /// </summary>
        [TestVariable("d6294252-dd67-4344-9763-91161f8c5a56")]
        public string StartLevel
        {
            get { return repo.StartLevel; }
            set { repo.StartLevel = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FinishLevel.
        /// </summary>
        [TestVariable("b5bd6d59-b746-4598-8ea7-7418a057d42c")]
        public string FinishLevel
        {
            get { return repo.FinishLevel; }
            set { repo.FinishLevel = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable VolumeGiven.
        /// </summary>
        [TestVariable("c29de188-cd8b-4556-9750-20f2ffbd6636")]
        public string VolumeGiven
        {
            get { return repo.VolumeGiven; }
            set { repo.VolumeGiven = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RunningTotal.
        /// </summary>
        [TestVariable("db75e44f-b20d-457f-b577-6ee83566aeb5")]
        public string RunningTotal
        {
            get { return repo.RunningTotal; }
            set { repo.RunningTotal = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.EndAnaesthetic' at Center.", repo.FrmORMain.EndAnaestheticInfo, new RecordItemIndex(0));
            repo.FrmORMain.EndAnaesthetic.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EndAnaestheticConfirmation.ButtonYes' at Center.", repo.EndAnaestheticConfirmation.ButtonYesInfo, new RecordItemIndex(1));
            repo.EndAnaestheticConfirmation.ButtonYes.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmConfirmation.Yes' at Center.", repo.FrmConfirmation.YesInfo, new RecordItemIndex(2));
            repo.FrmConfirmation.Yes.Click();
            Delay.Milliseconds(200);
            
            // Verify the complete FL box exist
            Report.Log(ReportLevel.Info, "Validation", "Verify the complete FL box exist\r\nValidating Exists on item 'AddFluidInput.CompleteFluidFinishLevel'.", repo.AddFluidInput.CompleteFluidFinishLevelInfo, new RecordItemIndex(3));
            Validate.Exists(repo.AddFluidInput.CompleteFluidFinishLevelInfo);
            Delay.Milliseconds(0);
            
            // Comlete finish level require
            FluidCollection.CompleteFinishLevel(CompleteAction, TypeFluid, StartLevel, FinishLevel, VolumeGiven, RunningTotal);
            Delay.Milliseconds(0);
            
            // Do not Print Anaesthetic
            Report.Log(ReportLevel.Info, "Mouse", "Do not Print Anaesthetic\r\nMouse Left Click item 'FrmConfirmation.No' at Center.", repo.FrmConfirmation.NoInfo, new RecordItemIndex(5));
            repo.FrmConfirmation.No.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}