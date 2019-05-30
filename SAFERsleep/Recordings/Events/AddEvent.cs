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

namespace SAFERsleep.Recordings.Events
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddEvent recording.
    /// </summary>
    [TestModule("1a64c796-e88c-44bb-8511-607d9b5eda4f", ModuleType.Recording, 1)]
    public partial class AddEvent : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static AddEvent instance = new AddEvent();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddEvent()
        {
            EventGroup = "General";
            EventDescription = "Anaesthesia Start";
            EventComment = "this is a test comment";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddEvent Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable EventDescription.
        /// </summary>
        [TestVariable("2158366d-4624-4d8b-9f27-bfccf82ae541")]
        public string EventDescription
        {
            get { return repo.EventDescription; }
            set { repo.EventDescription = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable EventGroup.
        /// </summary>
        [TestVariable("b2250061-67ff-4b9e-9387-e6296b10eb8c")]
        public string EventGroup
        {
            get { return repo.EventGroup; }
            set { repo.EventGroup = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable EventComment.
        /// </summary>
        [TestVariable("49ceed78-5bdb-4fb1-a824-23cf6774ca19")]
        public string EventComment
        {
            get { return repo.EventComment; }
            set { repo.EventComment = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.Events.AddEventF3' at Center.", repo.FrmORMain.Events.AddEventF3Info, new RecordItemIndex(0));
            repo.FrmORMain.Events.AddEventF3.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmEditEvent.Group' at Center.", repo.FrmEditEvent.GroupInfo, new RecordItemIndex(1));
            repo.FrmEditEvent.Group.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EventGroup'.", new RecordItemIndex(2));
            Keyboard.Press(EventGroup);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmEditEvent.Description' at Center.", repo.FrmEditEvent.DescriptionInfo, new RecordItemIndex(4));
            repo.FrmEditEvent.Description.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EventDescription'.", new RecordItemIndex(5));
            Keyboard.Press(EventDescription);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(6));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmEditEvent.Comment' at Center.", repo.FrmEditEvent.CommentInfo, new RecordItemIndex(7));
            repo.FrmEditEvent.Comment.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EventComment'.", new RecordItemIndex(8));
            Keyboard.Press(EventComment);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmEditEvent.OK' at Center.", repo.FrmEditEvent.OKInfo, new RecordItemIndex(9));
            repo.FrmEditEvent.OK.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmORMain.Events.EventListItem'.", repo.FrmORMain.Events.EventListItemInfo, new RecordItemIndex(10));
            Validate.Exists(repo.FrmORMain.Events.EventListItemInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
