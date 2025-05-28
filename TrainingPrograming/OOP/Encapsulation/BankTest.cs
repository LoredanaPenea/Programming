using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Encapsulation
{
    // Encapsulation 
    //  - hiding the internal details (like variables and implementation logic) of a class
    //  - exposing only what’s necessary through public methods or properties
    //  - can control how values are read or changed using get and set
    public class BankTest
    {
        private Wallet wallet;

        [SetUp]
        public void Setup() 
        {
            wallet = new Wallet(100);
        }

        [Test]
        public void TestDeposit() 
        {
            wallet.DepositMoney(400);
            //Console.WriteLine($"Your wallet amount is: {wallet.GetBalance()}");
            Console.WriteLine($"Your wllet amount is: {wallet.Balance}");
        }

        [Test]
        public void TestWithdraw()
        {
            wallet.WithdrawMoney(150);
            Console.WriteLine($"Your wallet amount is: {wallet.Balance}");
        }
    }
}
