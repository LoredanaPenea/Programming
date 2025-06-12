using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingPrograming.OOP.Abstractization.GeometricFigures;

namespace TrainingPrograming.OOP.Abstractization.GeometricFigures_AbstractClasses
{
    public class Square : Shape
    {
        public int Latura { get; set; }
        public override void Area()
        {
            Console.WriteLine($"Square Area is:{Math.Pow(Latura,2)}");
        }
    }
}
