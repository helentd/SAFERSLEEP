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

namespace SAFERsleep.Recordings.Fluids.FunctionalTesting.Output
{
    public partial class DeleteFluidOutput
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void SelectFirstOutputItem()
        {
            // create a table Fluid from path
            Ranorex.Table tblFluid= "/form[@controlname='frmMain']/?/?/form[@name='frmFluidBalanceModule']/?/?/tabpage[@name='tsFluidOutput']/?/?/table[@class='TcxGridSite']";
           // get the first row of the table
           if (tblFluid.Rows.Count>0)
           {
	           	Ranorex.Row firstRow = tblFluid.Rows[1];
	           // get list cells of this row
	            IList<Cell> lstCell=  firstRow.Cells; 
	            // get time of firt Output fluid
	            string sttrTime= lstCell[0].GetAttributeValue<string>("Text");
	            
				repo.TimeAddFluid= sttrTime;	            
	            Delay.Milliseconds(0);
           }
            
        }

    }
}
