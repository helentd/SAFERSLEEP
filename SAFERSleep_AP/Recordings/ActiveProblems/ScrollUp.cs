/*
 * Created by Ranorex
 * User: Admin
 * Date: 1/04/2019
 * Time: 3:25 PM
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

namespace SAFERSleep_AP.Recordings.ActiveProblems
{
    /// <summary>
    /// Description of ScrollUp.
    /// </summary>
    [TestModule("327BD92C-683F-47F2-9E3E-766CA45205F9", ModuleType.UserCode, 1)]
    public class ScrollUp : ITestModule
    {
    	SAFERSleep_APRepository MyRepo = new SAFERSleep_APRepository();
    	
    	int _Count = 0;
    	[TestVariable("3a294e12-fd42-4e1c-8b3c-0c121ca89731")]
    	public int Count
    	{
    		get { return _Count; }
    		set { _Count = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ScrollUp()
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
            
            int StartCount = 0;
            
            if (MyRepo.MainWindow.ActiveProblems.Addition_ScrollBarInfo.Exists(3000) == true)
            {
	            Ranorex.Report.Info("Scroll Up: "+Count+" times");
	            while (StartCount < Count)
	            {
	            	MyRepo.MainWindow.ActiveProblems.UpButton.DoubleClick();
	            	StartCount++;
	            }
            }
        }
    }
}
