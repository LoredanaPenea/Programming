using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Abstractization
{
    public class Employee : Person, IEmployee
    {
        private string Company {  get; set; }
        private double Salary { get; set; }

        public Employee(string firstName,string lastName, int age, string company, double salary) : base (firstName,lastName, age)
        {
            this.Company = company;
            this.Salary = salary;
        }

        public void DisplayEmployeeInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Company: {Company}");
            Console.WriteLine($"Salary: {Salary}");
        }

        public void GoToWork()
        {
            Console.WriteLine("Employee goes to work");
        }

        public void TakeABreak()
        {
            Console.WriteLine("Employee takes a break");
        }

        public void AttendMeeting()
        {
            Console.WriteLine("Employee attends a meeting");
        }
    }
}
