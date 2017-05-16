using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PoolPipes
{
    class PoolPipes
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            var VolumOfPull = int.Parse(Console.ReadLine());
            var firstPipeFlow = int.Parse(Console.ReadLine());
            var secondPipeFlow = int.Parse(Console.ReadLine());
            var time = double.Parse(Console.ReadLine());

            var firstPipeVolum = firstPipeFlow * time;
            var secondPipeVolum = secondPipeFlow * time;
            var totalPipes = firstPipeVolum + secondPipeVolum;

            if (totalPipes <= VolumOfPull)
            {
                var purcentFull = (int)(totalPipes / VolumOfPull * 100);
                var firstPipePurcent = (int)(firstPipeVolum / totalPipes * 100);
                var secondPipePurcent = (int)(secondPipeVolum / totalPipes * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", purcentFull, firstPipePurcent, secondPipePurcent);
            }
            else
            {
                var overflow = totalPipes - VolumOfPull;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", time, overflow);
            }
        }
    }
}
