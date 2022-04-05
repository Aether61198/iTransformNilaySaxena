using System;

namespace Calculator
{

    using CalculatorMethods;
    public class CalculatorMain
    {
        static void Main()
        {
            int ch = 0;
            do
            {
                Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
                ch = Convert.ToInt32(Console.ReadLine());
                int firstNumber, secondNumber;

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter two numbers");
                        firstNumber = Convert.ToInt32(Console.ReadLine());
                        secondNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Sum = {0}\n", Operations.Addition(firstNumber, secondNumber));
                        break;
                    case 2:
                        Console.WriteLine("Enter two numbers");
                        firstNumber = Convert.ToInt32(Console.ReadLine());
                        secondNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Difference = {0}\n", Operations.Subtraction(firstNumber, secondNumber));
                        break;
                    case 3:
                        Console.WriteLine("Enter two numbers");
                        firstNumber = Convert.ToInt32(Console.ReadLine());
                        secondNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Product = {0}\n", Operations.Multiplication(firstNumber, secondNumber));
                        break;
                    case 4:
                        Console.WriteLine("Enter two numbers");
                        firstNumber = Convert.ToInt32(Console.ReadLine());
                        secondNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Quotient = {0}\n", Operations.Division(firstNumber, secondNumber));
                        break;
                    case 5:
                        Console.WriteLine("Exiting...\n");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice\n");
                        break;
                }
            }
            while (ch != 5);
        }
    }

    namespace CalculatorMethods
    {
        class Operations
        {
            public static int Addition(int firstNumber, int secondNumber)
            {
                int sumOfNumbers = firstNumber + secondNumber;
                return sumOfNumbers;
            }

            public static int Subtraction(int firstNumber, int secondNumber)
            {
                int differenceOfNumbers = firstNumber - secondNumber;
                return differenceOfNumbers;
            }

            public static int Multiplication(int firstNumber, int secondNumber)
            {
                int productOfNumbers = firstNumber * secondNumber;
                return productOfNumbers;
            }

            public static float Division(int firstNumber, int secondNumber)
            {
                float quotientOfNumbers = 0F;
                try
                {
                    quotientOfNumbers = (float)firstNumber / secondNumber;
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }
                return quotientOfNumbers;
            }
        }
    }
}