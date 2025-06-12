using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Abstractization.GeometricFigures_AbstractClasses
{
    public class GeometricFiguresTest
    {
        [Test]
        public void TestShapes()
        {
            Circle circle = new Circle { Radius = 5 , Color = "Blue"};
            circle.Area();
            circle.Draw();

            Square square = new Square { Latura = 7, Color = "Red" };
            square.Area();
            square.Draw();
        }
    }
}
