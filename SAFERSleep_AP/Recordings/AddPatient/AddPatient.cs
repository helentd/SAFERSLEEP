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

namespace SAFERSleep_AP.Recordings.AddPatient
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddPatient recording.
    /// </summary>
    [TestModule("6204a5e5-44fa-43f8-8d0a-8f4f6acb16f8", ModuleType.Recording, 1)]
    public partial class AddPatient : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERSleep_AP.SAFERSleep_APRepository repository.
        /// </summary>
        public static SAFERSleep_AP.SAFERSleep_APRepository repo = SAFERSleep_AP.SAFERSleep_APRepository.Instance;

        static AddPatient instance = new AddPatient();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddPatient()
        {
            NHI = "APA1000";
            LastName = "Test";
            FirstName = "APA1000";
            DOB = "06-Aug-2000";
            Gender = "Male";
            ASA = "3";
            Weight = "50";
            Height = "170";
            Ward = "21";
            Room = "Room 1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddPatient Instance
        {
            get { return instance; }
        }

#region Variables

        string _LastName;

        /// <summary>
        /// Gets or sets the value of variable LastName.
        /// </summary>
        [TestVariable("d22e848b-a53c-453c-a526-cfb97d99624d")]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        string _FirstName;

        /// <summary>
        /// Gets or sets the value of variable FirstName.
        /// </summary>
        [TestVariable("3267e443-9ccd-4ace-bca4-2452c2e09e50")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        string _Height;

        /// <summary>
        /// Gets or sets the value of variable Height.
        /// </summary>
        [TestVariable("5f082bc6-8a80-4436-abaa-25287e3ae95f")]
        public string Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NHI.
        /// </summary>
        [TestVariable("9bf9700e-6eb1-46f9-a98b-621fe43abbd8")]
        public string NHI
        {
            get { return repo.NHI; }
            set { repo.NHI = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DOB.
        /// </summary>
        [TestVariable("87330333-8585-40ae-90ea-c920d4146287")]
        public string DOB
        {
            get { return repo.DOB; }
            set { repo.DOB = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Gender.
        /// </summary>
        [TestVariable("f7eadb1d-1cad-449a-8b0f-d2f4db88980a")]
        public string Gender
        {
            get { return repo.Gender; }
            set { repo.Gender = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ASA.
        /// </summary>
        [TestVariable("fe39172a-0f2d-447f-82fd-cec7b4a0d2ec")]
        public string ASA
        {
            get { return repo.ASA; }
            set { repo.ASA = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Weight.
        /// </summary>
        [TestVariable("68fc7dfd-903c-41b7-9928-2ef222672bb8")]
        public string Weight
        {
            get { return repo.Weight; }
            set { repo.Weight = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Ward.
        /// </summary>
        [TestVariable("789b7a1e-b375-4469-9eae-e1b60024e2f0")]
        public string Ward
        {
            get { return repo.Ward; }
            set { repo.Ward = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Room.
        /// </summary>
        [TestVariable("bb6437a6-01a3-4620-833f-1c262ef1262a")]
        public string Room
        {
            get { return repo.Room; }
            set { repo.Room = value; }
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

            // Click on "Add Patient"
            Report.Log(ReportLevel.Info, "Mouse", "Click on \"Add Patient\"\r\nMouse Left Click item 'MainWindow.AddPatient' at Center.", repo.MainWindow.AddPatientInfo, new RecordItemIndex(0));
            repo.MainWindow.AddPatient.Click();
            
            // Enter NHI
            Report.Log(ReportLevel.Info, "Mouse", "Enter NHI\r\nMouse Left Click item 'MainWindow.AddingPatient.NHI' at Center.", repo.MainWindow.AddingPatient.NHIInfo, new RecordItemIndex(1));
            repo.MainWindow.AddingPatient.NHI.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NHI'.", new RecordItemIndex(2));
            Keyboard.Press(NHI);
            
            // Enter "Last name"
            Report.Log(ReportLevel.Info, "Mouse", "Enter \"Last name\"\r\nMouse Left Click item 'MainWindow.AddingPatient.LastName' at Center.", repo.MainWindow.AddingPatient.LastNameInfo, new RecordItemIndex(3));
            repo.MainWindow.AddingPatient.LastName.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LastName'.", new RecordItemIndex(4));
            Keyboard.Press(LastName);
            
            // Enter First Name
            Report.Log(ReportLevel.Info, "Mouse", "Enter First Name\r\nMouse Left Click item 'MainWindow.AddingPatient.FirstName' at Center.", repo.MainWindow.AddingPatient.FirstNameInfo, new RecordItemIndex(5));
            repo.MainWindow.AddingPatient.FirstName.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FirstName'.", new RecordItemIndex(6));
            Keyboard.Press(FirstName);
            
            // Enter DOB
            Report.Log(ReportLevel.Info, "Mouse", "Enter DOB\r\nMouse Left Click item 'MainWindow.AddingPatient.DOB' at Center.", repo.MainWindow.AddingPatient.DOBInfo, new RecordItemIndex(7));
            repo.MainWindow.AddingPatient.DOB.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DOB'.", new RecordItemIndex(8));
            Keyboard.Press(DOB);
            
            // Enter Gender
            Report.Log(ReportLevel.Info, "Mouse", "Enter Gender\r\nMouse Left Click item 'MainWindow.AddingPatient.Gender' at Center.", repo.MainWindow.AddingPatient.GenderInfo, new RecordItemIndex(9));
            repo.MainWindow.AddingPatient.Gender.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Gender'.", new RecordItemIndex(10));
            Keyboard.Press(Gender);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(11));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            // Enter ASA
            Report.Log(ReportLevel.Info, "Mouse", "Enter ASA\r\nMouse Left Click item 'MainWindow.AddingPatient.ASA' at Center.", repo.MainWindow.AddingPatient.ASAInfo, new RecordItemIndex(12));
            repo.MainWindow.AddingPatient.ASA.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ASA'.", new RecordItemIndex(13));
            Keyboard.Press(ASA);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(14));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            // Enter Weight
            Report.Log(ReportLevel.Info, "Mouse", "Enter Weight\r\nMouse Left Click item 'MainWindow.AddingPatient.Weight' at Center.", repo.MainWindow.AddingPatient.WeightInfo, new RecordItemIndex(15));
            repo.MainWindow.AddingPatient.Weight.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Weight'.", new RecordItemIndex(16));
            Keyboard.Press(Weight);
            
            // Enter Height
            Report.Log(ReportLevel.Info, "Mouse", "Enter Height\r\nMouse Left Click item 'MainWindow.AddingPatient.Height' at Center.", repo.MainWindow.AddingPatient.HeightInfo, new RecordItemIndex(17));
            repo.MainWindow.AddingPatient.Height.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Height'.", new RecordItemIndex(18));
            Keyboard.Press(Height);
            
            // Enter Ward
            Report.Log(ReportLevel.Info, "Mouse", "Enter Ward\r\nMouse Left Click item 'MainWindow.AddingPatient.Ward' at Center.", repo.MainWindow.AddingPatient.WardInfo, new RecordItemIndex(19));
            repo.MainWindow.AddingPatient.Ward.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Ward'.", new RecordItemIndex(20));
            Keyboard.Press(Ward);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(21));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.AddingPatient.Room' at Center.", repo.MainWindow.AddingPatient.RoomInfo, new RecordItemIndex(22));
            repo.MainWindow.AddingPatient.Room.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Room'.", new RecordItemIndex(23));
            Keyboard.Press(Room);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(24));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
