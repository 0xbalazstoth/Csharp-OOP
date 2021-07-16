using System;

namespace Difference
{
    class Calculator
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Sum(int num1, int num2, int num3, int num4)
        {
            return num1 + num2 + num3 + num4;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine($"{10} + {20} = {calculator.Sum(10, 20)}");
            Console.WriteLine($"{10} + {20} + {30} = {calculator.Sum(10, 20, 30)}");
            Console.WriteLine($"{10} + {20} + {30} + {40} = {calculator.Sum(10, 20, 30, 40)}");
        }
    }
}
