using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2_11
    {
        public static void Main2()
        {
            Console.Write("Input number of terms : ");
            int limit = Convert.ToInt32(Console.ReadLine());

            for ( int i = 1; i <= limit; i++)
                Console.WriteLine($"Number is : {i} and cube of the {i} is : {i*i*i}");

            Console.ReadKey();
        }
    }
}
