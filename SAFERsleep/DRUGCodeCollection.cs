/*
 * Created by Ranorex
 * User: Win7-VM
 * Date: 6/12/2018
 * Time: 11:49 a.m.
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

namespace SAFERsleep
{
	    /// <summary>
    /// This is collection is used to publish user code methods to the user code library. USe for Drug module
    /// </summary>
    [UserCodeCollection]
    public class DRUGCodeCollection
    {
    	 public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        /// <summary>
        /// Select Drug mode ( Bolus/Infusion) when Add Dug
        /// </summary>
        [UserCodeMethod]
        public static void SelectMode(string Mode)
        {
        	Ranorex.Report.Info("Select Drug Mode");
        	
        	if (Mode == "Bolus")
        	{
        		repo.FrmEditDrug.Bolus.Click();
        	}
        	else if (Mode == "Infusion")
        	{
        		repo.FrmEditDrug.Infusion.Click();
        	}
        	else if (Mode == "InfusionPurge")
        	{
        		// if mode is Purge=> Click on Infusion then click on Purge
        		repo.FrmEditDrug.Infusion.Click();
        		repo.FrmEditDrug.Purge.Click();
        		
        	}
        	
        	Delay.Milliseconds(200);
        }
        
        /// <summary>
        /// Enter Dose/Rate when add drug
        /// </summary>
        [UserCodeMethod]
        public static void EnterDosage(string Mode, string Dosage)
        {
        	Ranorex.Report.Info("Enter Dosage");
        	
        	if (Mode == "Bolus")
        	{
        		repo.FrmEditDrug.BolusDose.Click();
        		Keyboard.Press(Dosage);
        	}
        	else if (Mode == "Infusion")
        	{
        		repo.FrmEditDrug.InfusionRate.Click();
        		Keyboard.Press(Dosage);
        	}
        	else if (Mode=="DefaultScript_Bolus" || Mode=="DefaultScript_Infusion")
        	{// If Mode is  DefaultScript, no need to input Dose/Rate
        		Ranorex.Report.Info("Dose/Rate is selected as Default script");
        	}
        	else if (Mode=="InfusionPurge")
        	{ // If Mode is  DefaultScript, no need to input Rate
        		Ranorex.Report.Info("No Rate input as Mode is purge");
        	}
        	
        	Delay.Milliseconds(200);
        	Keyboard.Press("{Tab}");
        	Delay.Milliseconds(200);
        }
        
        /// <summary>
        /// Enter Unit
        /// </summary>
        [UserCodeMethod]
        public static void EnterUnit(string Mode, string Unit)
        {   
			Ranorex.Report.Info("Select Unit");
        	
            if (Mode == "Bolus")        	
            {	
            	repo.FrmEditDrug.UnitBolus.Click();
				Delay.Milliseconds(200);
				
				// delete the current value	        	
	        	Keyboard.Press("{Home}");
				Delay.Milliseconds(200);
				Keyboard.Press(System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Shift, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
				Delay.Milliseconds(200);
				Keyboard.Press("{Back}");
	        	Delay.Milliseconds(200);
	        	// enter the value
	        	Keyboard.Press(Unit);
	        	Delay.Milliseconds(200);
	        	
	        	// press "Enter" to add the current value         	
        		Keyboard.Press("{Enter}");
        		Delay.Milliseconds(200); 
            	
            }
        	else if (Mode == "Infusion")        	
        	{	      		
        		repo.FrmEditDrug.UnitInfusion.Click();
				Delay.Milliseconds(200);
				// press "Backspace" to delete the current value
				Keyboard.Press("{Home}");
				Delay.Milliseconds(200);
				Keyboard.Press(System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Shift, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
				Delay.Milliseconds(200);
				Keyboard.Press("{Back}");
	        	Delay.Milliseconds(200);
	        	
	        	// enter the value
	        	Keyboard.Press(Unit);
	        	Delay.Milliseconds(200);
	        	
	        	// press "Enter" to add the current value
	        	Keyboard.Press("{Enter}");
				Delay.Milliseconds(200);   		
        	}  
			else if (Mode=="InfusionPurge" || Mode=="DefaultScript_Bolus" || Mode=="DefaultScript_Infusion") 
			{ // If Mode is  InfusionPurge/Default script, no need to input unit
        		Ranorex.Report.Info("No Unit inut as Mode is InfusionPurge/Default script");
        	}        	
        	
        }
   
        
        /// <summary>
        /// Enter Route
        /// </summary>
        [UserCodeMethod]
        public static void EnterRoute(string Route)
        {
        	Ranorex.Report.Info("Select Route");
        	
        	repo.FrmEditDrug.Route.DoubleClick();             	
            // press "Backspace" to delete the current value
        	Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
        	
        	// enter the value
        	Keyboard.Press(Route);
        	
        	// press "Enter" to add the current value
        	Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
        	
        	Delay.Milliseconds(200);
        }

        
        /// <summary>
        /// ReaonForNotAdminisDrug.
        /// </summary>
        [UserCodeMethod]
        public static void ReaonForNotAdminisDrug(string reasonNotAdmininis, string NotAdminisComment)
        {
        	Ranorex.Report.Info("Select a reason: " +reasonNotAdmininis);
        	// 1. Click on reason radio button
         switch (reasonNotAdmininis)
         {
         	case "Inadvertent double scan" :
        			repo.ReasonDrugNotAdministered.InadvertentDoubleScan.Click();
         		break;
         	case "Near miss" :
        			repo.ReasonDrugNotAdministered.NearMiss.Click();
         		break;
         	case "Drug Allergy or CI" :
        			repo.ReasonDrugNotAdministered.DrugAllergyOrCI.Click();
         		break;
         	case "Decision changed" :
        			repo.ReasonDrugNotAdministered.DecisionChanged.Click();
         		break;
         	case "Clinical condition changed" :
        			repo.ReasonDrugNotAdministered.ClinicalConditionChanged.Click();
         		break;
         	case "Other" :
        			repo.ReasonDrugNotAdministered.OtherReason.Click();
         		break;       		
         		
         	default:
         		Ranorex.Report.Info("Reason is invalid");
         		break;        	
       
         }
        	// 2. Enter comment
        	
        	// clear old comment first
         		UserCodeCollection_OR.Clear_TextBox(repo.ReasonDrugNotAdministered.NotAdminisCommentInfo, "Text");
                Delay.Milliseconds(0);
                
            // Enter comment whenever user inpu comment
         	if(NotAdminisComment!= "")
         	{
         		Ranorex.Report.Info("Enter comment: " + NotAdminisComment );
         		repo.ReasonDrugNotAdministered.NotAdminisComment.Click();
                
                // enter comment
         		Keyboard.Press(NotAdminisComment);        		
         		
         	}         	
              
			// 3. Click OK
				Ranorex.Report.Info("Click OK");
				repo.ReasonDrugNotAdministered.ButtonOK.Click();         	
                
         	// check error message shows when user not enter comment for other reason 
         	if (reasonNotAdmininis=="Other" && NotAdminisComment=="") 
         	{         		
         		Validate.Exists(repo.Error.EnterTheNotAdministeredCommentInfo);
         		repo.Error.ButtonOK.Click();
         		// enter a space to pypass the error if User not provide comment for OtherReason
         		string tempComment="temp";
         		repo.ReasonDrugNotAdministered.NotAdminisComment.Click();         		
         		Keyboard.Press(tempComment);  
         		repo.NotAdminisComment=tempComment;
         		repo.ReasonDrugNotAdministered.ButtonOK.Click(); 
         	}          		
			
        }
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void ValidateNotAdminisDrugItem(string ReasonNotAdminis, string NotAdminisComment)
        {
        	// combine the NotAdminisReason and NotAdminisComment
        	if (NotAdminisComment!="") {
        		repo.NotAd_ReasonComment= "NA: " + ReasonNotAdminis + " - " + NotAdminisComment;
        	}
        	else
        		{
        		repo.NotAd_ReasonComment= "NA: " + ReasonNotAdminis;
        	}
        	// check NotAdminisDrugItem exist
        	Ranorex.Report.Info("Check NotAdministered Drug item exist on the list after view all not Adminis drug");
        	Validate.Exists(repo.FrmORMain.Drugs.NotAdminisDrugItemInfo);
        	Delay.Milliseconds(100);
            
        }
        
        /// <summary>
        /// Validate the  Drug is added/edited succesfully- Exist in the Drug list
        /// </summary>
        [UserCodeMethod]
        public static void CheckDrugListItem( string Mode)
        {
        	Report.Log(ReportLevel.Info,"Validate the  Drug is exist in the Drug list");
            if (Mode == "Bolus" || Mode == "Infusion")        	
           {	            	  
            	Validate.Exists(repo.FrmORMain.Drugs.Drugs.DrugListItemDetailInfo);
	            Delay.Milliseconds(0);            	
        		
           }
           else if (Mode == "InfusionPurge")        	
           {	// If Drug is added as Purge, the dosesage will be Purge int the drug list
           		repo.DoseUnit="Purge";
             	//Report.Log(ReportLevel.Info,"Mode is InfusionPurge: " + DoseUnit);
	        	Validate.Exists(repo.FrmORMain.Drugs.Drugs.DrugListItemDetailInfo);
	            Delay.Milliseconds(0);       		
	        		 
           }
        }  
        
    }
}
