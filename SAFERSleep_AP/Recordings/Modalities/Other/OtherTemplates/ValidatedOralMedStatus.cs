/*
 * Created by Ranorex
 * User: Admin
 * Date: 14/03/2019
 * Time: 3:13 PM
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

namespace SAFERSleep_AP.Recordings.Modalitties.OralTemplates
{
    /// <summary>
    /// Description of ValidatedOralMedStatus.
    /// </summary>
    [TestModule("D0D39AB7-6170-40E0-A681-F27A14F11BB9", ModuleType.UserCode, 1)]
    public class ValidatedOralMedStatus : ITestModule
    {
    	SAFERSleep_APRepository MyRepo = new SAFERSleep_APRepository();
    	
    	string _Medication = "";
    	[TestVariable("d0ff94a0-b10e-486f-8a72-2a2838a8f83c")]
    	public string Medication
    	{
    		get { return _Medication; }
    		set { _Medication = value; }
    	}
    	
    	string _Status = "Checked";
    	[TestVariable("edd32c28-ffb1-4fc7-b2fe-f2beb544ddaf")]
    	public string Status
    	{
    		get { return _Status; }
    		set { _Status = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidatedOralMedStatus()
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
            
            MyRepo.Medication = Medication;
            
            Ranorex.Report.Info("Validate Medication is selected: "+Medication);
            Validate.AreEqual(MyRepo.MainWindow.Modalities.OtherModalityTemplate.OtherMed_Checkbox.Element.GetAttributeValueText("CheckState"), Status);
        }
    }
}
