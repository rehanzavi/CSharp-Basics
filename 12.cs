using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2_12
    {
        public static void Main2()
        {
            Console.Write("Input the Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
                Console.WriteLine($"{number} x {i} = {number * i}");

            Console.ReadKey();
        }
    }
}
