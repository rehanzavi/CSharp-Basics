using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2_13
    {
        public static void Main2()
        {
            Console.WriteLine("Input upto the table number starting from 1 :");
            int limit = Convert.ToInt32(Console.Read());

            Console.WriteLine($"Multiplication table from 1 to {limit}");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= limit; j++)
                {
                    Console.Write($"{j}x{i}={j*i}, ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
