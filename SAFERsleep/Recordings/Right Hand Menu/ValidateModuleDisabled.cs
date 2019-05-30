/*
 * Created by Ranorex
 * User: Admin
 * Date: 31/01/2019
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

namespace SAFERsleep.Recordings.Right_Hand_Menu
{
    /// <summary>
    /// Description of ValidateModuleDisabled.
    /// </summary>
    [TestModule("B518EBBB-9DBB-4145-AF4C-ADA016D57E7B", ModuleType.UserCode, 1)]
    public class ValidateModuleDisabled : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;    	
    	
    	string _ORModule = "";
    	[TestVariable("176d94a7-714c-4c40-a540-05b4bec07398")]
    	public string ORModule
    	{
    		get { return _ORModule; }
    		set { _ORModule = value; }
    	}
    	  	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateModuleDisabled()
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
            
            Ranorex.Report.Info("Validate Module is Disabled: "+ORModule);
            
            if (ORModule == "Pain Prescriptions")
            	Validate.AreEqual(MyRepo.FrmORMain.OR_Modules.PainPrescriptions.Element.GetAttributeValueText("Visible"), "False");
        }
    }
}
