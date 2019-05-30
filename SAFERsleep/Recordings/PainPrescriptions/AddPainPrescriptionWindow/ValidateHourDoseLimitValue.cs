/*
 * Created by Ranorex
 * User: Admin
 * Date: 18/12/2018
 * Time: 12:25 PM
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
    /// Description of ValidateHourDoseLimitValue.
    /// </summary>
    [TestModule("2EFBC510-FB16-4B54-BFD7-EECF570D1C10", ModuleType.UserCode, 1)]
    public class ValidateHourDoseLimitValue : ITestModule
    {  	
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _DoseLimitValue = "";
    	[TestVariable("8ac38cb1-f9b3-463a-906f-b73d5800aefe")]
    	public string DoseLimitValue
    	{
    		get { return _DoseLimitValue; }
    		set { _DoseLimitValue = value; }
    	}
    	
    	
    	string _FormName = "";
    	[TestVariable("76f80f9b-71c7-46b7-8830-ad91e7146d4b")]
    	public string FormName
    	{
    		get { return _FormName; }
    		set { _FormName = value; }
    	}
    	
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateHourDoseLimitValue()
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
     
            string DoseLimitActual = MyRepo.AddPainPrescription.DoseDetails.DoseLimit.Element.GetAttributeValueText("Text");
            
            Ranorex.Report.Info("Validate the value in Dose Limit which is: "+DoseLimitValue);
            Validate.AreEqual(DoseLimitActual, DoseLimitValue);
        }
    }
}
