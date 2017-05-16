using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Stop
{
    class Stop
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //first row
            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', 2 * n + 1));
            Console.WriteLine(new string('.', n + 1));
            //mid row
            var dotCount = n;
            var linesCount = n * 2 - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', dotCount));
                Console.Write("//");
                Console.Write(new string('_', linesCount));
                Console.Write("\\\\");
                Console.WriteLine(new string('.', dotCount));
                dotCount--;
                linesCount += 2;
            }
            Console.Write("//");
            Console.Write(new string('_', n * 2 - 3));
            Console.Write("STOP!");
            Console.Write(new string('_', n * 2 - 3));
            Console.WriteLine("\\\\");
            dotCount = 0;
            linesCount = n * 4 - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', dotCount));
                Console.Write("\\\\");
                Console.Write(new string('_', linesCount));
                Console.Write("//");
                Console.WriteLine(new string('.', dotCount));
                dotCount++;
                linesCount -= 2;
            }
        }
    }
}
