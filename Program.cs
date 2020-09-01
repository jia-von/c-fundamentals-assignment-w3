using System;

namespace C_Fundamentals_Assignment_W3
{
    class Program

    {
        static void Main(string[] args)
        {

            //Exercise 2: Change the value from "Volvo" to "Opel", in the cars array.


            string[] cars = { "Volvo", "BMW", "Ford", "Mazda"};
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);

        }
    }
}
