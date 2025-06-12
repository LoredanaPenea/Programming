using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Abstractization.Abstractization_Interfaces
{
    public  class Student : Person, IStudent
    {
        private string University { get; set; }
        private string Profile { get; set; }
        private bool HaveScholarShip { get; set; }

        //if FirstName, LastName and Age are set as private in Person class 
        // can not use Name and Age from IStudent interface
        
        //proprieties from Interface need to be public in order to use them
        public string Name => FirstName + LastName;
        public int Age => base.Age; //does not recognize Age as Person.Age , need to add base.Age
        public bool Erasmus { get ; }


       
        public Student(string firstName, string lastName, int age, string university, string profile, bool haveScholarShip) : base(firstName, lastName, age)
        {
            University = university;
            Profile = profile;
            HaveScholarShip = haveScholarShip;
        }
        //new contructor to also add the property Erasmus
        public Student(string firstName, string lastName, int age, string university, string profile, bool haveScholarShip,bool erasmus) : base(firstName, lastName, age)
        {
            University = university;
            Profile = profile;
            HaveScholarShip = haveScholarShip;
            Erasmus = erasmus;
        }
        
        public void DisplayStudentInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Full Name: {Name}");
            Console.WriteLine($"University: {University}");
            Console.WriteLine($"With profile: {Profile}");
            Console.WriteLine($"Has Scholarship: {HaveScholarShip}");
            Console.WriteLine($"Is in Erasmus: {Erasmus}");
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
