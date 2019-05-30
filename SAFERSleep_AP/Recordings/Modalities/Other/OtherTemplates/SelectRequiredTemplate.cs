/*
 * Created by Ranorex
 * User: Admin
 * Date: 14/03/2019
 * Time: 2:32 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace SAFERSleep_AP.Recordings.Modalitties.OralTemplates
{
    /// <summary>
    /// Description of SelectRequiredTemplate.
    /// </summary>
    [TestModule("F3FE4AFB-30E1-47D6-81CF-FCF6346E22C3", ModuleType.UserCode, 1)]
    public class SelectRequiredTemplate : ITestModule
    {
    	SAFERSleep_APRepository MyRepo = new SAFERSleep_APRepository();
    	
    	string _Template = "Standard";
    	[TestVariable("25d50aff-d640-4104-bf88-5a4cc2fa1464")]
    	public string Template
    	{
    		get { return _Template; }
    		set { _Template = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectRequiredTemplate()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            Ranorex.Report.Info("Select Oral Modality required template: "+Template);
            if (Template == "Standard")
            	MyRepo.MainWindow.Modalities.OtherModalityTemplate.Standard.Click();
            else if (Template == "Elderly")
            	MyRepo.MainWindow.Modalities.OtherModalityTemplate.Elderly.Click();
        }
    }
}
