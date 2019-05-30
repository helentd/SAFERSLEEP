/*
 * Created by Ranorex
 * User: Admin
 * Date: 31/01/2019
 * Time: 10:02 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace SAFERsleep.Recordings.PainPrescriptions.PainPresINISetting
{
    /// <summary>
    /// Description of PainPrescriptionModuleEnabled.
    /// </summary>
    [TestModule("B2502761-A7E6-4342-B80C-DC03A0D9541E", ModuleType.UserCode, 1)]
    public class PainPrescriptionModuleEnabled : ITestModule
    {
    	
    	string _stat = "";
    	[TestVariable("4e5f8b85-5955-48ec-bed4-2a9b9aa4b183")]
    	public string stat
    	{
    		get { return _stat; }
    		set { _stat = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PainPrescriptionModuleEnabled()
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
            
            string getActualDir = Directory.GetParent(Directory.GetParent(TestSuite.WorkingDirectory.ToString()).ToString()).ToString();
            if (stat == "false")
        	{
	        	Report.Log(ReportLevel.Info, "Application", "Run application 'Set_PainPrescriptionModule_Enabled_False.vbs'.");
	            Host.Local.RunApplication(getActualDir + "\\Scripts\\Set_PainPrescriptionModule_Enabled_False.vbs", "", getActualDir + "\\Scripts", false);
        	}
        	else if (stat == "true")
        	{
        		Report.Log(ReportLevel.Info, "Application", "Run application 'Set_PainPrescriptionModule_Enabled_True.vbs'.");
	            Host.Local.RunApplication(getActualDir + "\\Scripts\\Set_PainPrescriptionModule_Enabled_True.vbs", "", getActualDir + "\\Scripts", false);
        	}
        }
    }
}
