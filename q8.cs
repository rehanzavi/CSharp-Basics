using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question9
    {
        public static void Main2()
        {
            Console.Write("Enter First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Fourth Number: ");
            int fourthNumber = Convert.ToInt32(Console.ReadLine());

            float average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

            Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber}, {fourthNumber} is {average}");
            Console.ReadKey();
        }
    }
}
