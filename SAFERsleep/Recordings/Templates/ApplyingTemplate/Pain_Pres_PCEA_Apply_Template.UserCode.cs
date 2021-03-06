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

namespace SAFERsleep.Recordings.Templates.ApplyingTemplate
{
    public partial class Pain_Pres_PCEA_Apply_Template
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        private string medication;
        private string unit;
        private string loadingdose;
        private string bolusdose;
        private string rate;
        private string lockout;
        private string hour;
        private string doselimit;
        private string instructions;
		
        public void GetTemplateValues()
        {
        	Ranorex.Report.Info("Getting the values of PCEA Template");
        	medication = repo.TemplateAdministration.PCEA.PCEAMedication.TextValue;
        	unit = repo.TemplateAdministration.PCEA.Unit.BolusDoseUnit.TextValue;
        	loadingdose = repo.TemplateAdministration.PCEA.PCEALoadingDose.TextValue;
        	bolusdose = repo.TemplateAdministration.PCEA.PCEABolusDose.TextValue;
        	rate = repo.TemplateAdministration.PCEA.PCEAInfusionRate.TextValue;
        	lockout = repo.TemplateAdministration.PCEA.PCEALockout.TextValue;
        	hour = repo.TemplateAdministration.PCEA.PCEAHour.TextValue;
        	doselimit = repo.TemplateAdministration.PCEA.PCEADoseLimit.TextValue;
        	instructions = repo.TemplateAdministration.PCEA.PCEAInstructions.TextValue;
        	Delay.Milliseconds(200);
        }
        
        public void ValidateTemplateApplied()
        {
        	Ranorex.Report.Info("Checking values applied from the Template");
        	
        	if (medication != null)
        	{
        		Ranorex.Report.Info("Checking Medication"); 
        		Validate.IsTrue(repo.FrmORMain.PainPrescriptions.AddedPrescription.Text.Contains(medication));
        		Delay.Milliseconds(200);
        	}        	
        	
        	if (loadingdose != null)
        	{
        		Ranorex.Report.Info("Checking Loading Dose");
        		Validate.IsTrue(repo.FrmORMain.PainPrescriptions.AddedPrescription.Text.Contains("Loading Dose: "+loadingdose+" "+unit));
        		Delay.Milliseconds(200);
        	}        	
        	
        	if (bolusdose != null)
        	{
        		Ranorex.Report.Info("Checking Bolus Dose");
        		Validate.IsTrue(repo.FrmORMain.PainPrescriptions.AddedPrescription.Text.Contains("Bolus Dose: "+bolusdose+" "+unit));
        		Delay.Milliseconds(200);
        	}        	
        	
        	if (rate != null)
        	{
        		Ranorex.Report.Info("Checking Continuous Rate");
        		Validate.IsTrue(repo.FrmORMain.PainPrescriptions.AddedPrescription.Text.Contains("Continuous Rate: "+rate+" "+unit+"/hr"));
        		Delay.Milliseconds(200);
        	}
        	
        	if (lockout != null)
        	{
        		Ranorex.Report.Info("Checking Lockout");
        		Validate.IsTrue(repo.FrmORMain.PainPrescriptions.AddedPrescription.Text.Contains("Lockout (minutes): "+lockout));
        		Delay.Milliseconds(200);
        	}
        	
        	if (hour != null && doselimit != null)
        	{
        		Ranorex.Report.Info("Checking Hour Dose Limit");
        		Validate.IsTrue(repo.FrmORMain.PainPrescriptions.AddedPrescription.Text.Contains(hour+" hour dose limit: "+doselimit+" "+unit));
        		Delay.Milliseconds(200);
        	}
        	
        	if (instructions != null)
        	{
        		Ranorex.Report.Info("Checking Instructions");
        		Validate.IsTrue(repo.FrmORMain.PainPrescriptions.AddedPrescription.Text.Contains(instructions));
        		Delay.Milliseconds(200);
        	}
        	
        }
    }
}
