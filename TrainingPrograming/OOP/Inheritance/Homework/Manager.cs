using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Inheritance.Homework
{
    public class Manager:Person
    {
        private int teamSize;
        private decimal bonus;

        public void SetTeamSize(int size)
        {
            if (size > 0) 
                teamSize = size;
            else Console.WriteLine("Please enter a number greater than 0");
        }

        public int GetTeamSize()
        {
            return teamSize;
        }

        public void SetBonus(decimal amount)
        {
            if(amount > 0)
                bonus = amount;
            else Console.WriteLine("Bonus must be greater than 0");
        }
        public decimal GetBonus()
        {
            return bonus;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager: {Name}, leads a team of {teamSize} people, with a bonus of {bonus}");
        }
    }
}
