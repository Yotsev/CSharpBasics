using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.NumberFrom100To200
{
    class NumberFrom100To200
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            var num = int.Parse(Console.ReadLine());
            if (num > 200)
            {
                Console.WriteLine("Greater then 200");
            }
            else if (num >= 100 )
            {
                Console.WriteLine("Betwin 100 and 200");
            }
            else
            {
                Console.WriteLine("Less then 100");

            }
        }
    }
}
