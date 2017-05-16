using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Journey
{
    class Journey
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", budget * 0.9);
            }
            else if (season == "summer")
            {
                if (budget <= 100)
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", budget * 0.3);
                }
                else if (budget <= 1000)
                {
                    Console.WriteLine("Scomewhere if Balkans");
                    Console.WriteLine("Camp - {0:f2}", budget * 0.4);
                }
            }
            else if (season == "winter")
            {
                if (budget <= 100)
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", budget * 0.7);
                }
                else if (budget <= 1000)
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", budget * 0.8);
                }
            }
        }
    }
}
