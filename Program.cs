using System;

namespace C_Fundamentals_Assignment_W3
{
    class Program

    {
        static void Main(string[] args)
        {
            Testpaper paper1 = new Testpaper("Maths", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%");


            Student student1 = new Student();
            student1.TakeTest(paper1, new string[] { "1A", "2D", "3D", "4A", "5A" });
        }

	}
}
