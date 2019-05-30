/*
 * Created by Ranorex
 * User: Admin
 * Date: 17/01/2019
 * Time: 10:30 AM
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
    /// Description of ValidatePCEA_Ticked.
    /// </summary>
    [TestModule("1A11E30F-0BC5-4E5A-9D23-52F5F298B3E7", ModuleType.UserCode, 1)]
    public class ValidatePCEA_Ticked : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _Status = "";
    	[TestVariable("bc7513e5-b0be-4fc8-96db-051a6099dfce")]
    	public string Status
    	{
    		get { return _Status; }
    		set { _Status = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidatePCEA_Ticked()
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
            	Ranorex.Report.Info("Validate Epidural Analgesia Prescription is ticked for printing");
            	string ActualStatus = MyRepo.Print.EpiduralAnalgesiaPrescription.Element.GetAttributeValueText("Checked");
            	Validate.AreEqual(ActualStatus, "True");
            }
            else if (Status == "Not Ticked")
            {
            	Ranorex.Report.Info("Validate Epidural Analgesia Prescription is not ticked for printing");
            	string ActualStatus = MyRepo.Print.EpiduralAnalgesiaPrescription.Element.GetAttributeValueText("Checked");
            	Validate.AreEqual(ActualStatus, "False");
            }
        }
    }
}
