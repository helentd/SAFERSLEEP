/*
 * Created by Ranorex
 * User: Win7-VM
 * Date: 26/07/2018
 * Time: 9:04 a.m.
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
    /// Description of ValidateBlocInDetail.
    /// </summary>
    [TestModule("528D32E6-30E7-426F-B793-8080BCE24EA3", ModuleType.UserCode, 1)]
    public class ValidateBlockInDetail : ITestModule
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
    	
    	string _Position = "Sitting";
    	[TestVariable("673e458d-8dad-44c9-bcff-676705a79e52")]
    	public string Position
    	{
    		get { return _Position; }
    		set { _Position = value; }
    	}
    	
    	string _valNeedle1 = "Tuohy";
    	[TestVariable("ce02b82c-dd65-47c4-af30-213eb8b4a787")]
    	public string valNeedle1
    	{
    		get { return _valNeedle1; }
    		set { _valNeedle1 = value; }
    	}
    	
    	string _valNeedle2 = "Sharp";
    	[TestVariable("21d0c82f-e80c-45c8-8ce1-51d07d3cdfbb")]
    	public string valNeedle2
    	{
    		get { return _valNeedle2; }
    		set { _valNeedle2 = value; }
    	}
    	
    	string _valSize1 = "16";
    	[TestVariable("977bd143-5a6c-4535-844b-7bddcaead1c3")]
    	public string valSize1
    	{
    		get { return _valSize1; }
    		set { _valSize1 = value; }
    	}
    	
    	
    	string _valSize2 = "20";
    	[TestVariable("32a3f1f5-fbee-4f3a-b705-e8ca33600b16")]
    	public string valSize2
    	{
    		get { return _valSize2; }
    		set { _valSize2 = value; }
    	}
    	
    	string _varCatheInsertLength = "7";
    	[TestVariable("fdcdc894-8812-4cae-975d-a0fc413fac40")]
    	public string varCatheInsertLength
    	{
    		get { return _varCatheInsertLength; }
    		set { _varCatheInsertLength = value; }
    	}
    	
    	
    	string _valInsertDepth1 = "5";
    	[TestVariable("7ff2be29-3fda-4fa0-b605-07f191b600cc")]
    	public string valInsertDepth1
    	{
    		get { return _valInsertDepth1; }
    		set { _valInsertDepth1 = value; }
    	}
    	
    	string _valInsertDepth2 = "10";
    	[TestVariable("46ae59b0-7163-4806-84a6-8d7f0dcd9222")]
    	public string valInsertDepth2
    	{
    		get { return _valInsertDepth2; }
    		set { _valInsertDepth2 = value; }
    	}
    	
    	string _valTechnique = "Awake";
    	[TestVariable("b30e4357-5760-49bd-b888-a705c53d99ec")]
    	public string valTechnique
    	{
    		get { return _valTechnique; }
    		set { _valTechnique = value; }
    	}
    	
    	string _valNumAttemp = "1";
    	[TestVariable("3dc98299-a5b9-4813-81c5-4f848c2cc949")]
    	public string valNumAttemp
    	{
    		get { return _valNumAttemp; }
    		set { _valNumAttemp = value; }
    	}
    	
    	string _valTechComent = "This is a Technique comment";
    	[TestVariable("27098786-6d21-4e2d-a9d2-da95512c03e0")]
    	public string valTechComent
    	{
    		get { return _valTechComent; }
    		set { _valTechComent = value; }
    	}
    	
    	string _valComplication = "Paraesthesia";
    	[TestVariable("3575f0b1-f29b-403e-864b-22e955fec05d")]
    	public string valComplication
    	{
    		get { return _valComplication; }
    		set { _valComplication = value; }
    	}
    	string _valCompliComment = "This is complication comment";
    	[TestVariable("caadf76e-9672-42b0-8d73-1311247e323d")]
    	public string valCompliComment
    	{
    		 	get { return _valCompliComment; }
    		   set { _valCompliComment = value; }
        }
    	
    	string _valDrugName = "Bupivacaine Plain 0.25%";
    	[TestVariable("974c8cf6-ae24-420a-b911-a7d1dc1abd08")]
    	public string valDrugName
    	{
    		get { return _valDrugName; }
    		set { _valDrugName = value; }
    	}
    	
    	
    	string _valDrugDose = "100";
    	[TestVariable("57b75c23-0b17-411a-b5fb-0f07b9227a45")]
    	public string valDrugDose
    	{
    		get { return _valDrugDose; }
    		set { _valDrugDose = value; }
    	}
    	
    	string _valDrugUnit = "mg";
    	[TestVariable("68b28b22-e661-4416-86d9-4ab32ef05684")]
    	public string valDrugUnit
    	{
    		get { return _valDrugUnit; }
    		set { _valDrugUnit = value; }
    	}
    	
    	string _varDrugComment = "Bolus drug test";
    	[TestVariable("19f11c3d-1b94-455a-9ea0-6f45a85a521e")]
    	public string varDrugComment
    	{
    		get { return _varDrugComment; }
    		set { _varDrugComment = value; }
    	}   
    	
    	string _varDrugTime = "10:00";
    	[TestVariable("5f111d3e-5582-49e7-8cd2-074ec1eae305")]
    	public string varDrugTime
    	{
    		get { return _varDrugTime; }
    		set { _varDrugTime = value; }
    	}
    	
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateBlockInDetail()
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
            
            // my code here
            
            // Select Side or level 
             var LevelSite= Level;            	
                        
            if (IsNeuroaxialBlock != "Yes")           
            	LevelSite=Side;
            
            // Get Time when the drug is added
                Report.Log(ReportLevel.Info, "Drug Time:", varDrugTime);
                //System.DateTime varTime =  System.DateTime.ParseExact(varDrugTime, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                                            
                /*var varFormat= "p.m";
                if( Int32.Parse(varDrugTime.Substring(0,2)) <12)
                	varFormat= "a.m";*/
              // create all detail of  the added drug 
                 string addedlBlock =Block+" "+BlockSite+" "+ LevelSite + "Patient Position: " + Position                     //   Block name, site, position
            					+ valNeedle1 + " Needle  "+ _valSize1+ "g" + ", Needle Inserted " + valInsertDepth1 + " cm"    // Needle 1
            					+ " Catheter Inserted  " + varCatheInsertLength + " cm"                                         // Catheter Insert
            	                + valNeedle2 + " Needle  "+ _valSize2+ "g" + ", Needle Inserted " + valInsertDepth2 + " cm"       // Needle 2
								+ valTechnique + "Number of attempts:   "+ valNumAttemp + valTechComent           	             //Technique
            	                + valComplication + valCompliComment                                                              // Complication
                 	            //+ varTime.ToString("h:mm") + " " + varFormat + ". " 
                 				+ varDrugTime + " " + valDrugName +  " " + valDrugDose + " "+ valDrugUnit + " "  + varDrugComment; // Drug
              // verify all inforamtion is correct  
                MyRepo.Regional_Block_List = addedlBlock;
            	Validate.Exists(MyRepo.FrmORMain.RegionalBlock.RegionalBlockListItem);   
        }
    }
}
