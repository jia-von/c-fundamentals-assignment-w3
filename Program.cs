using System;

namespace C_Fundamentals_Assignment_W3
{
    class Car

    {
        int maxSpeed;
        static void Main(string[] args)
        {
            //Exercise 3: Create an object of Car called myObj, and use it to set the value of maxSpeed to 200.
            Car myObj = new Car();
            myObj.maxSpeed = 200;
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
        }

    }
}
