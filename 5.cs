using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2_5
    {
        public static void Main2()
        {
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            else
                Console.WriteLine("Sorry! You are not eligible for casting your vote.");

            Console.ReadKey();
        }
    }
}
