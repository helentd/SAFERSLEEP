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

namespace SAFERsleep.Recordings.Templates
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Discharge_Save_Template recording.
    /// </summary>
    [TestModule("a894c9da-b581-400a-8c64-22142df4d0d8", ModuleType.Recording, 1)]
    public partial class Discharge_Save_Template : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static Discharge_Save_Template instance = new Discharge_Save_Template();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Discharge_Save_Template()
        {
            TemplateName = "Auto Discharge Prescription";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Discharge_Save_Template Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable TemplateName.
        /// </summary>
        [TestVariable("7d5221ee-f10d-4de1-a07d-367e4c113a7e")]
        public string TemplateName
        {
            get { return repo.TemplateName; }
            set { repo.TemplateName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DischarSupply.
        /// </summary>
        [TestVariable("97a6c343-dae8-4e4f-bbdf-3627b518bf73")]
        public string DischarSupply
        {
            get { return repo.DischarSupply; }
            set { repo.DischarSupply = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DischarInstruction.
        /// </summary>
        [TestVariable("8ed1c80c-50c0-463d-83a3-bbc3e2ac725f")]
        public string DischarInstruction
        {
            get { return repo.DischarInstruction; }
            set { repo.DischarInstruction = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DischargeDrug.
        /// </summary>
        [TestVariable("cea22d0d-9404-448a-bf5f-9439925141c0")]
        public string DischargeDrug
        {
            get { return repo.DischargeDrug; }
            set { repo.DischargeDrug = value; }
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Templates.TemplatesForm.SaveCurrentScreenAsTemplate' at Center.", repo.Templates.TemplatesForm.SaveCurrentScreenAsTemplateInfo, new RecordItemIndex(1));
            repo.Templates.TemplatesForm.SaveCurrentScreenAsTemplate.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Back' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaveTemplate.TemplateName' at Center.", repo.SaveTemplate.TemplateNameInfo, new RecordItemIndex(3));
            repo.SaveTemplate.TemplateName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TemplateName'.", new RecordItemIndex(4));
            Keyboard.Press(TemplateName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(5));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaveTemplate.ButtonOK' at Center.", repo.SaveTemplate.ButtonOKInfo, new RecordItemIndex(6));
            repo.SaveTemplate.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Templates.TemplatesForm.TemplateListItem' at Center.", repo.Templates.TemplatesForm.TemplateListItemInfo, new RecordItemIndex(7));
            repo.Templates.TemplatesForm.TemplateListItem.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Templates.TemplatesForm.ViewTemplate' at Center.", repo.Templates.TemplatesForm.ViewTemplateInfo, new RecordItemIndex(8));
            repo.Templates.TemplatesForm.ViewTemplate.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TemplateAdministration.DischargeInsListItem'.", repo.TemplateAdministration.DischargeInsListItemInfo, new RecordItemIndex(9));
            Validate.Exists(repo.TemplateAdministration.DischargeInsListItemInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TemplateAdministration.ButtonClose' at Center.", repo.TemplateAdministration.ButtonCloseInfo, new RecordItemIndex(10));
            repo.TemplateAdministration.ButtonClose.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Templates.TemplatesForm.Close' at Center.", repo.Templates.TemplatesForm.CloseInfo, new RecordItemIndex(11));
            repo.Templates.TemplatesForm.Close.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}