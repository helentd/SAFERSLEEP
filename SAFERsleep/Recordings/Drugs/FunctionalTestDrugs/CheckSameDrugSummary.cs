/*
 * Created by Ranorex
 * User: Win7-VM
 * Date: 7/12/2018
 * Time: 2:27 p.m.
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

namespace SAFERsleep.Recordings.Drugs.FunctionalTestDrugs
{
    /// <summary>
    /// Description of CheckSameDrugSummary.
    /// </summary>
    [TestModule("B6DD17CF-D56A-4698-9FF6-33646882FF19", ModuleType.UserCode, 1)]
    public class CheckSameDrugSummary : ITestModule
    {
    
        // Constructs a new instance.Do not delete - a parameterless constructor is required!      
        public CheckSameDrugSummary()
        {
            
        }
		
        // Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;    	
    	
    	string _TimeAddDrug1 = "00:00";
    	[TestVariable("c748ed5c-2391-4c48-bea6-f65853facb4b")]
    	public string TimeAddDrug1
    	{
    		get { return _TimeAddDrug1; }
    		set { _TimeAddDrug1 = value; }
    	}
    	
    	string _TimeAddDrug2 = "00:00";
    	[TestVariable("b0b6082f-742f-4674-a0f2-7736287622cd")]
    	public string TimeAddDrug2
    	{
    		get { return _TimeAddDrug2; }
    		set { _TimeAddDrug2 = value; }
    	}
    	
    	double _Dosage1 = 100;
    	[TestVariable("826e4bce-e3a1-4465-8555-1bacc8986dcd")]
    	public double Dosage1
    	{
    		get { return _Dosage1; }
    		set {_Dosage1 = value; }
    	}
    	
    	double _Dosage2 = 55.5;
    	[TestVariable("15397705-a34c-4ae7-9ba3-6e067405e8bd")]
    	public double Dosage2
    	{
    		get { return _Dosage2; }
    		set { _Dosage2= value; }
    	}
    	
    	
    	string _Mode = "Bouls";
    	[TestVariable("11c932a5-d40a-4246-a28d-055789389aa2")]
    	public string Mode
    	{
    		get { return _Mode; }
    		set { _Mode = value; }
    	}
    	string _Unit = "ml";
    	[TestVariable("3a3f6812-ea8c-432d-af0e-de179028177c")]
    	public string Unit
    	{
    		get { return _Unit; }
    		set { _Unit = value; }
    	}
    	
    	
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
           
            // my code here
            
            // Click on Summary tab
            Report.Log(ReportLevel.Info, "Mouse", "Click on Summary tab\r\nMouse Left Click item 'FrmORMain.Drugs.Tabs.DrugSummaryTab' at Center.", MyRepo.FrmORMain.Drugs.Tabs.DrugSummaryTabInfo, new RecordItemIndex(0));
            MyRepo.FrmORMain.Drugs.Tabs.DrugSummaryTab.Click();
            Delay.Milliseconds(200);
            
            // check summary
            if (Mode == "Bolus")        	
	           {	 
	           	// if there is no same drugs added , total dose= DoseUnit and Totaltime= time added drug
	             	MyRepo.TotalDose = (Dosage1 + Dosage2).ToString() + " " + Unit;
	           		MyRepo.TotalTime= "(" + TimeAddDrug1 + ")" +", " + "(" + TimeAddDrug2 + ")";
	            	Validate.Exists(MyRepo.FrmORMain.Drugs.Drug_Summary.DrugSummaryBolusDetailInfo);       	
	        		
	           }
	           else if (Mode == "Infusion" || Mode=="InfusionPurge")        	
	           {		           		
	           		MyRepo.TotalTime= "(" + TimeAddDrug1 + ")" +", " + "(" + TimeAddDrug2 + ")";
	           		
		        	Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmORMain.DrugSummaryInsusionName'.", MyRepo.FrmORMain.Drugs.Drug_Summary.DrugSummaryInsusionNameInfo, new RecordItemIndex(14));
		        	Validate.Exists(MyRepo.FrmORMain.Drugs.Drug_Summary.DrugSummaryInsusionDetailInfo);
		        		 
	         	} 
        }
    }
}
