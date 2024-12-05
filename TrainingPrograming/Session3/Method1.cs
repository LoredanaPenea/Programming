using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Session3
{
    public class Method1
    {
        [Test]
        public void MethodTest ()
        {
            Sum2Numbers();
            Sum2Numbers(10, 20);
            int sum = GetResult(15, 33, 47);
            Console.WriteLine($"The result is {sum}");
        }
      
        public void Sum2Numbers()
        {
            int firstNumber = 30;
            int secondNumber = 123;
            int sum = firstNumber + secondNumber;   
            Console.WriteLine($"Sum of 2 numbers is: {sum}");
        }

        public void Sum2Numbers (int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            Console.WriteLine($"Sum of 2 numbers is: {sum}");
        }

        public int GetResult(int firstNumber, int secondNumber, int thirdNumber)
        {
            int sum = firstNumber + secondNumber + thirdNumber;
            return sum;
        }

    }
}
