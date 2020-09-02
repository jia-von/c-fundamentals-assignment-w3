using System;
using System.Collections.Generic;
using System.Text;

namespace C_Fundamentals_Assignment_W3
{
    public class Student : IStudent
    {
        //Property Implementation
        public string[] TestsTaken { get; }
        public string[] Answers { get; set; }
        public ITestpaper Paper { get; set; }

        public void TakeTest(ITestpaper paper, string[] answers)
        {
            Paper = paper;
            Answers = answers;
        }

        public Student()
        {
            TestsTaken = new string[] { };
        }
    }

    public interface IStudent
    {
        string[] TestsTaken { get; } //Ouput the subject taken and the qualifications
        void TakeTest(ITestpaper paper, string[] answers);
    }

}
