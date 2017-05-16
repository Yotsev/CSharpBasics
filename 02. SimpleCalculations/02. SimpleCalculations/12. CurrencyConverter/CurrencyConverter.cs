using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            Console.Write("Enrer amount: ");
            var amount = decimal.Parse(Console.ReadLine());
            Console.Write("Enter currency: ");
            string inCurrency = Console.ReadLine();
            Console.Write("Enter Currency to:");
            string outCurrency = Console.ReadLine();
            var factor = 0.0m;
            if (inCurrency == "USD")
            {
                factor = 1*1.79549m;
            }
            else if (inCurrency == "EUR")
            {
                factor = 1*1.95583m;
            }
            else if (inCurrency == "GBP")
            {
                factor = 1*2.53405m;
            }
            else if (inCurrency == "BGN")
            {
                factor = 1m;
            }
            var currnecy = amount * factor;
            if (outCurrency == "USD")
            {
                factor = 1/1.79549m;
            }
            else if (outCurrency == "EUR")
            {
                factor = 1/1.95583m;
            }
            else if (outCurrency == "GBP")
            {
                factor = 1/2.53405m;
            }
            else if (outCurrency == "BGN")
            {
                factor = 1m;
            }
            Console.WriteLine("{0:f2} {1}",currnecy * factor, outCurrency);
        }
    }
}
