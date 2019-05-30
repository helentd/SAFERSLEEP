/*
 * Created by Ranorex
 * User: Admin
 * Date: 16/07/2018
 * Time: 12:43 PM
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

namespace SAFERsleep.Recordings.Post_opMedications
{
    /// <summary>
    /// Description of Information_OK.
    /// </summary>
    [TestModule("EE69743E-4773-4657-A3BB-34B5D614C22A", ModuleType.UserCode, 1)]
    public class Information_OK : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Information_OK()
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
            
        	if (MyRepo.Information.ButtonOKInfo.Exists(5000))
        		MyRepo.Information.ButtonOK.Click();
        	
        }
    }
}
