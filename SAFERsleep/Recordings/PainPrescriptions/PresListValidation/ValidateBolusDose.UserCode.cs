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

namespace SAFERsleep.Recordings.PainPrescriptions.PresListValidation
{
    public partial class ValidateBolusDose
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        public void CheckBolusDose(string bd, string unit)
        {
        	Ranorex.Report.Info("Check if correct Bolus Dose is applied in the prescription");
        	Validate.IsTrue(repo.FrmORMain.PainPrescriptions.AddedPrescription.Text.Contains("Bolus Dose: "+bd+" "+unit));
        	Delay.Milliseconds(200);
        }
    }
}
