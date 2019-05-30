/*
 * Created by Ranorex
 * User: Admin
 * Date: 18/07/2018
 * Time: 9:58 AM
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
    /// Description of ValidateRegionalBlockList.
    /// </summary>
    [TestModule("FA7B193B-BD41-45DB-A71E-534A523D1E20", ModuleType.UserCode, 1)]
    public class ValidateRegionalBlockList : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERsleepORRepository MyRepo = SAFERsleepORRepository.Instance;
    	  	
    	string _Block = "Epidural";
    	[TestVariable("9cc7179f-ed5e-456a-b5ab-6a19f429c0ee")]
    	public string Block
    	{
    		get { return _Block; }
    		set { _Block = value; }
    	}
       
    	string _BlockSite = "Cervical";
    	[TestVariable("b5569d93-dc0b-42e1-bb83-ef5c72f21c21")]
    	public string BlockSite
    	{
    		get { return _BlockSite; }
    		set { _BlockSite = value; }
    	}
    	
    	string _Level = "1-2";
    	[TestVariable("6e58e31f-b0c4-4ebb-8447-24cf3b75d4d8")]
    	public string Level
    	{
    		get { return _Level; }
    		set { _Level = value; }
    	}   	
    	
    	string _Side = "Left";
    	[TestVariable("ba681c10-d2f8-4ac8-b115-bd6afa217ad3")]
    	public string Side
    	{
    		get { return _Side; }
    		set { _Side = value; }
    	}
    	
    	string _IsNeuroaxialBlock = "Yes";
    	[TestVariable("7347a0ff-4c79-4aee-b5fe-afc0da09eb4f")]
    	public string IsNeuroaxialBlock
    	{
    		get { return _IsNeuroaxialBlock; }
    		set { _IsNeuroaxialBlock = value; }
    	}
    	
    		   	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateRegionalBlockList()
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
            
            //string RegionalBlockList = MyRepo.FrmORMain.RegionalBlock.RegionalBlockListItemInfo.Name.ToString();
            //Validate.AttributeRegex(MyRepo.FrmORMain.RegionalBlock.RegionalBlockListItemInfo, "Text", new Regex("^Epidural\\ Cervical\\ 1-2"));
            if (IsNeuroaxialBlock == "Yes")
            {
            	MyRepo.Regional_Block_List = "^"+Block+"\\ "+BlockSite+"\\ "+Level;
            	Validate.Exists(MyRepo.FrmORMain.RegionalBlock.RegionalBlockListItem);
            }
            else
            {
            	MyRepo.Regional_Block_List = "^"+Block+"\\ "+BlockSite+"\\ "+Side;
            	Validate.Exists(MyRepo.FrmORMain.RegionalBlock.RegionalBlockListItem);
            }
        }
    }
}
