using System;

namespace C_Fundamentals_Assignment_W3
{
    class Program

    {
        static void Main(string[] args)
        {

            //Exercise 4: Print "1" if x is equal to y, print "2" if x is greater than y, otherwise print "3".

            int x = 50;
            int y = 50;
            if(x == y) 
            {
                Console.WriteLine("1");
            }else
            if(x > y) 
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("3");
            }

        }
    }
}
