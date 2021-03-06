﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
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

namespace SAFERsleep.Recordings.Application.Setup_INI
{
    public partial class IVLinesFlushedRequired
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void SetIVLinesFlushedRequired(bool stat)
        {
        	string getActualDir = Directory.GetParent(Directory.GetParent(TestSuite.WorkingDirectory.ToString()).ToString()).ToString();
        	if (stat == false)
        	{
	        	Report.Log(ReportLevel.Info, "Application", "Run application 'Set_IVLines_False.vbs'.");
	            Host.Local.RunApplication(getActualDir + "\\Scripts\\Set_IVLines_False.vbs", "", getActualDir + "\\Scripts\\", false);
        	}
        	else if (stat == true)
        	{
        		Report.Log(ReportLevel.Info, "Application", "Run application 'Set_IVLines_True.vbs'.");
	            Host.Local.RunApplication(getActualDir + "\\Scripts\\Set_IVLines_True.vbs", "", getActualDir + "\\Scripts\\", false);
        	}
        }

    }
}
