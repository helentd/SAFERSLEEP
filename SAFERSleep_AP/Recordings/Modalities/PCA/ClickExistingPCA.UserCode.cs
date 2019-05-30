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

namespace SAFERSleep_AP.Recordings.Modalities.PCA
{
    public partial class ClickExistingPCA
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Mouse_Click_AddedPCA(RepoItemInfo textInfo)
        {
        	int index = Medication.IndexOf("(");
            if (index > 0)
            	Medication = Medication.Substring(0, index - 1);
            repo.Medication = Medication;
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'textInfo' at Center.", textInfo);
            textInfo.FindAdapter<Text>().Click();
        }

    }
}
