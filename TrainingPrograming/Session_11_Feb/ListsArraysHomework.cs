using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Session_11_Feb
{
    public class ListsArraysHomework
    {
        [Test]

        public void HomeworkList()
        {
            ListItems(4);

        }

        
        public void ListItems(int nr)
        {
            Console.WriteLine("We will build a list of numbers: ");
            List<int> numbers = new List<int>();
            
            int i = 0;
            while (i < nr) {
                numbers.Add(i+1);
                Console.WriteLine($"Number for list[{i}]: " + $"{numbers[i]}");
                i++;
            }

            Console.Write("Your list contains the following items: ");
            foreach (var number in numbers)
                Console.Write($"{number}; ");

            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();
            foreach(var number in numbers)
            {
                if (number % 2 == 0)
                    evenNumbers.Add(number);
                else oddNumbers.Add(number);
            }

            Console.Write($"\n List of even numbers is: ");
            foreach (var number in evenNumbers)
                Console.Write($"{number}; ");

            Console.Write($"\n List of odd numbers is: ");
            foreach (var number in oddNumbers)
                Console.Write($"{number}; ");

            Console.WriteLine($"\n Sum of even numbers from list is: {evenNumbers.Sum()}");
            Console.WriteLine($"Sum of odd numbers from list is: {oddNumbers.Sum()}");

        }

       // ********
        public List<int> CreateList(int nr)
        {
            Console.WriteLine("We will build a list of numbers: ");
            List<int> numbers = new List<int>();

            int i = 0;
            while (i < nr)
            {
                numbers.Add(i + 1);
                Console.WriteLine($"Number for list[{i}]: " + $"{numbers[i]}");
                i++;
            }

            return numbers;
        }

        public void ListNumbers(int nr)
        {
            List<int> numbers = CreateList(nr); //will display again each item of teh list
            Console.Write("Your list contains the following items: ");
            foreach (var number in numbers)
                Console.Write($"{number}; ");
        }
        public void ListEvenNumbers(int nr)
        {
            List<int> listNumbers = CreateList(nr);
            List<int> evenNumbers = new List<int>();
            foreach (var number in listNumbers)
            {
                if (number % 2 == 0)
                    evenNumbers.Add(number);
            }
            Console.Write($"\n List of even numbers is: ");
            foreach (var number in evenNumbers)
                Console.Write($"{number}; ");
        }

        public void ListOddNumbers(int nr)
        {
            List<int> listNumbers = CreateList(nr);
            List<int> oddNumbers = new List<int>();
            foreach (var number in listNumbers)
            {
                if (number % 2 == 0)
                    oddNumbers.Add(number);
            }
            Console.Write($"\n List of odd numbers is: ");
            foreach (var number in oddNumbers)
                Console.Write($"{number}; ");
        }

    }
}
