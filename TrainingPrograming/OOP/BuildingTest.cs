using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP
{
    public class BuildingTest
    {
        [Test]
        public void BuildingMethodTest()
        {
            Building villa = new Building(1,"BCA", false);
            villa.DisplayData();
            villa.DisplayFurniture();
            villa.AddFurniture();
            villa.AddFurnitureItem("bed");
            villa.AddFurnitureItem("sofa");
            villa.AddFurnitureItem("desk");
            villa.AddFurnitureItem("chairs");
            villa.DisplayFurniture();
            villa.RemoveFurnitureItem("couch");
            villa.SetName("Vila Familia Popescu");
            villa.DisplayData();

            Console.WriteLine();
            Building blockAp = new Building(4, "Porotherm", true);
            blockAp.DisplayData();
            blockAp.DisplayFurniture();
            blockAp.AddFurnitureItem("couch");
            Console.WriteLine($"Current number of floors: {blockAp.getFloorNumbers()}");
            blockAp.SetFloorNumbers(7);

        }
    }
}
