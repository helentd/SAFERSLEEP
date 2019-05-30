/*
 * Created by Ranorex
 * User: Admin
 * Date: 1/11/2019
 * Time: 3:23 PM
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

namespace SAFERsleep.Recordings.Patient_Details.Medical_Alerts_and_Allergies
{
    /// <summary>
    /// Description of CheckAllergyInMedicalBox.
    /// </summary>
    [TestModule("FE3BEC19-C3BE-4EC7-A726-2B92834BE804", ModuleType.UserCode, 1)]
    public class CheckAllergyInMedicalBox : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckAllergyInMedicalBox()
        {
            // Do not delete - a parameterless constructor is required!
        }

string _WarningType = "Allergy";
[TestVariable("74c04f2c-a59d-4515-b75b-5a1c55848c5d")]
public string WarningType
{
	get { return _WarningType; }
	set { _WarningType = value; }
}

string _AllergyName = "Opioid";
[TestVariable("3547cc7b-04c1-4e16-b4bf-812530020cb1")]
public string AllergyName
{
	get { return _AllergyName; }
	set { _AllergyName = value; }
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
            
            string AllergyText= WarningType + " - " + AllergyName;
           Ranorex.Report.Info("Check the added Allergy item displays in Medical Alert box");
            Validate.AttributeContains(MyRepo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.MedicalAlertBoxInfo,"Text", AllergyText);
            
            
        }
    }
}
