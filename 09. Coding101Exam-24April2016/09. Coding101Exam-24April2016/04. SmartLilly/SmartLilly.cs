using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SmartLilly
{
    class SmartLilly
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var priceOfWashMachine = double.Parse(Console.ReadLine());
            var priceOfToy = int.Parse(Console.ReadLine());
            var money = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i %2 ==0)
                {
                    money  = money + i*5;
                    money -= 1;
                }
                else
                {
                    money += priceOfToy;
                }
            }
            if (money > priceOfWashMachine)
            {
                Console.Write("Yes! {0:f2}", money - priceOfWashMachine);
            }
            else
            {
                Console.Write("No! {0:f2}", priceOfWashMachine - money);

            }
        }
    }
}
