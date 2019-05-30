/*
 * Created by Ranorex
 * User: Admin
 * Date: 4/23/2018
 * Time: 3:01 PM
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

namespace SAFERsleep.Recordings.Patient_Details.Patient_or_Operation
{
    /// <summary>
    /// Description of SelectASA.
    /// </summary>
    [TestModule("39898895-9144-4F30-A9DD-EAC069BD22CB", ModuleType.UserCode, 1)]
    public class SelectASA : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectASA()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        
        string _ASA = "1";
        [TestVariable("0dc941a4-4cf1-4e6d-98fc-ad3eef805700")]
        public string ASA
        {
        	get { return _ASA; }
        	set { _ASA = value; }
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
            
            MyRepo.FrmORMain.Patient_Details.Patient_or_Operation.ASA.Click();
            
            if (ASA == "1")
            	Keyboard.Press(System.Windows.Forms.Keys.Down, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            else if (ASA == "2")
            {
            	Keyboard.Press(System.Windows.Forms.Keys.Down, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            	Keyboard.Press(System.Windows.Forms.Keys.Down, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            }
            else if (ASA == "3")
            {
            	Keyboard.Press(System.Windows.Forms.Keys.Down, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            	Keyboard.Press(System.Windows.Forms.Keys.Down, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            	Keyboard.Press(System.Windows.Forms.Keys.Down, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            }
            
            Keyboard.Press(System.Windows.Forms.Keys.Enter, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
        }
    }
}
