/*
 * Created by Ranorex
 * User: Admin
 * Date: 10/01/2019
 * Time: 1:34 PM
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
    /// Description of ValidateUnits.
    /// </summary>
    [TestModule("B950C8A0-D77B-4A71-825D-B36A931D7C10", ModuleType.UserCode, 1)]
    public class ValidateUnits : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _FormName = "";
    	[TestVariable("91e90883-9504-4486-9942-a4f03ae7f138")]
    	public string FormName
    	{
    		get { return _FormName; }
    		set { _FormName = value; }
    	}
    	
    	string _BolusUnit = "";
    	[TestVariable("ed741686-69e3-46ec-b36c-b1165fe98101")]
    	public string BolusUnit
    	{
    		get { return _BolusUnit; }
    		set { _BolusUnit = value; }
    	}
    	
    	string _RateUnit = "";
    	[TestVariable("c6ad6c8f-c2cc-466f-a190-d8b419d055bb")]
    	public string RateUnit
    	{
    		get { return _RateUnit; }
    		set { _RateUnit = value; }
    	}
    	
    	string _DoseLimitUnit = "";
    	[TestVariable("573c6812-b1a1-4616-a0e5-6e00cb10ab21")]
    	public string DoseLimitUnit
    	{
    		get { return _DoseLimitUnit; }
    		set { _DoseLimitUnit = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateUnits()
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
            
            if (BolusUnit != "")
            {
            	Ranorex.Report.Info("Validate Bolus Dose Unit to be equal to: " +BolusUnit);
            	Validate.AreEqual(MyRepo.AddPainPrescription.DoseDetails.BolusUnit.Element.GetAttributeValueText("Text"), BolusUnit);
            }
            
            if (RateUnit != "")
            {
            	Ranorex.Report.Info("Validate Continuous Rate Unit to be equal to: " +RateUnit +"/hr");
            	Validate.AreEqual(MyRepo.AddPainPrescription.DoseDetails.RateUnit.Element.GetAttributeValueText("Text"), RateUnit +"/hr");
            }
            
            if (DoseLimitUnit != "")
            {
            	Ranorex.Report.Info("Validate Dose Limit Unit to be equal to: " +DoseLimitUnit);
            	Validate.AreEqual(MyRepo.AddPainPrescription.DoseDetails.DoseLimitUnit.Element.GetAttributeValueText("Text"), DoseLimitUnit);
            }
        }
    }
}
