using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());


        //first
        int wholeRow = 2 * n;
        int halfN = n / 2;
        Console.WriteLine("/{0}\\{1}/{0}\\",
            new string('^', halfN),
            new string('_', wholeRow - (2 * halfN) - 4));

        for (int i = 0; i < n - 3; i++)
        {
            Console.WriteLine("|{0}|", new string(' ', wholeRow - 2));
        }

        Console.WriteLine("|{0}{1}{0}|", new string(' ', halfN + 1),
            new string('_', wholeRow - (2 * halfN) - 4));

        //last row
        Console.WriteLine("\\{0}/{1}\\{0}/",
            new string('_', halfN),
            new string(' ', wholeRow - (2 * halfN) - 4));
    }
}

