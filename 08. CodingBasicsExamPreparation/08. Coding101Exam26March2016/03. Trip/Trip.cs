using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            var spent = 0.0;
            string place = string.Empty;
            string country = string.Empty;
            if (budget<= 100)
            {
                country = "Bulgaria";
                if (season == "summer")
                {
                    spent = budget * 0.3;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    spent = budget * 0.7;
                    place = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                country = "Balkans";
                if (season == "summer")
                {
                    spent = budget * 0.4;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    spent = budget * 0.8;
                    place = "Hotel";
                }
            }
            else
            {
                country = "Europe";
                spent = budget * 0.9;
                place = "Hotel";
            }
            Console.WriteLine("Somewhere in {0}",country
                );
            Console.WriteLine("{0} - {1:f2}",place,spent);
        }
    }
}
