using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Abstractization
{
    public  class Student : Person, IStudent
    {
        private string University { get; set; }
        private string Profile { get; set; }
        private bool HaveScholarShip { get; set; }

        public string Name => ;

        public int Age => ;

        public Student (string firstName, string lastName, int age, string university, string profile, bool haveScholarShip) : base(firstName, lastName, age)
        {
            University = university;
            Profile = profile;
            HaveScholarShip = haveScholarShip;
        }
        public void DisplayStudentInfo()
        {

        }
        public void Study()
        {
            Console.WriteLine("Student study");
        }

        public void AttendClass()
        {
            Console.WriteLine("Student attends a class");
        }

        public void TakeExam()
        {
            Console.WriteLine("Student takes an exam");
        }
    }
}
