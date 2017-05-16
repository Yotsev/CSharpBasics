using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var biggestNumber = int.MinValue;
            var numbersSum = 0;

            for (int i = 0; i < num; i++)
            {
                var numbers = int.Parse(Console.ReadLine());
                if (numbers > biggestNumber)
                {
                    biggestNumber = numbers;
                }
                numbersSum += numbers;
            }
            if (numbersSum == biggestNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", numbersSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}",Math.Abs(numbersSum - biggestNumber));
            }
        }
    }
}
