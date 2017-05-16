using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var p1 = 0;
            var p2 = 0;
            var p3 = 0;
            var p4 = 0;
            var p5 = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                else if (num < 400)
                {
                    p2++;
                }
                else if (num < 600)
                {
                    p3++;
                }
                else if (num < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            var total = (p1 + p2 + p3 + p4 + p5) * 1.0;
            Console.WriteLine("{0:f2%}", (p1 / total) * 100);
            Console.WriteLine("{0:f2%}", (p2 / total) * 100);
            Console.WriteLine("{0:f2%}", (p3 / total) * 100);
            Console.WriteLine("{0:f2%}", (p4 / total) * 100);
            Console.WriteLine("{0:f2%}", (p5 / total) * 100);
        }
    }
}
