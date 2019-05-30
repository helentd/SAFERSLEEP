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

namespace SAFERsleep.Recordings.RegionalBlock
{
    public partial class EditRegionalBlockDrugs
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        public void SelectMode(string New_BlockDrug_Mode)
        {
            if (New_BlockDrug_Mode == "Bolus")
        	{
        		repo.FrmEditDrug.Bolus.Click();
        	}
        	else if (New_BlockDrug_Mode == "Infusion")
        	{
        		repo.FrmEditDrug.Infusion.Click();
        	}
        }
        
        public void EnterDose(string New_Mode, string New_Dosage)
        {
            if (New_Mode == "Bolus")
        	{
        		repo.FrmEditDrug.BolusDose.Click();
        		Keyboard.Press(New_Dosage);
        	}
        	else if (New_Mode == "Infusion")
        	{
        		repo.FrmEditDrug.InfusionRate.Click();
        		Keyboard.Press(New_Dosage);
        	}
        	Delay.Milliseconds(200);
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(200);
        }
        
        public void EnterUnit(string New_Mode, string New_Unit)
        {
            if (New_Mode == "Bolus")        	
            {	
            	repo.FrmEditDrug.UnitBolus.DoubleClick();    
				// press "Backspace" to delete the current value
	        	Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
	        	
	        	// enter the value
	        	Keyboard.Press(New_Unit);
	        	
	        	// press "Enter" to add the current value
	        	Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);            	
        		
            }
        	else if (New_Mode == "Infusion")        	
        	{	
        		repo.FrmEditDrug.UnitInfusion.DoubleClick();  
				// press "Backspace" to delete the current value
	        	Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
	        	
	        	// enter the value
	        	Keyboard.Press(New_Unit);
	        	
	        	// press "Enter" to add the current value
	        	Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);        		 
        		 
        	}
        }

    }
}