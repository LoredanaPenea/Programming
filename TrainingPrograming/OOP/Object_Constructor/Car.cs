using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Object_Constructor
{
    public class Car
    {
        string engine;
        string color;
        int doors;
        double cilinders;
        string gearboxType;

        public Car(string engine, string color, int doors, double cilinders)
        {
            this.engine = engine;
            this.color = color;
            this.doors = doors;
            this.cilinders = cilinders;
        }

        public Car(string engine, string color, int doors, double cilinders, string gearboxType)
        {
            this.engine=engine;
            this.color = color;
            this.doors = doors;
            this.cilinders = cilinders;
            this.gearboxType = gearboxType;
        }

        public void DisplayData()
        {
            Console.WriteLine($"Engine is: {engine}");
            Console.WriteLine($"Color is: {color}");
            Console.WriteLine($"Number of doors is: {doors}");
            Console.WriteLine($"Cilinders: {cilinders}");

            if (gearboxType != null) 
                Console.WriteLine($"Gearbox type is: {gearboxType}");
        }
    }
}
