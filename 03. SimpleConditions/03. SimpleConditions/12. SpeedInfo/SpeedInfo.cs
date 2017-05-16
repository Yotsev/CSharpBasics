using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SpeedInfo
{
    class SpeedInfo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter speed: ");
            var speed = double.Parse(Console.ReadLine());
            if (speed <= 10)
            {
                Console.WriteLine("Slow");
            }
            else if (speed <= 50)
            {
                Console.WriteLine("Average");
            }
            else if (speed <= 150)
            {
                Console.WriteLine("Fast");
            }
            else if (speed <= 1000)
            {
                Console.WriteLine("Ultra fast");
            }
            else
            {
                Console.WriteLine("Extremly fast");
            }
        }
    }
}
