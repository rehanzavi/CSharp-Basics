using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2_10
    {
        public static void Main2()
        {
            Console.Write("Input the marks obtained in Physics: ");
            int physicsMark = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry: ");
            int chemistryMark = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Mathematics: ");
            int mathMark = Convert.ToInt32(Console.ReadLine());

            if (mathMark >= 65 && physicsMark >= 55 && chemistryMark >=50)
                if (mathMark + physicsMark + chemistryMark >= 180)
                    Console.WriteLine("The candidate is eligible for admission.");
                else if (mathMark + physicsMark >= 140)
                    Console.WriteLine("The candidate is eligible for admission.");
                else
                    Console.WriteLine("The candidate is not eligible.");
            else
                Console.WriteLine("The candidate is not eligible.");

            Console.ReadKey();
        }
    }
}
