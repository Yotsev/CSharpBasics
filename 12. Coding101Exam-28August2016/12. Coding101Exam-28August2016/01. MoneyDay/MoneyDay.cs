using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MoneyDay
{
    class MoneyDay
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var money = double.Parse(Console.ReadLine());
            var usd = double.Parse(Console.ReadLine());

            var sal = days * money;
            var year = sal * 12 + sal * 2.5;
            var tax = year * 0.25;
            var cleanMoney = year - tax;
            var bgn = cleanMoney * usd;
            var moneyParDay = bgn / 365;
            Console.WriteLine("{0:f2}",moneyParDay);
        }
    }
}
