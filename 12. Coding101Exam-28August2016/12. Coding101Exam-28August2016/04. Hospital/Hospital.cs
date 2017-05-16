using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var docs = 7;
            var treated = 0;
            var untreated = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 3 == 0)
                {
                    if (untreated > treated)
                    {
                        docs++;
                    }
                }
                var pat = int.Parse(Console.ReadLine());

                if (pat < docs)
                {
                    treated += pat;
                }
                else
                {
                    treated += docs;
                    untreated += pat - docs;

                }
            }
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }
}
