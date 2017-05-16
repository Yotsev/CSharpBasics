using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddOrEvenPosition
{
    class OddOrEvenPosition
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;

            var evenSum = 0.0;
            var oddSum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i %2 ==0)
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }
            }
            if (n == 0)
            {
                Console.WriteLine("OddSum = 0");
                Console.WriteLine("OddMin = No");
                Console.WriteLine("OddMax = No");
                Console.WriteLine("EvenSum = 0");
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
            }
            else if (n == 1)
            {
                Console.WriteLine("OddSum = {0}",oddSum);
                Console.WriteLine("OddMin = {0}",oddMin);
                Console.WriteLine("OddMax = {0}", oddMax);
                Console.WriteLine("EvenSum = 0");
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                Console.WriteLine("OddSum = {0}", oddSum);
                Console.WriteLine("OddMin = {0}", oddMin);
                Console.WriteLine("OddMax = {0}", oddMax);
                Console.WriteLine("EvenSum = {0}", evenSum);
                Console.WriteLine("EvenMin = {0}", evenMin);
                Console.WriteLine("EvenMax = {0}", evenMax);
            }
        }
    }
}
