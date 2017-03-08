using System;

namespace CSharpTutorial
{

    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Base class constructor called");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    class PartTimeEmployee : Employee
    {
        public float HourlyRate { get; set; }
    }

    class FullTimeEmployee : Employee
    {
        public float YearlySalary { get; set; }
    }
    class Program
    {
        static void Main()
        {
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.FirstName = "PartTime";
            partTimeEmployee.LastName = "Employee";
            partTimeEmployee.HourlyRate = 65;
            partTimeEmployee.PrintFullName();
            
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.FirstName = "FullTime";
            fullTimeEmployee.LastName = "Employee";
            fullTimeEmployee.YearlySalary = 65000;
            fullTimeEmployee.PrintFullName();
        }
    }
}

