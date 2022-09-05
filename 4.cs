using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2_4
    {
        public static void Main2()
        {
            Console.Write("Enter Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0) && (year % 100 != 0))
                Console.WriteLine($"{year} is a leap year");
            else if (year % 400 == 0)
                Console.WriteLine($"{year} is a leap year");
            else
                Console.WriteLine($"{year} is not a leap year");

            Console.ReadKey();
        }
    }
}
