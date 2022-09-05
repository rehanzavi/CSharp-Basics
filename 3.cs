using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2_3
    {
        public static void Main2()
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
                Console.WriteLine($"{number} is positive");
            else if (number < 0)
                Console.WriteLine($"{number} is negative");
            else
                Console.WriteLine($"{number} is Zero");

            Console.ReadKey();
        }
    }
}
