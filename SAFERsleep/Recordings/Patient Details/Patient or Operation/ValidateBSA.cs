/*
 * Created by Ranorex
 * User: Admin
 * Date: 21/01/2019
 * Time: 3:26 PM
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
    /// Description of ValidateBSA.
    /// </summary>
    [TestModule("0658B096-DC86-48F8-8B9D-D3AA9144A488", ModuleType.UserCode, 1)]
    public class ValidateBSA : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _BSA = "";
    	[TestVariable("6b60be12-4032-4872-afac-aa493961a8c1")]
    	public string BSA
    	{
    		get { return _BSA; }
    		set { _BSA = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateBSA()
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
            
            string BSAActual = MyRepo.FrmORMain.Patient_Details.Patient_or_Operation.BSA.Element.GetAttributeValueText("Text");
			Ranorex.Report.Info("Validate Patient's BSA which should be: "+BSA);
            Validate.AreEqual(BSAActual, BSA);
        }
    }
}
