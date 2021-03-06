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

namespace SAFERsleep_Portal.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OpenBrowser recording.
    /// </summary>
    [TestModule("fa139de7-823f-4cde-90af-39adcdb1ff76", ModuleType.Recording, 1)]
    public partial class OpenBrowser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep_Portal.SAFERsleep_PortalRepository repository.
        /// </summary>
        public static SAFERsleep_Portal.SAFERsleep_PortalRepository repo = SAFERsleep_Portal.SAFERsleep_PortalRepository.Instance;

        static OpenBrowser instance = new OpenBrowser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenBrowser()
        {
            Browser = "IE";
            Portal_URL = "http://atserver12r2/portal/account/LogOn";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenBrowser Instance
        {
            get { return instance; }
        }

#region Variables

        string _Browser;

        /// <summary>
        /// Gets or sets the value of variable Browser.
        /// </summary>
        [TestVariable("b078aa40-5a34-48b6-a784-bd819ff49979")]
        public string Browser
        {
            get { return _Browser; }
            set { _Browser = value; }
        }

        string _Portal_URL;

        /// <summary>
        /// Gets or sets the value of variable Portal_URL.
        /// </summary>
        [TestVariable("8fd3bd19-f608-45d9-97f4-72b7eb7d1c92")]
        public string Portal_URL
        {
            get { return _Portal_URL; }
            set { _Portal_URL = value; }
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $Portal_URL with browser specified by variable $Browser in maximized mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser(Portal_URL, Browser, "", false, true, false, false, false);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
