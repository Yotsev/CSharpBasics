using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Number0to100ToText
{
    class Number0to100ToText
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] toNineteen = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
                "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tensNumbers = { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string word = "";

            if (number == 100)
            {
                Console.Write("one hundred");
            }
            else if (number >= 0 && number < 100)
            {

                if (number / 100 > 0)
                {
                    word = toNineteen[number / 100] + " " + "hundred";
                    number = number % 100;
                }

                if (word != "")
                {
                    word = word + " " + "and ";
                }
                if (number < 20)
                {
                    word = word + toNineteen[number];
                }
                else if (number / 10 > 1)
                {
                    word = word + tensNumbers[number / 10];
                    if (number % 10 > 0)
                    {
                        word = word + " " + toNineteen[number % 10];
                    }
                }
            }
            else
            {
                Console.Write("invalid number");

            }
            Console.WriteLine(word);
        }
    }
}
