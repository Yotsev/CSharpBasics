using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var inner = n - 1;
            var left = 3 * n;
            var right = n - 1;

            //first row
            Console.Write(new string('-', 3 * n));
            Console.Write("**");
            Console.WriteLine(new string('-', (5 * n) - (3 * n + 2)));

            //first to hendel

            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string('-', 3 * n));
                Console.Write("*{0}*", new string('-', i));
                Console.WriteLine(new string('-', (5 * n) - ((3 * n + 2) + i)));
            }

            //handle

            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('*', 3 * n));
                Console.Write("*{0}*", new string('-', n - 1));
                Console.WriteLine(new string('-', n - 1));
            }
            // hendle to blade

            if (n % 2 == 0)
            {
                for (int i = 1; i <= ((2 * n) / 4) - 1; i++)
                {
                    Console.Write(new string('-', left));
                    Console.Write("*{0}*", new string('-', inner));
                    Console.WriteLine(new string('-', right));
                    right--;
                    inner += 2;
                    left--;
                }
                Console.Write(new string('-', (3 * n) - ((2 * n) / 4) + 1));
                Console.Write(new string('*', 2 * n - 1));
                Console.WriteLine(new string('-', n / 2));

            }
            else
            {
                for (int i = 1; i <= n / 2 - 1; i++)
                {
                    Console.Write(new string('-', left));
                    Console.Write("*{0}*", new string('-', inner));
                    Console.WriteLine(new string('-', right));
                    left--;
                    inner += 2;
                    right--;
                }
                Console.Write(new string('-', (3 * n) - ((2 * n) / 4) + 1));
                Console.Write(new string('*', 2 * n - 2));
                Console.WriteLine(new string('-', n / 2 + 1));
            }
        }
    }
}
