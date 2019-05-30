/*
 * Created by Ranorex
 * User: Admin
 * Date: 22/01/2019
 * Time: 2:52 PM
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
    /// Description of ValidateTypeNotExist.
    /// </summary>
    [TestModule("DDDB263D-9F71-4786-AED5-1A3E8F975620", ModuleType.UserCode, 1)]
    public class ValidateTypeNotExist : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _PrescriptionType = "";
    	[TestVariable("f00b8934-f8c3-42c2-bdde-b08dbc0f3f3d")]
    	public string PrescriptionType
    	{
    		get { return _PrescriptionType; }
    		set { _PrescriptionType = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateTypeNotExist()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// This module will confirm if the selected Prescription Type do not exist from the list.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            MyRepo.Item = PrescriptionType;
            Ranorex.Report.Info("Confirm if the Prescription Type do not exist: "+PrescriptionType);
            MyRepo.AddPainPrescription.PrescriptionType.Click(Location.CenterRight);
            Delay.Milliseconds(200);
            Validate.IsFalse(MyRepo.ListItems.PrescriptionTypeListItemInfo.Exists(2000));
        }
    }
}
