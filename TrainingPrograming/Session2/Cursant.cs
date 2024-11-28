using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Session2
{
    public class Cursant
    {
        string FirstName;
        string LastName;
        int age;
        bool isActive;
        char gendre;
        float grade;
        double height;

        [Test]
        public void RunCursant()
        {
            FirstName = "Loredana";
            LastName = "Penea";
            age = 36;
            isActive = true;
            gendre = 'F';
            grade = 8.75f;
            height = 1.65;
            Console.WriteLine("Cursant details:");
            Console.WriteLine("Name is: " + FirstName + " " + LastName);
            Console.Write("Age is: "+ age + "\n");
            Console.WriteLine("Height: " + height);
            Console.Write("You will be " + (age+20) + " years old in 20 years!");
        }

    }
}
