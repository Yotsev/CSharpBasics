﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareArea
{
    class SquareArea
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            var a = double.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Square= ");
            Console.WriteLine(area);
        }
    }
}
