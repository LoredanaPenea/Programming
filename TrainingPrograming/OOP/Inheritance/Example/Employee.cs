using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingPrograming.OOP.Inheritance.Example;

namespace TrainingPrograming.OOP.Inheritance
{
    public class Employee : Person
    {
        public string job;
        public double salary;
        public string employer;

        public Employee(string name, int age, double weight, string job, double salary, string employer) : base(name, age, weight)
        {
            this.job = job;
            this.salary = salary;
            this.employer = employer;
        }

        public void InfoEmployee()
        {
            InfoPerson();
            Console.WriteLine($"Job angajat: {job}");
            Console.WriteLine($"Salariu angajat: {salary}");
            Console.WriteLine($"Angajator : {employer}");
        }
    }
}
