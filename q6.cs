using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question6
    {
        public static void Main2()
        {
            Console.Write("Enter First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            int product = firstNumber * secondNumber * thirdNumber;

            Console.Write($"{firstNumber} x {secondNumber} x {thirdNumber} = {product}");
            Console.ReadKey();
        }
    }
}
