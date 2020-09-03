using System;
using System.Collections.Generic;
using System.Text;

namespace C_Fundamentals_Assignment_W3
{
    public class Student : IStudent
    {
        //Property Implementation
        public string[] TestsTaken { get; }

        int index = 0; //declare initial index for TestsTaken array based instead of Lists
        public void TakeTest(ITestpaper paper, string[] answers)
        {
            decimal matches = 0; // calculate the number of matches between answers and paper.MarkScheme

            for (int i = 0; i<paper.MarkScheme.Length; i++)//start of comparison of the answer
            {
                bool temp = Array.Equals(answers[i], paper.MarkScheme[i]);

                if (temp == true)
                {
                    matches++;
                }
            }//end of the comparison of answers

            //Calculate the percentage of the paper
            decimal resultPercentage = matches/paper.MarkScheme.Length;
            decimal finalResult = Math.Round(resultPercentage * 100);

            //Validation for pass and fail
            if (finalResult>decimal.Parse(paper.PassMark.Remove(2)))
            {   
                //push the result into TestsTaken Array
                TestsTaken[index] =  $"{paper.Subject}: Pass! ({finalResult}%)";
                index++;
            }
            else
            {
                TestsTaken[index] = $"{paper.Subject}: Fail! ({finalResult}%)";
                index++;
            }
        }// end of the method


        public Student()
        {
            TestsTaken = new string[20];
            TestsTaken[0] = "No tests taken";
        }
    }

    public interface IStudent
    {
        string[] TestsTaken { get; } //Ouput the subject taken and the qualifications
        void TakeTest(ITestpaper paper, string[] answers);
    }

}
