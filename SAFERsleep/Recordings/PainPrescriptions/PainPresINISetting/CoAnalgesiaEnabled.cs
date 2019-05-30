/*
 * Created by Ranorex
 * User: Admin
 * Date: 8/02/2019
 * Time: 10:15 AM
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
    /// Description of CoAnalgesiaEnabled.
    /// </summary>
    [TestModule("910BE4F2-8F1D-4A63-875E-62081D723E3C", ModuleType.UserCode, 1)]
    public class CoAnalgesiaEnabled : ITestModule
    {
    	
    	string _stat = "";
    	[TestVariable("7ae120de-0456-4b35-8ba1-a840722383f0")]
    	public string stat
    	{
    		get { return _stat; }
    		set { _stat = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CoAnalgesiaEnabled()
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
	        	Report.Log(ReportLevel.Info, "Application", "Run application 'Set_CoAnalgesia_Enabled_False.vbs'.");
	            Host.Local.RunApplication(getActualDir + "\\Scripts\\Set_CoAnalgesia_Enabled_False.vbs", "", getActualDir + "\\Scripts", false);
        	}
        	else if (stat == "true")
        	{
        		Report.Log(ReportLevel.Info, "Application", "Run application 'Set_CoAnalgesia_Enabled_True.vbs'.");
	            Host.Local.RunApplication(getActualDir + "\\Scripts\\Set_CoAnalgesia_Enabled_True.vbs", "", getActualDir + "\\Scripts", false);
        	}
        }
    }
}
