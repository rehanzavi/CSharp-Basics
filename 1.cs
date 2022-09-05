using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2_1
    {
        public static void Main2()
        {
            Console.Write("Enter First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber == secondNumber)
                Console.WriteLine($"{firstNumber} and {secondNumber} are equal");
            else
                Console.WriteLine($"{firstNumber} and {secondNumber} are not equal");

            Console.ReadKey();
        }
    }
}
