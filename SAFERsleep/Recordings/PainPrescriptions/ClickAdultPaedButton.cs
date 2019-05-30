/*
 * Created by Ranorex
 * User: Admin
 * Date: 11/01/2019
 * Time: 2:25 PM
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

namespace SAFERsleep.Recordings.PainPrescriptions
{
    /// <summary>
    /// Description of ClickAdultPaedButton.
    /// </summary>
    [TestModule("0019D09A-79B8-4470-BFC6-E7BDA5B3E450", ModuleType.UserCode, 1)]
    public class ClickAdultPaedButton : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _Button = "";
    	[TestVariable("81428c80-7055-45d4-8f7f-9e388ac2f774")]
    	public string Button
    	{
    		get { return _Button; }
    		set { _Button = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClickAdultPaedButton()
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
            
            if (Button == "Adult")
            {
            	Ranorex.Report.Info("Press Adult button");
            	MyRepo.FrmORMain.PainPrescriptions.Adult.Click();
            	Delay.Milliseconds(200);
            }
            else if (Button == "Paediatric")
            {
            	Ranorex.Report.Info("Press Paediatric button");
            	MyRepo.FrmORMain.PainPrescriptions.Paediatric.Click();
            	Delay.Milliseconds(200);
            }
        }
    }
}
