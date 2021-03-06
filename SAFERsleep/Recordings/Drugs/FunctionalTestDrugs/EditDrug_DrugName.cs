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
    ///The EditDrug_DrugName recording.
    /// </summary>
    [TestModule("ad2a9184-3760-4ed6-87bc-7486c019dc5b", ModuleType.Recording, 1)]
    public partial class EditDrug_DrugName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static EditDrug_DrugName instance = new EditDrug_DrugName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditDrug_DrugName()
        {
            AddNewDrug = "Yes";
            NewDrugName = "Protamine";
            TimeAddDrug = "12:00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditDrug_DrugName Instance
        {
            get { return instance; }
        }

#region Variables

        string _AddNewDrug;

        /// <summary>
        /// Gets or sets the value of variable AddNewDrug.
        /// </summary>
        [TestVariable("000250ba-7c1b-4227-b072-fc9c08a16d0f")]
        public string AddNewDrug
        {
            get { return _AddNewDrug; }
            set { _AddNewDrug = value; }
        }

        string _NewDrugName;

        /// <summary>
        /// Gets or sets the value of variable NewDrugName.
        /// </summary>
        [TestVariable("a1ba52b5-3a93-45e3-9170-7d9dd8a9c26c")]
        public string NewDrugName
        {
            get { return _NewDrugName; }
            set { _NewDrugName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Comment.
        /// </summary>
        [TestVariable("b107503a-1905-4d9f-a866-10f858263131")]
        public string Comment
        {
            get { return repo.Comment; }
            set { repo.Comment = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Route.
        /// </summary>
        [TestVariable("546ee88d-2806-45a5-b54d-c0dc04e81fcc")]
        public string Route
        {
            get { return repo.Route; }
            set { repo.Route = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DoseUnit.
        /// </summary>
        [TestVariable("b39ccba1-21c8-4d2d-9901-b253fec485cf")]
        public string DoseUnit
        {
            get { return repo.DoseUnit; }
            set { repo.DoseUnit = value; }
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
        [TestVariable("d4c4388d-644c-4d4a-bbfd-cfa10a5a3878")]
        public string TimeAddDrug
        {
            get { return repo.TimeAddDrug; }
            set { repo.TimeAddDrug = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.Drugs.Drugs.DrugListItem' at Center.", repo.FrmORMain.Drugs.Drugs.DrugListItemInfo, new RecordItemIndex(0));
            repo.FrmORMain.Drugs.Drugs.DrugListItem.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.Drugs.Drugs.EditDrug' at Center.", repo.FrmORMain.Drugs.Drugs.EditDrugInfo, new RecordItemIndex(1));
            repo.FrmORMain.Drugs.Drugs.EditDrug.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'FrmEditDrug.DrugTime' and assigning its value to variable 'TimeAddDrug'.", repo.FrmEditDrug.DrugTimeInfo, new RecordItemIndex(2));
            TimeAddDrug = repo.FrmEditDrug.DrugTime.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            // Click on Druct Prodcut name
            Report.Log(ReportLevel.Info, "Mouse", "Click on Druct Prodcut name\r\nMouse Left Click item 'FrmEditDrug.DrugProduct' at Center.", repo.FrmEditDrug.DrugProductInfo, new RecordItemIndex(3));
            repo.FrmEditDrug.DrugProduct.Click();
            Delay.Milliseconds(200);
            
            UserCodeCollection_OR.Clear_TextBox(repo.FrmEditDrug.DrugProductInfo, "Combobox");
            Delay.Milliseconds(0);
            
            // Select another Drug or enter new drug
            ChooseNewDrugProduct(AddNewDrug, NewDrugName);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
