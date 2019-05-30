/*
 * Created by Ranorex
 * User: Admin
 * Date: 19/12/2018
 * Time: 3:21 PM
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
    /// Description of ValidateHourDoseLimitCalc.
    /// </summary>
    [TestModule("9E9E881E-7A65-4117-ADAC-CCDDC47FB5B6", ModuleType.UserCode, 1)]
    public class ValidateHourDoseLimitCalc : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _FormName = "";
    	[TestVariable("fa88248a-2bc3-4523-be2a-2b5bd300c3ec")]
    	public string FormName
    	{
    		get { return _FormName; }
    		set { _FormName = value; }
    	}
	 	
	 	float _BolusDose = 0;
	 	[TestVariable("13e7bec0-441a-4cc7-8597-5c21e4b5c7f5")]
	 	public float BolusDose
	 	{
	 		get { return _BolusDose; }
	 		set { _BolusDose = value; }
	 	}
	 	
	 	float _ContinuousRate = 0;
	 	[TestVariable("2e83eec6-6660-47d2-bd2f-dc9f15c5a21d")]
	 	public float ContinuousRate
	 	{
	 		get { return _ContinuousRate; }
	 		set { _ContinuousRate = value; }
	 	} 	
	 	
	 	float _Lockout = 0;
	 	[TestVariable("3e32911d-41e7-4dc4-9b27-42ff0e6775e6")]
	 	public float Lockout
	 	{
	 		get { return _Lockout; }
	 		set { _Lockout = value; }
	 	}
	 	
	 	float _hr = 0;
	 	[TestVariable("c4bbe68c-01c3-4580-aa45-ad93d641fa3f")]
	 	public float hr
	 	{
	 		get { return _hr; }
	 		set { _hr = value; }
	 	}
	 	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateHourDoseLimitCalc()
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
    
            MyRepo.AddPainPrescription.DoseDetails.DoseLimit.Click();
            
            string DoseLimitActual = MyRepo.AddPainPrescription.DoseDetails.DoseLimit.Element.GetAttributeValueText("Text");         
            
            float DoseLimitCalc = (((BolusDose/Lockout)*60)+ContinuousRate)*hr;
            
            Ranorex.Report.Info("Validate the value in Dose Limit which is: "+DoseLimitCalc.ToString("0.##"));
            Validate.AreEqual(DoseLimitActual, DoseLimitCalc.ToString("0.##"));
        }
    }
}
