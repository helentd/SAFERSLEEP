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

namespace SAFERsleep.Recordings.RegionalBlock
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EnterNewSurgeon recording.
    /// </summary>
    [TestModule("cfbb4b73-7e54-4226-bb80-1cbd6d23fee8", ModuleType.Recording, 1)]
    public partial class EnterNewSurgeon : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static EnterNewSurgeon instance = new EnterNewSurgeon();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterNewSurgeon()
        {
            SurgeonFirstName = "";
            SurgeonLastName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterNewSurgeon Instance
        {
            get { return instance; }
        }

#region Variables

        string _SurgeonFirstName;

        /// <summary>
        /// Gets or sets the value of variable SurgeonFirstName.
        /// </summary>
        [TestVariable("f2a569c2-d514-47b6-9cd8-6aa4d48a16be")]
        public string SurgeonFirstName
        {
            get { return _SurgeonFirstName; }
            set { _SurgeonFirstName = value; }
        }

        string _SurgeonLastName;

        /// <summary>
        /// Gets or sets the value of variable SurgeonLastName.
        /// </summary>
        [TestVariable("d4a59fb8-366f-422f-a287-7cea82481ed1")]
        public string SurgeonLastName
        {
            get { return _SurgeonLastName; }
            set { _SurgeonLastName = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PleaseEnterSurgeon.AddNewTeamMember' at Center.", repo.PleaseEnterSurgeon.AddNewTeamMemberInfo, new RecordItemIndex(0));
            repo.PleaseEnterSurgeon.AddNewTeamMember.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddNewClinicalTeamMember.FirstName' at Center.", repo.AddNewClinicalTeamMember.FirstNameInfo, new RecordItemIndex(1));
            repo.AddNewClinicalTeamMember.FirstName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SurgeonFirstName'.", new RecordItemIndex(2));
            Keyboard.Press(SurgeonFirstName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddNewClinicalTeamMember.LastName' at Center.", repo.AddNewClinicalTeamMember.LastNameInfo, new RecordItemIndex(3));
            repo.AddNewClinicalTeamMember.LastName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SurgeonLastName'.", new RecordItemIndex(4));
            Keyboard.Press(SurgeonLastName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddNewClinicalTeamMember.ButtonOK' at Center.", repo.AddNewClinicalTeamMember.ButtonOKInfo, new RecordItemIndex(5));
            repo.AddNewClinicalTeamMember.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PleaseEnterSurgeon.ButtonOK' at Center.", repo.PleaseEnterSurgeon.ButtonOKInfo, new RecordItemIndex(6));
            repo.PleaseEnterSurgeon.ButtonOK.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}