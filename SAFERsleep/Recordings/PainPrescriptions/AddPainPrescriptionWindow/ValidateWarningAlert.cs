/*
 * Created by Ranorex
 * User: Admin
 * Date: 8/02/2019
 * Time: 1:57 PM
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
    /// Description of ValidateWarningAlert.
    /// </summary>
    [TestModule("C2FF32D9-49F8-47AE-8850-DF6A8101A014", ModuleType.UserCode, 1)]
    public class ValidateWarningAlert : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;

    	string _AlertName = "";
    	[TestVariable("538229ea-853f-4868-8fe0-abb17b6a5754")]
    	public string AlertName
    	{
    		get { return _AlertName; }
    		set { _AlertName = value; }
    	}
    	
    	string _AlertType = "";
    	[TestVariable("16f00124-04e0-4463-b92d-14b1f476f18c")]
    	public string AlertType
    	{
    		get { return _AlertType; }
    		set { _AlertType = value; }
    	}
    	
    	string _AlertClass = "";
    	[TestVariable("a0b71029-be02-4a7f-b12b-a9ffa958be9c")]
    	public string AlertClass
    	{
    		get { return _AlertClass; }
    		set { _AlertClass = value; }
    	}
    	
    	string _DrugClass = "";
    	[TestVariable("25f11723-8fcb-4f73-82a1-b5283c4b5abe")]
    	public string DrugClass
    	{
    		get { return _DrugClass; }
    		set { _DrugClass = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateWarningAlert()
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
            
            UserCodeCollection_OR CodeCollection = new UserCodeCollection_OR();
            string WarningText = CodeCollection.WarningAlertMessage(AlertName, AlertType, AlertClass, DrugClass);
            
            // validate Warning box displays when added Drug is in patient's allergy list 
            MyRepo.WarningMessage = WarningText;
            Validate.Exists(MyRepo.AddPainPrescription.WarningMessageTextBoxInfo);
        }
    }
}
