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

        public void TestExample()
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
    }
}
