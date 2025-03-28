using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP
{
    public class Building
    {
        int floorNumbers;
        string constructionMaterial;
        bool hasFurniture;
        List<string> furnitureItems;
        string name;

        public Building(int floorNumbers, string constructionMaterial, bool hasFurniture)
        {
            this.floorNumbers = floorNumbers;
            this.constructionMaterial = constructionMaterial;
            this.hasFurniture = hasFurniture;
            this.furnitureItems = hasFurniture ? new List<string>() : new List<string>();
        }
        public void DisplayData()
        {
            Console.WriteLine($"This building has {floorNumbers} floors");
            Console.WriteLine($"This building is made of {constructionMaterial}");
            if (hasFurniture)
                Console.WriteLine("This building is furnished");
            else Console.WriteLine("This building has no furniture");

            if (name != null) Console.WriteLine($"This building name is: {name}");
        }
        public int getFloorNumbers()
        {
            return floorNumbers;
        }

        public void SetFloorNumbers(int newFloorCount)
        {
            if (newFloorCount > 0)
            {
                floorNumbers = newFloorCount;
                Console.WriteLine($"New number of floors is set to: {floorNumbers}");
            }
            else
                Console.WriteLine("Invalid number of floors.");
        }
        public void AddFurniture()
        {
            this.hasFurniture= true;

        }

        public void AddFurnitureItem(string item)
        {
            if (!string.IsNullOrWhiteSpace(item))
            {
                furnitureItems.Add(item);
                hasFurniture = true;
                Console.WriteLine($"{item} was added to the building.");
            }
        }

        public void DisplayFurniture()
        {
            if (furnitureItems.Count == 0)
            {
                Console.WriteLine("No furniture in the building.");
            }
            else
            {
                Console.WriteLine("Furniture items in the building:");
                foreach (var item in furnitureItems)
                {
                    Console.WriteLine($"> {item}");
                }
            }
        }
        public void RemoveFurnitureItem(string item)
        {
            if (furnitureItems.Contains(item))
            {
                furnitureItems.Remove(item);
                Console.WriteLine($"{item} was removed.");
            }
            else
            {
                Console.WriteLine($"{item} not found in the building.");
            }

            if (furnitureItems.Count == 0)
                hasFurniture = false;
        }
        public void SetName (string name)
        {
            this.name = name;
        }
    }
}
