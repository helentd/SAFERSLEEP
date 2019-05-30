/*
 * Created by Ranorex
 * User: Admin
 * Date: 6/12/2018
 * Time: 11:44 AM
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
    /// Description of ValidateBlockDeleted.
    /// </summary>
    [TestModule("7332696E-8296-4DD1-9E2C-B31B42D9C76E", ModuleType.UserCode, 1)]
    public class ValidateBlockDeleted : ITestModule
    {  	
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _BlockName = "";
    	[TestVariable("759cedcb-f514-4d7b-9b07-7fba99c3e73b")]
    	public string BlockName
    	{
    		get { return _BlockName; }
    		set { _BlockName = value; }
    	}
    	
    	string _BlockSite = "";
    	[TestVariable("2edf678e-82b5-45e4-a971-634eb9dd2e5a")]
    	public string BlockSite
    	{
    		get { return _BlockSite; }
    		set { _BlockSite = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateBlockDeleted()
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
            
            Duration newDuration = new Duration(400);
            Duration oldDuration = MyRepo.FrmORMain.RegionalBlock.RegionalBlockListItemInfo.SearchTimeout;
            
            MyRepo.FrmORMain.RegionalBlock.RegionalBlockListItemInfo.SearchTimeout = newDuration;
            
            MyRepo.Regional_Block_List = "^"+BlockName+"\\ "+BlockSite;
            Validate.NotExists(MyRepo.FrmORMain.RegionalBlock.RegionalBlockListItemInfo);
            
            MyRepo.FrmORMain.RegionalBlock.RegionalBlockListItemInfo.SearchTimeout = oldDuration;
        }
    }
}
