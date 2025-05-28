using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Inheritance.Example
{
    public class Test
    {
        //Inheritance/Mostenire = concept prin care o clasa(copil) mosteneste alta clasa(parinte)
        //in C# se poate mosteni doar o singura clasa
        //clasa copil preia proprietatile si metodele unei clase parinte

        [Test]
        public void TestMethod()
        {
            //var person = new Person("Mihai",30,55.5);
            //person.InfoPerson();

            //var ion = new Employee("Ion", 27, 60.4, "contabil", 4444, "Endava");
            //ion.InfoEmployee();

            var student = new Student("Alina", 20, 55, "UCB", "real", true);
            student.InfoStudent();
           
        }
    }
}
