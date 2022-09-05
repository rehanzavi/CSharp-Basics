using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question3
    {
        public static void Main2()
        {
            Console.Write("Enter First Number: ");
            decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
            Console.Write($"Quotient is: {firstNumber / secondNumber}");
 
            Console.ReadKey();
        }
    }
}
