using System;

namespace AnalyzingThePerformanceOfStudents
{
    class Student
    {
        // Declare the fields and properties here
        private string _name;
        private double _physicsMarks;
        private double _chemistryMarks;
        private double _biologyMarks;

        public string Name
        {
            get
            {
                return this._name;
            }
        }

        public double PhysicsMarks
        {
            get
            {
                return this._physicsMarks;
            }
        }

        public double ChemistryMarks
        {
            get
            {
                return this._chemistryMarks;
            }
        }

        public double BiologyMarks
        {
            get
            {
                return this._biologyMarks;
            }
        }

        // Modify the below constructor
        public Student(string name, double phy, double chem, double bio)
        {
            // Write definition here
            this._name = name;
            this._physicsMarks = phy;
            this._chemistryMarks = chem;
            this._biologyMarks = bio;
        }

        public double TotalObtained()
        {
            return PhysicsMarks + ChemistryMarks + BiologyMarks;
        }

        public double Percentage()
        {
            double percentage = ((double)TotalObtained() / 300) * 100;
            return percentage;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Student john = new Student("John", 75, 75, 90);
            Console.WriteLine(john.TotalObtained());
            Console.WriteLine(john.Percentage());
            Console.WriteLine(john.PhysicsMarks);
        }
    }
}
