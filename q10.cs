using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question10
    {
        public static void Main2 ()
        {
            Console.Write("Enter First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            int result1 = (firstNumber + secondNumber) * thirdNumber;
            int result2 = (firstNumber * secondNumber) + (secondNumber * thirdNumber);

            Console.WriteLine($"Result of specified numbers {firstNumber}, {secondNumber} and {thirdNumber}, (x+y).z is {result1} and x.y + y.z is {result2}");
            Console.ReadKey();
        }
    }
}
