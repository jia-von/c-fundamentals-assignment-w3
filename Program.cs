using System;

namespace C_Fundamentals_Assignment_W3
{
    class Program

    {
        static void Main(string[] args)
        {

            //Exercise 3: Add a fname parameter of type string to MyMethod.
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");

        }

        static void MyMethod(string fname) 
        {
            Console.WriteLine(fname + " Refsnes");
        }
}
}
