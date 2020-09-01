using System;

namespace C_Fundamentals_Assignment_W3 
{
    class Program 

    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Initial Commit"); 

            double myDoubleNum = 5.99D;
            Console.WriteLine(myDoubleNum); // output myDoubleNum doesn't show the 'D' at the end. 

            //Execise 1:  Create a variable named myNum and assign the value 50 to it.
            int myNum = 50;

            //Exercise 2: Create a variable named myName and assign the value "John" to it.
            string myName = "John";

            //Exercise 3: Display the sum of 5 + 10, using two variables: x and y.
            int x = 5;
            int y = 10;
            Console.WriteLine(x + y);

            //Exercise 4: Create an int variable called z, assign x + y to it, and display the result.

            int x = 5;
            int y = 10;
            int z = x + y;
            Console.WriteLine(z);

            //Exercise 5: Fill in the missing parts to create three variables of the same type, using a comma-separated list:
            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);
        }
    }
}
