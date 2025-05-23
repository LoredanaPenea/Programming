﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.BeginerTier.Session3
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
            int xAge = AgeInXYears(15);
            DisplayPersonDetails();
           // Console.WriteLine($"You will be {xAge} years old in 15 years!");

            AddSkills("Software");
            AddSkills("Testing");
            AddSkills("Gardening");
            AddSkills("Ninja");
            AddSkills("Dancing");
            AddSkills("Driving");
            AddSkills("CIA");
            AddSkills("Spanish Language");
            AddSkills("Baking");

            DisplayPersonSkills();
            CountTo(114);
            CountUpTo(103);
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
                if (!skill.Equals("Ninja") && !skill.Equals("CIA"))
                    Console.Write(skill + "; ");
                else if (skill.Equals("CIA"))
                {
                    Console.WriteLine("\n >>>>> Classified information, no further skilss are displayed! <<<<<<");
                    break;
                }
            }
        }

        public static void CountTo(int number)
        {
            Console.WriteLine($"Counting up to {number}:");
            
            int i = 0;
            while (i < number)
            {
                i++;
                if (i == 10)
                {
                    Console.WriteLine("\nNumber skipped!");
                    continue;
                }
                if (i == 99)
                {
                    Console.WriteLine(i + "; \nCannot count past 99!");
                    break;
                }
                
                Console.Write(i + "; ");
            }
        }

        public static void CountUpTo(int number)
        {
            Console.WriteLine($"Counting up to {number}:");
            int i = 0;

            do
            {
                i++;
                if (i == 10)
                {
                    Console.WriteLine("\n Number skipped!");
                    continue;
                }
                if (i == 99)
                {
                    Console.WriteLine("\nCannot count past 99!");
                    break;
                }
                Console.Write(i + "; ");
               
            } while (i < number);
        }
    }
}

