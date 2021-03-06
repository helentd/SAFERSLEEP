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
    ///The SelectDrugFromList recording.
    /// </summary>
    [TestModule("db2cc4d2-bc08-46ad-bbc0-2ea8223f705f", ModuleType.Recording, 1)]
    public partial class SelectDrugFromList : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static SelectDrugFromList instance = new SelectDrugFromList();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectDrugFromList()
        {
            DrugProduct = "Acarbose";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectDrugFromList Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable DrugProduct.
        /// </summary>
        [TestVariable("82b3dc0c-cf68-4af4-a1bf-e2ae9e787d91")]
        public string DrugProduct
        {
            get { return repo.DrugProduct; }
            set { repo.DrugProduct = value; }
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

            // CLick on Drug Product drop down list
            Report.Log(ReportLevel.Info, "Mouse", "CLick on Drug Product drop down list\r\nMouse Left Click item 'FrmEditDrug.DrugProduct' at 308;16.", repo.FrmEditDrug.DrugProductInfo, new RecordItemIndex(0));
            repo.FrmEditDrug.DrugProduct.Click("308;16");
            Delay.Milliseconds(200);
            
            // Enter Drug Product name
            Report.Log(ReportLevel.Info, "Keyboard", "Enter Drug Product name\r\nKey sequence from variable '$DrugProduct'.", new RecordItemIndex(1));
            Keyboard.Press(DrugProduct);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
