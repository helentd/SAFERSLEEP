/*
 * Created by Ranorex
 * User: Admin
 * Date: 7/01/2019
 * Time: 11:43 AM
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
    /// Description of ValidateHourDoseLimitNull.
    /// </summary>
    [TestModule("25B8F732-8285-4B55-A890-38200A145475", ModuleType.UserCode, 1)]
    public class ValidateHourDoseLimitNull : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _FormName = "";
    	[TestVariable("cc88d764-289b-4952-b730-3e17e8cdd891")]
    	public string FormName
    	{
    		get { return _FormName; }
    		set { _FormName = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateHourDoseLimitNull()
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
            
            Ranorex.Report.Info("Validate Hour Dose Limit Value is null");
            Validate.IsTrue(String.IsNullOrEmpty(DoseLimitActual));
        }
    }
}
