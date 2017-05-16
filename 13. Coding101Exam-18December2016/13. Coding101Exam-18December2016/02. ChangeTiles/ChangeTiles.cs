using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            double savedMoney = double.Parse(Console.ReadLine());
            double widthOfFloar = double.Parse(Console.ReadLine());
            double lenghtOfFloar = double.Parse(Console.ReadLine());
            double sideOfTriangle = double.Parse(Console.ReadLine());
            double haightOfTriangle = double.Parse(Console.ReadLine());
            double priceOfOneTile = double.Parse(Console.ReadLine());
            double priceForWorker = double.Parse(Console.ReadLine());
            int fira = 5;

            double areaOfFloar = widthOfFloar * lenghtOfFloar;
            double areaOfTile = sideOfTriangle * haightOfTriangle / 2;
            double tilesNeeded = Math.Ceiling(areaOfFloar / areaOfTile) + fira;
            double totalPriceoOfTiles = tilesNeeded*priceOfOneTile + priceForWorker;

            if (savedMoney >= totalPriceoOfTiles)
            {
                Console.WriteLine("{0:f2} lv left.", savedMoney - totalPriceoOfTiles);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", totalPriceoOfTiles - savedMoney);
            }

        }
    }
}
