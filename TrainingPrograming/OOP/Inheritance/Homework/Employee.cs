using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Inheritance.Homework
{
    public class Employee : Person
    {
        public string Department { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Employee info: " +
                $"\n Name: {Name}, " +
                $"\n Age: {Age}, " +
                $"\n Department: {Department}");
        }
    }
}
