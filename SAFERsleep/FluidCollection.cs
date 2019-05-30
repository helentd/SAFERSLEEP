/*
 * Created by Ranorex
 * User: Win7-VM
 * Date: 1/03/2019
 * Time: 3:04 p.m.
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
using SAFERsleep.Recordings.Fluids.FunctionalTesting;

namespace SAFERsleep
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class FluidCollection
    {  
    	public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        
        
        [UserCodeMethod]
        public static void CompleteFinishLevel(string CompleteAction, string typeFluid, string StartLevel, string FinishLevel, string VolumeGiven,string RunningTotal)
        {
        	  Report.Log(ReportLevel.Info, "Complete FinishLevel:");
            if (CompleteAction=="Finish") {
        		
        		// click on Finish button
        	   Report.Log(ReportLevel.Info, "Click item 'AddFluidInput.ButtonFinish'.");
	            repo.AddFluidInput.ButtonFinish.Click();
	            Delay.Milliseconds(200);
	            
	              // Validate finish level =0
	            Report.Log(ReportLevel.Info, "Validation", "Validate FinishLEvel= 0", repo.FrmORMain.FluidBalance.FinishLevelCellInfo, new RecordItemIndex(1));
	            Validate.AttributeEqual(repo.FrmORMain.FluidBalance.FinishLevelCellInfo, "Text","0");
	            Delay.Milliseconds(0);
            
            }
        	else if (CompleteAction=="EnterNumber")
        	{        		 
        		// enter number to FinishLEvel
        		 Report.Log(ReportLevel.Info,"Enter number to FinishLEvel");
        		 repo.AddFluidInput.FinishVolume.Click();
           		 Keyboard.Press(FinishLevel);
           		 // click OK           		 
	            Report.Log(ReportLevel.Info,"", "Click ButtonOK.", repo.AddFluidInput.ButtonOKInfo, new RecordItemIndex(0));
	            repo.AddFluidInput.ButtonOK.Click();	           		 
           		 
        		 
	            CheckInFluidList obj= new CheckInFluidList();
	            
	            // assign values to repo items
        		 repo.StartLevel= StartLevel;
        		 repo.FinishLevel= FinishLevel;
        		 repo.VolumeGiven= VolumeGiven;
        		 repo.RunningTotal= RunningTotal;
	            obj.CheckAddedFluidInTheList(typeFluid,repo.StartLevel );
        		 
        	}
        	
        	else if (CompleteAction=="Continue")
        	{
        		//CLick on Continue button
        		Report.Log(ReportLevel.Info,"", "Click ButtonContinue.", repo.AddFluidInput.ButtonContinueInfo, new RecordItemIndex(2));
	            repo.AddFluidInput.ButtonContinue.Click();
	            Delay.Milliseconds(200);
	            
	             // Validate finish level is empty
	            Report.Log(ReportLevel.Info, "Validation", "Validate finish level is empty\r\nValidating AttributeEqual (Text='(null)') on item 'FrmORMain.FluidBalance.FinishLevelCell'.", repo.FrmORMain.FluidBalance.FinishLevelCellInfo, new RecordItemIndex(1));
	            Validate.AttributeEqual(repo.FrmORMain.FluidBalance.FinishLevelCellInfo, "Text", (string)null);
	            Delay.Milliseconds(0);
	            
	            // Validate Volume given is empty
	            Report.Log(ReportLevel.Info, "Validation", "Validate Volume given is empty\r\nValidating AttributeEqual (Text='(null)') on item 'FrmORMain.FluidBalance.VolumeGivenCell'.", repo.FrmORMain.FluidBalance.VolumeGivenCellInfo, new RecordItemIndex(2));
	            Validate.AttributeEqual(repo.FrmORMain.FluidBalance.VolumeGivenCellInfo, "Text", (string)null);
	            Delay.Milliseconds(0);
	            
	            // Validate TotalRunningl is empty
	            Report.Log(ReportLevel.Info, "Validation", "Validate TotalRunningl is empty\r\nValidating AttributeEqual (Text='(null)') on item 'FrmORMain.FluidBalance.TotalRunningCell'.", repo.FrmORMain.FluidBalance.TotalRunningCellInfo, new RecordItemIndex(3));
	            Validate.AttributeEqual(repo.FrmORMain.FluidBalance.TotalRunningCellInfo, "Text", (string)null);
	            Delay.Milliseconds(0);
        	}
        }
    }
}
