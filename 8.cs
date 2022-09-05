using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2_8
    {
        public static void Main2()
        {
            Console.Write("Enter First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
                if(firstNumber > thirdNumber)
                    Console.WriteLine("The 1st Number is the greatest among the three");
                else
                    Console.WriteLine("The 3rd Number is the greatest among the three");
            else if(secondNumber > thirdNumber)
                Console.WriteLine("The 2nd Number is the greatest among the three");
            else
                Console.WriteLine("The 3rd Number is the greatest among the three");

            Console.ReadKey();
        }
    }
}
