using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StopNumber
{
    class StopNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());
            for (int i = m; i >= n; i--)
            {
                if (i %2 == 0)
                {
                    if (i %3 == 0)
                    {
                        if (i == s)
                        {
                            return;
                        }
                        Console.Write("{0} ",i);

                    }
                }
                
            }
        }
    }
}
