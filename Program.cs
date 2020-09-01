using System;

namespace C_Fundamentals_Assignment_W3
{
    class Program

    {

        static void Main(string[] args)
        {
            //Exercise 1: Fill in the missing parts to output an error message if an error occurs.
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
