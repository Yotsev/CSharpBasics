using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FruitAndVegetableShop
{
    class FruitAndVegetableShop
    {
        static void Main(string[] args)
        {
            Console.Write("Enter price of vegetables: ");
            var priceVegy = double.Parse(Console.ReadLine());
            Console.Write("Enter price of fruits: ");
            var priceFruit = double.Parse(Console.ReadLine());
            Console.Write("Enter amount of vegetables: ");
            var amountVegy = int.Parse(Console.ReadLine());
            Console.Write("Enter amount of fruits: ");
            var amountFruit = int.Parse(Console.ReadLine());
            Console.WriteLine("Total price is: {0}", (priceVegy*amountVegy + priceFruit * amountFruit)/1.94);
        }
    }
}
