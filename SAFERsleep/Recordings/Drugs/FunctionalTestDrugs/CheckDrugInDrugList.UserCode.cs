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

namespace SAFERsleep.Recordings.Drugs.FunctionalTestDrugs
{
    public partial class CheckDrugInDrugList
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        //Validate the  Drug is added/edited succesfully- Exist in the Drug list
        public void CheckDrugListItem( string Mode)
        {
        	Report.Log(ReportLevel.Info,"Validate the  Drug is added succesfully");
            if (Mode == "Bolus" || Mode == "Infusion")        	
           {	            	  
            	Validate.Exists(repo.FrmORMain.Drugs.Drugs.DrugListItemDetailInfo);
	            Delay.Milliseconds(100);            	
        		
           }
           else if (Mode == "InfusionPurge")        	
           {	// If Drug is added as Purge, the dosesage will be Purge int the drug list
           		repo.DoseUnit="Purge";
             	Report.Log(ReportLevel.Info,"Mode is InfusionPurge: " + DoseUnit);
	        	Validate.Exists(repo.FrmORMain.Drugs.Drugs.DrugListItemDetailInfo);
	            Delay.Milliseconds(100);       		
	        		 
           } 
        }
        
        

    }
}