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
    ///The ValidateLoadingDose recording.
    /// </summary>
    [TestModule("8f29db5b-4c80-4a22-a817-64ea71882d2b", ModuleType.Recording, 1)]
    public partial class ValidateLoadingDose : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static ValidateLoadingDose instance = new ValidateLoadingDose();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateLoadingDose()
        {
            PrescriptionType = "Epidural Analgesia";
            PrescriptionDetails = "5";
            PrescriptionUnit = "ml";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateLoadingDose Instance
        {
            get { return instance; }
        }

#region Variables

        string _PrescriptionUnit;

        /// <summary>
        /// Gets or sets the value of variable PrescriptionUnit.
        /// </summary>
        [TestVariable("c4e7028a-618d-498a-9493-c4aa735efa63")]
        public string PrescriptionUnit
        {
            get { return _PrescriptionUnit; }
            set { _PrescriptionUnit = value; }
        }

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
        /// Gets or sets the value of variable PrescriptionDetails.
        /// </summary>
        [TestVariable("468da0ff-cb85-4774-a2d4-3678876ecd5f")]
        public string PrescriptionDetails
        {
            get { return repo.PrescriptionDetails; }
            set { repo.PrescriptionDetails = value; }
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

            CheckLoadingDose(PrescriptionDetails, PrescriptionUnit);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}