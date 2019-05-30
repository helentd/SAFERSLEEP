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
    ///The Login recording.
    /// </summary>
    [TestModule("d8d06853-a20c-4db6-bf8b-1206a748466b", ModuleType.Recording, 1)]
    public partial class Login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep_ClinicManagement.SAFERsleep_ClinicManagementRepository repository.
        /// </summary>
        public static SAFERsleep_ClinicManagement.SAFERsleep_ClinicManagementRepository repo = SAFERsleep_ClinicManagement.SAFERsleep_ClinicManagementRepository.Instance;

        static Login instance = new Login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Login()
        {
            varPassWord = "poi098{LShiftKey down})(*{LShiftKey up}";
            varHospital = "Wellington Hospital";
            varUserName = "admin";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Login Instance
        {
            get { return instance; }
        }

#region Variables

        string _varPassWord;

        /// <summary>
        /// Gets or sets the value of variable varPassWord.
        /// </summary>
        [TestVariable("369269cf-8e4e-4910-8a8b-b3277f413c07")]
        public string varPassWord
        {
            get { return _varPassWord; }
            set { _varPassWord = value; }
        }

        string _varHospital;

        /// <summary>
        /// Gets or sets the value of variable varHospital.
        /// </summary>
        [TestVariable("0892f0d1-5eaf-45c1-8f70-c0e9ae262ee3")]
        public string varHospital
        {
            get { return _varHospital; }
            set { _varHospital = value; }
        }

        string _varUserName;

        /// <summary>
        /// Gets or sets the value of variable varUserName.
        /// </summary>
        [TestVariable("fa5902cc-f67a-4315-a84d-e2d7264e07ba")]
        public string varUserName
        {
            get { return _varUserName; }
            set { _varUserName = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.LoginDetail.Hospitals' at Center.", repo.SAFERsleepClinicManagement.LoginDetail.HospitalsInfo, new RecordItemIndex(0));
            repo.SAFERsleepClinicManagement.LoginDetail.Hospitals.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varHospital' with focus on 'SAFERsleepClinicManagement.LoginDetail.Hospitals'.", repo.SAFERsleepClinicManagement.LoginDetail.HospitalsInfo, new RecordItemIndex(1));
            repo.SAFERsleepClinicManagement.LoginDetail.Hospitals.PressKeys(varHospital);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SAFERsleepClinicManagement.LoginDetail.Hospitals'.", repo.SAFERsleepClinicManagement.LoginDetail.HospitalsInfo, new RecordItemIndex(2));
            repo.SAFERsleepClinicManagement.LoginDetail.Hospitals.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.LoginDetail.Username' at Center.", repo.SAFERsleepClinicManagement.LoginDetail.UsernameInfo, new RecordItemIndex(3));
            repo.SAFERsleepClinicManagement.LoginDetail.Username.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$varUserName' on item 'SAFERsleepClinicManagement.LoginDetail.Username'.", repo.SAFERsleepClinicManagement.LoginDetail.UsernameInfo, new RecordItemIndex(4));
            repo.SAFERsleepClinicManagement.LoginDetail.Username.Element.SetAttributeValue("Value", varUserName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.LoginDetail.Password' at Center.", repo.SAFERsleepClinicManagement.LoginDetail.PasswordInfo, new RecordItemIndex(5));
            repo.SAFERsleepClinicManagement.LoginDetail.Password.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$varPassWord' on item 'SAFERsleepClinicManagement.LoginDetail.Password'.", repo.SAFERsleepClinicManagement.LoginDetail.PasswordInfo, new RecordItemIndex(6));
            repo.SAFERsleepClinicManagement.LoginDetail.Password.Element.SetAttributeValue("Value", varPassWord);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.MainBody.LOG_BtnLogin' at 56;18.", repo.SAFERsleepClinicManagement.MainBody.LOG_BtnLoginInfo, new RecordItemIndex(7));
            repo.SAFERsleepClinicManagement.MainBody.LOG_BtnLogin.Click("56;18");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}