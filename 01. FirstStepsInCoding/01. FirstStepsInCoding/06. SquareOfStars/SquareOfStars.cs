using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); // първи ред е статичен       
            Console.WriteLine(new string('*', N));
            for (int i = 0; i < N - 2; i++) // цикъла за останалите редове
            {
                Console.WriteLine("*{0}*", new string(' ', N - 2));
            }
            Console.WriteLine(new string('*', N)); // последния ред е като първия, също е статичен
        }
    }
}
