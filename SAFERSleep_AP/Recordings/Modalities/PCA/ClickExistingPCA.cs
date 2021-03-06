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

namespace SAFERSleep_AP.Recordings.Modalities.PCA
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ClickExistingPCA recording.
    /// </summary>
    [TestModule("57723294-ecde-4022-8821-7b2954ac1e78", ModuleType.Recording, 1)]
    public partial class ClickExistingPCA : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERSleep_AP.SAFERSleep_APRepository repository.
        /// </summary>
        public static SAFERSleep_AP.SAFERSleep_APRepository repo = SAFERSleep_AP.SAFERSleep_APRepository.Instance;

        static ClickExistingPCA instance = new ClickExistingPCA();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClickExistingPCA()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClickExistingPCA Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Medication.
        /// </summary>
        [TestVariable("52b6827b-4200-457f-8aad-91aaa2b7444c")]
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

            Mouse_Click_AddedPCA(repo.MainWindow.Modalities.AdvancedModalities.AddedPCAInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
