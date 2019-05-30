/*
 * Created by Ranorex
 * User: Admin
 * Date: 25/01/2019
 * Time: 10:59 AM
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
    /// Description of ObservationParametersLocked.
    /// </summary>
    [TestModule("6A19C7E5-3689-45CE-9D64-245C9D6252EA", ModuleType.UserCode, 1)]
    public class ObservationParametersReadOnly : ITestModule
    {
    	
    	string _stat = "";
    	[TestVariable("d7ca5c5a-c8e9-4e1b-ab40-f950a2bdc2f3")]
    	public string stat
    	{
    		get { return _stat; }
    		set { _stat = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ObservationParametersReadOnly()
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
	        	Report.Log(ReportLevel.Info, "Application", "Run application 'Set_Obs_Param_ReadOnly_False.vbs'.");
	            Host.Local.RunApplication(getActualDir + "\\Scripts\\Set_Obs_Param_ReadOnly_False.vbs", "", getActualDir + "\\Scripts", false);
        	}
        	else if (stat == "true")
        	{
        		Report.Log(ReportLevel.Info, "Application", "Run application 'Set_Obs_Param_ReadOnly_True.vbs'.");
	            Host.Local.RunApplication(getActualDir + "\\Scripts\\Set_Obs_Param_ReadOnly_True.vbs", "", getActualDir + "\\Scripts", false);
        	}
        }
    }
}
