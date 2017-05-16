using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TraningLab
{
    class TraningLab
    {
        static void Main(string[] args)
        {
            var hight = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            hight *= 100;
            width *= 100 - 100;
            Console.WriteLine(Math.Floor(hight / 120));
            Console.WriteLine(Math.Floor(width / 70));
            Console.WriteLine(Math.Floor(hight / 120) * Math.Floor(width / 70));
        }
    }
}
