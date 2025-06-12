using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Abstractization.Abstractization_Interfaces
{
    public class EmployeeStudent :Person, IEmployee,IStudent
    {
        private string Company {  get; set; }
        private double Salary { get; set; }
        private string University { get; set; }
        private string Profile {  get; set; }

        public string Name { get; }

        public int Age { get; }

        public bool Erasmus { get; }

        public EmployeeStudent(string firstName, string lastName, int age, string company, double salary, string university,string profile) : base(firstName,lastName, age)
        {
            Company = company;
            Salary = salary;
            University = university;
            Profile = profile;
        }

        public void GoToWork()
        {
            Console.WriteLine("Employee Student goes to work");
        }

        public void TakeABreak()
        {
            Console.WriteLine("Employee Student takes a break");
        }

        public void AttendMeeting()
        {
            Console.WriteLine("Employee Student attends a meeting");
        }

        public void Study()
        {
            Console.WriteLine("Employee Student study");
        }

        public void AttendClass()
        {
            Console.WriteLine("Employee Student attends a class");
        }

        public void TakeExam()
        {
            Console.WriteLine("Employee Student takes an exam");
        }
    }
}
