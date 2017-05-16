using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n - 2; row++)
            {
                var character = '*';
                if (row % 2 == 1) // съкратен иф (row % 2 == 0) ?'*':'-' 
                {
                    character = '-';
                }

                Console.WriteLine("{0}\\ /{0}", new string(character, n - 2));
            }
            Console.WriteLine("{0}@", new string(' ', n - 1));
            for (int row = 0; row < n - 2; row++)
            {
                var character = '*';
                if (row % 2 == 1)
                {
                    character = '-';
                }

                Console.WriteLine("{0}/ \\{0}", new string(character, n - 2));
            }
        }
    }
}
