/*
 * Created by Ranorex
 * User: Admin
 * Date: 4/16/2018
 * Time: 3:29 PM
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
    /// Description of SelectModule.
    /// </summary>
    [TestModule("F34879A6-BE5B-4665-BDB5-70A94BF5B90F", ModuleType.UserCode, 1)]
    public class SelectModule : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectModule()
        {
            // Do not delete - a parameterless constructor is required!
        }

        string _ORModule = "Patient Details";
        [TestVariable("755d54aa-1183-42e6-8fa0-3c6b94ea8ccd")]
        public string ORModule
        {
	        get { return _ORModule; }
	        set { _ORModule = value; }
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
            
            Ranorex.Report.Info("Click OR Module: "+ORModule);
            
            if (ORModule == "Patient Details")
            	MyRepo.FrmORMain.OR_Modules.PatientDetails.Click();
            else if (ORModule == "Drugs")
            	MyRepo.FrmORMain.OR_Modules.Drugs.Click();
            else if (ORModule == "Events")
            	MyRepo.FrmORMain.OR_Modules.Events.Click();
            else if (ORModule == "Fluids")
            	MyRepo.FrmORMain.OR_Modules.Fluids.Click();
            else if (ORModule == "Regional / Blocks")
            	MyRepo.FrmORMain.OR_Modules.RegionalBlocks.Click();
            else if (ORModule == "Lab Results")
            	MyRepo.FrmORMain.OR_Modules.LabResults.Click();
            else if (ORModule == "Post Op Medication")
            	MyRepo.FrmORMain.OR_Modules.PostOpMedication.Click();
            else if (ORModule == "PACU")
            	MyRepo.FrmORMain.OR_Modules.PACU.Click();
            else if (ORModule == "Recovery")
            	MyRepo.FrmORMain.OR_Modules.PACU.Click();
            else if (ORModule == "Post-Op Instructions")
            	MyRepo.FrmORMain.OR_Modules.PostOpInstructions.Click();
            else if (ORModule == "Pain Prescriptions")
            	MyRepo.FrmORMain.OR_Modules.PainPrescriptions.Click();
            else if (ORModule == "Discharge Prescriptions")
            	MyRepo.FrmORMain.OR_Modules.DischargePrescriptions.Click();          
        }
    }
}
