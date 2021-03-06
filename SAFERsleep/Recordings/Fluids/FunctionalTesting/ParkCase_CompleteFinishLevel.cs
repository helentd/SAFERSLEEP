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
    ///The ParkCase_CompleteFinishLevel recording.
    /// </summary>
    [TestModule("5c55474f-9fbf-4c99-9e46-ac245f02572c", ModuleType.Recording, 1)]
    public partial class ParkCase_CompleteFinishLevel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static ParkCase_CompleteFinishLevel instance = new ParkCase_CompleteFinishLevel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ParkCase_CompleteFinishLevel()
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
        public static ParkCase_CompleteFinishLevel Instance
        {
            get { return instance; }
        }

#region Variables

        string _CompleteAction;

        /// <summary>
        /// Gets or sets the value of variable CompleteAction.
        /// </summary>
        [TestVariable("e17de8d0-6f17-42fa-98b0-6a6401346fdd")]
        public string CompleteAction
        {
            get { return _CompleteAction; }
            set { _CompleteAction = value; }
        }

        string _TypeFluid;

        /// <summary>
        /// Gets or sets the value of variable TypeFluid.
        /// </summary>
        [TestVariable("3ae2d6e7-5d52-4bba-8705-ee1ca658a73f")]
        public string TypeFluid
        {
            get { return _TypeFluid; }
            set { _TypeFluid = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable StartLevel.
        /// </summary>
        [TestVariable("eca51eb3-d2e7-44b9-8bf3-56685a647b15")]
        public string StartLevel
        {
            get { return repo.StartLevel; }
            set { repo.StartLevel = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FinishLevel.
        /// </summary>
        [TestVariable("dfc83df3-5928-4fad-8f44-d9e84647deeb")]
        public string FinishLevel
        {
            get { return repo.FinishLevel; }
            set { repo.FinishLevel = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable VolumeGiven.
        /// </summary>
        [TestVariable("72732214-1aba-42a8-8bae-7f33cdf4cabf")]
        public string VolumeGiven
        {
            get { return repo.VolumeGiven; }
            set { repo.VolumeGiven = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RunningTotal.
        /// </summary>
        [TestVariable("4b29db12-8dca-4c2f-9cca-0a6d2503dc47")]
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

            // Click on Park case
            Report.Log(ReportLevel.Info, "Mouse", "Click on Park case\r\nMouse Left Click item 'FrmORMain.ParkAnaesthetic' at Center.", repo.FrmORMain.ParkAnaestheticInfo, new RecordItemIndex(0));
            repo.FrmORMain.ParkAnaesthetic.Click();
            Delay.Milliseconds(200);
            
            // Click YEs on Park case confirmation
            Report.Log(ReportLevel.Info, "Mouse", "Click YEs on Park case confirmation\r\nMouse Left Click item 'FrmParkAnaestheticConfirmation.ButtonYes' at Center.", repo.FrmParkAnaestheticConfirmation.ButtonYesInfo, new RecordItemIndex(1));
            repo.FrmParkAnaestheticConfirmation.ButtonYes.Click();
            Delay.Milliseconds(200);
            
            // Verify the complete FL box exist
            Report.Log(ReportLevel.Info, "Validation", "Verify the complete FL box exist\r\nValidating Exists on item 'AddFluidInput.CompleteFluidFinishLevel'.", repo.AddFluidInput.CompleteFluidFinishLevelInfo, new RecordItemIndex(2));
            Validate.Exists(repo.AddFluidInput.CompleteFluidFinishLevelInfo);
            Delay.Milliseconds(0);
            
            // Comlete finish level require
            FluidCollection.CompleteFinishLevel(CompleteAction, TypeFluid, StartLevel, FinishLevel, VolumeGiven, RunningTotal);
            Delay.Milliseconds(0);
            
            // Chick do not Print Anaesthetic
            Report.Log(ReportLevel.Info, "Mouse", "Chick do not Print Anaesthetic\r\nMouse Left Click item 'FrmConfirmation.No' at Center.", repo.FrmConfirmation.NoInfo, new RecordItemIndex(4));
            repo.FrmConfirmation.No.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
