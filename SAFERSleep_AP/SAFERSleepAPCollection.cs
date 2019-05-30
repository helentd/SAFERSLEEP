/*
 * Created by Ranorex
 * User: Win7-VM
 * Date: 31/08/2018
 * Time: 3:16 p.m.
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

namespace SAFERSleep_AP
{	
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class SAFERSleepAPCollection
    {    	
    	public static SAFERSleep_AP.SAFERSleep_APRepository repo = SAFERSleep_AP.SAFERSleep_APRepository.Instance;
    	
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void SelectComboboxItems(string strItem, RepoItemInfo Combo_Items)
         {   
        	
          if (Combo_Items.Exists()) {
          	//create a combobox adapter
           ComboBox cbxItems= Combo_Items.CreateAdapter<ComboBox>(true);
            IList<ListItem> lstItems= cbxItems.Items;          	
          	// go through all combobox items to select the answer
          	if (lstItems != null && lstItems.Count> 0) {
            	for (int i = 0; i < lstItems.Count; i++) {
            		if (lstItems[i].Text== strItem) {
           			           			
           				Report.Log(ReportLevel.Info,"CLick on item name: " + strItem );          				
            			
            			lstItems[i].Selected= true;
            			lstItems[i].Click();
            			Delay.Milliseconds(200);
            			break;
            		}
            	}
            }
          } 
        	else
        		Report.Log(ReportLevel.Info,"Combobox is not exist " + strItem );  
            
        }
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void SelectReviewRound(int ReviewRound, RepoItemInfo Combo_Items)
        {   
			 if (Combo_Items.Exists())
			 { 	//create a combobox adapter
	          	 ComboBox cbxItem= Combo_Items.CreateAdapter<ComboBox>(true);
			 
           
	        	if (ReviewRound==0) 
	        	{        	
					Report.Log(ReportLevel.Info,"Select item: " + ReviewRound.ToString());        		
	        		cbxItem.Items[ReviewRound].Click();
	        		Delay.Milliseconds(200); 
	        	}        	
	        	else
	        	{   
	        		Report.Log(ReportLevel.Info,"Select item: " + (ReviewRound-1).ToString());
	        		//repo.MainWindow.PrintingReview.ReviewRound.SelectedItemIndex= NextReviewRound-1;
	        		//Delay.Milliseconds(200);   
	        		
	        		cbxItem.Items[ReviewRound-1].Click();
	        		Delay.Milliseconds(200);     
	        	}
			 }
        }
        
        
        /// <summary>
        /// IF drug is allergy=> CLick on "Acknowledge button and enter reason, click Save".
        /// </summary>
        [UserCodeMethod]
        public static void AcknowledgeAllergy(string ReasonAcknowledge, RepoItemInfo AckButton, RepoItemInfo SaveButton)
        {      
        	if (AckButton.Exists(3000))
        	{ 
        		Report.Log(ReportLevel.Info,"AcknowledgedButton exist");      		        		
        		       			
        			//if the Acknowledge Button displays, click on Acknowledge button
        			Delay.Milliseconds(500);
        			Report.Log(ReportLevel.Info,"Click on AcknowledgedButton");
        			AckButton.FindAdapter<CheckBox>().Click();
        			Delay.Milliseconds(100);
        			
        			// enter reason detail 
        			repo.MainWindow.Modalities.ReasonForAcknowledgeAllergy.Reason.Click();
        			Delay.Milliseconds(100);
        			
        			Report.Log(ReportLevel.Info,"Enter on Acknowledged reason");
        			Keyboard.Press(ReasonAcknowledge);
            		Delay.Milliseconds(100);
            		            		
            		// Click on Save   
            		Delay.Milliseconds(100);
            		Report.Log(ReportLevel.Info, "Click on Save" );
            		SaveButton.FindAdapter<Text>().Click();
            		Delay.Milliseconds(1000);
            }   
			else 
				Report.Log(ReportLevel.Info,"No allergy. AcknowledgedButton does not exist");    				
        }

        
         [UserCodeMethod]
        public static void AcknowledgeAllergyBackup(RepoItemInfo AcknowledgedButtonInfo,Adapter AcknowledgeButton, RepoItemInfo ReasonBox, string ReasonAcknowledge, RepoItemInfo SaveButton)
        {        
        	if (AcknowledgedButtonInfo.Exists(1000))        		
        	{ 
        		Report.Log(ReportLevel.Info,"AcknowledgedButton esixt" + AcknowledgeButton.GetPath().ToString());
        		//CheckBox chkbxItem= AcknowledgedButtonInfo.CreateAdapter<CheckBox>(true);
        		
        		if (AcknowledgeButton.Visible ){
        			//click on Acknowledge button
        			Delay.Milliseconds(200);
        			AcknowledgeButton.Click();
        			Delay.Milliseconds(100);
        			Report.Log(ReportLevel.Info,"Click on AcknowledgedButton");
        			// enter reason detail        			
        			
        			Text txtItem= ReasonBox.CreateAdapter<Text>(true);
        			txtItem.Click();
        			Delay.Milliseconds(100);
        			
        			Keyboard.Press(ReasonAcknowledge);
            		Delay.Milliseconds(100);
            		Report.Log(ReportLevel.Info,"Enter on Acknowledged reason" + txtItem.GetPath().ToString());
            		
            		// Click on Save            		
            		//Text txtItemSave= SaveButton.CreateAdapter<Text>(true);
            		Report.Log(ReportLevel.Info, "Save pathe: " + SaveButton.AbsolutePath.ToString());
            		SaveButton.FindAdapter<Text>().Click();
            		
            		//string xpath=SaveButton.AbsolutePath.ToString();            		
            		
            		
            		//Ranorex.Text txtItemSave =xpath; 
            		//txtItemSave.Click();
            		//repo.MainWindow.Modalities.AllergyChecking.Save.Click();
            		
            		//IList<Ranorex.Text> lstText = Host.Local.Find<Ranorex.Text>(SaveButton.AbsolutePath);
            	    //Text item =  Host.Local.FindSingle(SaveButton.AbsolutePath);
            		//item.Click();
            		//Report.Log(ReportLevel.Info,"CLick Save" + item.GetPath().ToString());
            		
            		//if(lstText != null && lstText.Count>0)
            		//	lstText[0].Click();
            		
            		//Report.Log(ReportLevel.Info,"CLick Save" + lstText[0].GetPath().ToString());
            	  //  Report.Log(ReportLevel.Info,"Number" + lstText.Count.ToString());
            		
            		//txtItemSave.Click();
            		Delay.Milliseconds(1000);
            		Report.Log(ReportLevel.Info,"CLick Save" + SaveButton.FindAdapter<Text>().GetPath().ToString());
            		        			
        		}        	    	
        	    	
            }        	
        }
    }
}
