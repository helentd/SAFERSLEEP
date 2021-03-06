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

namespace SAFERsleep_Portal.Recordings.Forms.PreOp_Assessment.Medical_Surgical_History
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Fill_FamilyHistory recording.
    /// </summary>
    [TestModule("ef9b1841-7ab5-416c-993f-d6e171527052", ModuleType.Recording, 1)]
    public partial class Fill_FamilyHistory : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep_Portal.SAFERsleep_PortalRepository repository.
        /// </summary>
        public static SAFERsleep_Portal.SAFERsleep_PortalRepository repo = SAFERsleep_Portal.SAFERsleep_PortalRepository.Instance;

        static Fill_FamilyHistory instance = new Fill_FamilyHistory();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Fill_FamilyHistory()
        {
            ProblemsAnaesthetic_Status = "Yes";
            ProblemsAnaesthetic_Note = "this is a test note for problems with anaesthetic";
            HistoryDiabetes_Status = "Yes";
            History_Diabetes_Note = "this is a test note only";
            MuscularDystrophy_Status = "Yes";
            MuscularDystrophy_Note = "this is a test note";
            BleedingDisorder_Status = "Yes";
            BleedingDisorder_Note = "this is a test note";
            MalignantHyperthermia_Status = "Yes";
            MalignantHyperthermia_Note = "this is a test note";
            OtherComments = "this is a test comment";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Fill_FamilyHistory Instance
        {
            get { return instance; }
        }

#region Variables

        string _ProblemsAnaesthetic_Status;

        /// <summary>
        /// Gets or sets the value of variable ProblemsAnaesthetic_Status.
        /// </summary>
        [TestVariable("f1ac3d28-a6fa-4ce1-9559-c80a06bf1799")]
        public string ProblemsAnaesthetic_Status
        {
            get { return _ProblemsAnaesthetic_Status; }
            set { _ProblemsAnaesthetic_Status = value; }
        }

        string _ProblemsAnaesthetic_Note;

        /// <summary>
        /// Gets or sets the value of variable ProblemsAnaesthetic_Note.
        /// </summary>
        [TestVariable("d88c6dca-7601-40c2-8077-42b748edf236")]
        public string ProblemsAnaesthetic_Note
        {
            get { return _ProblemsAnaesthetic_Note; }
            set { _ProblemsAnaesthetic_Note = value; }
        }

        string _HistoryDiabetes_Status;

        /// <summary>
        /// Gets or sets the value of variable HistoryDiabetes_Status.
        /// </summary>
        [TestVariable("324cf20e-5fb0-43ea-8569-2b88f8b4afab")]
        public string HistoryDiabetes_Status
        {
            get { return _HistoryDiabetes_Status; }
            set { _HistoryDiabetes_Status = value; }
        }

        string _History_Diabetes_Note;

        /// <summary>
        /// Gets or sets the value of variable History_Diabetes_Note.
        /// </summary>
        [TestVariable("f370d038-84d7-40ba-802e-8c30a304ed69")]
        public string History_Diabetes_Note
        {
            get { return _History_Diabetes_Note; }
            set { _History_Diabetes_Note = value; }
        }

        string _MuscularDystrophy_Status;

        /// <summary>
        /// Gets or sets the value of variable MuscularDystrophy_Status.
        /// </summary>
        [TestVariable("9ead3b59-bb6d-4ca2-a0ea-2b76be36ca00")]
        public string MuscularDystrophy_Status
        {
            get { return _MuscularDystrophy_Status; }
            set { _MuscularDystrophy_Status = value; }
        }

        string _MuscularDystrophy_Note;

        /// <summary>
        /// Gets or sets the value of variable MuscularDystrophy_Note.
        /// </summary>
        [TestVariable("0d9261c1-2be5-4499-aeac-b7c3c8bb5be2")]
        public string MuscularDystrophy_Note
        {
            get { return _MuscularDystrophy_Note; }
            set { _MuscularDystrophy_Note = value; }
        }

        string _BleedingDisorder_Status;

        /// <summary>
        /// Gets or sets the value of variable BleedingDisorder_Status.
        /// </summary>
        [TestVariable("a21e6e7e-941c-4796-ae15-a2f03eb56038")]
        public string BleedingDisorder_Status
        {
            get { return _BleedingDisorder_Status; }
            set { _BleedingDisorder_Status = value; }
        }

        string _BleedingDisorder_Note;

        /// <summary>
        /// Gets or sets the value of variable BleedingDisorder_Note.
        /// </summary>
        [TestVariable("07143341-7638-4bf2-8b57-4ff5bc2b9068")]
        public string BleedingDisorder_Note
        {
            get { return _BleedingDisorder_Note; }
            set { _BleedingDisorder_Note = value; }
        }

        string _MalignantHyperthermia_Status;

        /// <summary>
        /// Gets or sets the value of variable MalignantHyperthermia_Status.
        /// </summary>
        [TestVariable("7e59952e-d115-4d6f-93a9-bbcf04b06d3b")]
        public string MalignantHyperthermia_Status
        {
            get { return _MalignantHyperthermia_Status; }
            set { _MalignantHyperthermia_Status = value; }
        }

        string _MalignantHyperthermia_Note;

        /// <summary>
        /// Gets or sets the value of variable MalignantHyperthermia_Note.
        /// </summary>
        [TestVariable("63d7f6aa-be0f-4fbc-9e17-05c47239bb1a")]
        public string MalignantHyperthermia_Note
        {
            get { return _MalignantHyperthermia_Note; }
            set { _MalignantHyperthermia_Note = value; }
        }

        string _OtherComments;

        /// <summary>
        /// Gets or sets the value of variable OtherComments.
        /// </summary>
        [TestVariable("6af29be2-597e-4123-bc66-c3b817725b86")]
        public string OtherComments
        {
            get { return _OtherComments; }
            set { _OtherComments = value; }
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
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            SetFill_ProblemsAnaesthetic(ProblemsAnaesthetic_Status, ProblemsAnaesthetic_Note);
            
            SetFill_HistoryDiabetes(HistoryDiabetes_Status, History_Diabetes_Note);
            
            SetFill_MuscularDystrophy(MuscularDystrophy_Status, MuscularDystrophy_Note);
            
            SetFill_BleedingDisorder(BleedingDisorder_Status, BleedingDisorder_Note);
            
            SetFill_MalignantHyperthermia(MalignantHyperthermia_Status, MalignantHyperthermia_Note);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PreOperativeForm.PreOpAssessment_Form.MedicalSurgicalHistorySection.FamilyHistory.OtherComments' at Center.", repo.PreOperativeForm.PreOpAssessment_Form.MedicalSurgicalHistorySection.FamilyHistory.OtherCommentsInfo, new RecordItemIndex(5));
            repo.PreOperativeForm.PreOpAssessment_Form.MedicalSurgicalHistorySection.FamilyHistory.OtherComments.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$OtherComments'.", new RecordItemIndex(6));
            Keyboard.Press(OtherComments);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
