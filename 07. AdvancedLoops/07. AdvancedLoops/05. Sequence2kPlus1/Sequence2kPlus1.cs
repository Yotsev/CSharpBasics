﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence2kPlus1
{
    class Sequence2kPlus1
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            while (num <=n )
            {
                Console.WriteLine(num);
                num = 2* num + 1;
            }
        }
    }
}
