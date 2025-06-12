using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Polymorphism
{
    public class Employee : Person
    {
        private string Company { get; set; }
        private double Salary { get; set; }

        public Employee(string firstName, string lastName, int age, string company, double salary) : base(firstName, lastName, age)
        {
            Company = company;
            Salary = salary;
        }

        public void DisplayEmployeeInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Company: {Company}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
