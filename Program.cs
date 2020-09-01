using System;

namespace C_Fundamentals_Assignment_W3
{
    class Program

    {
        static void Main(string[] args)
        {

            //Exercise 2: Insert the missing parts to call MyMethod two times.
            MyMethod();
            MyMethod();

        }

        static void MyMethod() 
        {
          Console.WriteLine("I just got executed!");
        }
}
}
