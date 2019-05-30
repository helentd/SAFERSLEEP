/*
 * Created by Ranorex
 * User: Admin
 * Date: 1/14/2019
 * Time: 10:58 AM
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
using Ranorex.Core.Repository;

namespace SAFERsleep
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class MedicalAlertAllergyCollection
    {
    	 public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void CheckButtonIsPress(RepoItemInfo itemInfo, string ButtonStatus)
        {
        	Report.Log(ReportLevel.Info, "Check Button is Press or not");
        
        	if (ButtonStatus == "Pressed")
        		Validate.Attribute(	itemInfo,"Pressed","True");
        	
        	else if (ButtonStatus == "NotPressed" )
        		Validate.Attribute(	itemInfo,"Pressed","False");
        	
        	if (ButtonStatus == "Hidden")
        		Validate.Attribute(	itemInfo,"Visible","False");
        	
        	else if (ButtonStatus == "NotHidden" )
        		Validate.Attribute(	itemInfo,"Visible","True");
        	
        	// if isPress is empty=> no need to do anything
        }
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void CheckDupplicateDrugLCassConditionName( string typeDuplicate)
        {
        	if (typeDuplicate=="Drug")    
        		Validate.Exists(repo.Error.SameDrugNameErrorInfo); 
        	else if (typeDuplicate=="Class") 
        			Validate.Exists(repo.Error.SameClassNameErrorInfo);  
				else if (typeDuplicate=="Condition") 
        			Validate.Exists(repo.Error.SameMedicalAlertErrorInfo); 	
					else if (typeDuplicate=="ConditionDelete") 
        			Validate.Exists(repo.Error.SameMedicalAlertErrorInfo);
					else if (typeDuplicate=="AllergyDelete") 
        			Validate.Exists(repo.Error.SameMedicalAlertErrorInfo); 							
        }
    }
}
