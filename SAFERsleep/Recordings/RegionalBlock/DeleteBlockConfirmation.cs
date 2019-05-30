/*
 * Created by Ranorex
 * User: Admin
 * Date: 6/12/2018
 * Time: 11:30 AM
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
    /// Description of DeleteBlockConfirmation.
    /// </summary>
    [TestModule("23A8DFD3-A72B-40B7-BCD3-1C8BFCC988E2", ModuleType.UserCode, 1)]
    public class DeleteBlockConfirmation : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _ConfirmationButton = "";
    	[TestVariable("6393208a-3872-4b0a-bc99-7279924f5a91")]
    	public string ConfirmationButton
    	{
    		get { return _ConfirmationButton; }
    		set { _ConfirmationButton = value; }
    	}
    	
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteBlockConfirmation()
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
            
            Ranorex.Report.Info("Confirm Block Deletion: "+ConfirmationButton);
            if (ConfirmationButton == "Yes")
            	MyRepo.FrmConfirmation.Yes.Click();
            else if (ConfirmationButton == "No")
            	MyRepo.FrmConfirmation.No.Click();
        }
    }
}
