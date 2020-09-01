using System;

namespace C_Fundamentals_Assignment_W3
{
    class Program

    {
        static void Main(string[] args)
        {

            //Exercise 3: Use the string interpolation method to concatenate two strings:

            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName} ";
            Console.WriteLine(name);

        }
    }
}
