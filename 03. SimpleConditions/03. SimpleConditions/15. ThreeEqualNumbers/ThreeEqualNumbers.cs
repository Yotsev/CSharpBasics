using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ThreeEqualNumbers
{
    class ThreeEqualNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            var num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            var num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            var num3 = int.Parse(Console.ReadLine());
            if (num1 == num2 && num2==num3)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
