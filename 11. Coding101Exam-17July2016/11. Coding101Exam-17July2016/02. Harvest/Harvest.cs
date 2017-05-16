using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            var vinYard = int.Parse(Console.ReadLine());
            var grape = double.Parse(Console.ReadLine());
            var wineNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var totalGrape = vinYard * grape;
            var wine = totalGrape * 0.4 / 2.5;
            if (wine >= wineNeeded)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",Math.Floor(wine));
                Console.WriteLine("{0} litters left -> {1} liters per person",Math.Floor(wine - wineNeeded), Math.Floor((wine - wineNeeded)/workers));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed",Math.Floor(wineNeeded - wine));
            }
        }
    }
}
