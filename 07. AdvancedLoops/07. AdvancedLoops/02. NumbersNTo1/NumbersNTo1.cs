﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumbersNTo1
{
    class NumbersNTo1
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
