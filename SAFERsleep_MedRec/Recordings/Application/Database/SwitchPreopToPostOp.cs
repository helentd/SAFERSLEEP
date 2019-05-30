/*
 * Created by Ranorex
 * User: Admin
 * Date: 13/08/2018
 * Time: 3:08 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace SAFERsleep_MedRec.Recordings.Application.Database
{
    /// <summary>
    /// Description of SwitchPreopToPostOp.
    /// </summary>
    [TestModule("95EECA92-193E-4698-9415-2E8DD077EE52", ModuleType.UserCode, 1)]
    public class SwitchPreopToPostOp : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SwitchPreopToPostOp()
        {
            // Do not delete - a parameterless constructor is required!
        }
		
		string _PatientNumber = "MNF3676";
		[TestVariable("6ed9fc31-ded9-46b8-a4e5-8f4811b699be")]
		public string PatientNumber
		{
			get { return _PatientNumber; }
			set { _PatientNumber = value; }
		}
		
		string _EpisodeDescription = "Test Procedure 1";
		[TestVariable("31478246-b4d0-43e2-9d9a-2175c37252a2")]
		public string EpisodeDescription
		{
			get { return _EpisodeDescription; }
			set { _EpisodeDescription = value; }
		}
		
        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            SqlConnection con = new SqlConnection("Data Source=ATServer12R2;Initial Catalog=SSAutoTest;Persist Security Info=True;User ID=sa;Password=p@ssw0rd");
            SqlCommand cmd;
        	
        	//Update Operation Status
        	Delay.Milliseconds(30000);
        	con.Open();        	
        	cmd = new SqlCommand("UPDATE Operation SET OperationStatusId = 6 WHERE EpisodeOfCareId = (SELECT mr.EpisodeOfCareId FROM MedicationReconciliation mr JOIN EpisodeOfCare eoc ON mr.EpisodeOfCareId = eoc.EpisodeOfCareId JOIN Patient p ON eoc.PatientId = p.PatientId WHERE p.PrimaryPatientNumber = @PatientNumber AND eoc.EpisodeDescription = @EpisodeDescription)", con);
        	cmd.Parameters.AddWithValue("@PatientNumber", PatientNumber);
        	cmd.Parameters.AddWithValue("@EpisodeDescription", EpisodeDescription);
            cmd.ExecuteNonQuery();
            con.Close();
			
			con.Open();        	
        	cmd = new SqlCommand("UPDATE MedicationReconciliation SET ReconciliationStatusId = 4 WHERE MedicationReconciliationId = (SELECT mr.MedicationReconciliationId FROM MedicationReconciliation mr JOIN EpisodeOfCare eoc ON mr.EpisodeOfCareId = eoc.EpisodeOfCareId JOIN Patient p ON eoc.PatientId = p.PatientId WHERE p.PrimaryPatientNumber = @PatientNumber AND eoc.EpisodeDescription = @EpisodeDescription)", con);
			cmd.Parameters.AddWithValue("@PatientNumber", PatientNumber);
        	cmd.Parameters.AddWithValue("@EpisodeDescription", EpisodeDescription);
            cmd.ExecuteNonQuery();
            con.Close();

			Delay.Milliseconds(30000);            
        }
    }
}
