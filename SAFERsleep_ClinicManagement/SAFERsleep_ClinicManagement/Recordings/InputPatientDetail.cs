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
    ///The InputPatientDetail recording.
    /// </summary>
    [TestModule("c7826232-b1fa-4d2d-8323-206ee2816018", ModuleType.Recording, 1)]
    public partial class InputPatientDetail : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep_ClinicManagement.SAFERsleep_ClinicManagementRepository repository.
        /// </summary>
        public static SAFERsleep_ClinicManagement.SAFERsleep_ClinicManagementRepository repo = SAFERsleep_ClinicManagement.SAFERsleep_ClinicManagementRepository.Instance;

        static InputPatientDetail instance = new InputPatientDetail();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InputPatientDetail()
        {
            varNHI = "PRE0003";
            varLastName = "Preop0002";
            varSex = "Male";
            varTitle = "Mrs";
            varFirstName = "Test";
            varDOB = "23/05/2000";
            varPreferNae = "Test0002";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InputPatientDetail Instance
        {
            get { return instance; }
        }

#region Variables

        string _varNHI;

        /// <summary>
        /// Gets or sets the value of variable varNHI.
        /// </summary>
        [TestVariable("e7cf3e73-f5a1-4ff8-8d6a-e782547c1efe")]
        public string varNHI
        {
            get { return _varNHI; }
            set { _varNHI = value; }
        }

        string _varLastName;

        /// <summary>
        /// Gets or sets the value of variable varLastName.
        /// </summary>
        [TestVariable("dd309f57-d392-4772-aa48-54d2bae70d4f")]
        public string varLastName
        {
            get { return _varLastName; }
            set { _varLastName = value; }
        }

        string _varSex;

        /// <summary>
        /// Gets or sets the value of variable varSex.
        /// </summary>
        [TestVariable("26a4a8d9-4f6b-48d3-a5bf-e26ffe25b409")]
        public string varSex
        {
            get { return _varSex; }
            set { _varSex = value; }
        }

        string _varTitle;

        /// <summary>
        /// Gets or sets the value of variable varTitle.
        /// </summary>
        [TestVariable("d0724cef-ce1d-4211-a74a-3cdf0abea8a2")]
        public string varTitle
        {
            get { return _varTitle; }
            set { _varTitle = value; }
        }

        string _varFirstName;

        /// <summary>
        /// Gets or sets the value of variable varFirstName.
        /// </summary>
        [TestVariable("5097386d-55f8-4f2f-81c1-729ca865a0f4")]
        public string varFirstName
        {
            get { return _varFirstName; }
            set { _varFirstName = value; }
        }

        string _varDOB;

        /// <summary>
        /// Gets or sets the value of variable varDOB.
        /// </summary>
        [TestVariable("f118854a-1e0b-40c6-b8c5-39b9e3713800")]
        public string varDOB
        {
            get { return _varDOB; }
            set { _varDOB = value; }
        }

        string _varPreferNae;

        /// <summary>
        /// Gets or sets the value of variable varPreferNae.
        /// </summary>
        [TestVariable("17b9ed38-ae54-4850-ab3f-30ab1e921fe3")]
        public string varPreferNae
        {
            get { return _varPreferNae; }
            set { _varPreferNae = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.PATIENT.PatietnDetail.NHI' at 18;18.", repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.NHIInfo, new RecordItemIndex(0));
            repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.NHI.Click("18;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varNHI' with focus on 'SAFERsleepClinicManagement.PATIENT.PatietnDetail.NHI'.", repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.NHIInfo, new RecordItemIndex(1));
            repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.NHI.PressKeys(varNHI);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.PATIENT.PatietnDetail.Title' at 76;17.", repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.TitleInfo, new RecordItemIndex(2));
            repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.Title.Click("76;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varTitle' with focus on 'SAFERsleepClinicManagement.PATIENT.PatietnDetail.Title'.", repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.TitleInfo, new RecordItemIndex(3));
            repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.Title.PressKeys(varTitle);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SAFERsleepClinicManagement.PATIENT.PatietnDetail.Title'.", repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.TitleInfo, new RecordItemIndex(4));
            repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.Title.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.PATIENT.PatietnDetail.FirstName' at 65;9.", repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.FirstNameInfo, new RecordItemIndex(5));
            repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.FirstName.Click("65;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varFirstName' with focus on 'SAFERsleepClinicManagement.PATIENT.PatietnDetail.FirstName'.", repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.FirstNameInfo, new RecordItemIndex(6));
            repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.FirstName.PressKeys(varFirstName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.PATIENT.Patient_Body.APAT_DOB' at Center.", repo.SAFERsleepClinicManagement.PATIENT.Patient_Body.APAT_DOBInfo, new RecordItemIndex(7));
            repo.SAFERsleepClinicManagement.PATIENT.Patient_Body.APAT_DOB.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varDOB' with focus on 'SAFERsleepClinicManagement.PATIENT.Patient_Body.APAT_DOB'.", repo.SAFERsleepClinicManagement.PATIENT.Patient_Body.APAT_DOBInfo, new RecordItemIndex(8));
            repo.SAFERsleepClinicManagement.PATIENT.Patient_Body.APAT_DOB.PressKeys(varDOB);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.PATIENT.PatietnDetail.PreferredName' at 49;3.", repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.PreferredNameInfo, new RecordItemIndex(9));
            repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.PreferredName.Click("49;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varPreferNae' with focus on 'SAFERsleepClinicManagement.PATIENT.PatietnDetail.PreferredName'.", repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.PreferredNameInfo, new RecordItemIndex(10));
            repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.PreferredName.PressKeys(varPreferNae);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.PATIENT.PatietnDetail.LastName' at 27;21.", repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.LastNameInfo, new RecordItemIndex(11));
            repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.LastName.Click("27;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varLastName' with focus on 'SAFERsleepClinicManagement.PATIENT.PatietnDetail.LastName'.", repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.LastNameInfo, new RecordItemIndex(12));
            repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.LastName.PressKeys(varLastName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.PATIENT.PatietnDetail.Sex' at 69;11.", repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.SexInfo, new RecordItemIndex(13));
            repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.Sex.Click("69;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varSex' with focus on 'SAFERsleepClinicManagement.PATIENT.PatietnDetail.Sex'.", repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.SexInfo, new RecordItemIndex(14));
            repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.Sex.PressKeys(varSex);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SAFERsleepClinicManagement.PATIENT.PatietnDetail.Sex'.", repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.SexInfo, new RecordItemIndex(15));
            repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.Sex.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.PATIENT.PatietnDetail.BtnSave' at 34;16.", repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.BtnSaveInfo, new RecordItemIndex(16));
            repo.SAFERsleepClinicManagement.PATIENT.PatietnDetail.BtnSave.Click("34;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$varNHI) on item 'SAFERsleepClinicManagement.PATIENT.Patient_Body.SEAC_NHIColumn'.", repo.SAFERsleepClinicManagement.PATIENT.Patient_Body.SEAC_NHIColumnInfo, new RecordItemIndex(17));
            Validate.AttributeContains(repo.SAFERsleepClinicManagement.PATIENT.Patient_Body.SEAC_NHIColumnInfo, "InnerText", varNHI);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
