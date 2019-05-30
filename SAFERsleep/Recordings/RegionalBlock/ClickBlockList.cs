/*
 * Created by Ranorex
 * User: Admin
 * Date: 6/12/2018
 * Time: 10:13 AM
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
    /// Description of ClickBlockList.
    /// </summary>
    [TestModule("9FF3C45E-C502-447D-8A2B-19907C9EA7ED", ModuleType.UserCode, 1)]
    public class ClickBlockList : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _BlockName = "";
    	[TestVariable("42ca3104-e28e-4bee-9618-21e406b6984b")]
    	public string BlockName
    	{
    		get { return _BlockName; }
    		set { _BlockName = value; }
    	}
    	
    	string _BlockSite = "";
    	[TestVariable("9e099eba-45fc-4725-815d-84c4e22adbb0")]
    	public string BlockSite
    	{
    		get { return _BlockSite; }
    		set { _BlockSite = value; }
    	}
    	
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClickBlockList()
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
            
            MyRepo.Regional_Block_List = "^"+BlockName+"\\ "+BlockSite;
            MyRepo.FrmORMain.RegionalBlock.RegionalBlockListItem.Click();
        }
    }
}
