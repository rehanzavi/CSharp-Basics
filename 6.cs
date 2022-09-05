using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2_6
    {
        public static void Main2()
        {
            Console.Write("Enter Number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int n;

            if (m > 0)
                n = 1;
            else if (m < 0)
                n = -1;
            else
                n = 0;

            Console.WriteLine($"The value of n = {n}");

            Console.ReadKey();
        }
    }
}
