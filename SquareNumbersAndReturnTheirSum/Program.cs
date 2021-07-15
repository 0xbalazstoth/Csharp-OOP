using System;

namespace SquareNumbersAndReturnTheirSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquaresSum(2, 3, 4));
        }

        public static double SquaresSum(double num1, double num2, double num3) => (Math.Pow(num1, 2) + Math.Pow(num2, 2) + Math.Pow(num3, 2));
    }
}
