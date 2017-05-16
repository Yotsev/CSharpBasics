using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Tiles
{
    class Tiles
    {
        static void Main(string[] args)
        {
            var sideOfPark = int.Parse(Console.ReadLine());
            var widthOfTile = double.Parse(Console.ReadLine());
            var hightOfTile = double.Parse(Console.ReadLine());
            var widthOfBench = int.Parse(Console.ReadLine());
            var hightOfBench = int.Parse(Console.ReadLine());

            var areaOfPark = sideOfPark * sideOfPark;
            var areaOfBench = widthOfBench * hightOfBench;
            var areaOfTile = widthOfTile * hightOfTile;
            var area = areaOfPark - areaOfBench;
            var tiles = area / areaOfTile;
            var time = tiles * 0.2;
            Console.WriteLine(tiles);
            Console.WriteLine(time);
        }
    }
}
