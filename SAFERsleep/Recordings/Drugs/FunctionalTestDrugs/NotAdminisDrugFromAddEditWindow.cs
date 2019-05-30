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

namespace SAFERsleep.Recordings.Drugs.FunctionalTestDrugs
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The NotAdminisDrugFromAddEditWindow recording.
    /// </summary>
    [TestModule("d79a265e-1861-4265-9733-56adef01b9fc", ModuleType.Recording, 1)]
    public partial class NotAdminisDrugFromAddEditWindow : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static NotAdminisDrugFromAddEditWindow instance = new NotAdminisDrugFromAddEditWindow();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NotAdminisDrugFromAddEditWindow()
        {
            ReasonNotAdminis = "OtherReason";
            NotAdminisComment = "Test NotAdminisComment";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NotAdminisDrugFromAddEditWindow Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable NotAd_ReasonComment.
        /// </summary>
        [TestVariable("34c77a02-8099-4ec5-93b7-8251ca3df77f")]
        public string NotAd_ReasonComment
        {
            get { return repo.NotAd_ReasonComment; }
            set { repo.NotAd_ReasonComment = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DrugProduct.
        /// </summary>
        [TestVariable("641b5c67-a6fb-4e92-8699-237e53aff7d5")]
        public string DrugProduct
        {
            get { return repo.DrugProduct; }
            set { repo.DrugProduct = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TimeAddDrug.
        /// </summary>
        [TestVariable("52b8ca0f-383d-46c5-b894-d9ae5ec5540d")]
        public string TimeAddDrug
        {
            get { return repo.TimeAddDrug; }
            set { repo.TimeAddDrug = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ReasonNotAdminis.
        /// </summary>
        [TestVariable("761922f1-6921-42de-85ea-03eef6b75086")]
        public string ReasonNotAdminis
        {
            get { return repo.ReasonNotAdminis; }
            set { repo.ReasonNotAdminis = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NotAdminisComment.
        /// </summary>
        [TestVariable("ecf1cb39-83fa-411d-ba42-9f18799aaa61")]
        public string NotAdminisComment
        {
            get { return repo.NotAdminisComment; }
            set { repo.NotAdminisComment = value; }
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

            // Click on NotAdministered button
            Report.Log(ReportLevel.Info, "Mouse", "Click on NotAdministered button\r\nMouse Left Click item 'FrmEditDrug.NotAdministered' at Center.", repo.FrmEditDrug.NotAdministeredInfo, new RecordItemIndex(0));
            repo.FrmEditDrug.NotAdministered.Click();
            Delay.Milliseconds(200);
            
            // Enter reason
            DRUGCodeCollection.ReaonForNotAdminisDrug(ReasonNotAdminis, NotAdminisComment);
            Delay.Milliseconds(0);
            
            // create comment from reason and notAdminis comment
            CreateNotAd_ReasonComment(ReasonNotAdminis, NotAdminisComment);
            Delay.Milliseconds(0);
            
            // Validate the add drug does not exist
            Report.Log(ReportLevel.Info, "Validation", "Validate the add drug does not exist\r\nValidating NotExists on item 'FrmORMain.Drugs.NotAdminisDrugItem'.", repo.FrmORMain.Drugs.NotAdminisDrugItemInfo, new RecordItemIndex(3));
            Validate.NotExists(repo.FrmORMain.Drugs.NotAdminisDrugItemInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}