using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingPrograming.BeginerTier.Session3;

namespace TrainingPrograming.BeginerTier.Session4
{
    public class Decisions
    {
        [Test]

        public void DecisionsTest()
        {
            IsOld();
            ShowGender();
            YourGenderPreference();
            EvenPositiveNegative(10);
            EvenPositiveNegative(-15);
            EvenPositiveNegative(-22);
            EvenPositiveNegative(0);
        }
        public void IsOld()
        {
            if (Person.Age >= 100)
            {
                Console.WriteLine("You are ancient!");
            }
            else if (Person.Age >= 50)
            {
                Console.WriteLine("You are old!");
            }
            else Console.WriteLine("You are still young!");
        }

        public void ShowGender()
        {
            if (Person.Gender.Equals("Male"))
            {
                Console.WriteLine("You are a male!");
            }
            else if (Person.Gender.Equals("Female"))
                Console.WriteLine("You are a female!");
            else Console.WriteLine("You haven't specified you gender!");
        }

        public void YourGenderPreference()
        {
            switch (Person.Gender)
            {
                case "Male":
                    Console.WriteLine("You are a male!");
                    break;
                case "Female":
                    Console.WriteLine("You are a female!");
                    break;
                case "Gay":
                    Console.WriteLine("You are gay!");
                    break;
                default:
                    Console.WriteLine("I don't recognize this gendre");
                    break;

            }
        }
        public void EvenPositiveNegative(int number)
        {
            if (number % 2 == 0)
            {
                if (number > 0)
                {
                    Console.WriteLine("The number is even and positive.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("The number is even and negative.");
                }
                else
                {
                    Console.WriteLine("The number is zero.");
                }
            }
            else
            {
                if (number > 0)
                {
                    Console.WriteLine("The number is odd and positive.");
                }
                else
                {
                    Console.WriteLine("The number is odd and negative.");
                }
            }
        }
    }
}
