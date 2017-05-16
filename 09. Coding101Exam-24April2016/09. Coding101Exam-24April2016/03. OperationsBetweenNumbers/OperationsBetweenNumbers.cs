using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OperationsBetweenNumbers
{
    class OperationsBetweenNumbers
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            var result = 0.0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{0} + {1} = {2} - even", num1, num2, result);
                    }
                    else
                    {
                        Console.WriteLine("{0} + {1} = {2} - odd", num1, num2, result);
                    }
                    break;
                case "-":
                    result = num1 - num2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{0} - {1} = {2} - even", num1, num2, result);
                    }
                    else
                    {
                        Console.WriteLine("{0} - {1} = {2} - odd", num1, num2, result);
                    }
                    break;
                case "*":
                    result = num1 * num2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{0} * {1} = {2} - even", num1, num2, result);
                    }
                    else
                    {
                        Console.WriteLine("{0} * {1} = {2} - odd", num1, num2, result);
                    }
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero",num1);
                        return;
                    }
                    result = num1*1.0 / num2;
                    Console.WriteLine("{0} / {1} = {2:f2}",num1,num2,result);
                    break;
                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero",num1);
                        return;
                    }
                    result = num1 % num2;
                    Console.WriteLine();
                    Console.WriteLine("{0} % {1} = {2}", num1, num2, result);

                    break;
            }
        }
    }
}
