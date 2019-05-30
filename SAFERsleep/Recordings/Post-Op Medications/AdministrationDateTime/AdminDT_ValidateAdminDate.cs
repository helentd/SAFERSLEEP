/*
 * Created by Ranorex
 * User: Admin
 * Date: 7/02/2019
 * Time: 1:04 PM
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

namespace SAFERsleep.Recordings.Post_Op_Medications.AdministrationDateTime
{
    /// <summary>
    /// Description of ValidateAdminDate.
    /// </summary>
    [TestModule("13F17A7E-5DAD-4A57-ABE4-8002654F90C0", ModuleType.UserCode, 1)]
    public class AdminDT_ValidateAdminDate : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	
    	string _AdminDate = "";
    	[TestVariable("6adb20a8-1350-4718-b07a-3d9fd698d45b")]
    	public string AdminDate
    	{
    		get { return _AdminDate; }
    		set { _AdminDate = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AdminDT_ValidateAdminDate()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Validate the current Administration Date set in the field
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            if (AdminDate == "today")
            {
            	Ranorex.Report.Info("Validate Administration Date is today's date by default");
            	string Date_Today = System.DateTime.Now.ToString("d/MM/yyyy");
            	Validate.AreEqual(MyRepo.AddAdministrationDateTime.AdminDate.Element.GetAttributeValueText("Text"), Date_Today);
            }
            else
            {
            	Validate.AreEqual(MyRepo.AddAdministrationDateTime.AdminDate.Element.GetAttributeValueText("Text"), AdminDate);
            }           
        }
    }
}
