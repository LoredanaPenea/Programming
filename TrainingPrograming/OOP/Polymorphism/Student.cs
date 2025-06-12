using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Polymorphism
{
    public class Student : Person
    {
        private string University { get; set; }
        private string Profile { get; set; }
        private bool HaveScholarShip { get; set; }

        public bool Erasmus { get; }

        public Student(string firstName, string lastName, int age, string university, string profile, bool haveScholarShip) : base(firstName, lastName, age)
        {
            University = university;
            Profile = profile;
            HaveScholarShip = haveScholarShip;
        }
        //new contructor to also add the property Erasmus
        public Student(string firstName, string lastName, int age, string university, string profile, bool haveScholarShip, bool erasmus) : base(firstName, lastName, age)
        {
            University = university;
            Profile = profile;
            HaveScholarShip = haveScholarShip;
            Erasmus = erasmus;
        }

        public void DisplayStudentInfo()
        {
            DisplayInfo();
            Console.WriteLine($"University: {University}");
            Console.WriteLine($"With profile: {Profile}");
            Console.WriteLine($"Has Scholarship: {HaveScholarShip}");
            Console.WriteLine($"Is in Erasmus: {Erasmus}");
        }

        public override void Eat()
        {
            Console.WriteLine("Student eat");
            Console.WriteLine("Method override to test polymorphism");
        }
    }
}
