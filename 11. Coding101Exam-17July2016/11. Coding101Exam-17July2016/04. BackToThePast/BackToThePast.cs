using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            var enheratens = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var age = 18;
            for (int i = 1800; i <= year; i++)
            {
                if (i %2 == 0)
                {
                    enheratens -= 12000; 
                }
                else
                {
                    enheratens -= 50 * age + 12000;
                }
                age++;
            }
            if (enheratens >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.",enheratens);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(enheratens));
            }

        }
    }
}
