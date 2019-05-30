/*
 * Created by Ranorex
 * User: Admin
 * Date: 21/01/2019
 * Time: 2:19 PM
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

namespace SAFERsleep.Recordings.Patient_Details.Patient_or_Operation
{
    /// <summary>
    /// Description of ValidateBMI.
    /// </summary>
    [TestModule("C7AF9C48-D196-4A58-8F1A-E3E1CF7BE663", ModuleType.UserCode, 1)]
    public class ValidateBMI : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _BMI = "";
    	[TestVariable("429e0557-2116-4a3b-b806-c8a814086c0a")]
    	public string BMI
    	{
    		get { return _BMI; }
    		set { _BMI = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateBMI()
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
            
            string BMIActual = MyRepo.FrmORMain.Patient_Details.Patient_or_Operation.BMI.Element.GetAttributeValueText("Text");
            Ranorex.Report.Info("Validate Patient's BMI which should be: "+BMI);
            Validate.AreEqual(BMIActual, BMI);
        }
    }
}
