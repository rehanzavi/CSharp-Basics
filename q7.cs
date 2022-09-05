using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question7
    {
        public static void Main2()
        {
            Console.Write("Enter First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            int difference = firstNumber - secondNumber;
            int product = firstNumber * secondNumber;
            float quotient = firstNumber / secondNumber;
            int remainder = firstNumber / secondNumber;

            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, sum);
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, difference);
            Console.WriteLine("{0} x {1} = {2}", firstNumber, secondNumber, product);
            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, quotient);
            Console.WriteLine("{0} % {1} = {2}", firstNumber, secondNumber, remainder);
            Console.ReadKey();
        }
    }
}
