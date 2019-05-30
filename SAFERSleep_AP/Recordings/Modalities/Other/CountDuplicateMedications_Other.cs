/*
 * Created by Ranorex
 * User: Admin
 * Date: 21/03/2019
 * Time: 4:34 PM
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

namespace SAFERSleep_AP.Recordings.Modalities.Oral
{
    /// <summary>
    /// Description of ValidateDuplicateMedications.
    /// </summary>
    [TestModule("D4886DC4-4BD5-4248-B28C-64D54C6179E8", ModuleType.UserCode, 1)]
    public class CountDuplicateMedications_Other : ITestModule
    {   	
    	string _Medication = "";
    	[TestVariable("455110dc-3dde-4631-ab1b-8efa3ec919c4")]
    	public string Medication
    	{
    		get { return _Medication; }
    		set { _Medication = value; }
    	}
    	
    	string _Expected_Count = "";
    	[TestVariable("3af93e8d-0c30-4af1-9213-0df4ee9c8d4b")]
    	public string Expected_Count
    	{
    		get { return _Expected_Count; }
    		set { _Expected_Count = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CountDuplicateMedications_Other()
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
            
            var repo = SAFERSleep_APRepository.Instance;
            var oralModalityRow = repo.MainWindow.Modalities.SimpleModalities.OtherModalityRow;

            IList<Text> List = oralModalityRow.Find<Text>("//text[@caption~'"+Medication+"']/following-sibling::text[@Visible='True']");
           	int count = List.Count;
           	Ranorex.Report.Info("Expected number of duplicate medication selected: "+Expected_Count);
           	Validate.AreEqual((count/2).ToString(),Expected_Count);
        }
    }
}
