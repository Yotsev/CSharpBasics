using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RadiansToDegrees
{
    class RadiansToDegrees
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radians: ");
            var rad = double.Parse(Console.ReadLine());
            Console.WriteLine("Degrees= {0:f0}", rad / Math.PI * 180);
        }
    }
}
