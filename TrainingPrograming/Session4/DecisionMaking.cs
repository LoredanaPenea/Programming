using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Session4
{
    public class DecisionMaking
    {
    [Test]

    public void TestMethod()
     {
            VerifyNumber(7,11);
            Compare(8);
            VerifyCar("Opel");
     }

    public void VerifyNumber (int a, int b)
        {
            if (a < b)
            {
                Console.WriteLine($"Number {a} is smaller than number {b}");
            }
            else
            {
                Console.WriteLine($"Number {a} is higher than number {b}");
            }
        }

    public void Compare (int x)
        {
            if (x < 5)
            {
                Console.WriteLine($"Number {x} is smaller than 5");
            }
            else if (x>5) 
            {
                Console.WriteLine($"Number {x} is bigger than 5");
            }
            else
            {
                Console.WriteLine($"Number {x} equals 5");
            }
        }

    public void VerifyCar(string car)
        {
            switch (car)
            {
                case "Audi":
                    Console.WriteLine("Audi is available");
                    break;
                case "Mercesdes":
                    Console.WriteLine("Mercedes is available");
                    break;
                case "BMW":
                    Console.WriteLine("BMW is available");
                    break;
                default:
                    Console.WriteLine("None");
                    break;
            }
        }

    }
}
