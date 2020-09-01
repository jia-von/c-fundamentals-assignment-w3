using System;

namespace C_Fundamentals_Assignment_W3
{
    class Program

    {
        static void Main(string[] args)
        {

            //Exercise 5: In the following loop, when the value is "4", jump directly to the next value.


            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
