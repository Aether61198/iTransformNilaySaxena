using System;

namespace CircleParameters
{
    class CircleOperations
    {
        static void Main()
        {
            Console.WriteLine("Enter the radius of the circle");
            float radiusOfCircle = Convert.ToSingle(Console.ReadLine());
            float pi = 3.141F;
            float areaOfCircle = pi * radiusOfCircle * radiusOfCircle;
            float circumferenceOfCircle = 2 * pi * radiusOfCircle;
            Console.WriteLine("Area of Circle: {0}", areaOfCircle);
            Console.WriteLine("Circumference of Circle: {0}", circumferenceOfCircle);
        }
    }
}