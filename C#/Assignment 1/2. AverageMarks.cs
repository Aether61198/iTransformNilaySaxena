using System;

namespace AverageMarks
{
    class Average
    {
        static void Main()
        {
            int[] averageMarks = new int[5];

            Console.WriteLine("Enter Average Marks of five students");
            averageMarks[0] = Convert.ToInt32(Console.ReadLine());
            int maxMarks = averageMarks[0];

            for (int i = 1; i < 5; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                averageMarks[i] = x;
                maxMarks = maxMarks < x ? x : maxMarks;
            }

            Console.WriteLine("Highest Marks = {0}", maxMarks);
        }
    }
}