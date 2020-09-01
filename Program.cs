using System;

namespace C_Fundamentals_Assignment_W3
{
    class Program

    {
        static void Main(string[] args)
        {

            //Exercise 2: Fill in the missing parts to print a number put in by the user:
            Console.WriteLine("Think of a number:");
            int myNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is: " + myNum);
        }
    }
}
