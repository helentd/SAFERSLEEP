/*
 * Created by Ranorex
 * User: Admin
 * Date: 11/02/2019
 * Time: 11:24 AM
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

namespace SAFERsleep.Recordings.PainPrescriptions.PresListValidation
{
    /// <summary>
    /// Description of ValidatePrescriptionNotExist.
    /// </summary>
    [TestModule("EB7F8943-E8B3-4F17-998A-9A60FA8ECF5E", ModuleType.UserCode, 1)]
    public class ValidatePrescriptionNotExist : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _PrescriptionType = "";
    	[TestVariable("b38ac782-9121-4291-bea9-c1f67473faca")]
    	public string PrescriptionType
    	{
    		get { return _PrescriptionType; }
    		set { _PrescriptionType = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidatePrescriptionNotExist()
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
            
            MyRepo.Item = PrescriptionType;
            Ranorex.Report.Info("Confirm if selected Pain Prescription is not in the list");
            Validate.IsFalse(MyRepo.FrmORMain.PainPrescriptions.AddedPrescriptionInfo.Exists(2000));
        }
    }
}
