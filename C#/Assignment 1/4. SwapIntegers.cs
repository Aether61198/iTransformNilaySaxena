using System;

namespace SwapIntegers
{
    public class SwapMain
    {
        static void Main()
        {
            SwapMain obj = new SwapMain();
            Console.WriteLine("Enter two values");
            int firstValue = Convert.ToInt32(Console.ReadLine()); // assume 6
            int secondValue = Convert.ToInt32(Console.ReadLine()); // assume 5
            Console.WriteLine("Values before swap");
            obj.DisplayValues(firstValue, secondValue);
            obj.SwapValues(ref firstValue, ref secondValue);
            Console.WriteLine("Values after swap");
            obj.DisplayValues(firstValue, secondValue);
        }

        void SwapValues(ref int firstValue, ref int secondValue)
        {
            firstValue = firstValue + secondValue; // firstValue = 6 + 5 = 11
            secondValue = firstValue - secondValue; // secondValue = 11 - 5 = 6
            firstValue = firstValue - secondValue; // firstValue = 11 - 6 = 5
        }

        void DisplayValues(int firstValue, int secondValue)
        {
            Console.WriteLine("First Value = {0}\nSecond Value = {1}\n", firstValue, secondValue);
        }
    }
}