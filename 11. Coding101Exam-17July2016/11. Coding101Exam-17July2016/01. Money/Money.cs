using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Money
    {
        static void Main(string[] args)
        {
            var bitCoins = int.Parse(Console.ReadLine());
            var juan = double.Parse(Console.ReadLine());
            var commision = double.Parse(Console.ReadLine());

            var bitToBgn = 1168;
            var usdToBgn = 1.76;
            var eurToBgn = 1/1.95;
            var chJuan = 0.15* juan;
            var usd = usdToBgn * chJuan;
            var bit = bitToBgn * bitCoins;
            var all = (bit + usd) * eurToBgn;
            var allAfterCommisin = all * (commision / 100);
            var total = all - allAfterCommisin;
            Console.WriteLine(total);
        }
    }
}
