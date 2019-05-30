/*
 * Created by Ranorex
 * User: Admin
 * Date: 5/02/2019
 * Time: 11:45 AM
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
    /// Description of ValidatePainReferralHidden.
    /// </summary>
    [TestModule("158D8B0D-DC6D-45E3-A504-422193003FF1", ModuleType.UserCode, 1)]
    public class ValidatePainReferral_Hidden : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidatePainReferral_Hidden()
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

            Ranorex.Report.Info("Validate Pain Referral Tick Box is Hidden");
            Validate.AreEqual(MyRepo.FrmORMain.PainPrescriptions.ReferPatientToPainService.Element.GetAttributeValueText("Visible"), "False");
        }
    }
}
