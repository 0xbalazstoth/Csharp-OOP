using System;

namespace Student
{
    class Student
    {
        private string _name;
        private string _rollNumber;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public string RollNumber
        {
            get
            {
                return this._rollNumber;
            }
            set
            {
                this._rollNumber = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "John";
            student.RollNumber = "20";
            Console.WriteLine($"{student.Name} {student.RollNumber}");
        }
    }
}
