/*
 * Created by Ranorex
 * User: Admin
 * Date: 4/12/2018
 * Time: 4:29 PM
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

namespace SAFERsleep.Recordings.RegionalBlock
{
    /// <summary>
    /// Description of ValidateInsertingClinician.
    /// </summary>
    [TestModule("457A1D03-13D9-41B2-B86F-892DE4E52C6A", ModuleType.UserCode, 1)]
    public class ValidateInsertingClinician : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _LastName = "";
    	[TestVariable("0e171558-8daa-4533-8b73-418701ff7d8f")]
    	public string LastName
    	{
    		get { return _LastName; }
    		set { _LastName = value; }
    	}
    	
    	string _FirstName = "";
    	[TestVariable("37ba2783-2ca5-4353-bca0-342b53ca3c63")]
    	public string FirstName
    	{
    		get { return _FirstName; }
    		set { _FirstName = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateInsertingClinician()
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
            
        	Ranorex.Report.Info("Validating Inserting Clinician is the Surgeon selected from Clinical Team");
        	string ActualName =  MyRepo.AddRegionalBlock.InsertingClinician.Element.GetAttributeValueText("Text");
        	string ExpectedName = LastName+", "+FirstName;
        	
        	Validate.AreEqual(ActualName, ExpectedName);
        }
    }
}
