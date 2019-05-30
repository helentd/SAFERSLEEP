/*
 * Created by Ranorex
 * User: Admin
 * Date: 19/12/2018
 * Time: 10:52 AM
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

namespace SAFERsleep.Recordings.PainPrescriptions.AddPainPrescriptionWindow.Infusion2DoseEntry
{
    /// <summary>
    /// Description of ValidateHourDoseLimit2Value.
    /// </summary>
    [TestModule("A9461F73-449D-4E93-A0D4-4D8D0D789360", ModuleType.UserCode, 1)]
    public class ValidateHourDoseLimit2Value : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _DoseLimit2Value = "";
    	[TestVariable("0012aea6-3708-47d3-bb84-df30254c0aea")]
    	public string DoseLimit2Value
    	{
    		get { return _DoseLimit2Value; }
    		set { _DoseLimit2Value = value; }
    	}
    	
    	string _FormName = "";
    	[TestVariable("85bcdd12-15ba-4b04-b2e5-cacce0beb1c7")]
    	public string FormName
    	{
    		get { return _FormName; }
    		set { _FormName = value; }
    	}
	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateHourDoseLimit2Value()
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
            
            MyRepo.FormName = FormName;
     
            string DoseLimit2Max = MyRepo.AddPainPrescription.RegionalInfusion.Infusion2Details.DoseLimit2.Element.GetAttributeValueText("Text");
            
            Ranorex.Report.Info("Validate the value in Dose Limit which is: "+DoseLimit2Value);
            Validate.AreEqual(DoseLimit2Max, DoseLimit2Value);
        }
    }
}
