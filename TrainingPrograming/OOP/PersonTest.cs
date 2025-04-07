using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP
{
    public class PersonTest
    {
        
        [Test]

        public void PersonTestMethods()
        {
            var person1 = new Person("Alina", "Marinescu");
            Console.WriteLine($"First person full name is: {person1.FullName()}");

            person1.SetAge(22);
            Console.WriteLine($"And has: { person1.GetAge()} years");

            var person2 = new Person();
            person2.FirstName = "Alex";
            person2.LastName = "Ionescu";
            person2.SetAge(30);

            Console.WriteLine($"New person added, with below data: {person2.FullName()} , {person2.GetAge()} years old");
        }

    }
}
