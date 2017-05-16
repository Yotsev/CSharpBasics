using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                var leftNumbers = int.Parse(Console.ReadLine());
                leftSum += leftNumbers;
            }
            for (int i = 0; i < n; i++)
            {
                var rightNumbers = int.Parse(Console.ReadLine());
                rightSum += rightNumbers;
            }
            if (rightSum == leftSum)
            {
                Console.WriteLine("Yes, sum = {0}",rightSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - rightSum));
            }
        }
    }
}
