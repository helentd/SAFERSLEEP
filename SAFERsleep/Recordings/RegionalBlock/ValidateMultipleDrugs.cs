/*
 * Created by Ranorex
 * User: Admin
 * Date: 3/12/2018
 * Time: 9:35 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace SAFERsleep.Recordings.RegionalBlock
{
    /// <summary>
    /// Description of ValidateMultipleDrugs.
    /// </summary>
    [TestModule("31CCA0D6-D086-4A86-8802-5AFB3BD10FFA", ModuleType.UserCode, 1)]
    public class ValidateMultipleDrugs : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;	
    	
    	string _Block = "";
    	[TestVariable("0ecb0e41-a282-4b2b-a042-21d609bb9f71")]
    	public string Block
    	{
    		get { return _Block; }
    		set { _Block = value; }
    	}	
    	
    	string _Block_DrugName = "";
    	[TestVariable("cc9fc461-d3b7-4028-8c51-d64840bd548f")]
    	public string Block_DrugName
    	{
    		get { return _Block_DrugName; }
    		set { _Block_DrugName = value; }
    	}
    	
    	string _Block_Dosage = "";
    	[TestVariable("0a4daf2d-06b9-4c51-9802-8b9a84a1366b")]
    	public string Block_Dosage
    	{
    		get { return _Block_Dosage; }
    		set { _Block_Dosage = value; }
    	}
    	
    	string _Block_Unit = "";
    	[TestVariable("6a8b2b83-a20e-4b0d-8192-344a13270943")]
    	public string Block_Unit
    	{
    		get { return _Block_Unit; }
    		set { _Block_Unit = value; }
    	}
    	
    	string _Block_Comment = "";
    	[TestVariable("81283d13-d14d-4255-9339-bb7ba156fd4b")]
    	public string Block_Comment
    	{
    		get { return _Block_Comment; }
    		set { _Block_Comment = value; }
    	}
    	
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateMultipleDrugs()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            string Drug = Block_DrugName+" "+Block_Dosage+" "+Block_Unit+" "+Block_Comment;
            
            MyRepo.Regional_Block_List = "^"+Block;
            MyRepo.Regional_Block_Detail = Drug;
            Validate.Exists(MyRepo.FrmORMain.RegionalBlock.RegionalBlockListItem);
            MyRepo.Regional_Block_Detail = "";
        }
    }
}
