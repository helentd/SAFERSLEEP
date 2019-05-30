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

namespace SAFERsleep.Recordings.PainPrescriptions.PresListValidation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateAddedCoAnalgesia recording.
    /// </summary>
    [TestModule("f374fc70-2042-4b18-8d04-cd970d90335e", ModuleType.Recording, 1)]
    public partial class ValidateAddedCoAnalgesia : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static ValidateAddedCoAnalgesia instance = new ValidateAddedCoAnalgesia();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateAddedCoAnalgesia()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateAddedCoAnalgesia Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable PrescriptionType.
        /// </summary>
        [TestVariable("16bcb67e-3d39-4841-a19b-65743594bffd")]
        public string PrescriptionType
        {
            get { return repo.PrescriptionType; }
            set { repo.PrescriptionType = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Medication.
        /// </summary>
        [TestVariable("4e354dd5-351b-48bc-8b77-d04432033491")]
        public string Medication
        {
            get { return repo.Medication; }
            set { repo.Medication = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmORMain.PainPrescriptions.AddedCoAnalgesia'.", repo.FrmORMain.PainPrescriptions.AddedCoAnalgesiaInfo, new RecordItemIndex(0));
            Validate.Exists(repo.FrmORMain.PainPrescriptions.AddedCoAnalgesiaInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
