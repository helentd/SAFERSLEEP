﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SAFERsleep_ClinicManagement.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BookApointment recording.
    /// </summary>
    [TestModule("4c25e419-5d76-4591-a80a-ee6dd9de443e", ModuleType.Recording, 1)]
    public partial class BookApointment : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep_ClinicManagement.SAFERsleep_ClinicManagementRepository repository.
        /// </summary>
        public static SAFERsleep_ClinicManagement.SAFERsleep_ClinicManagementRepository repo = SAFERsleep_ClinicManagement.SAFERsleep_ClinicManagementRepository.Instance;

        static BookApointment instance = new BookApointment();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BookApointment()
        {
            varOperationName = "Operation1";
            varAppDate = "24/05/2018";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BookApointment Instance
        {
            get { return instance; }
        }

#region Variables

        string _varOperationName;

        /// <summary>
        /// Gets or sets the value of variable varOperationName.
        /// </summary>
        [TestVariable("8bb2c111-2dfe-481a-91ca-eb2abe21b833")]
        public string varOperationName
        {
            get { return _varOperationName; }
            set { _varOperationName = value; }
        }

        string _varAppDate;

        /// <summary>
        /// Gets or sets the value of variable varAppDate.
        /// </summary>
        [TestVariable("9f61044e-7015-42ff-9dd1-a35e8294854e")]
        public string varAppDate
        {
            get { return _varAppDate; }
            set { _varAppDate = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.PATIENT.Patient_Body.APOIT_CreateAppointment' at Center.", repo.SAFERsleepClinicManagement.PATIENT.Patient_Body.APOIT_CreateAppointmentInfo, new RecordItemIndex(0));
            repo.SAFERsleepClinicManagement.PATIENT.Patient_Body.APOIT_CreateAppointment.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.PATIENT.CreateAppoinment.OperationName' at Center.", repo.SAFERsleepClinicManagement.PATIENT.CreateAppoinment.OperationNameInfo, new RecordItemIndex(1));
            repo.SAFERsleepClinicManagement.PATIENT.CreateAppoinment.OperationName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varOperationName' with focus on 'SAFERsleepClinicManagement.PATIENT.CreateAppoinment.OperationName'.", repo.SAFERsleepClinicManagement.PATIENT.CreateAppoinment.OperationNameInfo, new RecordItemIndex(2));
            repo.SAFERsleepClinicManagement.PATIENT.CreateAppoinment.OperationName.PressKeys(varOperationName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varAppDate' with focus on 'SAFERsleepClinicManagement.PATIENT.CreateAppoinment.ApoinmentDate'.", repo.SAFERsleepClinicManagement.PATIENT.CreateAppoinment.ApoinmentDateInfo, new RecordItemIndex(3));
            repo.SAFERsleepClinicManagement.PATIENT.CreateAppoinment.ApoinmentDate.PressKeys(varAppDate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.PATIENT.CreateAppoinment.Rdo_AM' at Center.", repo.SAFERsleepClinicManagement.PATIENT.CreateAppoinment.Rdo_AMInfo, new RecordItemIndex(4));
            repo.SAFERsleepClinicManagement.PATIENT.CreateAppoinment.Rdo_AM.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.PATIENT.Patient_Body.APOT_BtnSave' at Center.", repo.SAFERsleepClinicManagement.PATIENT.Patient_Body.APOT_BtnSaveInfo, new RecordItemIndex(5));
            repo.SAFERsleepClinicManagement.PATIENT.Patient_Body.APOT_BtnSave.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
