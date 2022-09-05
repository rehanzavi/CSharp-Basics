using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2_9
    {
        public static void Main2()
        {
            Console.Write("Input the value for X coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value for X coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            else if (x < 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            else if (x < 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            else if (x > 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
            else if (x == 0 && y == 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Origin.");
            else if (x == 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Y-axis.");
            else if (y == 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the X-axis.");

            Console.ReadKey();
        }
    }
}
