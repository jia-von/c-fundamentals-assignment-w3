using System;

namespace C_Fundamentals_Assignment_W3
{
    class Car

    {
        public string model;

        public Car()
        {
            model = "Mustang";
        }
        static void Main(string[] args)
        {
            //Exercise 5: Create a constructor of Car, and call it:
            Car Ford = new Car();
            Console.WriteLine(Ford.model);
        }

    }
}
