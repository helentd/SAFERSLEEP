/*
 * Created by Ranorex
 * User: Admin
 * Date: 27/03/2019
 * Time: 2:07 PM
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

namespace SAFERSleep_AP.Recordings.Modalities.CoAnalgesia.CoAnalgesiaHistory
{
    /// <summary>
    /// Description of ValidateCoAnalgesiaHistory.
    /// </summary>
    [TestModule("50793FAD-AADA-4676-9042-580F90BC2442", ModuleType.UserCode, 1)]
    public class ValidateCoAnalgesiaHistory : ITestModule
    {
    	SAFERSleep_APRepository MyRepo = new SAFERSleep_APRepository();
    	
    	string _Date = "Today";
    	[TestVariable("27d90b3e-a200-4c90-aa0b-60d7b1279bb7")]
    	public string Date
    	{
    		get { return _Date; }
    		set { _Date = value; }
    	}
    	
    	string _Medication = "";
    	[TestVariable("719df2b8-634b-4294-a49d-3311c7afa8ef")]
    	public string Medication
    	{
    		get { return _Medication; }
    		set { _Medication = value; }
    	}
    	
    	string _Mode = "";
    	[TestVariable("0bc08804-b6a7-4cee-8058-594086e1c60b")]
    	public string Mode
    	{
    		get { return _Mode; }
    		set { _Mode = value; }
    	}
    	
    	string _Unit = "";
    	[TestVariable("0563398c-fdd7-4d0e-9ce0-6304a5c47ca2")]
    	public string Unit
    	{
    		get { return _Unit; }
    		set { _Unit = value; }
    	}
    	
    	string _Dose = "";
    	[TestVariable("10c4f4fc-ffd7-455f-85be-3b333c22aa51")]
    	public string Dose
    	{
    		get { return _Dose; }
    		set { _Dose = value; }
    	}
    	
    	string _Rate = "";
    	[TestVariable("ff020e2c-3920-4056-9b5e-afe90e1de048")]
    	public string Rate
    	{
    		get { return _Rate; }
    		set { _Rate = value; }
    	}
    	
    	string _TeamMember = "";
    	[TestVariable("42c5049f-c3d1-4896-8783-22966b9f899a")]
    	public string TeamMember
    	{
    		get { return _TeamMember; }
    		set { _TeamMember = value; }
    	}
    	
    	string _TeamMember2 = "";
    	[TestVariable("83f9d32c-0eaa-4e6a-8f0e-372d00785abf")]
    	public string TeamMember2
    	{
    		get { return _TeamMember2; }
    		set { _TeamMember2 = value; }
    	}
    	  	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateCoAnalgesiaHistory()
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
            
            Ranorex.Report.Info("Validate Co-Analgesia Modality History for: "+Medication);
            MyRepo.Medication = Medication;
            
            Ranorex.Report.Info("Validate Date: "+Date);
            if (Date == "Today" || Date == "")
            	MyRepo.Date = System.DateTime.Now.ToString("dd MMM yyy");
            else
            	MyRepo.Date = Date;
            Validate.Exists(MyRepo.MainWindow.Modalities.ModalityHistory.CoAnalgesiaHistory.CoAnalgesiaHistoryColumn.DateInfo);
            
            Ranorex.Report.Info("Validate Mode: "+Mode);
            MyRepo.Mode = Mode;
            Validate.Exists(MyRepo.MainWindow.Modalities.ModalityHistory.CoAnalgesiaHistory.CoAnalgesiaHistoryColumn.ModeInfo);
            
            if (Dose != "")
            {
	            Ranorex.Report.Info("Validate Dose: "+Dose+" "+Unit);
	            MyRepo.Dose = Dose+" "+Unit;
	            Validate.Exists(MyRepo.MainWindow.Modalities.ModalityHistory.CoAnalgesiaHistory.CoAnalgesiaHistoryColumn.LoadingDoseInfo);
            }
            
            if (Rate != "")
            {
	            Ranorex.Report.Info("Validate Rate: "+Rate+" "+Unit+"/hr");
	            MyRepo.Rate	 = Rate+" "+Unit+"/hr";
	            Validate.Exists(MyRepo.MainWindow.Modalities.ModalityHistory.CoAnalgesiaHistory.CoAnalgesiaHistoryColumn.ContinuousRateInfo);
            }
            
            Ranorex.Report.Info("Validate Updated By: "+TeamMember);
            MyRepo.TeamMember = TeamMember;
            Validate.Exists(MyRepo.MainWindow.Modalities.ModalityHistory.CoAnalgesiaHistory.CoAnalgesiaHistoryColumn.UpdatedByInfo);
            if (TeamMember2 != "")
            {
            	Ranorex.Report.Info("Validate Updated By: "+TeamMember2);
            	MyRepo.TeamMember = TeamMember2;
            	Validate.Exists(MyRepo.MainWindow.Modalities.ModalityHistory.CoAnalgesiaHistory.CoAnalgesiaHistoryColumn.UpdatedByInfo);
            }  
        }
    }
}
