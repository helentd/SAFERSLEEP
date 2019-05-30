/*
 * Created by Ranorex
 * User: Win7-VM
 * Date: 11/02/2019
 * Time: 4:18 p.m.
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

namespace SAFERsleep.Recordings.Fluids.INISetting
{
    /// <summary>
    /// Description of FLuidFinishLEvelRequired.
    /// </summary>
    [TestModule("1F390D25-6689-4423-B313-F10A448E35D0", ModuleType.UserCode, 1)]
    public class FLuidInput : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FLuidInput()
        {
            // Do not delete - a parameterless constructor is required!
        }

string _SetValue = "True";
[TestVariable("93b1649a-920e-4200-b741-ac759df707e6")]
public string SetValue
{
	get { return _SetValue; }
	set { _SetValue = value; }
}

string _SetField = "FinishLvel_Required";
[TestVariable("a3ca8945-99a7-49bf-a03d-bb65e73af56f")]
public string SetField
{
	get { return _SetField; }
	set { _SetField = value; }
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
            
           // if (SetField="FinishLvel_Required") {
            	
            	if (SetValue == "false")
	        	{
		        	Report.Log(ReportLevel.Info, "Application", "Run application 'Set_Fluid_FinishLevel_Required_False.vbs'.");
		            Host.Local.RunApplication(getActualDir + "\\Scripts\\Set_Fluid_FinishLevel_Required_False.vbs", "", getActualDir + "\\Scripts\\", false);
	        	}
	        	else if (SetValue == "true")
	        	{
	        		Report.Log(ReportLevel.Info, "Application", "Run application 'Set_Fluid_FinishLevel_Required_True.vbs'.");
		            Host.Local.RunApplication(getActualDir + "\\Scripts\\Set_Fluid_FinishLevel_Required_True.vbs", "", getActualDir + "\\Scripts\\", false);
	        	}
            	
           
            
        }
    }
}
