﻿/*
 * Created by Ranorex
 * User: Admin
 * Date: 17/01/2019
 * Time: 11:55 AM
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

namespace SAFERsleep.Recordings.Print
{
    /// <summary>
    /// Description of ValidateRegInf_Ticked.
    /// </summary>
    [TestModule("473C539D-E94F-478D-9C14-08DF41E97BB7", ModuleType.UserCode, 1)]
    public class ValidateRegInf_Ticked : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _Status = "";
    	[TestVariable("070bafd7-99a0-4676-b0aa-e037a49d5f7c")]
    	public string Status
    	{
    		get { return _Status; }
    		set { _Status = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateRegInf_Ticked()
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
            
            if (Status == "Ticked")
            {
            	Ranorex.Report.Info("Validate Regional Infusion Prescription is ticked for printing");
            	string ActualStatus = MyRepo.Print.RegionalInfusionPrescription.Element.GetAttributeValueText("Checked");
            	Validate.AreEqual(ActualStatus, "True");
            }
            else if (Status == "Not Ticked")
            {
            	Ranorex.Report.Info("Validate Regional Infusion Prescription is not ticked for printing");
            	string ActualStatus = MyRepo.Print.RegionalInfusionPrescription.Element.GetAttributeValueText("Checked");
            	Validate.AreEqual(ActualStatus, "False");
            }
        }
    }
}
