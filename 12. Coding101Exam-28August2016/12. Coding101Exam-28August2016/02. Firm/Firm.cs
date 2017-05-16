using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.firma
{
    class Firm
    {
        static void Main(string[] args)
        {
            var houers = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var learning = days * 0.1;
            var workhouers = (days - learning) * 8;
            var overtime = workers * 2 * days;
            var allHoures = Math.Floor(workhouers + overtime);

            if (allHoures >= houers)
            {
                Console.WriteLine("Yes!{0} hours left.", allHoures - houers);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", houers - allHoures);
            }
        }
    }
}
