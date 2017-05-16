using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Numbers
{
    class Numbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var n1 = n;

            var o = 0;
            var print = n1 - o;
            var prod = 1;
            var lastDigit = n % 10;
            prod *= lastDigit;
            n /= 10;

            var prod1 = 1;
            var secondDigit = n % 10;
            prod1 *= secondDigit;
            n /= 10;
           
            var prod2 = 1;
            var firstDigit = n % 10;
            prod2 *= firstDigit;
            n /= 10;

            var row = prod2 + prod1;
            var col = prod2 + prod;

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (print % 5 == 0)
                    {
                        o = prod2;
                        print -= o;
                    }
                    else if (print % 3 == 0)
                    {
                        o = prod1;
                        print -= o;
                    }
                    else
                    {
                        o = prod;
                        print += o;
                    }
                    Console.Write("{0} ",print);
                }
                Console.WriteLine();
            }
        }
    }
}
