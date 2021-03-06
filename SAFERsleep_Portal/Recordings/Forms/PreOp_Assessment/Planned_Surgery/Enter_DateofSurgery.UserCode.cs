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

namespace SAFERsleep_Portal.Recordings.Forms.PreOp_Assessment.Planned_Surgery
{
    public partial class Enter_DateofSurgery
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        public void Enter_DateofSurgery_Method()
        {
            Ranorex.Report.Info("Enter Current Date for Date of Surgery");
            repo.PreOperativeForm.PreOpAssessment_Form.PlannedSurgerySection.DateofSurgery.Click();
            Delay.Milliseconds(200);
            String DateofSurgery = System.DateTime.Now.ToString("dd/MM/yyyy");
            Keyboard.Press(DateofSurgery);
            Delay.Milliseconds(200);
        }

    }
}
