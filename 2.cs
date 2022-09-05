using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2_2
    {
        public static void Main2()
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 1)
                Console.WriteLine($"{number} is odd");
            else
                Console.WriteLine($"{number} is even");

            Console.ReadKey();
        }
    }
}
