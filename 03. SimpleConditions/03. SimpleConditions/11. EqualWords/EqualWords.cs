using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualWords
{
    class EqualWords
    {
        static void Main(string[] args)
        {
            Console.Write("Ënter first Word: ");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word ");
            string word2 = Console.ReadLine();
            word1 = word1.ToLower();
            word2 = word2.ToLower();
            if (word1 == word2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
