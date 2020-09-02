using System;
using System.Collections.Generic;
using System.Text;

namespace C_Fundamentals_Assignment_W3
{
    public class Student : IStudent
    {
        public void TakeTest(ITestpaper paper, string[] answers)
        {
            IStudent.TestTaken = answers;
        }
    }

    public interface IStudent
    {
        string[] TestsTaken { get; }
        void TakeTest(ITestpaper paper, string[] answers);
    }

}
