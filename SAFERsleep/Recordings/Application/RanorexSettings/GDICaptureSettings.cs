/*
 * Created by Ranorex
 * User: paul.campbell
 * Date: 1/08/2018
 * Time: 1:10 PM
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
using Ranorex.Plugin;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace SAFERsleep.Recordings.Application.RanorexSettings
{
    /// <summary>
    /// Description of GDISettings.
    /// </summary>
    [TestModule("C0E84F9E-871F-4263-A562-05D4CB87EB4B", ModuleType.UserCode, 1)]
    public class GDICaptureSettings : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GDICaptureSettings()
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
            
            var plugins = Ranorex.Core.PluginManager.Instance;  
			plugins.LoadDefaultPlugins();  
            
            RawTextFlavor.Instance.ClassNames.Add(new Regex("^TcxGridSite$"));
            RawTextFlavor.Instance.ClassNames.Add(new Regex("^TPanel$"));
            RawTextFlavor.Instance.ClassNames.Add(new Regex("^TSAFERsleepPanel$"));
            RawTextFlavor.Instance.ClassNames.Add(new Regex("^TcxPageControl$"));
            RawTextFlavor.Instance.ClassNames.Add(new Regex("^TcxTabSheet$"));
        }
    }
}
