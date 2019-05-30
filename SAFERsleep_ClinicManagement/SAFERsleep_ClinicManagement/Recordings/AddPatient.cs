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
    ///The AddPatient recording.
    /// </summary>
    [TestModule("c5ba6e15-1775-4ccd-bb9e-661a0d9a11b7", ModuleType.Recording, 1)]
    public partial class AddPatient : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep_ClinicManagement.SAFERsleep_ClinicManagementRepository repository.
        /// </summary>
        public static SAFERsleep_ClinicManagement.SAFERsleep_ClinicManagementRepository repo = SAFERsleep_ClinicManagement.SAFERsleep_ClinicManagementRepository.Instance;

        static AddPatient instance = new AddPatient();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddPatient()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddPatient Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.PATIENT.Patient_Body.APAT_btnSearchBooking' at 120;18.", repo.SAFERsleepClinicManagement.PATIENT.Patient_Body.APAT_btnSearchBookingInfo, new RecordItemIndex(0));
            repo.SAFERsleepClinicManagement.PATIENT.Patient_Body.APAT_btnSearchBooking.Click("120;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.PATIENT.Patient_Body.APAT_btnAddPatient' at 41;16.", repo.SAFERsleepClinicManagement.PATIENT.Patient_Body.APAT_btnAddPatientInfo, new RecordItemIndex(1));
            repo.SAFERsleepClinicManagement.PATIENT.Patient_Body.APAT_btnAddPatient.Click("41;16");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}