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
    ///The Fluid_Apply_Template recording.
    /// </summary>
    [TestModule("70302aa5-904a-442b-aea4-4ac5d48c2288", ModuleType.Recording, 1)]
    public partial class Fluid_Apply_Template : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static Fluid_Apply_Template instance = new Fluid_Apply_Template();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Fluid_Apply_Template()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Fluid_Apply_Template Instance
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
        /// Gets or sets the value of variable FluidInstruction.
        /// </summary>
        [TestVariable("6ec28f55-412a-4d98-a958-d1b30ccecd21")]
        public string FluidInstruction
        {
            get { return repo.FluidInstruction; }
            set { repo.FluidInstruction = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FluidRate.
        /// </summary>
        [TestVariable("f438dd07-70ce-4ff2-ab1f-87313b802fbc")]
        public string FluidRate
        {
            get { return repo.FluidRate; }
            set { repo.FluidRate = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FluidVolume.
        /// </summary>
        [TestVariable("ea79c042-41bd-43a7-82f0-cf631466a6dd")]
        public string FluidVolume
        {
            get { return repo.FluidVolume; }
            set { repo.FluidVolume = value; }
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
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.PostOpInstructions.FluidPrescription' at Center.", repo.FrmORMain.PostOpInstructions.FluidPrescriptionInfo, new RecordItemIndex(0));
            repo.FrmORMain.PostOpInstructions.FluidPrescription.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.Templates' at Center.", repo.FrmORMain.TemplatesInfo, new RecordItemIndex(1));
            repo.FrmORMain.Templates.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Templates.TemplatesForm.TemplateListItem' at Center.", repo.Templates.TemplatesForm.TemplateListItemInfo, new RecordItemIndex(2));
            repo.Templates.TemplatesForm.TemplateListItem.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Templates.TemplatesForm.ViewTemplate' at Center.", repo.Templates.TemplatesForm.ViewTemplateInfo, new RecordItemIndex(3));
            repo.Templates.TemplatesForm.ViewTemplate.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TemplateAdministration.FluidPresListItem'.", repo.TemplateAdministration.FluidPresListItemInfo, new RecordItemIndex(4));
            Validate.Exists(repo.TemplateAdministration.FluidPresListItemInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TemplateAdministration.ButtonClose' at Center.", repo.TemplateAdministration.ButtonCloseInfo, new RecordItemIndex(5));
            repo.TemplateAdministration.ButtonClose.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Templates.TemplatesForm.ApplyToCurrentScreen' at Center.", repo.Templates.TemplatesForm.ApplyToCurrentScreenInfo, new RecordItemIndex(6));
            repo.Templates.TemplatesForm.ApplyToCurrentScreen.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmORMain.PostOpInstructions.Fluid.FluidListItem'.", repo.FrmORMain.PostOpInstructions.Fluid.FluidListItemInfo, new RecordItemIndex(7));
            Validate.Exists(repo.FrmORMain.PostOpInstructions.Fluid.FluidListItemInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
