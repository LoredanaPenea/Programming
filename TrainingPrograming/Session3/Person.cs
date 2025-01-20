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
        public static List<string> Skills = new List<string>();

        [Test]
        public static void MethodHomework()
        {
            int xAge = Person.AgeInXYears(15);
            Person.DisplayPersonDetails();
            Console.WriteLine($"You will be {xAge} years old in 15 years!");

            Person.AddSkills("Software");
            Person.AddSkills("Testing");
            Person.AddSkills("Gardening");
            Person.AddSkills("Ninja");
            Person.AddSkills("Dancing");
            Person.AddSkills("Driving");
            Person.AddSkills("CIA");
            Person.AddSkills("Spanish Language");
            Person.AddSkills("Baking");

            Person.DisplayPersonSkills();

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

        public static void AddSkills(string skill)
        {
            Console.WriteLine($"Added  a new skill: {skill}");
            Skills.Add(skill);
        }

        public static void DisplayPersonSkills()
        {
            Console.WriteLine("The person has the following skills:");

            foreach (string skill in Skills)
            {
                if (!skill.Equals("Ninja") && (!skill.Equals("CIA")))
                    Console.Write(skill + "; ");
                else if (skill.Equals("CIA"))
                {
                    Console.WriteLine("\n >>>>> Classified information, no further skilss are displayed! <<<<<<");
                    break;
                }
            }
        }
    }
}

