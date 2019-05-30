/*
 * Created by Ranorex
 * User: Admin
 * Date: 11/01/2019
 * Time: 4:07 PM
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
    /// Description of ClearAllPrescriptionConfirmation.
    /// </summary>
    [TestModule("4EEC5664-DA50-4D82-9862-85B6CA3A54E9", ModuleType.UserCode, 1)]
    public class ClearAllPrescriptionConfirmation : ITestModule
    {
    	// Repository object to access UI Elements
   		SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
		
		string _Button = "";
		[TestVariable("0ec6019b-cbb7-4946-a3e7-4b4bd97dc51a")]
		public string Button
		{
			get { return _Button; }
			set { _Button = value; }
		}
		
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClearAllPrescriptionConfirmation()
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
            
            if (Button == "Yes")
            {
            	Ranorex.Report.Info("Press Yes to clear all prescriptions");
            	MyRepo.FrmConfirmation.Yes.Click();
            	Delay.Milliseconds(200);
            }
            else if (Button == "No")
            {
            	Ranorex.Report.Info("Press No to revert");
            	MyRepo.FrmConfirmation.No.Click();
            	Delay.Milliseconds(200);
            }
        }
    }
}
