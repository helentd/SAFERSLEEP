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
    ///The Pain_Pres_PCA_Apply_Template recording.
    /// </summary>
    [TestModule("06bdf365-0dfa-473e-b087-3fb686e3a7ac", ModuleType.Recording, 1)]
    public partial class Pain_Pres_PCA_Apply_Template : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static Pain_Pres_PCA_Apply_Template instance = new Pain_Pres_PCA_Apply_Template();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pain_Pres_PCA_Apply_Template()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pain_Pres_PCA_Apply_Template Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable PrescriptionType.
        /// </summary>
        [TestVariable("16bcb67e-3d39-4841-a19b-65743594bffd")]
        public string PrescriptionType
        {
            get { return repo.PrescriptionType; }
            set { repo.PrescriptionType = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TemplateName.
        /// </summary>
        [TestVariable("1e4aca5b-2112-4f79-a4bf-9ef97efb938f")]
        public string TemplateName
        {
            get { return repo.TemplateName; }
            set { repo.TemplateName = value; }
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TemplateAdministration.PCA.PCAIntravenousTab' at Center.", repo.TemplateAdministration.PCA.PCAIntravenousTabInfo, new RecordItemIndex(3));
            repo.TemplateAdministration.PCA.PCAIntravenousTab.Click();
            Delay.Milliseconds(200);
            
            GetTemplateValues();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TemplateAdministration.ButtonClose' at Center.", repo.TemplateAdministration.ButtonCloseInfo, new RecordItemIndex(5));
            repo.TemplateAdministration.ButtonClose.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Templates.TemplatesForm.ApplyToCurrentScreen' at Center.", repo.Templates.TemplatesForm.ApplyToCurrentScreenInfo, new RecordItemIndex(6));
            repo.Templates.TemplatesForm.ApplyToCurrentScreen.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TemplateConfirmation.PCAIntravenous' at Center.", repo.TemplateConfirmation.PCAIntravenousInfo, new RecordItemIndex(7));
            repo.TemplateConfirmation.PCAIntravenous.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TemplateConfirmation.ButtonOK' at Center.", repo.TemplateConfirmation.ButtonOKInfo, new RecordItemIndex(8));
            repo.TemplateConfirmation.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            ValidateTemplateApplied();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
