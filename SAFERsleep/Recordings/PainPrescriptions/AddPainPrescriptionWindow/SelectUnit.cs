/*
 * Created by Ranorex
 * User: Admin
 * Date: 14/01/2019
 * Time: 3:59 PM
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
    /// Description of SelectUnit.
    /// </summary>
    [TestModule("1A4770C7-5DFF-4937-A3CE-8199C18E0D95", ModuleType.UserCode, 1)]
    public class SelectUnit : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _FormName = "";
    	[TestVariable("9757bf70-d22f-46d6-886c-5afa55d624f9")]
    	public string FormName
    	{
    		get { return _FormName; }
    		set { _FormName = value; }
    	}
    	
    	string _UnitOf = "";
    	[TestVariable("08ce7e8c-241f-47a0-92a2-9e6fbd77c982")]
    	public string UnitOf
    	{
    		get { return _UnitOf; }
    		set { _UnitOf = value; }
    	}
    	
    	string _UnitType = "";
    	[TestVariable("1445ceeb-1e38-464f-b27d-513e228733ae")]
    	public string UnitType
    	{
    		get { return _UnitType; }
    		set { _UnitType = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectUnit()
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
            
            if (UnitOf == "Bolus Dose")
            {
            	Ranorex.Report.Info("Select Unit for Bolus Dose: "+UnitType);
            	UserCodeCollection_OR.Clear_TextBox(MyRepo.AddPainPrescription.DoseDetails.BolusUnitInfo, "Combobox");
            	Keyboard.Press(UnitType);
            	Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            	Delay.Milliseconds(200);
            }
            else if (UnitOf == "Continuous Rate")
            {
            	Ranorex.Report.Info("Select Unit for Continuous Rate: "+UnitType);
            	UserCodeCollection_OR.Clear_TextBox(MyRepo.AddPainPrescription.DoseDetails.RateUnitInfo, "Combobox");
            	Keyboard.Press(UnitType);
            	Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            	Delay.Milliseconds(200);
            }
            else if (UnitOf == "Dose Limit")
            {
            	Ranorex.Report.Info("Select Unit for Dose Limit: "+UnitType);
            	UserCodeCollection_OR.Clear_TextBox(MyRepo.AddPainPrescription.DoseDetails.DoseLimitUnitInfo, "Combobox");
            	Keyboard.Press(UnitType);
            	Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            	Delay.Milliseconds(200);
            }
        }
    }
}
