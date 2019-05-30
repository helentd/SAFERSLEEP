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
using System.Diagnostics;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace SAFERsleep.Recordings.AutoUpdate
{
    public partial class Check_OR_Version
    {   	
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        public void ValidateORVersion(string ver)
        {
        	var versionInfo = FileVersionInfo.GetVersionInfo("C:\\Program Files\\SAFERsleep\\SAFERsleep OR\\SAFERsleepOR.exe");
			string version = versionInfo.ProductVersion;
			
			Validate.AreEqual(version, ver);
			Delay.Milliseconds(200);
			
			Ranorex.Report.Info("SAFERsleep OR Version: "+version);
        }

    }
}
