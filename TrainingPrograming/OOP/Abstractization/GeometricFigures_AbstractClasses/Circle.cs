using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingPrograming.OOP.Abstractization.GeometricFigures;

namespace TrainingPrograming.OOP.Abstractization.GeometricFigures_AbstractClasses
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public override void Area()
        {
            Console.WriteLine($"Circle Area is: {Math.PI * Math.Pow(Radius,2)}");
        }
    }
}
