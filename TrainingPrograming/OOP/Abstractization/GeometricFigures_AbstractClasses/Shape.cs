using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Abstractization.GeometricFigures
{
    public abstract class Shape
    {
        public string Color {  get; set; }

        public abstract void Area();

        public void Draw()
        {
            Console.WriteLine("Draw shape");
        }
    }
}
