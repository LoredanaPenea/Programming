using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Session3
{
    public class Decisions
    {
        [Test]
        
        public void DecisionsTest()
        {
            IsOld();
            ShowGender();
        }
        public void IsOld()
        {
            if (Person.Age >= 100) {
                Console.WriteLine("You are ancient!");
            } else if (Person.Age >= 50) {
                Console.WriteLine("You are old!");
            } else Console.WriteLine("You are still young!");
        }
        
        public void ShowGender()
        {
            if (Person.Gender.Equals("Male"))
            {
                Console.WriteLine("You are a male!");
            } else if (Person.Gender.Equals("Female"))
                Console.WriteLine("You are a female!");
            else Console.WriteLine("You haven't specified you gender!");
        }
    }
}
