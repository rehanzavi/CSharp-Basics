using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2_15
    {
        public static void Main2()
        {
            Console.Write("Enter Limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= limit; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
