/*
 * Created by Ranorex
 * User: Admin
 * Date: 30/01/2019
 * Time: 9:07 AM
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
    /// Description of WeightConfirmationEnabled.
    /// </summary>
    [TestModule("BAEC5A6A-5692-45A8-AB3D-A63D645E8580", ModuleType.UserCode, 1)]
    public class WeightConfirmationEnabled : ITestModule
    {
    	
    	string _stat = "";
    	[TestVariable("bb40e6c1-f310-43a3-8375-dee174f077b0")]
    	public string stat
    	{
    		get { return _stat; }
    		set { _stat = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WeightConfirmationEnabled()
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
	        	Report.Log(ReportLevel.Info, "Application", "Run application 'Set_ConfirmWeight_False.vbs'.");
	            Host.Local.RunApplication(getActualDir + "\\Scripts\\Set_ConfirmWeight_False.vbs", "", getActualDir + "\\Scripts", false);
        	}
        	else if (stat == "true")
        	{
        		Report.Log(ReportLevel.Info, "Application", "Run application 'Set_ConfirmWeight_True.vbs'.");
	            Host.Local.RunApplication(getActualDir + "\\Scripts\\Set_ConfirmWeight_True.vbs", "", getActualDir + "\\Scripts", false);
        	}
        }
    }
}
