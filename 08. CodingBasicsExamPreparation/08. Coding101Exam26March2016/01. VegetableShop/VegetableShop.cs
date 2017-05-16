using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.VegetableShop
{
    class VegetableShop
    {
        static void Main(string[] args)
        {
            //megical row
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            var priceVegetabl = decimal.Parse(Console.ReadLine());
            var priceFruit = decimal.Parse(Console.ReadLine());
            var kgVegetable = int.Parse(Console.ReadLine());
            var kgFruit = int.Parse(Console.ReadLine());

            var totalprice = priceVegetabl * kgVegetable + priceFruit * kgFruit;
            var tototalEu = totalprice / (decimal)1.94;
            Console.WriteLine(tototalEu);
        }
    }
}
