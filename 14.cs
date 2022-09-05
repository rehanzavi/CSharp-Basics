using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2_14
    {
        public static void Main2()
        {
            Console.Write("Input number of terms : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < 2*number; i+=2)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"The Sum of odd Natural Number upto {number} terms : {sum}");

            Console.ReadKey();
        }
    }
}
