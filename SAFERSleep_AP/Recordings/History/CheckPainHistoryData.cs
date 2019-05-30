/*
 * Created by Ranorex
 * User: Admin
 * Date: 7/03/2019
 * Time: 3:40 PM
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

namespace SAFERSleep_AP.Recordings.History
{
    /// <summary>
    /// Description of CheckDataValues.
    /// </summary>
    [TestModule("442CFC56-9B51-4C4B-B5F1-F462B0FA9664", ModuleType.UserCode, 1)]
    public class CheckPainHistoryData : ITestModule
    {
    	// Repository object to access UI Elements
    	SAFERSleep_APRepository MyRepo = SAFERSleep_APRepository.Instance;
    	
    	string _ReviewDate = "Today"; //or set exact date e.g. 07 Mar 2019
    	[TestVariable("baacf860-4798-4703-a17a-b2b7f8685e39")]
    	public string ReviewDate
    	{
    		get { return _ReviewDate; }
    		set { _ReviewDate = value; }
    	}  	
    	
    	string _TeamMember = "";
    	[TestVariable("5fef000a-6afe-4309-9ca2-015a17e235f2")]
    	public string TeamMember
    	{
    		get { return _TeamMember; }
    		set { _TeamMember = value; }
    	}
   		
   		string _TeamMember2 = "";
   		[TestVariable("a27db3ec-718f-449b-8764-b4f8dce0289a")]
   		public string TeamMember2
   		{
   			get { return _TeamMember2; }
   			set { _TeamMember2 = value; }
   		}
   		
    	string _ReviewQuestion = "";
    	[TestVariable("e3d38c4b-2400-4099-a657-a349caa3c2bb")]
    	public string ReviewQuestion
    	{
    		get { return _ReviewQuestion; }
    		set { _ReviewQuestion = value; }
    	}
    	
    	string _IsAnswered = "Yes";
    	[TestVariable("265db359-f753-45ca-81f4-b462aace5a08")]
    	public string IsAnswered
    	{
    		get { return _IsAnswered; }
    		set { _IsAnswered = value; }
    	}
    	
    	string _ReviewAnswer = "";
    	[TestVariable("454b2641-cfff-40a1-b694-5331a72cb517")]
    	public string ReviewAnswer
    	{
    		get { return _ReviewAnswer; }
    		set { _ReviewAnswer = value; }
    	}
    	
    	string _PainTrendIndex = "";
    	[TestVariable("2ae2ba0d-5137-4b16-ab80-27e8119403ba")]
    	public string PainTrendIndex
    	{
    		get { return _PainTrendIndex; }
    		set { _PainTrendIndex = value; }
    	}

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckPainHistoryData()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Check Data Values for each Pain Review Questions on a given date
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            //Will set which Pain Trend Data Column to be checked
            //Limitation: Not working if there are multiple columns on the same date
            Ranorex.Report.Info("Checking the Pain Trend from the specified date: "+ReviewDate);
            if (ReviewDate == "Today" || ReviewDate == "")
            	MyRepo.PainTrendDate = System.DateTime.Now.ToString("dd MMM yyy");
            else
            	MyRepo.PainTrendDate = ReviewDate;
            
            Ranorex.Report.Info("Validate Pain Review Questionaire Data History for: "+ReviewQuestion);
        	if (IsAnswered == "Yes")
        	{
        		MyRepo.PainTrendIndex = PainTrendIndex;
        		MyRepo.ReviewAnswer = ReviewAnswer;
        		Validate.Exists(MyRepo.MainWindow.PainTrend.PainTrendColumn.ReviewHistoryDataInfo);
        	}
        	
        	if (PainTrendIndex == "16") // Will run this method after Audit Completed is checked
            {
            	Ranorex.Report.Info("Validate Updated By: "+TeamMember);
            	MyRepo.TeamMember = TeamMember;
            	Validate.Exists(MyRepo.MainWindow.PainTrend.PainTrendColumn.UpdatedByInfo);
            	if (TeamMember2 != "")
            	{
            		Ranorex.Report.Info("Validate Updated By: "+TeamMember2);
            		MyRepo.TeamMember = TeamMember2;
            		Validate.Exists(MyRepo.MainWindow.PainTrend.PainTrendColumn.UpdatedByInfo);
            	}            	        	
            }
        }
    }
}
