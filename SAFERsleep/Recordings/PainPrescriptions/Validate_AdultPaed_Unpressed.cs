/*
 * Created by Ranorex
 * User: Admin
 * Date: 11/01/2019
 * Time: 1:42 PM
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
    /// Description of Validate_AdultPaed_Unpressed.
    /// </summary>
    [TestModule("9C9A8AED-3369-423B-81DE-C829587F2C53", ModuleType.UserCode, 1)]
    public class Validate_AdultPaed_Unpressed : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _Button = "";
    	[TestVariable("574962b1-6451-4158-99db-e4b98c323fec")]
    	public string Button
    	{
    		get { return _Button; }
    		set { _Button = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_AdultPaed_Unpressed()
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
                                  
            string status = "";
            if (Button == "Paediatric")
            {
            	Ranorex.Report.Info("Validate if Paediatric button is not pressed"); 
            	status = MyRepo.FrmORMain.PainPrescriptions.Paediatric.Element.GetAttributeValueText("pressed");
            }
            else if (Button == "Adult")
            {
            	Ranorex.Report.Info("Validate if Adult button is not pressed"); 
            	status = MyRepo.FrmORMain.PainPrescriptions.Adult.Element.GetAttributeValueText("pressed");
            }
            Validate.AreEqual(status, "False");
        }
    }
}
