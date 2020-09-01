using System;

namespace C_Fundamentals_Assignment_W3
{
    class Car

    {
        private string model;

        public Car()
        {
            model = "Mustang";
        }
        static void Main(string[] args)
        {
            //Exercise 6: Use an access modifier to make the model variable NOT accessible from outside its own class.
            Car Ford = new Car();
            Console.WriteLine(Ford.model);
        }

    }
}
