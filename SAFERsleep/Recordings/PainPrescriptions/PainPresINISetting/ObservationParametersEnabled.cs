/*
 * Created by Ranorex
 * User: Admin
 * Date: 25/01/2019
 * Time: 9:49 AM
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
    /// Description of ObservationParametersEnabled.
    /// </summary>
    [TestModule("977C3B41-1BE4-429C-998D-455BCFF581AB", ModuleType.UserCode, 1)]
    public class ObservationParametersEnabled : ITestModule
    {
    	
    	string _stat = "";
    	[TestVariable("2e515fd5-9876-47a9-aab5-e7e3296b4689")]
    	public string stat
    	{
    		get { return _stat; }
    		set { _stat = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ObservationParametersEnabled()
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
	        	Report.Log(ReportLevel.Info, "Application", "Run application 'Set_Obs_Param_Enabled_False.vbs'.");
	            Host.Local.RunApplication(getActualDir + "\\Scripts\\Set_Obs_Param_Enabled_False.vbs", "", getActualDir + "\\Scripts", false);
        	}
        	else if (stat == "true")
        	{
        		Report.Log(ReportLevel.Info, "Application", "Run application 'Set_Obs_Param_Enabled_True.vbs'.");
	            Host.Local.RunApplication(getActualDir + "\\Scripts\\Set_Obs_Param_Enabled_True.vbs", "", getActualDir + "\\Scripts", false);
        	}
        }
    }
}
