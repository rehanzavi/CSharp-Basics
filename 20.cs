using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2_20
    {
        public static void Main()
        {
            Console.Write("Enter Limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= limit; i++)
            {
                for (int k = limit; k > i; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
