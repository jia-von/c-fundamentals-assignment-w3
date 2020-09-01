using System;

namespace C_Fundamentals_Assignment_W3
{
    class Program

    {

        static void Main(string[] args)
        {
            //Exercise 2: Fill in the missing parts to execute some code, after the exception statements, regardless of the result.
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }

    }
}
