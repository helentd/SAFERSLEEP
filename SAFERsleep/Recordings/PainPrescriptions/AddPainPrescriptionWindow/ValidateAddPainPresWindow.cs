/*
 * Created by Ranorex
 * User: Admin
 * Date: 30/01/2019
 * Time: 3:38 PM
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

namespace SAFERsleep.Recordings.PainPrescriptions.AddPainPrescriptionWindow
{
    /// <summary>
    /// Description of ValidateAddPainPresWindow.
    /// </summary>
    [TestModule("17DBFE89-5434-4F6E-A343-700A6F2F0B54", ModuleType.UserCode, 1)]
    public class ValidateAddPainPresWindow : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _Exists = "";
    	[TestVariable("a7d7cac2-84e6-4502-9014-3cbc62028726")]
    	public string Exists
    	{
    		get { return _Exists; }
    		set { _Exists = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateAddPainPresWindow()
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
            
            if (Exists == "true")
            {
            	Ranorex.Report.Info("Add Pain Prescription window is displayed");
            	Validate.IsTrue(MyRepo.AddPainPrescription.SelfInfo.Exists(2000));
            }
            else if (Exists == "false")
            {
            	Ranorex.Report.Info("Add Pain Prescription window is not displayed");
            	Validate.IsFalse(MyRepo.AddPainPrescription.SelfInfo.Exists(2000));
            }
        }
    }
}
