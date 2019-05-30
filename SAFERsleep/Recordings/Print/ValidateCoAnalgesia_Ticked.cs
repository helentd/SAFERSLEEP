/*
 * Created by Ranorex
 * User: Admin
 * Date: 17/01/2019
 * Time: 1:19 PM
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
    /// Description of ValidateCoAnalgesia_Ticked.
    /// </summary>
    [TestModule("069E02D5-63C6-4CD5-B8AC-58490B845705", ModuleType.UserCode, 1)]
    public class ValidateCoAnalgesia_Ticked : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _Status = "";
    	[TestVariable("35383505-411c-49c2-ab17-06511e3de385")]
    	public string Status
    	{
    		get { return _Status; }
    		set { _Status = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateCoAnalgesia_Ticked()
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
            	Ranorex.Report.Info("Validate Co-Analgesia Prescription is ticked for printing");
            	string ActualStatus = MyRepo.Print.CoAnalgesiaPrescription.Element.GetAttributeValueText("Checked");
            	Validate.AreEqual(ActualStatus, "True");
            }
            else if (Status == "Not Ticked")
            {
            	Ranorex.Report.Info("Validate Co-Analgesia Prescription is not ticked for printing");
            	string ActualStatus = MyRepo.Print.CoAnalgesiaPrescription.Element.GetAttributeValueText("Checked");
            	Validate.AreEqual(ActualStatus, "False");
            }
        }
    }
}
