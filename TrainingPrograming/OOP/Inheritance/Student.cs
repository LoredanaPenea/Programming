using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Inheritance
{
    public class Student : Person
    {
        public string university;
        public string profile;
        public bool bursier;

        public Student(string name, int age, double weight,string university, string profile, bool bursier) : base(name, age, weight)
        {
            this.university = university;
            this.profile = profile;
            this.bursier = bursier;
        }

        public void InfoStudent()
        {
            InfoPerson();
            Console.WriteLine($"Student la universitate: {university}");
            Console.WriteLine($"Student la profilul: {profile}");
            Console.WriteLine($"Student are bursa: {bursier}");
        }
    }
}
