using System;

namespace Calculator
{
    class Calculator
    {
        private double _num1;
        private double _num2;

        public double Add()
        {
            return _num1 + _num2;
        }

        public double Subtract()
        {
            return _num2 - _num1;
        }

        public double Multiply()
        {
            return _num1 * _num2;
        }

        public double Divide()
        {
            return (double)_num2 / _num1;
        }

        public Calculator(double num1, double num2)
        {
            this._num1 = num1;
            this._num2 = num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(10, 94);
            Console.WriteLine(calc.Add());
            Console.WriteLine(calc.Subtract());
            Console.WriteLine(calc.Multiply());
            Console.WriteLine(calc.Divide());
        }
    }
}
