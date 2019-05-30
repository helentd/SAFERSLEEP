/*
 * Created by Ranorex
 * User: Admin
 * Date: 14/12/2018
 * Time: 2:12 PM
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

namespace SAFERsleep.Recordings.PainPrescriptions
{
    /// <summary>
    /// Description of ValidateNormalClearance.
    /// </summary>
    [TestModule("9838E94C-755D-434A-8036-C16705610306", ModuleType.UserCode, 1)]
    public class ValidateNormalClearance : ITestModule
    {
    	SAFERsleepORRepository repo = new SAFERsleepORRepository();
    	
    	string _Clearance = "";
    	[TestVariable("0ab6f5b7-57a1-49ca-b170-1ff900988404")]
    	public string Clearance
    	{
    		get { return _Clearance; }
    		set { _Clearance = value; }
    	}    	
    	
    	string _FormName = "";
    	[TestVariable("2397ff6f-7f02-450a-b10a-bf2c7d7a4904")]
    	public string FormName
    	{
    		get { return _FormName; }
    		set { _FormName = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateNormalClearance()
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
            
            repo.Clearance = Clearance;
            repo.FormName = FormName;
            
            Ranorex.Report.Info("Toxicity Normal Clearance is: "+Clearance);
            Validate.Exists(repo.AddPainPrescription.DisclaimerNormalClearance);            
            Delay.Milliseconds(200);
        }
    }
}
