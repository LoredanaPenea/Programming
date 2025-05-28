using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Encapsulation
{
    public class Wallet
    {
        private decimal balance;

        public Wallet(decimal initialAmount)
        {
            balance = initialAmount;
        }

        public void DepositMoney(decimal amount) 
        { 
            if (amount > 0)
                balance += amount;
            else Console.WriteLine("Amount must be positive.");
        }

        public void WithdrawMoney(decimal amount) 
        { 
            if((amount > 0) && (balance >= amount))
                balance -= amount;
            else Console.WriteLine("Not enought founds in your account.");
        }
        public decimal Balance
        {
            get { return balance; }
        }
        /*
        public decimal GetBalance() 
        { 
            return balance;
        } */
    }
}
