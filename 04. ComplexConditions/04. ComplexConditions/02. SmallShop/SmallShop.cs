﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            var amount = double.Parse(Console.ReadLine());
            var price = 0.0;
            if (town == "Sofia")
            {
                if (product == "coffee") price = 0.50;
                else if (product == "water") price = 0.80;
                else if (product == "beer") price = 1.20;
                else if (product == "sweets") price = 1.45;
                else if (product == "peanuts") price = 1.60;
                Console.WriteLine(amount * price);
            }
            if (town == "Plovdiv")
            {
                if (product == "coffee") price = 0.40;
                else if (product == "water") price = 0.70;
                else if (product == "beer") price = 1.15;
                else if (product == "sweets") price = 1.30;
                else if (product == "peanuts") price = 1.50;
                Console.WriteLine(amount * price);
            }
            if (town == "Varna")
            {
                if (product == "coffee") price = 0.45;
                else if (product == "water") price = 0.70;
                else if (product == "beer") price = 1.10;
                else if (product == "sweets") price = 1.35;
                else if (product == "peanuts") price = 1.55;
                Console.WriteLine(amount * price);
            }
        }
    }
}
