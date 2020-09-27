using System;

namespace C_Fundamentals_Assignment_W3
{
    class Program

    {
        static void Main(string[] args)
        {
            Allergies person = new Allergies("Joe", 65);
            Console.WriteLine(person.IsAllergicTo(2));
        }

	}
}
