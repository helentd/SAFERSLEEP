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
using System.Globalization;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace SAFERsleep.Recordings.Fluids.FunctionalTesting
{
    public partial class CheckInFluidList
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void CheckAddedFluidInTheList(string TypeFluid, string StartLevel)
        {
        	if (StartLevel.Contains(".")== false && StartLevel.Length>3)
        	{
        		
		        // repo.StartLevel = string.Format("{0:n0}",repo.StartLevel);
		       repo.StartLevel=  repo.StartLevel.Insert( repo.StartLevel.Length - 3, ",");
		       // Report.Log(ReportLevel.Info, "New Start Level: " +repo.StartLevel + "," + string.Format("{0:n}",repo.StartLevel));
        	
        	}
          
           if (TypeFluid=="Input") 
        	{
        		 // Validate Fluid is added successfully
	            Report.Log(ReportLevel.Info, "Validation", "Validate Fluid is added successfully.", repo.FrmORMain.FluidBalance.AddedFluidInputDetailInfo, new RecordItemIndex(0));
	            Validate.Exists(repo.FrmORMain.FluidBalance.AddedFluidInputDetailInfo);
	            Delay.Milliseconds(0);
            
        	}
        	else if (TypeFluid=="Output") 
        	{
        		  // Validate Fluid is added successfully
	            Report.Log(ReportLevel.Info, "Validation", "Validate Fluid is added successfully.", repo.FrmORMain.FluidBalance.AddedFluidOutputDetailInfo, new RecordItemIndex(0));
	            Validate.Exists(repo.FrmORMain.FluidBalance.AddedFluidOutputDetailInfo);
	            Delay.Milliseconds(0);
        	}
        }

    }
}