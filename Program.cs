using System;

namespace C_Fundamentals_Assignment_W3
{
    class Program

    {
        static void Main(string[] args)
        {
            Allergies person = new Allergies("Rob", "Peanuts Chocolate Cats Strawberries");
            Console.WriteLine(person.Score);
        }

	}
}
