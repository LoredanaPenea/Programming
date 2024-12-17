using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Session3
{
    public static class Person
     {
        public static string FirstName = "Loredana";
        public static string LastName = "Penea";
        public static int Age = 36;
        public static string Gender = "Bi";

        [Test]
        public static void MethodHomework()
        {
            int xAge = Person.AgeInXYears(15);
            Person.DisplayPersonDetails();
            Console.WriteLine($"You will be {xAge} years old in 15 years!");

        }

        public static int AgeInXYears(int x)
        {
             return x + Age;
        }

        public static void DisplayPersonDetails()
        {
            Console.WriteLine($"Person details are as follows: \n" +
                    $"- First Name: {FirstName} \n" +
                    $"- Last Name: {LastName} \n" +
                    $"- Gender: {Gender}");
        }
    }
}

