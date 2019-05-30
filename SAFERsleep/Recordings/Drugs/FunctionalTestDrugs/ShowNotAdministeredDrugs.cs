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
    ///The ShowNotAdministeredDrugs recording.
    /// </summary>
    [TestModule("7714c447-018f-45e3-840d-44288e17b58a", ModuleType.Recording, 1)]
    public partial class ShowNotAdministeredDrugs : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static ShowNotAdministeredDrugs instance = new ShowNotAdministeredDrugs();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ShowNotAdministeredDrugs()
        {
            Reason = "OtherReason";
            NotAdminisComment = "Test comment";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ShowNotAdministeredDrugs Instance
        {
            get { return instance; }
        }

#region Variables

        string _Reason;

        /// <summary>
        /// Gets or sets the value of variable Reason.
        /// </summary>
        [TestVariable("b97d5f5a-cb2f-4078-82aa-23381684a9fa")]
        public string Reason
        {
            get { return _Reason; }
            set { _Reason = value; }
        }

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
        /// Gets or sets the value of variable NotAdminisComment.
        /// </summary>
        [TestVariable("31972c6f-7277-471a-9523-89cecd666521")]
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

            // Click on Not Administer Drug
            Report.Log(ReportLevel.Info, "Mouse", "Click on Not Administer Drug\r\nMouse Left Click item 'FrmORMain.Drugs.ShowNotAdministeredDrugs' at Center.", repo.FrmORMain.Drugs.ShowNotAdministeredDrugsInfo, new RecordItemIndex(0));
            repo.FrmORMain.Drugs.ShowNotAdministeredDrugs.Click();
            Delay.Milliseconds(200);
            
            // Check  the drug has been NotADministered
            ValidateNotAdminisDrugItem(Reason, NotAdminisComment);
            Delay.Milliseconds(0);
            
            // Click on "Not Administer Drug" again
            Report.Log(ReportLevel.Info, "Mouse", "Click on \"Not Administer Drug\" again\r\nMouse Left Click item 'FrmORMain.Drugs.ShowNotAdministeredDrugs' at Center.", repo.FrmORMain.Drugs.ShowNotAdministeredDrugsInfo, new RecordItemIndex(2));
            repo.FrmORMain.Drugs.ShowNotAdministeredDrugs.Click();
            Delay.Milliseconds(200);
            
            // Check  NotADministeredDrug disappears
            //Report.Log(ReportLevel.Info, "Validation", "Check  NotADministeredDrug disappears\r\nValidating NotExists on item 'FrmORMain.Drugs.NotAdminisDrugItem'.", repo.FrmORMain.Drugs.NotAdminisDrugItemInfo, new RecordItemIndex(3));
            //Validate.NotExists(repo.FrmORMain.Drugs.NotAdminisDrugItemInfo);
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
