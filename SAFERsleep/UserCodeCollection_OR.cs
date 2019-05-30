/*
 * Created by Ranorex
 * User: Admin
 * Date: 16/10/2018
 * Time: 2:11 PM
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace SAFERsleep
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class UserCodeCollection_OR
    {
    	public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        /// <summary>
        /// This method will clear the values currently in the text box
        /// itemInfo element type can be: Text, Combobox
        /// </summary>
        [UserCodeMethod]
        public static void Clear_TextBox(RepoItemInfo itemInfo, string elementType)
        {           	
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'itemInfo' at Center.", itemInfo);
        	if (elementType == "Text")
            	itemInfo.FindAdapter<Text>().Click();
        	else if (elementType == "Combobox")
        		itemInfo.FindAdapter<ComboBox>().Click();
        	else
        		Ranorex.Report.Info("Element Type incorrect");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Home' Press.");
            Keyboard.Press(System.Windows.Forms.Keys.Home, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Shift+End' Press.");
            Keyboard.Press(System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Shift, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Back' Press.");
            Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(200);
        }
        
        
        /// <summary>
        /// This method will enter today's date on the text box with the format you specify
        /// </summary>
        [UserCodeMethod]
        public static void EnterDate_Today(RepoItemInfo itemInfo, string dateFormat)
        {
        	itemInfo.FindAdapter<Text>().Click();
        	Delay.Milliseconds(200);
        	
        	Ranorex.Report.Info("Enter Today's Date with format: "+dateFormat);
        	String TDate = System.DateTime.Now.ToString(dateFormat);
        	Keyboard.Press(TDate);
            Delay.Milliseconds(200);
        }
        
        
        /// <summary>
        /// This method will process the expected allergy warning message. Output in string
        /// </summary>
        [UserCodeMethod]
        public string WarningAlertMessage(string AlertName, string AlertType, string AlertClass, string DrugClass)
        {
        	// Check warning message
        	string WarningText="Warning: ";
            if (AlertClass=="Drug")
            {  // if AlertName is a drug 
        		WarningText= WarningText + AlertType + " to " + AlertName;
            	
            }
            else if (AlertClass=="Class")
            { 	 // if AlertName is a class
            	if (DrugClass=="Drug") 
            		WarningText= WarningText + "Query Drug Class " + AlertType + " to " + AlertName; // if add a Drug
            	else
            		WarningText= WarningText + "Drug Class " + AlertType + " to " + AlertName; // if add a class
            	
            }
            else if (AlertClass=="Condition") {
            	 // if AlertName is a medical/condition
            	WarningText= WarningText + "Contraindication " + "to " + AlertName;
            	
            }
            
            return WarningText;
        }
        
        /// <summary>
        /// If a number is >=1000. It is displayed as 1,000 in some OR modules. 
		///  This method to add a "," in this number    
        /// </summary>
        [UserCodeMethod]
        public static void ConvertNumberToString(string strValue)
        {
        	if (strValue.Contains(".")== false && strValue.Length>3)
        	{
        		
		        // string strNewValue = string.Format("{0:n0}",strValue);
		       string strNewValue =  strValue.Insert( strValue.Length - 3, ",");
        	
        	}
        	
        }
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static IList<Cell> GetLastRowOfTable(string xPath)
        {    
			IList<Cell> lstCell= null;    	
        	// create a table from path
            Ranorex.Table tblFluid= xPath;
            if (tblFluid !=null) {
            	// get the last row of the table
	            Ranorex.Row lastRow = tblFluid.Rows[tblFluid.Rows.Count-1];
	           // get list cells of last row
	             lstCell=  lastRow.Cells; 
            }  
            return lstCell;
        }
    }
}
