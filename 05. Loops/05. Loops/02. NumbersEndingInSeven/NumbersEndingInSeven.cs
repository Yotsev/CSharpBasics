﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumbersEndingInSeven
{
    class NumbersEndingInSeven
    {
        static void Main(string[] args)
        {
            for (var i =1; i<=1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
