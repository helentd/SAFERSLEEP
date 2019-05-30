/*
 * Created by Ranorex
 * User: Admin
 * Date: 18/03/2019
 * Time: 1:34 PM
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

namespace SAFERSleep_AP.Recordings.SearchPatient
{
    /// <summary>
    /// Description of ClickPatient_WardView.
    /// </summary>
    [TestModule("DED2EF32-D1C0-4B8F-BFC4-79C78269E1FE", ModuleType.UserCode, 1)]
    public class ClickPatient_WardView : ITestModule
    {
    	SAFERSleep_APRepository MyRepo = new SAFERSleep_APRepository();
    	
    	string _LastName = "";
    	[TestVariable("72ce70ab-afea-49b7-aab5-3e7165b9c1e4")]
    	public string LastName
    	{
    		get { return _LastName; }
    		set { _LastName = value; }
    	}
    	
    	string _FirstName = "";
    	[TestVariable("5ddf4ace-32a3-494c-8033-05cdea31468b")]
    	public string FirstName
    	{
    		get { return _FirstName; }
    		set { _FirstName = value; }
    	}
    	
    	string _IsDischarged = ""; //Yes or No
    	[TestVariable("ae6c3ebf-54e2-4806-a152-34d3ea2e2728")]
    	public string IsDischarged
    	{
    		get { return _IsDischarged; }
    		set { _IsDischarged = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClickPatient_WardView()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Click the Patient in search screen with Ward View
        /// Enter Patients LastName and FirstName
        /// Enter Discharge status (Yes or No)
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            if (IsDischarged == "Yes")
            	MyRepo.Patient = LastName +", "+ FirstName +" (discharged)";
            else
            	MyRepo.Patient = LastName +", "+ FirstName;
            MyRepo.MainWindow.SearchPatientScreen.PatientSearchWardView.Click();
        }
    }
}
