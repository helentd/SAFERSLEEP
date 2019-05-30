/*
 * Created by Ranorex
 * User: Admin
 * Date: 4/12/2018
 * Time: 3:25 PM
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

namespace SAFERsleep.Recordings.Patient_Details.Clinical_Team
{
    /// <summary>
    /// Description of ValidateSurgeon_1.
    /// </summary>
    [TestModule("083731A6-B526-48FC-9127-98BC89AAD79F", ModuleType.UserCode, 1)]
    public class ValidateSurgeon_1 : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _SurgeonLastName = "";
    	[TestVariable("b26c9f54-6862-4fdc-bdbb-9330704ff317")]
    	public string SurgeonLastName
    	{
    		get { return _SurgeonLastName; }
    		set { _SurgeonLastName = value; }
    	}	
    	
    	string _SurgeonFirstName = "";
    	[TestVariable("b1c23372-0cab-45eb-be96-248cf9295eb3")]
    	public string SurgeonFirstName
    	{
    		get { return _SurgeonFirstName; }
    		set { _SurgeonFirstName = value; }
    	}
    	
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateSurgeon_1()
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
            
            Ranorex.Report.Info("Validating First Surgeon is the Surgeon entered in Regional / Blocks");
            string ActualName = MyRepo.FrmORMain.Patient_Details.Clinical_Team.Surgeon1.Element.GetAttributeValueText("Text");
            string ExpectedName = SurgeonLastName+", "+SurgeonFirstName;
            
            Validate.AreEqual(ActualName, ExpectedName);
        }
    }
}
