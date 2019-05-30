/*
 * Created by Ranorex
 * User: Admin
 * Date: 8/02/2019
 * Time: 1:09 PM
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
    /// Description of ValidateOKButtonDisabled.
    /// </summary>
    [TestModule("CFBCE80A-BF35-4D36-A718-94D183A94615", ModuleType.UserCode, 1)]
    public class ValidateOKButtonDisabled : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateOKButtonDisabled()
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
            
            Ranorex.Report.Info("Validate Add Prescription OK button is disabled");
            Validate.AreEqual(MyRepo.AddPainPrescription.ButtonOK.Element.GetAttributeValueText("Enabled"), "False");
        }
    }
}
