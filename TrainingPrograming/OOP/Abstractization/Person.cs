using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Abstractization
{
    public class Person
    { 
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int Age {  get; set; }

        public Person(string firstName, string lastName, int age) 
        { 
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Age: {Age}");
        }
    }
}
