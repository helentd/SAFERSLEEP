﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace SAFERsleep.Recordings.Drugs
{
    public partial class AddDrug
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        /// 
        
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        public void SelectMode(string Mode)
        {
        	Ranorex.Report.Info("Select Mode");
        	
        	if (Mode == "Bolus")
        	{
        		repo.FrmEditDrug.Bolus.Click();
        	}
        	else if (Mode == "Infusion")
        	{
        		repo.FrmEditDrug.Infusion.Click();
        	}
        	
        	Delay.Milliseconds(200);
        }
        
        public void EnterDosage(string Mode, string Dosage)
        {
        	Ranorex.Report.Info("Enter Dosage");
        	
        	if (Mode == "Bolus")
        	{
        		repo.FrmEditDrug.BolusDose.Click();
        		Keyboard.Press(Dosage);
        	}
        	else if (Mode == "Infusion")
        	{
        		repo.FrmEditDrug.InfusionRate.Click();
        		Keyboard.Press(Dosage);
        	}
        	else if (Mode=="Default_Bolus" || Mode=="Default_Infusion") {
        		Ranorex.Report.Info("Dose/Rate is selected as Default script");
        	}
        	
        	Delay.Milliseconds(200);
        	Keyboard.Press("{Tab}");
        	Delay.Milliseconds(200);
        }

        public void EnterUnit(string Mode, string Unit)
        {   
			Ranorex.Report.Info("Select Unit");
        	
            if (Mode == "Bolus")        	
            {	
            	repo.FrmEditDrug.UnitBolus.Click();
				Delay.Milliseconds(200);
				// press "Backspace" to delete the current value
	        	//Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
	        	Keyboard.Press("{Home}");
				Delay.Milliseconds(200);
				Keyboard.Press(System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Shift, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
				Delay.Milliseconds(200);
				Keyboard.Press("{Back}");
	        	Delay.Milliseconds(200);
	        	// enter the value
	        	Keyboard.Press(Unit);
	        	Delay.Milliseconds(200);
	        	
	        	// press "Enter" to add the current value
	        	//Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);            	
        		Keyboard.Press("{Enter}");
        		Delay.Milliseconds(200); 
            	/*
            	Keyboard.Press("{Tab}");
        		Delay.Milliseconds(200);
        		Keyboard.Press("{Back}");
	        	Delay.Milliseconds(200);
	        	// enter the value
	        	Keyboard.Press(Unit);
	        	Keyboard.Press("{Enter}");
        		Delay.Milliseconds(200); */
            }
        	else if (Mode == "Infusion")        	
        	{	      		
        		repo.FrmEditDrug.UnitInfusion.Click();
				Delay.Milliseconds(200);
				// press "Backspace" to delete the current value
				Keyboard.Press("{Home}");
				Delay.Milliseconds(200);
				Keyboard.Press(System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Shift, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
				Delay.Milliseconds(200);
				Keyboard.Press("{Back}");
	        	Delay.Milliseconds(200);
	        	
	        	// enter the value
	        	Keyboard.Press(Unit);
	        	Delay.Milliseconds(200);
	        	
	        	// press "Enter" to add the current value
	        	Keyboard.Press("{Enter}");
				Delay.Milliseconds(200);	  
				/*
				Keyboard.Press("{Tab}");
        		Delay.Milliseconds(200);
        		Keyboard.Press("{Back}");
	        	Delay.Milliseconds(200);
	        	// enter the value
	        	Keyboard.Press(Unit);
	        	Keyboard.Press("{Enter}");
        		Delay.Milliseconds(200);   */     		
        	}   	
        }

        public void EnterRoute(string Route)
        {
        	Ranorex.Report.Info("Select Route");
        	
        	repo.FrmEditDrug.Route.DoubleClick();             	
            // press "Backspace" to delete the current value
        	Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
        	
        	// enter the value
        	Keyboard.Press(Route);
        	
        	// press "Enter" to add the current value
        	Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
        	
        	Delay.Milliseconds(200);
        }

        public void CheckInDrugSummary(string DrugProduct, string Mode)
        {
           if (Mode == "Bolus")        	
           {	
            	Validate.Exists(repo.FrmORMain.Drugs.Drug_Summary.DrugSummaryBolusNameInfo);       	
        		
           }
           else if (Mode == "Infusion")        	
           {	
	        	Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmORMain.DrugSummaryInsusionName'.", repo.FrmORMain.Drugs.Drug_Summary.DrugSummaryInsusionNameInfo, new RecordItemIndex(14));
	            Validate.Exists(repo.FrmORMain.Drugs.Drug_Summary.DrugSummaryInsusionNameInfo);     		
	        		 
           }      	
        }

        public void Validate_DrugSummaryInsusionName(RepoItemInfo cellInfo)
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'cellInfo'.", cellInfo);
            Validate.Exists(cellInfo);
        }

    }
}