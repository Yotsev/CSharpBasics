using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine().ToLower();
            var row = int.Parse(Console.ReadLine());
            var column = int.Parse(Console.ReadLine());
            var price = 0.0;
            var income = 0.0;
            if (projection == "premiere")
            {
                price = 12;
                income = row * column * price;
                Console.WriteLine("{0:f2} leva", income);
            }
            else if (projection == "normal")
            {
                price = 7.50;
                income = row * column * price;
                Console.WriteLine("{0:f2} leva", income);
            }
            else if (projection == "discount")
            {
                price = 5.00;
                income = row * column * price;
                Console.WriteLine("{0:f2} leva", income);
            }

        }
    }
}
