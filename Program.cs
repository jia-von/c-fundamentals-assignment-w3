using System;

namespace C_Fundamentals_Assignment_W3
{
    class Program

    {
        static void Main(string[] args)
        {

            //Exercise 4: Stop the loop if i is 5.


            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }

        }
    }
}
