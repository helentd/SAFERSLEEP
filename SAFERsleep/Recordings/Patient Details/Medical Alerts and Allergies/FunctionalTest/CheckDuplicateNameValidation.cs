/*
 * Created by Ranorex
 * User: Admin
 * Date: 1/15/2019
 * Time: 10:57 AM
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

namespace SAFERsleep.Recordings.Patient_Details.Medical_Alerts_and_Allergies.FunctionalTest
{
    /// <summary>
    /// Description of CheckDuplicateNameValidation.
    /// </summary>
    [TestModule("70B3E19A-BA81-4BD9-9F04-E6967E7AF4C7", ModuleType.UserCode, 1)]
    public class CheckDuplicateNameValidation : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository repo = SAFERsleepORRepository.Instance;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckDuplicateNameValidation()
        {
            // Do not delete - a parameterless constructor is required!
        }

string _typeDuplicate = "Drug";
[TestVariable("c989e555-1264-4d2b-9951-c4e72c0c9454")]
public string typeDuplicate
{
	get { return _typeDuplicate; }
	set { _typeDuplicate = value; }
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
            
            // call check duplicate fucntiion
            MedicalAlertAllergyCollection.CheckDupplicateDrugLCassConditionName(typeDuplicate);
              Delay.Milliseconds(200);
            // Click OK on Error message poppup
            Report.Log(ReportLevel.Info, "Mouse", "Click OK on Error poppup\r\nMouse Left Click item 'Error.ButtonOK' at Center.", repo.Error.ButtonOKInfo, new RecordItemIndex(6));
            repo.Error.ButtonOK.Click();
            Delay.Milliseconds(200);
            
        }
    }
}
