using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2_7
    {
        public static void Main2()
        {
            Console.Write("Enter Height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (height < 150)
                Console.WriteLine("The person is Dwarf.");
            else if (height <= 165)
                Console.WriteLine("The person is of Average Height.");
            else
                Console.WriteLine("The person is Tall.");

            Console.ReadKey();
        }
    }
}
