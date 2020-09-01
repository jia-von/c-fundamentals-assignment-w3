using System;

namespace C_Fundamentals_Assignment_W3
{
    class Car

    {
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        static void Main(string[] args)
        {
            //Exercise 4: Call the fullThrottle() method from the object:
            Car myObj = new Car();
            myObj.fullThrottle();

        }

    }
}
