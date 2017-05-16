using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            var num = int.Parse(Console.ReadLine());
            var bonusScore = 0.0;
            if (num > 1000)
            {
                bonusScore = num * 0.1;
            }
            else if (num > 100)
            {
                bonusScore = num * 0.2;
            }
            else if (num <= 100)
            {
                bonusScore += 5;
            }
            if (num % 2 == 0)
            {
                bonusScore += 1;
            }
            else if (num % 10 == 5)
            {
                bonusScore += 2;
            }
            Console.WriteLine("Bonus Score: {0}", bonusScore);
            Console.WriteLine("Toral Score: {0}", bonusScore + num);
        }
    }
}
