/*
 * Created by Ranorex
 * User: Admin
 * Date: 6/12/2018
 * Time: 11:36 AM
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
    /// Description of DeleteBlockDrugsConfirmation.
    /// </summary>
    [TestModule("6F2811BD-508D-417F-BF82-7F1106C11D53", ModuleType.UserCode, 1)]
    public class DeleteBlockDrugsConfirmation : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _ConfirmationButton = "";
    	[TestVariable("c529d504-fda0-4436-baf8-38c5488c79f4")]
    	public string ConfirmationButton
    	{
    		get { return _ConfirmationButton; }
    		set { _ConfirmationButton = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteBlockDrugsConfirmation()
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
            
            Ranorex.Report.Info("Confirm Block Drugs Deletion: "+ConfirmationButton);
            if (ConfirmationButton == "Yes")
            	MyRepo.FrmConfirmation.Yes.Click();
            else if (ConfirmationButton == "No")
            	MyRepo.FrmConfirmation.No.Click();
        }
    }
}
