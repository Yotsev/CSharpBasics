using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TriangleOf55Stars
{
    class TriangleOf55Stars
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                string stars = new string('*', i);  // създаваме стринг от звезди за определиния ред!
                Console.WriteLine(stars); // принтираме звездите
            }
        }
    }
}
