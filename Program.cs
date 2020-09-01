using System;

namespace C_Fundamentals_Assignment_W3
{
    class Program

    {
        static void Main(string[] args)
        {

            //Exercise 2: Complete the switch statement, and add the correct keyword at the end to specify some code to run if there is no case match in the switch statement.

            int day = 3;
            switch (day)
            {
            case 1:
                Console.WriteLine("Today is Saturday");
            break;
            case 2:
                Console.WriteLine("Today is Sunday");
            break;
            default:
                Console.WriteLine("Looking forward to the Weekend");
            break;
        }

    }
    }
}
