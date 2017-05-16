using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Celsius: ");
            var c = double.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenhite= {0:f2}", c * 1.8 + 32);
        }
    }
}
