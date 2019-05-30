/*
 * Created by Ranorex
 * User: Admin
 * Date: 27/03/2019
 * Time: 4:01 PM
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

namespace SAFERSleep_AP.Recordings.Modalities
{
    /// <summary>
    /// Description of SelectComplexModality.
    /// </summary>
    [TestModule("A982D0A5-C0F7-470E-ADEF-1EC4C56BD055", ModuleType.UserCode, 1)]
    public class SelectAdvModality : ITestModule
    {
    	SAFERSleep_APRepository MyRepo = new SAFERSleep_APRepository();
    	
    	string _AdvModality = "";
    	[TestVariable("09e477c8-67b9-4894-b3b8-f4db7bcd12ec")]
    	public string AdvModality
    	{
    		get { return _AdvModality; }
    		set { _AdvModality = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectAdvModality()
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
            
            Ranorex.Report.Info("Click Complex Modality: "+AdvModality); 
            if (AdvModality == "Co-Analgesia")
            	MyRepo.ModalityMenuItems.CoAnalgesia.Click();
            else if (AdvModality == "Other")
            	MyRepo.ModalityMenuItems.Other.Click();
            else if (AdvModality == "Epidural")
            	MyRepo.ModalityMenuItems.Epidural.Click();
            else if (AdvModality == "PCA")
            	MyRepo.ModalityMenuItems.PCA.Click();
            else if (AdvModality == "Regional")
            	MyRepo.ModalityMenuItems.Regional.Click();
            Delay.Milliseconds(200);
        }
    }
}
