﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C_Fundamentals_Assignment_W3
{
    public class Student : IStudent
    {
        //Property Implementation
        private string[] _testsTaken;
        public string[] TestsTaken {
            get
            { 
                return _testsTaken;
            } 
            protected set
            {
                if (value.Length == 0)
                {
                    _testsTaken = new string[] { "No tests taken" };
                }
                else
                {
                    _testsTaken = value;
                }
            }
        }
        //public string[] Answers { get; set; }
        //public ITestpaper Paper { get; set; }

        //public void TakeTest(ITestpaper paper, string[] answers)
        //{
        //    Paper = paper;
        //    Answers = answers;
        //}

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
                TestsTaken = new string[] { $"{paper.Subject}: Pass! ({finalResult}%)" };
            }
            else
            {
                TestsTaken = new string[] { $"{paper.Subject}: Fail! ({finalResult}%)" };
            }


        }
        public Student()
        {
            TestsTaken = new string[]{};
        }
    }

    public interface IStudent
    {
        string[] TestsTaken { get; } //Ouput the subject taken and the qualifications
        void TakeTest(ITestpaper paper, string[] answers);
    }

}
