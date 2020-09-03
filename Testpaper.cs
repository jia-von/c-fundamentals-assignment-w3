using System;
using System.Collections.Generic;
using System.Text;

namespace C_Fundamentals_Assignment_W3
{
    public class Testpaper : ITestpaper
    {
        //Property Implementation: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface
        public string Subject { get; }
        public string[] MarkScheme { get; }
        public string PassMark { get; }

        public Testpaper(string subject, string[] markScheme, string passMark)
        {
            Subject = subject;
            MarkScheme = markScheme;
            PassMark = passMark.Trim();
        }
        
    }

    public interface ITestpaper
    {
        string Subject { get; }
        string[] MarkScheme { get; }
        string PassMark { get; }
    }
}
