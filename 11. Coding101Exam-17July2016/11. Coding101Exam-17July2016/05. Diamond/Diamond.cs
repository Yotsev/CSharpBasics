using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var dotsOut = number -1;
            var dotsIn = number*3;
            //first row
            Console.WriteLine("{0}{1}{0}", new string ('.',number),new string('*',3*number));
            // after first row to middle
            for (int i = 0; i < number-1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.',dotsOut),new string ('.',dotsIn));
                dotsIn +=2;
                dotsOut --;
            }
            // middle row
            Console.WriteLine(new string('*',5*number));
            // middle to bot row
            for (int i = 0; i < number*2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",new string('.',dotsOut+1),new string('.',dotsIn-2));
                dotsIn -= 2;
                dotsOut++;
            }
            //bot row
            Console.WriteLine("{0}{1}{0}",new string('.',number*2+1),new string('*',number-2));
        }
    }
}
