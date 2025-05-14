using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Inheritance.Homework
{
    public class TestClass
    {
        [Test]
        public void TestOOPPrinciples()
        {
            Manager manager1 = new Manager { Name = "Popescu Andrei" };
            manager1.SetTeamSize(2);
            manager1.SetBonus(250);

            List<Person> persons = new List<Person>
            {
                new Employee { Name = "Marinescu Marina", Age = 28, Department = "Finance" },
                manager1
            };

            Manager manager2 = new Manager { Name = "Barbu Alina", Age = 40 };
            manager2.SetTeamSize(5);
            manager2.SetBonus(1200);
            persons.Add(manager2);

            foreach (Person person in persons)
            {
                person.DisplayInfo();
            }
         }
    }
}
