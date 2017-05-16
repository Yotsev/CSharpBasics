using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a= ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Enter h= ");
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine("Triangle area= {0:f2}", a * h / 2);
        }
    }
}
