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
    ///The EnterDateAndTime recording.
    /// </summary>
    [TestModule("528cf215-3c02-4b82-a20f-9a52b61babc8", ModuleType.Recording, 1)]
    public partial class EnterDateAndTime : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static EnterDateAndTime instance = new EnterDateAndTime();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterDateAndTime()
        {
            NewDate = "6/02/2019";
            NewTime = "14:14";
            TimeAddFluid = "14:00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterDateAndTime Instance
        {
            get { return instance; }
        }

#region Variables

        string _NewDate;

        /// <summary>
        /// Gets or sets the value of variable NewDate.
        /// </summary>
        [TestVariable("1666fea4-5c15-4491-8b91-12fa571d6c72")]
        public string NewDate
        {
            get { return _NewDate; }
            set { _NewDate = value; }
        }

        string _NewTime;

        /// <summary>
        /// Gets or sets the value of variable NewTime.
        /// </summary>
        [TestVariable("6ff9448e-2c32-4b5f-98f8-eff7a1c479d4")]
        public string NewTime
        {
            get { return _NewTime; }
            set { _NewTime = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TimeAddFluid.
        /// </summary>
        [TestVariable("13f75962-0adf-4482-91a0-60c4fa847d62")]
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

            //UserCodeCollection_OR.Clear_TextBox(repo.AddFluidInput.DateInfo, "Text");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NewDate'.", new RecordItemIndex(1));
            //Keyboard.Press(NewDate);
            //Delay.Milliseconds(100);
            
            UserCodeCollection_OR.Clear_TextBox(repo.AddFluidInput.TimeInfo, "Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NewTime'.", new RecordItemIndex(3));
            Keyboard.Press(NewTime);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'AddFluidInput.Time' and assigning its value to variable 'TimeAddFluid'.", repo.AddFluidInput.TimeInfo, new RecordItemIndex(4));
            TimeAddFluid = repo.AddFluidInput.Time.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
