using System;
using System.Collections;

namespace MultipleInheritance
{
    /*
        When a class is derived from more than one base class,
        i.e., when a class has more than one immediate parent
        class, this type of inheritance is called multiple
        inheritance. 
    */
    class Person
    {
        public void Show1()
        {
            Console.WriteLine("This is a method of Person class");
        }
    }

    interface Employee
    {
        void Show2();
        void ShowEmployeeId();
    }

    class Teacher : Person, Employee
    {
        public void Show2()
        {
            Console.WriteLine("I'm an employee");
        }

        void Employee.ShowEmployeeId()
        {
            Console.WriteLine("Employee id: 22");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.Show1();
            teacher.Show2();

            Employee employee = new Teacher();
            employee.ShowEmployeeId();
        }
    }
}
