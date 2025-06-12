using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Polymorphism
{
    public class PolymorphismTest
    {
        [Test]
        public void TestMehtod()
        {
            //polymorphism dynamic
            Student student = new Student("Ana Maria", "Avram", 31, "UCV", "Management", true);
            student.Eat();

        }
        //polymorphism static
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(in int a, in int b, int c) 
        { 
            return a + b + c; 
        }
        public int Add(double a, double b)
        {
            return (int)(a + b);
        }
    }
}
