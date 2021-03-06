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

namespace SAFERsleep.Recordings.Templates.ApplyingTemplate
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Events_Apply_Template recording.
    /// </summary>
    [TestModule("b0371cc7-723f-4275-a47c-809a333a345e", ModuleType.Recording, 1)]
    public partial class Events_Apply_Template : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static Events_Apply_Template instance = new Events_Apply_Template();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Events_Apply_Template()
        {
            TemplateName = "Auto Events";
            EventComment = "testing only";
            EventDescription = "Awake Fibreoptic";
            EventGroup = "Airway";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Events_Apply_Template Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable TemplateName.
        /// </summary>
        [TestVariable("1e4aca5b-2112-4f79-a4bf-9ef97efb938f")]
        public string TemplateName
        {
            get { return repo.TemplateName; }
            set { repo.TemplateName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable EventComment.
        /// </summary>
        [TestVariable("3c37853f-f48a-45e5-8781-76a7fa7943d0")]
        public string EventComment
        {
            get { return repo.EventComment; }
            set { repo.EventComment = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable EventDescription.
        /// </summary>
        [TestVariable("0b814e55-1d25-4d69-80e7-94e975692542")]
        public string EventDescription
        {
            get { return repo.EventDescription; }
            set { repo.EventDescription = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable EventGroup.
        /// </summary>
        [TestVariable("3dac64ee-a22a-419f-bb49-069da512f64e")]
        public string EventGroup
        {
            get { return repo.EventGroup; }
            set { repo.EventGroup = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.Templates' at Center.", repo.FrmORMain.TemplatesInfo, new RecordItemIndex(0));
            repo.FrmORMain.Templates.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Templates.TemplatesForm.TemplateListItem' at Center.", repo.Templates.TemplatesForm.TemplateListItemInfo, new RecordItemIndex(1));
            repo.Templates.TemplatesForm.TemplateListItem.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Templates.TemplatesForm.ViewTemplate' at Center.", repo.Templates.TemplatesForm.ViewTemplateInfo, new RecordItemIndex(2));
            repo.Templates.TemplatesForm.ViewTemplate.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TemplateAdministration.EventListItem'.", repo.TemplateAdministration.EventListItemInfo, new RecordItemIndex(3));
            Validate.Exists(repo.TemplateAdministration.EventListItemInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TemplateAdministration.ButtonClose' at Center.", repo.TemplateAdministration.ButtonCloseInfo, new RecordItemIndex(4));
            repo.TemplateAdministration.ButtonClose.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Templates.TemplatesForm.ApplyToCurrentScreen' at Center.", repo.Templates.TemplatesForm.ApplyToCurrentScreenInfo, new RecordItemIndex(5));
            repo.Templates.TemplatesForm.ApplyToCurrentScreen.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmORMain.Events.EventListItem'.", repo.FrmORMain.Events.EventListItemInfo, new RecordItemIndex(6));
            Validate.Exists(repo.FrmORMain.Events.EventListItemInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
