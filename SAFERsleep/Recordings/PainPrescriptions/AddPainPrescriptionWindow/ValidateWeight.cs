/*
 * Created by Ranorex
 * User: Admin
 * Date: 11/01/2019
 * Time: 10:20 AM
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
    /// Description of ValidateWeight.
    /// </summary>
    [TestModule("CAB7A652-785C-40E9-8134-5DBA511DA9FA", ModuleType.UserCode, 1)]
    public class ValidateWeight : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _FormName = "";
    	[TestVariable("baafb29e-cfae-4d6d-a83d-0ed2eca6ea62")]
    	public string FormName
    	{
    		get { return _FormName; }
    		set { _FormName = value; }
    	}
    	
    	string _PatientWeight = "";
    	[TestVariable("b9ff201a-0fd6-4868-af10-7034147161a7")]
    	public string PatientWeight
    	{
    		get { return _PatientWeight; }
    		set { _PatientWeight = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateWeight()
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
            
            MyRepo.FormName = FormName;
            
            Ranorex.Report.Info("Validate Patient Weight default value is: "+PatientWeight);
            Validate.AreEqual(MyRepo.AddPainPrescription.Weight.Element.GetAttributeValueText("Text"), PatientWeight);
        }
    }
}
