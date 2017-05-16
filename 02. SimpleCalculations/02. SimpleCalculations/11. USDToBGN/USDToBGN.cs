using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USDToBGN
{
    class USDToBGN
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of USD: ");
            var usd = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2} BGN", usd * 1.79549m);
        }
    }
}
