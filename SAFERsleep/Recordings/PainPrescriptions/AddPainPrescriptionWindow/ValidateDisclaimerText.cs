/*
 * Created by Ranorex
 * User: Admin
 * Date: 20/12/2018
 * Time: 1:40 PM
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
    /// Description of ValidateDisclaimerText.
    /// </summary>
    [TestModule("AD3A6A0B-3F4A-41C5-B219-F3A18C6A3FA4", ModuleType.UserCode, 1)]
    public class ValidateDisclaimerText : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _Disclaimer = "";
    	[TestVariable("cfc90fd0-4ec3-4dc8-a227-f1a32db6a57e")]
    	public string Disclaimer
    	{
    		get { return _Disclaimer; }
    		set { _Disclaimer = value; }
    	}
    	
    	string _FormName = "";
    	[TestVariable("9b40c457-6ae2-490f-a5f8-cba91dcad4fe")]
    	public string FormName
    	{
    		get { return _FormName; }
    		set { _FormName = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateDisclaimerText()
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
            
            Ranorex.Report.Info("Validate Toxicity Zero Disclaimer Text");
            string DisclaimerTextActual = MyRepo.AddPainPrescription.Disclaimer.Element.GetAttributeValueText("Text");
            Validate.AreEqual(DisclaimerTextActual, Disclaimer);
        }
    }
}
