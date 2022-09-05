using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question8
    {
        public static void Main2()
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 11; i++)
                Console.WriteLine($"{number} * {i} = {number * i}");

            Console.ReadKey();
        }
    }
}
