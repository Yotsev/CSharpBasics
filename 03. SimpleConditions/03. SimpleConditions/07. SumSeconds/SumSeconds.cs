using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first seconds: ");
            var sec1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second seconds: ");
            var sec2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third seconds: ");
            var sec3 = int.Parse(Console.ReadLine());
            var secs = sec1 + sec2 + sec3;
            var mins = 0;
            mins = secs / 60;
            secs = secs % 60;
            if (secs <10)
            {
                Console.WriteLine(mins + ":"+"0" + secs);
            }
            else
            {
                Console.WriteLine(mins + ":" + secs);
            }
        }
    }
}
