/*
 * Created by Ranorex
 * User: Admin
 * Date: 20/03/2019
 * Time: 11:04 AM
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

namespace SAFERSleep_AP.Recordings.PatientPainReview
{
    /// <summary>
    /// Description of ValidatedExistingPainReview.
    /// </summary>
    [TestModule("751AC4C2-E53F-44EA-A90E-93D415744D01", ModuleType.UserCode, 1)]
    public class ValidatedExistingPainReview : ITestModule
    {	
    	SAFERSleep_APRepository MyRepo = new SAFERSleep_APRepository();
    	
    	string _ReviewQuestion = "";
    	[TestVariable("f4f7abaf-6db2-4e97-a227-7cecfd4973ce")]
    	public string ReviewQuestion
    	{
    		get { return _ReviewQuestion; }
    		set { _ReviewQuestion = value; }
    	}
    	
    	string _ReviewAnswer = "";
    	[TestVariable("1be64c5d-2772-4f47-8950-b67b7ae8554c")]
    	public string ReviewAnswer
    	{
    		get { return _ReviewAnswer; }
    		set { _ReviewAnswer = value; }
    	}
    	
    	string _IsAnswered = "";
    	[TestVariable("fc052cf6-1dbb-4fae-8407-6122692fa6ef")]
    	public string IsAnswered
    	{
    		get { return _IsAnswered; }
    		set { _IsAnswered = value; }
    	}
    	
    	string _QuestionType = "";
    	[TestVariable("39f85004-46b5-4b49-b405-e3315a565c0e")]
    	public string QuestionType
    	{
    		get { return _QuestionType; }
    		set { _QuestionType = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidatedExistingPainReview()
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
            
            if (IsAnswered == "Yes")
            {
            	string ActualReviewAnswer;
            	Ranorex.Report.Info("Validate existing Review Question and Answer = "+ReviewQuestion+" "+ReviewAnswer);
			    MyRepo.ReviewQuestion = ReviewQuestion;
		    	if (QuestionType == "Option")
	            {		       
			        ActualReviewAnswer = MyRepo.MainWindow.PatientPainReview.PainReviewAnswer_SelectOption.Element.GetAttributeValueText("Text");
			        Validate.AreEqual(ActualReviewAnswer, ReviewAnswer);
	            }
	            else if (QuestionType == "YesNo")
	            {
	            	ActualReviewAnswer = MyRepo.MainWindow.PatientPainReview.PainReviewAnswer_YesNo.Element.GetAttributeValueText("Checked");
	            	Validate.AreEqual(ActualReviewAnswer, "True");
	            }
            }
        }
    }
}
