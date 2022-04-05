using System;

namespace ParamIntegers
{
    public class Parameters
    {
        static void Main()
        {
            int result = SumOfIntegers(1, 2, 3, 4, 5, 6);
            Console.WriteLine("Sum of Integers = {0}", result);
        }

        static int SumOfIntegers(params int[] integers)
        {
            int res = 0;
            foreach (int integer in integers)
            {
                res += integer;
            }
            return res;
        }
    }
}