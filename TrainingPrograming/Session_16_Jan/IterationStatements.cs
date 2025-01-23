using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Session_16_Jan
{
    public class IterationStatements
    {
        [Test]

        public void TestExampleFor()
        {
            /*for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine(i);
            }

            int j = 1;
            for(; j<=8; j++)
            {
                Console.WriteLine(j);
            }*/

            string[] coleagueName = new string[3];
            coleagueName[0] = "A";
            coleagueName[1] = "B";
            coleagueName[2] = "C";

            for (int i = 0; i < coleagueName.Length; i++)
            {
                Console.WriteLine(coleagueName[i]);
            }

            List<string> Names = new List<string>
            {
                "Lore",
                "Mihai",
                "Andra"
            };

            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
        }

        [Test]

        public void TestExampleWhile()
        {
          //  int counter = 18;
         //   while (counter <= 30)
         //   {
         //       Console.WriteLine($"The current counter value is: {counter}");
         //       counter++;
         //   }

         //   MethodWhile(50,61);
           // MethodWhileBreak(50, 60, 55);
            MethodWhileSkip(50, 60, 55);
            MethodDoWhile();
        }

        public void MethodWhile(int counterStart, int counterEnd)
        {
            while (counterStart <= counterEnd)
            {
                Console.WriteLine($"The current counter value is: {counterStart}");
                counterStart++;
            }
        }

        public void MethodWhileBreak(int counter, int limit, int stopValue)
        {
            while (counter <= limit)
            {
                if (counter == stopValue)
                    break;
                Console.WriteLine($"The current counter value is: {counter}");
                counter++;
            }
        }

        public void MethodWhileSkip(int counter, int limit, int skipValue)
        {
            while (counter <= limit)
            {
                counter++;
                if (counter == skipValue)
                {
                    continue;
                }
                 Console.WriteLine($"The current counter value is: {counter}");
            }
        }

        public void MethodDoWhile()
        {
            int counter = -5;
            do
            {
                Console.WriteLine($"Counter value is: {counter}");
                counter++;
            } while (counter <= 5);
        }
    }
}
